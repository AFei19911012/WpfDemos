
/*****************************************************************************

This class has been written by Elmü (elmue@gmx.de)

Check if you have the latest version on:
https://www.codeproject.com/Articles/5293980/Editor3DRenderer-A-Windows-Forms-Render-Control-in-Csharp

*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static Editor3D.Editor3DRenderer;
using CColorScheme = Editor3D.CColorScheme;
using CLine3D = Editor3D.Editor3DRenderer.CLine3D;
using CLineData = Editor3D.Editor3DRenderer.CLineData;
using CMessgData = Editor3D.Editor3DRenderer.CMessgData;
// classes
using CObject3D = Editor3D.Editor3DRenderer.CObject3D;
using CPoint3D = Editor3D.Editor3DRenderer.CPoint3D;
using CPolygon3D = Editor3D.Editor3DRenderer.CPolygon3D;
using CPolygonData = Editor3D.Editor3DRenderer.CPolygonData;
using CScatterData = Editor3D.Editor3DRenderer.CScatterData;
using CShape3D = Editor3D.Editor3DRenderer.CShape3D;
using CSurfaceData = Editor3D.Editor3DRenderer.CSurfaceData;
// callback function
using DelRendererFunction = Editor3D.Editor3DRenderer.DelRendererFunction;

namespace Editor3D
{
    public partial class MainForm : Form
    {
        #region enums

        enum eDemo
        {
            Math_Callback,
            Surface_Fill,
            Surface_Grid,
            Surface_Fill_Missing,
            Surface_Grid_Missing,
            Nested_Graphs,
            Scatter_Plot,
            Connected_Lines,
            Scatter_Shapes,
            Pyramid,
            Sphere_Fill_Closed,
            Sphere_Fill_Open,
            Sphere_Grid,
            Valentine,
            Animation,       
        }

        #endregion

        eDemo        me_Demo;
        EnumColorScheme me_ColorScheme;
        Timer        mi_StatusTimer = new Timer();
        CMessgData   mi_MesgTop     = new CMessgData("", -7,  7, Color.Blue); // For special hint
        CMessgData   mi_MesgBottom  = new CMessgData("", -7, -7, Color.Gray); // For selection mode

        // Only for demo "Animation"
        Timer        mi_AnimationTimer = new Timer();
        CScatterData mi_SinusData;
        CPoint3D[]   mi_Pyramid;
        int          ms32_AnimationAngle;

        public MainForm()
        {
            InitializeComponent();

            mi_StatusTimer.Interval = 8000;
            mi_StatusTimer.Tick += new EventHandler(OnClearStatusTimer);

            mi_AnimationTimer.Interval = 100;
            mi_AnimationTimer.Tick += new EventHandler(OnAnimationTimer);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            // This is only required for DemoSphere() where the DEL key deletes polygons
            editor3D.KeyDown += new KeyEventHandler(OnEditorKeyDown);

            CMessgData i_Mesg = new CMessgData("Please select a 3D Demo in the combobox at the left", 10, 10, Color.Blue);

            editor3D.Clear();
            editor3D.AddMessageData(i_Mesg);
            editor3D.Invalidate();

            comboDemo.Sorted = false;
            foreach (eDemo e_Demo in Enum.GetValues(typeof(eDemo)))
            {
                comboDemo.Items.Add(e_Demo.ToString().Replace('_', ' '));
            }

            comboColors.Sorted = false;
            foreach (EnumColorScheme e_Scheme in Enum.GetValues(typeof(EnumColorScheme)))
            {
                comboColors.Items.Add(e_Scheme.ToString().Replace('_', ' '));
            }
            comboColors.SelectedIndex = (int)EnumColorScheme.Rainbow_Bright;

            comboRaster.Sorted = false;
            foreach (EnumRaster e_Raster in Enum.GetValues(typeof(EnumRaster)))
            {
                comboRaster.Items.Add(e_Raster);
            }
            comboRaster.SelectedIndex = (int)EnumRaster.Labels;

            comboDemo .SelectedIndex = -1; // set empty
            comboMouse.SelectedIndex = 0;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // ToolStripStatusLabel.AutoSize works like SHIT: If the window is too small, the text will not be displayed at all!
            statusLabel.AutoSize = false;
            statusLabel.Width = ClientSize.Width - 30;
        }

        /// <summary>
        /// Restore the default message in the status bar
        /// </summary>
        void OnClearStatusTimer(object sender, EventArgs e)
        {
            mi_StatusTimer.Stop();
            statusLabel.Text = "";
        }

        // ================================================================================================

        private void comboMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor3D.SetUserInputs();
            labelMouseInfo.Text = "Left mouse: Elevate and Rotate";

            labelMouseInfo.Text += ",  Left mouse + SHIFT: Move,  Left mouse + CTRL or wheel: Zoom, Left mouse + ALT: Select";
        }

        private void comboDemo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawDemo();
        }

        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawDemo();
        }

        private void checkMirrorX_CheckedChanged(object sender, EventArgs e)
        {
            editor3D.AxisX.Mirror = checkMirrorX.Checked;
            editor3D.Invalidate();
        }

        private void checkMirrorY_CheckedChanged(object sender, EventArgs e)
        {
            editor3D.AxisY.Mirror = checkMirrorY.Checked;
            editor3D.Invalidate();
        }

        private void checkIncludeZeroZ_CheckedChanged(object sender, EventArgs e)
        {
            editor3D.AxisZ.IncludeZero = checkIncludeZeroZ.Checked;
            editor3D.Invalidate();
        }

        private void checkPointSelection_CheckedChanged(object sender, EventArgs e)
        {
            editor3D.Selection.SinglePoints = checkPointSelection.Checked;
            SetSelectionMessages();
            editor3D.Invalidate();
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            editor3D.Selection.DeSelectAll();
            editor3D.Invalidate();
        }

        private void comboRaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor3D.Raster = (EnumRaster)comboRaster.SelectedIndex;
            editor3D.Invalidate();

            checkIncludeZeroZ.Enabled = comboRaster.SelectedIndex != (int)EnumRaster.Off;
            if (!checkIncludeZeroZ.Enabled)
                 checkIncludeZeroZ.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            editor3D.SetCoefficients(1350, 90, 90);
            editor3D.Invalidate();
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            SaveFileDialog i_Dlg = new SaveFileDialog();
            i_Dlg.Title      = "Save as PNG image";
            i_Dlg.Filter     = "PNG Image|*.png";
            i_Dlg.DefaultExt = ".png";

            if (DialogResult.Cancel == i_Dlg.ShowDialog(this))
                return;

            Bitmap i_Bitmap = editor3D.GetScreenshot();
            try
            {
                i_Bitmap.Save(i_Dlg.FileName, ImageFormat.Png);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================================================================================================

        private void DrawDemo()
        {
            checkPointSelection.Enabled = true; // Some of the demos will disable this checkbox
            comboColors        .Enabled = true; // Some of the demos will disable this combobox

            mi_AnimationTimer.Stop();
            mi_StatusTimer   .Stop();
            me_Demo              = (eDemo)       comboDemo.SelectedIndex;
            me_ColorScheme       = (EnumColorScheme)comboColors.SelectedIndex;     
            editor3D.TooltipMode = EnumTooltip.All;

            switch (me_Demo)
            {
                case eDemo.Math_Callback:        DemoCallback();                         break;
                case eDemo.Surface_Fill:         DemoSurface(EnumPolygonMode.Fill,  false); break;
                case eDemo.Surface_Grid:         DemoSurface(EnumPolygonMode.Lines, false); break;
                case eDemo.Surface_Fill_Missing: DemoSurface(EnumPolygonMode.Fill,  true);  break;
                case eDemo.Surface_Grid_Missing: DemoSurface(EnumPolygonMode.Lines, true);  break;
                case eDemo.Nested_Graphs:        DemoNestedGraphs();                     break;
                case eDemo.Scatter_Plot:         DemoScatterPlot(false);                 break;
                case eDemo.Connected_Lines:      DemoScatterPlot(true);                  break;
                case eDemo.Scatter_Shapes:       DemoScatterShapes();                    break;
                case eDemo.Sphere_Fill_Closed:   DemoSphere(EnumPolygonMode.Fill,  true);   break;
                case eDemo.Sphere_Fill_Open:     DemoSphere(EnumPolygonMode.Fill,  false);  break;
                case eDemo.Sphere_Grid:          DemoSphere(EnumPolygonMode.Lines, true);   break;
                case eDemo.Valentine:            DemoValentine();                        break;
                case eDemo.Pyramid:              DemoPyramid();                          break;
                case eDemo.Animation:            DemoAnimation();                        break;
                default: return;
            }

            // A demo may have changed the axis mode --> adapt checkboxes
            checkMirrorX     .Checked = editor3D.AxisX.Mirror;
            checkMirrorY     .Checked = editor3D.AxisY.Mirror;
            checkIncludeZeroZ.Checked = editor3D.AxisZ.IncludeZero;

            btnDeselect.Enabled = editor3D.Selection.Enabled;

            // All demos call editor3D.Clear() --> messages must be added always anew.
            editor3D.AddMessageData(mi_MesgTop, mi_MesgBottom);

            // Show total count of Lines, Shapes, Polygons
            lblInfo.Text = editor3D.ObjectStatistics;

            statusLabel.Text = (editor3D.Selection.Callback == null) ? "Callback: OFF" : "";

            SetSelectionMessages();
        }

        void SetSelectionMessages()
        {
            mi_MesgTop   .Text = "";
            mi_MesgBottom.Text = "";

            if (editor3D.Selection.Enabled)
            {
                if (me_Demo == eDemo.Sphere_Fill_Closed || me_Demo == eDemo.Sphere_Fill_Open)
                {
                    mi_MesgTop.Text = "DEL key: Delete selected polygons, CTRL+Z: Undo, CTRL+Y: Redo";
                }
                else if (editor3D.Selection.Callback != null)
                {
                    string s_Obj = "points";
                    if (!editor3D.Selection.SinglePoints)
                    {
                        switch (me_Demo)
                        {
                            case eDemo.Surface_Fill:    s_Obj = "polygons"; break;
                            case eDemo.Scatter_Shapes:
                            case eDemo.Scatter_Plot:    s_Obj = "shapes"; break;
                            case eDemo.Pyramid:
                            case eDemo.Connected_Lines: s_Obj = "lines"; break;
                        }
                    }
                    mi_MesgTop.Text = "ALT + CTRL + left mouse: Move selected "+s_Obj+", CTRL+Z: Undo, CTRL+Y: Redo";
                }

                string s_Multi = editor3D.Selection.MultiSelect  ? "ON" : "OFF";
                mi_MesgBottom.Text      = "Multiple selection: "+s_Multi+", Selection color: ▇▇▇▇▇▇";
                mi_MesgBottom.TextColor = editor3D.Selection.HighlightColor;
            }
            else
            {
                checkPointSelection.Enabled = false;
                checkPointSelection.Checked = false;

                mi_MesgBottom.Text      = "Selection is disabled";
                mi_MesgBottom.TextColor = Color.Gray;
            }
        }

        // ================================================================================================

        /// <summary>
        /// This demonstrates how to use a mathematical callback function which calculates Z values from X and Y
        /// </summary>
        private void DemoCallback()
        {
            CColorScheme i_Scheme = new CColorScheme(me_ColorScheme);
            CSurfaceData i_Data   = new CSurfaceData(49, 33, EnumPolygonMode.Fill, Pens.Black, i_Scheme);

            DelRendererFunction f_Callback = delegate(double X, double Y)
            {
                double r = 0.15 * Math.Sqrt(X * X + Y * Y);
                if (r < 1e-10) return 120;
                else           return 120 * Math.Sin(r) / r;
            };

            i_Data.ExecuteFunction(f_Callback, new PointF(-120, -80), new PointF(120, 80));

            CMessgData i_Mesg1 = new CMessgData("r = 0.15 * sqrt(x * x + y * y)", 7, -24, Color.Indigo);
            CMessgData i_Mesg2 = new CMessgData("z = 120  * sin(r) / r",          7,  -4, Color.Indigo);

            // IMPORTANT: Normalize maintainig the relation between X,Y,Z values otherwise the function will be distorted.
            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.MaintainXYZ;
            editor3D.AddMessageData(i_Mesg1, i_Mesg2);
            editor3D.AddRenderData (i_Data);

            editor3D.Selection.Callback = null;  
            editor3D.Selection.Enabled  = false;
            editor3D.Invalidate();

            // Selection does not make sense for this demo
        }

        // ================================================================================================

        /// <summary>
        /// This demonstrates how to use a string formula which calculates Z values from X and Y
        /// </summary>
        private void DemoFormula()
        {
            CColorScheme i_Scheme = new CColorScheme(me_ColorScheme);
            CSurfaceData i_Data   = new CSurfaceData(41, 41, EnumPolygonMode.Fill, Pens.Black, i_Scheme);

            string s_Formula = "7 * sin(x) * cos(y) / (sqrt(sqrt(x * x + y * y)) + 0.2)";

            try
            {
                
            }
            catch (Exception Ex) // invalid formula
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CMessgData i_Mesg = new CMessgData("Formula: z = " + s_Formula, 7, -7, Color.Indigo);

            // IMPORTANT: Normalize maintainig the relation between X,Y,Z values otherwise the function will be distorted.
            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.MaintainXYZ;
            editor3D.AddMessageData(i_Mesg);
            editor3D.AddRenderData (i_Data);
            
            editor3D.Selection.Callback = null;  
            editor3D.Selection.Enabled  = false;
            editor3D.Invalidate();

            // Selection does not make sense for this demo
        }

        // ================================================================================================

        /// <summary>
        /// This demonstrates how to set X, Y, Z values directly (without math function)
        /// </summary>
        private void DemoSurface(EnumPolygonMode e_Mode, bool b_Missing)
        {
            int m = 50;
            int n = 50;
            double[] xs = new double[m];
            double[] ys = new double[n];
            double[,] datas= new double[m, n];
            for (int i = 0; i < m; i++)
            {
                xs[i] = 10 * Math.PI / m * i - 5 * Math.PI;
            }
            for (int i = 0; i < n; i++)
            {
                ys[i] = 10 * Math.PI / n * i - 5 * Math.PI;
            }
            for(int i = 0;i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    datas[i, j] = 7 * Math.Sin(xs[i]) * Math.Cos(ys[j]) / (Math.Sqrt(Math.Sqrt(xs[i] * xs[i] + ys[j] * ys[j])) + 0.2);
                }
            }

            int s32_Cols = datas.GetLength(1);
            int s32_Rows = datas.GetLength(0);

            CColorScheme i_Scheme = new CColorScheme(me_ColorScheme);

            // In Line mode the pen is used to draw the polygon border lines. The color is assigned from the ColorScheme.
            // In Fill mode the pen is used to draw the thin separator lines (always 1 pixel, black)
            Pen i_Pen = (e_Mode == EnumPolygonMode.Lines) ? new Pen(Color.Yellow, 2) : Pens.Black;

            // In mode 'Missing' circles with a radius of 4 pixels represent single points that have insufficient neighbours to draw a polygon.
            int s32_Radius = b_Missing ? 4 : 0;

            CSurfaceData i_Data = new CSurfaceData(s32_Cols, s32_Rows, e_Mode, i_Pen, i_Scheme, s32_Radius);

            for (int C = 0; C < i_Data.Cols; C++)
            {
                for (int R = 0; R < i_Data.Rows; R++)
                {
                    if (b_Missing)
                    {
                        // Skip some points which will be missing.
                        bool b_Skip = C > 4 && C < 8 && R > 9 && R < 14;
                        if (C == 6 && R == 11) b_Skip = false;
                        if (C == 6 && R == 12) b_Skip = false;
                        if (C == 6 && R == 13) b_Skip = false;
                        if (C == 8 && R == 11) b_Skip = true;
                        if (C == 7 && R == 4) b_Skip = true;
                        if (C == 8 && R == 4) b_Skip = true;
                        if (C == 16 && R == 0) b_Skip = true;
                        if (C == 15 && R == 0) b_Skip = true;
                        if (C == 16 && R == 1) b_Skip = true;
                        if (C == 15 && R == 1) b_Skip = true;
                        if (b_Skip)
                            continue;
                    }

                    var s32_RawValue = datas[R, C];

                    double d_X = C * 0.02; // X must be related to Colum
                    double d_Y = R * 0.01; // Y must be related to Row
                    double d_Z = s32_RawValue;

                    string s_Tooltip = string.Format("Speed = {0} rpm\nMAP = {1} kPa\nVolume Eff. = {2} %\nColumn = {3}\nRow = {4}",
                                                     d_X, d_Y, Editor3DRenderer.FormatDouble(d_Z), C, R);

                    CPoint3D i_Point = new CPoint3D(d_X, d_Y, d_Z, s_Tooltip, s32_RawValue);
                    i_Data.SetPointAt(C, R, i_Point);
                }
            }


            // IMPORTANT: Normalize X,Y,Z separately because the axes have different ranges
            editor3D.Clear();
            editor3D.Normalize    = EnumNormalize.Separate;
            editor3D.TooltipMode  = EnumTooltip.UserText;
            editor3D.AxisY.Mirror = true;
            editor3D.AxisX.LegendText = "Engine Speed (rpm)";
            editor3D.AxisY.LegendText = "MAP (kPa)";
            editor3D.AxisZ.LegendText = "Volume Efficiency (%)";
            editor3D.LegendPos        = EnumLegendPos.BottomLeft;
            editor3D.AddRenderData(i_Data);

            editor3D.Selection.Callback       = OnSelectEvent;
            editor3D.Selection.HighlightColor = Color.FromArgb(90, 90, 90);
            editor3D.Selection.MultiSelect    = true;
            editor3D.Selection.Enabled        = true;
            editor3D.Invalidate();

            if (e_Mode == EnumPolygonMode.Fill) // Polygons
            {
                i_Data.GetPolygonAt(10, 5).Selected = true;
            }
            else // Lines
            {
                // Selection of polygons is not possible here.
                checkPointSelection.Enabled = false;
                checkPointSelection.Checked = true;

                i_Data.GetPointAt(10, 5).Selected = true;
                i_Data.GetPointAt(10, 6).Selected = true;
                i_Data.GetPointAt(11, 5).Selected = true;
                i_Data.GetPointAt(11, 6).Selected = true;
            }
        }

        // ================================================================================================

        /// <summary>
        /// This loads 2 graphs, one nested into the other
        /// </summary>
        private void DemoNestedGraphs()
        {
            const int POINTS = 8;
            CSurfaceData i_Data1 = new CSurfaceData(POINTS, POINTS, EnumPolygonMode.Lines, new Pen(Color.Orange, 3), null);
            CSurfaceData i_Data2 = new CSurfaceData(POINTS, POINTS, EnumPolygonMode.Lines, new Pen(Color.Green,  2), null);

            for (int C=0; C<POINTS; C++)
            {
                for (int R=0; R<POINTS; R++)
                {
                    double d_X = (C - POINTS / 2.3) / (POINTS / 5.5); // X must be related to Colum !
                    double d_Y = (R - POINTS / 2.3) / (POINTS / 5.5); // Y must be related to Row !
                    double d_Radius = Math.Sqrt(d_X * d_X + d_Y * d_Y);
                    double d_Z = Math.Cos(d_Radius) + 1.0;

                    string  s_Tooltip = string.Format("Col = {0}\nRow = {1}", C, R);
                    CPoint3D i_Point1 = new CPoint3D(d_X, d_Y, d_Z,       s_Tooltip + "\nWrong Data");
                    CPoint3D i_Point2 = new CPoint3D(d_X, d_Y, d_Z * 0.6, s_Tooltip + "\nCorrect Data");

                    i_Data1.SetPointAt(C, R, i_Point1);
                    i_Data2.SetPointAt(C, R, i_Point2);
                }
            }

            CMessgData i_Mesg1 = new CMessgData("Graph with error data",   7,  -7, Color.Orange);
            CMessgData i_Mesg2 = new CMessgData("Graph with correct data", 7, -24, Color.Green);

            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.Separate;
            editor3D.AddRenderData (i_Data1, i_Data2);
            editor3D.AddMessageData(i_Mesg1, i_Mesg2);

            editor3D.Selection.HighlightColor = Color.Black;
            editor3D.Selection.MultiSelect    = false;
            editor3D.Selection.Callback       = null;  
            editor3D.Selection.Enabled        = true;
            editor3D.Invalidate();

            // Single point selection works only in Fill mode
            checkPointSelection.Enabled = false;
            checkPointSelection.Checked = true;

            // This demo ignores the ColorScheme
            comboColors.Enabled = false; 
        }

        // ================================================================================================

        /// <summary>
        /// This demonstrates how to set X, Y, Z scatter plot points or lines in form of a spiral.
        /// </summary>
        private void DemoScatterPlot(bool b_Lines)
        {
            // 3 pixels for line width and for circle radius
            const int SIZE = 3;

            CColorScheme   i_Scheme    = new CColorScheme(me_ColorScheme);
            CScatterData   i_ShapeData = new CScatterData(i_Scheme);
            CLineData      i_LineData  = new CLineData   (i_Scheme);
            List<CPoint3D> i_Points    = new List<CPoint3D>();

            for (double P = -22.0; P < 22.0; P += 0.1)
            {
                double d_X = Math.Sin(P) * P;
                double d_Y = Math.Cos(P) * P;
                double d_Z = P;
                if (d_Z > 0.0) d_Z /= 3.0;

                CPoint3D i_Point = new CPoint3D(d_X, d_Y, d_Z, "Scatter Point");
                if (b_Lines) 
                {
                    i_Points.Add(i_Point);
                }
                else // Shapes
                {
                    // You can store the returned shape in a variable and later modify it's properties
                    CShape3D i_Shape = i_ShapeData.AddShape(i_Point, EnumScatterShape.Circle, SIZE, null); 
                }
            }
            
            // You can store the returned lines in a variable and later modify their properties
            CLine3D[] i_Lines = i_LineData.AddConnectedLines(i_Points, SIZE, null);

            // Depending on your use case you can also specify MaintainXY or MaintainXYZ here
            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.Separate;
            editor3D.AddRenderData(i_ShapeData, i_LineData);

            editor3D.Selection.HighlightColor = Color.FromArgb(90,90,90);
            editor3D.Selection.Callback       = OnSelectEvent;
            editor3D.Selection.MultiSelect    = true;
            editor3D.Selection.Enabled        = true;
            editor3D.Invalidate();

            // For shapes this setting does not make a difference
            checkPointSelection.Checked = false;
            if (!b_Lines)
                checkPointSelection.Enabled = false;
        }

        // ================================================================================================

        private void DemoScatterShapes()
        {
            #region double d_Values definitions

            double[,] d_Values = new double[,]
            {
                // Value  X        Y      Z
                {   1.46, 0.0007,  0.077, 0.72 },
                {  -1.85, 0.0137,  0.053, 0.87 },
                {   5.51, 0.0047,  0.016, 1.12 },
                {   1.15, 0.0076,  0.117, 1.36 },
                {   1.98, 0.0157, -0.004, 1.23 },
                {  -2.22, 0.0029,  0.037, 1.09 },
                {   4.70, 0.0333, -0.154, 1.38 },
                {  -6.42, 0.0594, -0.228, 2.48 },
                {  -7.93, 0.0487, -0.394, 1.24 },
                {   1.57, 0.0874, -0.504, 0.78 },
                {  -6.92, 0.0739, -0.395, 1.05 },
                {   4.65, 0.0341, -0.484, 2.18 },
                {   7.10, 0.0326, -0.477, 2.00 },
                {   3.31, 0.0024, -0.090, 0.62 },
                {   6.83, 0.0138, -0.045, 1.04 },
                {   3.71, 0.0137,  0.033, 0.81 },
                {   1.95, 0.0043,  0.147, 0.89 },
                {   4.91, 0.0192,  0.046, 1.69 },
                {  -7.47, 0.0488, -0.021, 1.18 },
                {  -1.09, 0.1051, -0.221, 1.17 },
                {  -1.72, 0.0322, -0.244, 0.95 },
                {   1.83, 0.0078,  0.083, 1.12 },
                {   1.71, 0.0049,  0.080, 0.79 },
                {  -7.24, 0.0012,  0.077, 2.08 },
                {   6.08, 0.0644, -0.131, 1.28 },
                {   1.86, 0.0131,  0.088, 0.69 },
                {   2.80, 0.0010,  0.068, 1.03 },
                {   1.66, 0.0094,  0.158, 1.20 },
                {   1.34, 0.0106,  0.162, 1.06 },
                {   2.36, 0.0090,  0.016, 1.18 },
                {   4.98, 0.0204,  0.118, 1.36 },
                {   3.02, 0.0314,  0.042, 1.57 },
                {  -7.98, 0.0452, -0.069, 1.06 },
                {   3.45, 0.0900, -0.390, 1.49 },
                {  -6.74, 0.0270, -0.688, 1.64 },
                { -12.86, 0.0538, -0.283, 1.87 },
                {  -9.34, 0.0526, -0.671, 1.56 },
                {  10.03, 0.0389, -0.981, 1.49 },
                {   5.26, 0.0299, -0.463, 1.31 },
                {   8.95, 0.0248, -0.442, 0.78 },
                {   5.51, 0.0182, -0.007, 0.90 },
                {   1.94, 0.0060,  0.356, 0.59 },
                {   1.23, 0.0041,  0.260, 0.97 },
                {  14.45, 0.0526, -0.013, 1.40 },
                {  -7.35, 0.0467,  0.223, 1.45 },
                {  -7.39, 0.0479, -0.138, 0.76 },
                {   2.00, 0.0174, -0.406, 1.05 },
                {   1.70, 0.0159, -0.080, 0.95 },
                {   1.74, 0.0073,  0.060, 0.51 },
                {   7.04, 0.0567, -0.400, 0.97 },
                {   1.20, 0.0077,  0.195, 0.98 },
                {   4.47, 0.0043,  0.206, 0.76 },
                {   3.85, 0.0297, -0.106, 0.99 },
                {   3.75, 0.0372, -0.085, 1.51 },
                {  -7.03, 0.0149,  0.077, 0.58 },
                {  -3.14, 0.0625, -0.537, 1.06 },
                {   4.01, 0.0421, -0.884, 1.34 },
                {   2.83, 0.0164, -0.375, 1.60 },
                {  -1.09, 0.0118, -0.143, 0.83 },
                {   2.59, 0.0291, -0.264, 0.78 },
                {   1.31, 0.0136,  0.581, 0.65 },
                {   4.08, 0.0142,  0.321, 0.65 },
                {   3.77, 0.0084,  0.219, 0.97 },
                {  -2.02, 0.0253, -0.548, 0.68 },
                {  -3.00, 0.0204, -0.658, 1.18 },
                {  -7.95, 0.0095, -0.283, 1.33 },
                {   3.54, 0.0592, -0.752, 1.35 },
                {   3.91, 0.0872, -1.002, 1.14 },
                {  -1.11, 0.0040, -0.305, 0.91 },
                { -11.04, 0.0265, -0.409, 0.93 },
                {   3.27, 0.0689, -1.163, 1.56 },
                {  -6.89, 0.0663, -0.678, 2.17 },
                {   1.12, 0.0448, -0.321, 1.40 },
                {   3.26, 0.0076,  0.161, 0.80 },
                {   2.00, 0.0056,  0.334, 0.63 },
                {  -2.28, 0.0138,  0.373, 0.92 },
                {  -2.61, 0.0264,  0.446, 0.88 },
                {  -9.24, 0.0299, -0.309, 0.79 },
            };
            #endregion

            // A ColorScheme is not needed because all points have their own Brush
            CScatterData i_Data = new CScatterData(null);

            for (int P = 0; P < d_Values.GetLength(0); P++)
            {
                double d_Value = d_Values[P, 0];
                int s32_Radius = (int)Math.Abs(d_Value) + 1;

                double X = d_Values[P,1];
                double Y = d_Values[P,2];
                double Z = d_Values[P,3];

                EnumScatterShape e_Shape = (d_Value < 0) ? EnumScatterShape.Square : EnumScatterShape.Triangle;
                Brush         i_Brush = (d_Value < 0) ? Brushes.Red          : Brushes.Lime;

                string s_Tooltip = "Value = " + Editor3DRenderer.FormatDouble(d_Value);

                // The original double value is passed to the callback when the user selects this point with ALT + Left click.
                CPoint3D i_Point = new CPoint3D(X, Y, Z, s_Tooltip, d_Value);  
                
                // You can store the returned shape in a variable and later modify it's properties
                CShape3D i_Shape = i_Data.AddShape(i_Point, e_Shape, s32_Radius, i_Brush);

                // pre-select the biggest shapes
                if (Math.Abs(d_Value) > 10)
                    i_Shape.Selected = true;
            }

            CMessgData i_Mesg1 = new CMessgData("Negative Values (size of square represents value)",   7,  -7, Color.Red);
            CMessgData i_Mesg2 = new CMessgData("Positive Values (size of triangle represents value)", 7, -24, Color.Lime);

            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.Separate;
            editor3D.AddRenderData (i_Data);
            editor3D.AddMessageData(i_Mesg1, i_Mesg2);

            editor3D.Selection.HighlightColor = Color.Blue;
            editor3D.Selection.Callback       = OnSelectEvent;
            editor3D.Selection.MultiSelect    = true;
            editor3D.Selection.Enabled        = true;
            editor3D.Invalidate();

            // For scatter shapes Single Point selection mode does not make a difference
            checkPointSelection.Enabled = false;

            // This demo ignores the ColorScheme
            comboColors.Enabled = false; 
        }

        // ================================================================================================

        /// <summary>
        /// This demonstrates how to set X, Y, Z scatterplot points in form of a heart
        /// </summary>
        private void DemoValentine()
        {
            const int WIDTH = 12;
            List<CPoint3D> i_Points = new List<CPoint3D>();

            double X = 0.0;
            double Z = 0.0;
            for (double P = 0.0; P <= Math.PI * 1.32; P += 0.025)
            {
                X = Math.Cos(P) * 1.8 - 1.8;
                Z = Math.Sin(P) * 3.0 + 6.0;

                i_Points.Add   (   new CPoint3D( X, -X, Z, "Upper Right Part"));
                i_Points.Insert(0, new CPoint3D(-X,  X, Z, "Upper Left Part"));
            }

            double d_X = X / 70;
            double d_Z = Z / 70;
            while (Z >= 0.0)
            {
                i_Points.Add   (   new CPoint3D( X, -X, Z, "Lower Right Part"));
                i_Points.Insert(0, new CPoint3D(-X,  X, Z, "Lower Left Part"));

                X -= d_X;
                Z -= d_Z;
            }

            i_Points.Add(new CPoint3D(0.0, 0.0, 0.0, "Zero"));

            CLineData i_Data = new CLineData(new CColorScheme(Color.Red));
            i_Data.AddConnectedLines(i_Points, WIDTH, null);

            CMessgData i_Mesg = new CMessgData("Happy Valentine's day, Sweetheart!", 7, -7, Color.Red);

            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.MaintainXYZ;
            editor3D.AddRenderData (i_Data);
            editor3D.AddMessageData(i_Mesg);

            editor3D.Selection.Callback = null;  
            editor3D.Selection.Enabled  = false;
            editor3D.Invalidate();

            // Selection does not make sense for this demo

            // This demo ignores the ColorScheme
            comboColors.Enabled = false; 
        }

        // ================================================================================================

        private void DemoSphere(EnumPolygonMode e_Mode, bool b_Closed)
        {
            const int LONGI  = 50; // count of 3D points along the longitude (360 degree)
            const int LATI   = 25; // count of 3D points along the latitude  (180 degree)
            const int RADIUS = 20;

            // ------ Calculate 3D points ------ 

            CPoint3D[,] i_Points = new CPoint3D[LONGI, LATI];

            for (int Long=0; Long<LONGI; Long++)
            {
                double d_Theta = 2 * Math.PI / LONGI * Long;

                for (int Lati=0; Lati<LATI; Lati++)
                {
                    double d_Phi = Math.PI / LATI * Lati;

                    // Cartesian coordinates
                    double X = RADIUS * Math.Sin(d_Phi) * Math.Cos(d_Theta) * 1.3;
                    double Y = RADIUS * Math.Sin(d_Phi) * Math.Sin(d_Theta);
                    double Z = RADIUS * Math.Cos(d_Phi);

                    i_Points[Long, Lati] = new CPoint3D(X, Y, Z);
                }
            }

            // ------ Create rectangular 3D polygons ------ 

            // In Line mode the pen is used to draw the polygon border lines. The color is assigned from the ColorScheme.
            // In Fill mode the pen is used to draw the thin separator lines (always 1 pixel, black)
            Pen i_Pen = (e_Mode == EnumPolygonMode.Lines) ? new Pen(Color.Yellow, 2) : Pens.Black;

            CColorScheme i_Scheme = new CColorScheme(me_ColorScheme);
            CPolygonData i_Data   = new CPolygonData(e_Mode, i_Pen, i_Scheme);

            // Omit top and bottom where ploygons become very narrow.
            // In case of the open sphere, omit 4 rows of rectangles so the interior becomes visible.
            int s32_Omit = b_Closed ? 1 : 4;

            for (int Long=0; Long<LONGI; Long++) // 0 .... 360 degree
            {
                // overflow to zero if maximum exceeded
                int NextLong = (Long + 1) % LONGI; 

                for (int Lati=s32_Omit; Lati<LATI-s32_Omit; Lati++) 
                {
                    int NextLati = Lati + 1;

                    // You can store the returned polygon in a variable and later modify it's properties
                    CPolygon3D i_Poly = i_Data.AddPolygon(null, i_Points[Long,     Lati],
                                                                i_Points[NextLong, Lati],
                                                                i_Points[NextLong, NextLati],
                                                                i_Points[Long,     NextLati]);                   
                }
            }

            // ----- Close the top and bottom with a round polygon ------

            if (e_Mode == EnumPolygonMode.Fill && b_Closed)
            {
                List<CPoint3D> i_ListTop    = new List<CPoint3D>();
                List<CPoint3D> i_ListBottom = new List<CPoint3D>();
                for (int Long=0; Long<LONGI; Long++) // 0 .... 360 degree
                {
                    i_ListTop   .Add(i_Points[Long, 1]);
                    i_ListBottom.Add(i_Points[Long, LATI-1]);
                }

                // You can store the returned polygon in a variable and later modify it's properties
                CPolygon3D i_PolyTop    = i_Data.AddPolygon(null, i_ListTop   .ToArray());
                CPolygon3D i_PolyBottom = i_Data.AddPolygon(null, i_ListBottom.ToArray());
            }

            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.MaintainXYZ;
            editor3D.AxisY.LegendText = "Longitude";
            editor3D.AxisZ.LegendText = "Latitude";
            editor3D.LegendPos        = EnumLegendPos.AxisEnd;
            editor3D.AddRenderData(i_Data);

            editor3D.Selection.HighlightColor = Color.FromArgb(90,90,90);
            editor3D.Selection.Callback       = null;  
            editor3D.Selection.MultiSelect    = true;
            editor3D.Selection.Enabled        = true;
            editor3D.Invalidate();

            // Single point selection works only in Fill mode
            if (e_Mode == EnumPolygonMode.Lines)
                checkPointSelection.Enabled = false;

            // FIRST: Adjust Selection.SinglePoints which will remove all selections
            checkPointSelection.Checked = (e_Mode == EnumPolygonMode.Lines);

            // AFTER: Pre-select one polygon
            CPolygon3D i_Polygon = i_Data.AllPolygons[5];
            if (editor3D.Selection.SinglePoints)
            {
                // Select the 4 corner points of the polygon
                foreach (CPoint3D i_Point in i_Polygon.Points)
                {
                    i_Point.Selected = true;
                }
            }
            else
            {
                // Select the polygon itself
                i_Polygon.Selected = true;
            }

            // Send key events to the editor
            editor3D.Focus();
        }

        /// <summary>
        /// This event handler will only receive key events while the Editor3DRenderer control has the keyboard focus!
        /// If Editor3DRenderer does not show the blue border you must click into the editor.
        /// </summary>
        void OnEditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;

            if (me_Demo != eDemo.Sphere_Fill_Closed &&
                me_Demo != eDemo.Sphere_Fill_Open)
                return;

            // Delete all selected polygons
            CObject3D[] i_Selected = editor3D.Selection.GetSelectedObjects(EnumSelType.Polygon);
            if (i_Selected.Length > 0)
            {
                editor3D.RemoveObjects(i_Selected);

                mi_StatusTimer.Stop();
                statusLabel.Text = i_Selected.Length + " polygons have been removed.";
                mi_StatusTimer.Start();
            }

            // update statistics
            lblInfo.Text = editor3D.ObjectStatistics;

            editor3D.Invalidate();
        }

        // ================================================================================================

        private void DemoPyramid()
        {
            const int COLOR_PARTS = 50;
            CLineData i_Data = new CLineData(new CColorScheme(me_ColorScheme));

            CPoint3D i_Center  = new CPoint3D(45, 45, 40, "Center");
            CPoint3D i_Corner1 = new CPoint3D(45, 25, 20, "Corner 1");
            CPoint3D i_Corner2 = new CPoint3D(25, 45, 20, "Corner 2");
            CPoint3D i_Corner3 = new CPoint3D(45, 65, 20, "Corner 3");
            CPoint3D i_Corner4 = new CPoint3D(65, 45, 20, "Corner 4");

            // Add the 4 vertical lines which are rendered as 50 parts with different colors
            // You can store the returned line in a variable and later modify it's properties
            CLine3D i_Vert1 = i_Data.AddMultiColorLine(COLOR_PARTS, i_Center, i_Corner1, 4, null);
            CLine3D i_Vert2 = i_Data.AddMultiColorLine(COLOR_PARTS, i_Center, i_Corner2, 4, null);
            CLine3D i_Vert3 = i_Data.AddMultiColorLine(COLOR_PARTS, i_Center, i_Corner3, 4, null);
            CLine3D i_Vert4 = i_Data.AddMultiColorLine(COLOR_PARTS, i_Center, i_Corner4, 4, null);

            // Add the 4 base lines with solid color
            // You can store the returned line in a variable and later modify it's properties
            CLine3D i_Hor1 = i_Data.AddSolidLine(i_Corner1, i_Corner2, 8, null);
            CLine3D i_Hor2 = i_Data.AddSolidLine(i_Corner2, i_Corner3, 8, null);
            CLine3D i_Hor3 = i_Data.AddSolidLine(i_Corner3, i_Corner4, 8, null);
            CLine3D i_Hor4 = i_Data.AddSolidLine(i_Corner4, i_Corner1, 8, null);

            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.Separate;
            editor3D.AxisZ.IncludeZero = false;
            editor3D.AddRenderData(i_Data);

            editor3D.Selection.HighlightColor = Color.Green;
            editor3D.Selection.Callback       = OnSelectEvent;
            editor3D.Selection.MultiSelect    = true;
            editor3D.Selection.Enabled        = true;
            editor3D.Invalidate();

            // default: select lines of outer pyramid
            checkPointSelection.Checked = false;
        }

        // ================================================================================================

        void DemoAnimation()
        {
            const int SHAPES = 50;

            // The animation needs ColorScheme RainbowSweep which provides a cyclic rainbow with all colors.
            // The other schemes are useless because they have an incomplete rainbow or only 64 colors.
                       mi_SinusData = new CScatterData(new CColorScheme(EnumColorScheme.Rainbow_Sweep));
            CPolygonData i_PolyData = new CPolygonData(EnumPolygonMode.Fill, Pens.Black, null);

            for (int i=0; i<SHAPES; i++)
            {
                // The coordinates of the points will be set in ProcessAnimation()
                // You can store the returned shape in a variable and later modify it's properties
                CShape3D i_Shape = mi_SinusData.AddShape(new CPoint3D(0,0,0), EnumScatterShape.Circle, 5, null);
            }

            // ------------------------------------------------------

            // store the points of the pyramid
            mi_Pyramid    = new CPoint3D[5];
            mi_Pyramid[0] = new CPoint3D(-100, -100, 75, "Top");
            mi_Pyramid[1] = new CPoint3D(-100,  -50, 50, "Edge 1");
            mi_Pyramid[2] = new CPoint3D( -50, -100, 50, "Edge 2");
            mi_Pyramid[3] = new CPoint3D(-100, -150, 50, "Edge 3");
            mi_Pyramid[4] = new CPoint3D(-150, -100, 50, "Edge 4");

            // Create the polygons
            CPolygon3D i_Poly1 = i_PolyData.AddPolygon(Brushes.Orange,    mi_Pyramid[0], mi_Pyramid[1], mi_Pyramid[2]); // Side
            CPolygon3D i_Poly2 = i_PolyData.AddPolygon(Brushes.Gold,      mi_Pyramid[0], mi_Pyramid[2], mi_Pyramid[3]); // Side
            CPolygon3D i_Poly3 = i_PolyData.AddPolygon(Brushes.Goldenrod, mi_Pyramid[0], mi_Pyramid[3], mi_Pyramid[4]); // Side
            CPolygon3D i_Poly4 = i_PolyData.AddPolygon(Brushes.Sienna,    mi_Pyramid[0], mi_Pyramid[4], mi_Pyramid[1]); // Side
            CPolygon3D i_Poly5 = i_PolyData.AddPolygon(Brushes.Tomato,    mi_Pyramid[1], mi_Pyramid[2], mi_Pyramid[3], mi_Pyramid[4]); // Bottom

            ProcessAnimation();

            // ------------------------------------------------------

            CMessgData i_Mesg = new CMessgData("CPU Load < 1%", 7, -7, Color.Gray);

            editor3D.Clear();
            editor3D.Normalize = EnumNormalize.Separate;
            editor3D.AddRenderData (mi_SinusData, i_PolyData);
            editor3D.AddMessageData(i_Mesg);

            editor3D.Selection.Callback = null;              
            editor3D.Selection.Enabled  = false; 
            editor3D.Invalidate();

            mi_AnimationTimer.Start();

            // Selection does not make sense for this demo

            // This demo ignores the ColorScheme
            comboColors.Enabled = false; 
        }

        void OnAnimationTimer(object sender, EventArgs e)
        {
            ProcessAnimation();
            editor3D.Invalidate();
        }

        void ProcessAnimation()
        {
            ms32_AnimationAngle ++;

            // ======== SCATTER =========

            CShape3D[]   i_AllShapes   = mi_SinusData.AllShapes;
            CColorScheme i_ColorScheme = mi_SinusData.ColorScheme;
            double       d_DeltaX      = 400.0 / i_AllShapes.Length;

            double d_X = -200.0;
            for (int S=0; S<i_AllShapes.Length; S++, d_X += d_DeltaX)
            {
                CShape3D i_Shape = i_AllShapes[S];

                i_Shape.Points[0].X =  d_X;
                i_Shape.Points[0].Y = -d_X;
                i_Shape.Points[0].Z = Math.Sin((ms32_AnimationAngle + d_X) / 50.0) * 50.0 + 50.0;

                i_Shape.Brush = i_ColorScheme.GetBrush(ms32_AnimationAngle * 10);
            }

            // ======== PYRAMID =========

            double d_Angle   = ms32_AnimationAngle / 30.0;
            double d_Sinus   = Math.Sin(d_Angle) * 50.0; // -50 ... +50
            double d_Cosinus = Math.Cos(d_Angle) * 50.0; // -50 ... +50
            double d_DeltaZ  = d_Sinus / 2.0;            // -25 ... +25

            // Top
            mi_Pyramid[0].X = -100.0;
            mi_Pyramid[0].Y = -100.0;
            mi_Pyramid[0].Z =   70.0 + d_DeltaZ; 
            // Edge 1
            mi_Pyramid[1].X = -100.0 + d_Sinus;
            mi_Pyramid[1].Y = -100.0 + d_Cosinus;
            mi_Pyramid[1].Z =   40.0 + d_DeltaZ;
            // Edge 2
            mi_Pyramid[2].X = -100.0 + d_Cosinus;
            mi_Pyramid[2].Y = -100.0 - d_Sinus;
            mi_Pyramid[2].Z =   40.0 + d_DeltaZ;
            // Edge 3
            mi_Pyramid[3].X = -100.0 - d_Sinus;
            mi_Pyramid[3].Y = -100.0 - d_Cosinus;
            mi_Pyramid[3].Z =   40.0 + d_DeltaZ;
            // Edge 4
            mi_Pyramid[4].X = -100.0 - d_Cosinus;
            mi_Pyramid[4].Y = -100.0 + d_Sinus;
            mi_Pyramid[4].Z =   40.0 + d_DeltaZ;
        }

        // ================================================================================================

        /// <summary>
        /// This callback is used by multiple demos.
        /// The callback function is called when the left mouse is down and the ALT key is pressed.
        /// Select objects with ALT only. Drag with ALT + CTRL.
        /// e_Event is the current mouse action (Down, Drag, Up).
        /// e_Modifiers are the modifier keys that are down (Control, Shift, Alt).
        /// s32_DeltaX, s32_DeltaY are the relative mouse movement in pixels since the last event.
        /// i_Object is the 3D object (point, shape, line, polygon) that the mouse is clicking or dragging.
        /// ATTENTION: i_Object may be null if the user has ALT-clicked a location without 3D object!
        /// Read the detailed comment of function Editor3DRenderer.SelectionCallback()
        /// </summary>
        private EnumInvalidate OnSelectEvent(EnumSelEvent e_Event, Keys e_Modifiers, int s32_DeltaX, int s32_DeltaY, CObject3D i_Object)
        {
            EnumInvalidate e_Invalidate = EnumInvalidate.NoChange;

            bool b_CTRL = (e_Modifiers & Keys.Control) > 0;
            
            // The left mouse button went down with ALT key down and CTRL key up
            if (e_Event == EnumSelEvent.MouseDown && !b_CTRL && i_Object != null)
            {
                i_Object.Selected = !i_Object.Selected;

                // After changing the selection status the object must be redrawn.
                e_Invalidate = EnumInvalidate.Invalidate;
            }
            else if (e_Event == EnumSelEvent.MouseDrag && b_CTRL)
            {
                // The user is dragging the mouse with ALT + CTRL keys down.
                // Convert the mouse movement in the 2D space into a movement in the 3D space.
                CPoint3D i_Project = editor3D.ReverseProject(s32_DeltaX, s32_DeltaY);

                // GetSelectedPoints() returns only unique points.
                CPoint3D[] i_Selected = editor3D.Selection.GetSelectedPoints(EnumSelType.All);
                foreach (CPoint3D i_Point in i_Selected)
                {
                    switch (me_Demo)
                    {
                        case eDemo.Pyramid:
                        case eDemo.Scatter_Shapes:
                        case eDemo.Scatter_Plot:
                        case eDemo.Connected_Lines:
                            // The pyramid line end points / scatter shapes can be moved freely in the 3D space
                            i_Point.Move(i_Project.X, i_Project.Y, i_Project.Z);
                            break;

                        case eDemo.Surface_Fill:
                        case eDemo.Surface_Grid:
                        case eDemo.Surface_Fill_Missing:
                        case eDemo.Surface_Grid_Missing:
                            // The points in the Surface grid have a fixed X,Y position, only Z can be modified.
                            i_Point.Move(0, 0, i_Project.Z);
                            break;

                        default:
                            Debug.Assert(false);
                            break;
                    }
                }

                // Set flag to recalculate the coordinate system, then Invalidate()
                e_Invalidate = EnumInvalidate.CoordSystem;
            }

            mi_StatusTimer.Stop();
            statusLabel.Text = string.Format("Callback Event: {0},        Modifiers: {1},        DeltaX: {2},        DeltaY: {3},        Object: {4}", 
                                             e_Event, e_Modifiers, s32_DeltaX, s32_DeltaY, 
                                             (i_Object == null) ? "null" : i_Object.ObjType.ToString());
            mi_StatusTimer.Start();
            return e_Invalidate;
        }
    }
}
