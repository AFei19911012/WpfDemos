
/*****************************************************************************

This class has been written by Elmü (elmue@gmx.de)

Check if you have the latest version on:
https://www.codeproject.com/Articles/5293980/Graph3D-A-Windows-Forms-Render-Control-in-Csharp

=======================================
 
IMPORTANT:
This class has been written by a software developer with 45 years programming exprience.
This class is optimized for the highest possible speed in every line of it's code.
If you found a fork of this code on Github or elsewhere you do NOT have the original high quality code!
This code with 5000 lines is extremely complex and there is a very high risk that a beginner has 
broken this code by modifying it without properly understanding it.

=======================================
 
NAMING CONVENTIONS which allow to see the type of a variable immediately without having to jump to the variable definition:
 
     cName  for class    definitions
     tName  for type     definitions
     eName  for enum     definitions
     kName  for "konstruct" (struct) definitions (letter 's' already used for string)
   delName  for delegate definitions

    b_Name  for bool
    c_Name  for Char, also Color
    d_Name  for double
    e_Name  for enum variables
    f_Name  for function delegates, also float
    i_Name  for instances of classes
    k_Name  for "konstructs" (struct) (letter 's' already used for string)
	r_Name  for Rectangle
    s_Name  for strings
    o_Name  for objects
 
   s8_Name  for   signed  8 Bit (sbyte)
  s16_Name  for   signed 16 Bit (short)
  s32_Name  for   signed 32 Bit (int)
  s64_Name  for   signed 64 Bit (long)
   u8_Name  for unsigned  8 Bit (byte)
  u16_Name  for unsigned 16 bit (ushort)
  u32_Name  for unsigned 32 Bit (uint)
  u64_Name  for unsigned 64 Bit (ulong)

  An additional "m" is prefixed for all member variables (e.g. ms_String)


*****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Editor3D
{
    /// <summary>
    /// ATTENTION: This class is not thread safe.
    /// Call all functions only from the GUI thread or use Control.Invoke()
    /// </summary>
    public class Editor3DRenderer : UserControl
    {
        #region CObject3D

        /// <summary>
        /// Base class for CPoint3D, CShape3D, CLine3D, cPloygon3D
        /// </summary>
        public abstract class CObject3D
        {
            public Editor3DRenderer   mi_Inst;
            protected object mo_Tag;
            protected bool       mb_Selected;
            protected bool       mb_CanSelect = true;
            protected CPoint3D[] mi_Points; // This instance must never be replaced by a new array!
            protected int        ms32_Col = -1;
            protected int        ms32_Row = -1;

            // --------------------------------------------------

            /// <summary>
            /// Gets the type of this CObject3D
            /// </summary>
            public virtual EnumObjType ObjType => throw new NotImplementedException();

            /// <summary>
            /// 1 point  for CPoint3D
            /// 1 point  for CShape3D
            /// 2 points for CLine3D
            /// n points for CPolygon3D
            /// </summary>
            public CPoint3D[] Points => mi_Points;

            /// <summary>
            /// The column in the grid.
            /// This is only valid for Polygons and Scatter circles created by CSurfaceData, otherwise -1
            /// </summary>
            public int Column => ms32_Col;

            /// <summary>
            /// The row in the grid.
            /// This is only valid for Polygons and Scatter circles created by CSurfaceData, otherwise -1
            /// </summary>
            public int Row => ms32_Row;

            /// <summary>
            /// Here you can store your private data which is passed in Selection.Callback to your code.
            /// </summary>
            public object Tag
            {
                get { return mo_Tag;  }
                set 
                {
                    if (mo_Tag == value)
                    {
                        return;
                    }

                    mo_Tag = value; 
                }
            }

            /// <summary>
            /// The draw object has been selected by ALT + click
            /// </summary>
            public virtual bool Selected
            {
                get { return mb_Selected;  }
                set 
                {
                    if (mb_Selected == value)
                    {
                        return;
                    }
                    
                    mb_Selected = value; 
                }
            }

            /// <summary>
            /// Defines if the user is allowed to select this object
            /// </summary>
            public virtual bool CanSelect
            {
                get { return mb_CanSelect;  }
                set 
                {
                    if (mb_CanSelect == value)
                    {
                        return;
                    }

                    mb_CanSelect = value; 
                }
            }

            /// <summary>
            /// Move the object in the 3D space
            /// </summary>
            public void Move(double d_DeltaX, double d_DeltaY, double d_DeltaZ)
            {
                foreach (CPoint3D i_Point in mi_Points)
                {
                    i_Point.X += d_DeltaX;
                    i_Point.Y += d_DeltaY;
                    i_Point.Z += d_DeltaZ;
                }
            }
        }

        #endregion

        #region CObject3D

        public class CPoint3D : CObject3D
        {
            private double md_X;
            private double md_Y;
            private double md_Z;
            private string ms_Tooltip;

            // --------------------------------------------------

            /// <summary>
            /// Gets the type of this CObject3D
            /// </summary>
            public override EnumObjType ObjType => EnumObjType.Point;

            /// <summary>
            /// 3D coordinate
            /// </summary>
            public double X
            {
                get { return md_X;  }
                set
                {
                    if (md_X == value)
                    {
                        return;
                    }

                    if (mi_Inst != null) 
                    {
                        mi_Inst.me_Recalculate |= EnumRecalculate.Objects;

                        if (value < mi_Inst.mi_Bounds.X.Min || value > mi_Inst.mi_Bounds.X.Max)
                        {
                            mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem;
                        }
                    }
                    md_X = value; 
                }
            }

            /// <summary>
            /// 3D coordinate
            /// </summary>
            public double Y
            {
                get { return md_Y;  }
                set 
                {
                    if (md_Y == value)
                    {
                        return;
                    }

                    if (mi_Inst != null) 
                    {
                        mi_Inst.me_Recalculate |= EnumRecalculate.Objects;

                        if (value < mi_Inst.mi_Bounds.Y.Min || value > mi_Inst.mi_Bounds.Y.Max)
                        {
                            mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem;
                        }
                    }
                    md_Y = value; 
                }
            }

            /// <summary>
            /// 3D coordinate
            /// </summary>
            public double Z
            {
                get { return md_Z;  }
                set 
                {
                    if (md_Z == value)
                    {
                        return;
                    }

                    if (mi_Inst != null)
                    {
                        mi_Inst.me_Recalculate |= EnumRecalculate.Objects;

                        if (value < mi_Inst.mi_Bounds.Z.Min || value > mi_Inst.mi_Bounds.Z.Max)
                        {
                            mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem;
                        }
                    }
                    md_Z = value; 
                }
            }

            /// <summary>
            /// Optional tooltip text to be displayed when the mouse is over this point
            /// </summary>
            public string Tooltip
            => ms_Tooltip;

            // --------------------------------------------------

            /// <summary>
            /// Constructor
            /// s_ToolTip is displayed when EnumTooltip.UserText is enabled
            /// In o_Tag you can store any data that you need when the Selection callback is called after the user has selected a point. 
            /// </summary>
            public CPoint3D(double d_X, double d_Y, double d_Z, string s_ToolTip = null, object o_Tag = null)
            {
                md_X      = d_X;
                md_Y      = d_Y;
                md_Z      = d_Z;
                mo_Tag    = o_Tag;
                mi_Points = new CPoint3D[] { this };

                if (s_ToolTip != null)
                {
                    ms_Tooltip = s_ToolTip.Trim();
                }
            }

            // =================== used for coordinate system ===================

            public CPoint3D Clone() => new CPoint3D(md_X, md_Y, md_Z, ms_Tooltip, Tag);

            public bool CoordEquals(CPoint3D i_Point) => md_X == i_Point.md_X && md_Y == i_Point.md_Y && md_Z == i_Point.md_Z;

            public double GetValue(EnumCoord e_Coord)
            {
                switch (e_Coord)
                {
                    case EnumCoord.X: return md_X;
                    case EnumCoord.Y: return md_Y;
                    case EnumCoord.Z: return md_Z;
                    default:       return 0;
                }
            }

            public void SetValue(EnumCoord e_Coord, double d_Value)
            {
                switch (e_Coord)
                {
                    case EnumCoord.X: X = d_Value; break;
                    case EnumCoord.Y: Y = d_Value; break;
                    case EnumCoord.Z: Z = d_Value; break;
                }
            }

            // For debugging in Visual Studio
            public override string ToString() => string.Format("CPoint3D (X={0}, Y={1}, Z={2})", FormatDouble(md_X), FormatDouble(md_Y), FormatDouble(md_Z));
        }

        #endregion

        #region CLine3D

        public class CLine3D : CObject3D
        {
            private Pen mi_Pen;
            private int ms32_Width;
            private int ms32_Parts;

            // --------------------------------------------------

            /// <summary>
            /// Gets the type of this CObject3D
            /// </summary>
            public override EnumObjType ObjType => EnumObjType.Line;

            /// <summary>
            /// The line width in pixels
            /// </summary>
            public int Width
            => ms32_Width;

            /// <summary>
            /// If Pen is null, a Pen from the ColorScheme will be used.
            /// The width of the Pen does not matter. It will be set to the property Width.
            /// IMPORTANT:
            /// If you use the UndoBuffer you must never modify any property of the Pen assigned here.
            /// If you externally change for example Pen.Color the Undo will not work correctly.
            /// Always assign a different instance of Pen to avoid this.
            /// </summary>
            public Pen Pen
            => mi_Pen;

            /// <summary>
            /// Parts of different color in multi-color lines
            /// </summary>
            public int ColorParts => ms32_Parts;

            /// <summary>
            /// Constructor
            /// IMPORTANT:
            /// If you use the UndoBuffer you must never modify any property of the Pen assigned here.
            /// If you externally change for example Pen.Color the Undo will not work correctly.
            /// Always assign a different instance of Pen to CLine3D.Pen to avoid this.
            /// </summary>
            public CLine3D(CPoint3D i_Start, CPoint3D i_End, int s32_Width, Pen i_Pen, int s32_Parts, object o_Tag = null)
            {
                mi_Points  = new CPoint3D[] { i_Start, i_End };
                ms32_Width = s32_Width;
                mi_Pen     = i_Pen;
                ms32_Parts = s32_Parts;
                mo_Tag     = o_Tag;
            }

            // For debugging in Visual Studio
            public override string ToString() => "CLine3D from " + mi_Points[0] + " to " + mi_Points[1];
        }

        #endregion

        #region CShape3D

        public class CShape3D : CObject3D
        {
            private EnumScatterShape me_Shape;
            private int           ms32_Radius;
            private Brush         mi_Brush;

            // --------------------------------------------------

            /// <summary>
            /// Gets the type of this CObject3D
            /// </summary>
            public EnumScatterShape Shape
            {
                get { return me_Shape; }
                set
                {
                    if (me_Shape == value)
                    {
                        return;
                    }

                    // Circle and rectangle are drawn by the framework --> no recalculation required.
                    if (mi_Inst != null)
                    {
                        if (value != EnumScatterShape.Circle && value != EnumScatterShape.Square)
                        {
                            mi_Inst.me_Recalculate |= EnumRecalculate.Objects;
                        }
                    }
                    me_Shape = value;
                }
            }


            /// <summary>
            /// The radius of the circle, square or triangle
            /// </summary>
            public int Radius
            {
                get { return ms32_Radius; }
                set
                {
                    if (ms32_Radius == value)
                    {
                        return;
                    }

                    if (mi_Inst != null)
                    {
                        mi_Inst.me_Recalculate |= EnumRecalculate.Objects;
                    }
                    ms32_Radius = value;
                }
            }

            /// <summary>
            /// The color of the Shape or null to use a color from the ColorScheme
            /// IMPORTANT:
            /// If you use the UndoBuffer you must never modify any property of the Brush assigned here.
            /// If you externally change for example SolidBrush.Color the Undo will not work correctly.
            /// Always assign a different instance of Brush to avoid this.
            /// </summary>
            public Brush Brush
            {
                get { return mi_Brush; }
                set
                {
                    if (mi_Brush == value)
                        return;

                    if (mi_Inst != null)
                    {
                        mi_Inst.me_Recalculate |= EnumRecalculate.Objects;
                    }
                    mi_Brush = value;
                }
            }

            /// <summary>
            /// The shape is selected
            /// </summary>
            public override bool Selected
            {
                get { return mi_Points[0].Selected;  }
                set { mi_Points[0].Selected = value; } // me_Recalculate needs no change
            }

            /// <summary>
            /// Defines if the user is allowed to select this shape
            /// </summary>
            public override bool CanSelect
            {
                get { return mi_Points[0].CanSelect;  }
                set { mi_Points[0].CanSelect = value; }
            }

            /// <summary>
            /// Constructor
            /// IMPORTANT:
            /// If you use the UndoBuffer you must never modify any property of the Brush assigned here.
            /// If you externally change for example SolidBrush.Color the Undo will not work correctly.
            /// Always assign a different instance of Brush to CShape3D.Brush to avoid this.
            /// </summary>
            public CShape3D(int s32_Col, int s32_Row, CPoint3D i_Point, EnumScatterShape e_Shape, int s32_Radius, Brush i_Brush, object o_Tag = null)
            {
                ms32_Col     = s32_Col;
                ms32_Row     = s32_Row;
                i_Point.Tag  = o_Tag;
                mi_Points    = new CPoint3D[] { i_Point };
                me_Shape     = e_Shape;
                ms32_Radius  = s32_Radius;
                mi_Brush     = i_Brush;
                mo_Tag       = o_Tag;
            }

            // For debugging in Visual Studio
            public override string ToString() => "CShape3D " + me_Shape + " at " + mi_Points[0];
        }

        #endregion

        #region CPolygon3D

        public class CPolygon3D : CObject3D
        {
            private Brush mi_Brush;
            // --------------------------------------------------

            /// <summary>
            /// Gets the type of this CObject3D
            /// </summary>
            public override EnumObjType ObjType => EnumObjType.Polygon;

            /// <summary>
            /// The color of the Polygon or null to use a color from the ColorScheme
            /// IMPORTANT:
            /// If you use the UndoBuffer you must never modify any property of the Brush assigned here.
            /// If you externally change for example SolidBrush.Color the Undo will not work correctly.
            /// Always assign a different instance of Brush to avoid this.
            /// </summary>
            public Brush Brush
            => mi_Brush;

            /// <summary>
            /// Constructor
            /// IMPORTANT:
            /// If you use the UndoBuffer you must never modify any property of the Brush assigned here.
            /// If you externally change for example SolidBrush.Color the Undo will not work correctly.
            /// Always assign a different instance of Brush to CPolygon3D.Brush to avoid this.
            /// </summary>
            public CPolygon3D(int s32_Col, int s32_Row, Brush i_Brush, params CPoint3D[] i_Points)
            {
                if (i_Points.Length < 3)
                {
                    throw new ArgumentException("At least 3 points are required to draw a polygon.");
                }

                mi_Points = i_Points;
                mi_Brush  = i_Brush;
                ms32_Col  = s32_Col;
                ms32_Row  = s32_Row;
            }

            // For debugging in Visual Studio
            public override string ToString() => "CPolygon3D (" + mi_Points.Length + " points)";
        }

        #endregion

        #region CAxis

        /// <summary>
        /// Used for the main axes and raster lines of the coordinate system
        /// </summary>
        [Serializable]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class CAxis
        {
            private Editor3DRenderer   mi_Inst;
            private EnumCoord     me_Coord;
            private Pen        mi_RasterPen;   // Raster lines (brigther)
            private Pen        mi_AxisPen;     // Main coordinate axis (darker)
            private SolidBrush mi_LegendBrush; // Label text
            private string     ms_LegendText;
            private bool       mb_Mirror;
            private bool       mb_IncludeZero;

            public CAxis(Editor3DRenderer i_Inst, EnumCoord e_Coord, Color c_Color)
            {
                mi_Inst  = i_Inst;
                me_Coord = e_Coord;
                Color    = c_Color;
                Reset();
            }

            public void Reset()
            {
                ms_LegendText  = null;
                mb_Mirror      = false;
                mb_IncludeZero = me_Coord == EnumCoord.Z;
            }

            /// <summary>
            /// The color of the axis lines and the legend. 
            /// This change will become visible the next time you call Invalidate()
            /// Not modified by Reset()
            /// </summary>
            public Color Color
            {
                get { return mi_AxisPen.Color; }
                set
                {
                    mi_LegendBrush = new SolidBrush(value);
                    mi_AxisPen     = new Pen(value, 3);
                    mi_RasterPen   = new Pen(BrightenColor(value), 1);
                    mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem;
                }
            }

            /// <summary>
            /// Internally used to draw raster lines (brighter)
            /// </summary>
            [Browsable(false)]
            public Pen RasterPen => mi_RasterPen;

            /// <summary>
            /// Internally used to draw main coordinates (darker)
            /// </summary>
            [Browsable(false)]
            public Pen AxisPen => mi_AxisPen;

            /// <summary>
            /// Internally used for label text
            /// </summary>
            [Browsable(false)]
            public SolidBrush LegendBrush => mi_LegendBrush;

            /// <summary>
            /// Here you can add an optional legend which is displayed for the axis.
            /// With the property Editor3D.LegendPos you can define where the legend is drawn.
            /// If the string is null or empty, no legend will be displayed for this axis.
            /// This change will become visible the next time you call Invalidate()
            /// </summary>
            public string LegendText
            {
                get { return ms_LegendText; }
                set { ms_LegendText = value; }
            }

            /// <summary>
            /// In the default rotation angle the axis values are normally increasing 
            /// from right to left (X), back to front (Y) and bottom to top (Z).
            /// If Mirror = true they will decrease instead of increase.
            /// This change will become visible the next time you call Invalidate()
            /// </summary>
            public bool Mirror
            {
                get { return mb_Mirror; }
                set
                {
                    if (mb_Mirror == value)
                        return;

                    if (me_Coord == EnumCoord.Z)
                        throw new NotImplementedException("Mirroring the Z axis is not implemented because there are multiple issues and it does not make sense to draw the Z values reverse.");

                    Debug.Assert(!mi_Inst.InvokeRequired); // Call only from GUI thread
                    mb_Mirror = value;
                    mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
                }
            }

            /// <summary>
            /// Example: If the axis has values from 4 to 10 and
            /// IncludeZero = false --> the coordinate axis has a range from 4 to 10
            /// IncludeZero = true  --> the coordinate axis has a range from 0 to 10 (default)
            /// ATTENTION: This setting is ignored if the coordinate system is not drawn (EnumRaster.Off)
            /// This change will become visible the next time you call Invalidate()
            /// </summary>
            public bool IncludeZero
            {
                get { return mb_IncludeZero; }
                set
                {
                    if (mb_IncludeZero == value)
                        return;

                    Debug.Assert(!mi_Inst.InvokeRequired); // Call only from GUI thread
                    mb_IncludeZero = value;
                    mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
                }
            }
        }

        #endregion

        #region CSelection

        /// <summary>
        /// This class controls the user selection of points, lines, shapes and polygons
        /// </summary>
        [Serializable]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class CSelection
        {
            private Editor3DRenderer  mi_Inst;
            private bool              mb_Enabled;
            private bool              mb_MultiSel;
            private bool              mb_SinglePoints;
            private delSelectHandler  mf_Callback;
            private Color             mc_HighlightColor = Color.Empty;
            private Brush             mi_HighlightBrush;
            private Pen               mi_HighlightPen;

            public CSelection(Editor3DRenderer i_Inst)
            {
                mi_Inst = i_Inst;
            }

            /// <summary>
            /// This property defines if the user is allowed to select 3D objects.
            /// The selection will only be visible if HighlightColor has also been set.
            /// The callback  will only be called  if Callback has also been assigned.
            /// </summary>
            public bool Enabled
            {
                get => mb_Enabled;
                set => mb_Enabled = value;
            }

            /// <summary>
            /// This defines the color with which selected draw objects / points are painted.
            /// If you pass Color.Empty draw objects will not be highlighted although they are selected!
            /// This change will become visible the next time you call Invalidate()
            /// </summary>
            public Color HighlightColor
            {
                set
                {
                    if (value.A > 0)
                    {
                        mi_HighlightBrush = new SolidBrush(value);
                        mi_HighlightPen = new Pen(value);
                        mi_HighlightPen.StartCap = LineCap.Round;
                        mi_HighlightPen.EndCap = LineCap.Round;
                    }
                    else
                    {
                        mi_HighlightBrush = null;
                        mi_HighlightPen = null;
                    }
                    mc_HighlightColor = value;
                }
                get
                {
                    return mc_HighlightColor;
                }
            }

            [Browsable(false)]
            public Pen HighlightPen
            {
                get 
                {
                    if (mb_Enabled)
                    {
                        return mi_HighlightPen;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            [Browsable(false)]
            public Brush HighlightBrush
            {
                get 
                {
                    if (mb_Enabled)
                    {
                        return mi_HighlightBrush;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            /// <summary>
            /// true  --> allow selection of multiple 3D objects at once
            /// false --> allow only selection of a single 3D object at a time
            /// This setting will be ignored when a Callback is assigned.
            /// The callback is responsible for any selection changes!
            /// </summary>
            public bool MultiSelect
            {
                get => mb_MultiSel;
                set => mb_MultiSel = value;
            }

            /// <summary>
            /// Enables selection of single points.
            /// true  --> the user can only select single points of a polygon or the end points of a line.
            /// false --> the user can only select an entire polygon or an entire line.
            /// For scatter shapes this setting does not matter because a scatter shape corresponds to one point.
            /// IMPORTANT: Selecting entire polygons makes only sense if Fill mode is used. Otherwise polygons are transparent 
            /// and a click would hit the background behind the polygon, so this setting is ignored for polygons in Line mode.
            /// This change will become visible the next time you call Invalidate()
            /// </summary>
            public bool SinglePoints
            {
                get => mb_SinglePoints;
                set
                {
                    mb_SinglePoints = value;

                    // A mix of selected lines or polygons and selected points is possible but the user will be confused.
                    DeSelectAll();
                }
            }

            /// <summary>
            /// IMPORTANT: Read the detailed comment of function SelectionCallback() at the end of this class.
            /// You can set null here to turn off the callback.
            /// </summary>
            [Browsable(false)]
            public delSelectHandler Callback
            {
                set => mf_Callback = value;
                get => mf_Callback;
            }

            /// <summary>
            /// Returns selected CLine3D, CShape3D or cPoygon3D objects.
            /// Multiple enums can be combined. Example: GetSelectedObjects(EnumSelType.Line | EnumSelType.Shape)
            /// NOTE: For Shape3D the selection of the shape itself and it's point is always the same.
            /// </summary>
            public CObject3D[] GetSelectedObjects(EnumSelType e_SelType)
            {
                List<CObject3D> i_List = new List<CObject3D>();
                foreach (CDrawObj i_Object in mi_Inst.mi_UserObjects)
                {
                    if (!i_Object.Selected || (i_Object.SelType & e_SelType) == 0)
                    {
                        continue;
                    }
                    
                    i_List.Add(i_Object.mi_Object3D);
                }
                return i_List.ToArray();
            }

            /// <summary>
            /// Gets the points that the user may select individually if Selection.SinglePoints = true
            /// and gets all points of a Line3D or Polygon3D if it is selected.
            /// Multiple enums can be combined. Example: GetSelectedPoints(EnumSelType.Line | EnumSelType.Shape)
            /// NOTE: The returned array contains only unique points.
            /// NOTE: For Shape3D the selection of the shape itself and it's point is always the same.
            /// </summary>
            public CPoint3D[] GetSelectedPoints(EnumSelType e_SelType)
            {
                List<CPoint3D> i_Unique = new List<CPoint3D>();

                foreach (CDrawObj i_Object in mi_Inst.mi_UserObjects)
                {
                    if ((i_Object.SelType & e_SelType) == 0)
                    {
                        continue;
                    }

                    // If the object itself is selected return all it's points, no matter if the points are selected or not.
                    if (i_Object.Selected)
                    {
                        foreach (CPoint i_Point in i_Object.mi_Points)
                        {
                            if (!i_Unique.Contains(i_Point.mi_P3D))
                            {
                                i_Unique.Add(i_Point.mi_P3D);
                            }
                        }
                    }
                    else // object not selected --> check if single points of the object are selected
                    {
                        foreach (CPoint i_Point in i_Object.mi_Points)
                        {
                            if (i_Point.mi_P3D.Selected && !i_Unique.Contains(i_Point.mi_P3D))
                            {
                                i_Unique.Add(i_Point.mi_P3D);
                            }
                        }
                    }
                }
                return i_Unique.ToArray();
            }

            /// <summary>
            /// Remove the selection from all draw objects
            /// This change will become visible the next time you call Invalidate()
            /// </summary>
            public void DeSelectAll()
            {
                foreach (CDrawObj i_Obj in mi_Inst.mi_UserObjects)
                {
                    i_Obj.Selected = false;

                    foreach (CPoint i_Point in i_Obj.mi_Points)
                    {
                        i_Point.mi_P3D.Selected = false;
                    }
                }
            }
        }

        #endregion

        #region CUserInput

        public class CUserInput
        {
            private MouseButtons me_MouseButton;
            private Keys         me_Modifiers;
            private EnumMouseAction me_Action;
            private Cursor       mi_Cursor;

            /// <summary>
            /// A unique identifier for the combination of mouse button and modifier(s)
            /// Keys.Shift            = 0x00010000
            /// Keys.Control          = 0x00020000
            /// Keys.Alt              = 0x00040000
            /// MouseButtons.Left     = 0x00100000
            /// MouseButtons.Right    = 0x00200000
            /// MouseButtons.Middle   = 0x00400000
            /// MouseButtons.XButton1 = 0x00800000
            /// MouseButtons.XButton2 = 0x01000000
            /// </summary>
            public int GetUID() => (int)me_MouseButton | (int)me_Modifiers;

            public MouseButtons MouseButton => me_MouseButton;
            public Keys Modifiers => me_Modifiers;
            public EnumMouseAction Action => me_Action;
            public Cursor Cursor => mi_Cursor;

            public CUserInput(MouseButtons e_MouseButton, Keys e_Modifiers, EnumMouseAction e_Action, Cursor i_Cursor = null)
            {
                me_MouseButton = e_MouseButton;
                me_Modifiers   = e_Modifiers;
                me_Action      = e_Action;
                mi_Cursor      = i_Cursor;

                if (mi_Cursor == null)
                {
                    switch (e_Action)
                    {
                        case EnumMouseAction.ThetaAndPhi: mi_Cursor = Cursors.SizeAll;     break;
                        case EnumMouseAction.Theta:       mi_Cursor = Cursors.NoMoveVert;  break;
                        case EnumMouseAction.Phi:         mi_Cursor = Cursors.NoMoveHoriz; break;
                        case EnumMouseAction.Rho:         mi_Cursor = Cursors.SizeNS;      break;
                        case EnumMouseAction.Move:        mi_Cursor = Cursors.NoMove2D;    break;
                        default:                       mi_Cursor = Cursors.Arrow;       break;
                    }
                }
            }

            /// <summary>
            /// For debugging in Visual Studio
            /// </summary>
            public override string ToString() => string.Format("MouseButton: {0}, Modifiers: {1} --> Action: {2}", me_MouseButton, me_Modifiers, me_Action);
        }

        #endregion

        #region CRenderData

        /// <summary>
        /// Base class for CSurfaceData, CScatterData, CLineData, CPolygonData
        /// </summary>
        public abstract class CRenderData
        {
            public virtual void AddDrawObjects(Editor3DRenderer i_Inst) => throw new NotImplementedException();

            /// <summary>
            /// The width and color of the Pen may be modified later.
            /// So the immutable framework collection like Pens.Black,... cannot be used here.
            /// </summary>
            protected static void CheckPenMutable(Pen i_Pen, CColorScheme i_ColorScheme)
            {
                if (i_Pen != null && i_ColorScheme != null)
                {
                    try
                    { 
                        i_Pen.Color = Color.BlanchedAlmond;
                    }
                    catch
                    { 
                        throw new ArgumentException("To use a color scheme create a new Pen. Do not use the immutable Pens.XYZ collection.");
                    }
                }
            }
        }

        #endregion

        #region CSurfaceData

        public class CSurfaceData : CRenderData
        {
            private bool          mb_Fill;
            private bool          mb_Missing;
            private int           ms32_Cols;
            private int           ms32_Rows;
            private int           ms32_Radius;
            private Pen           mi_Pen;
            private CPoint3D[,]   mi_PointArray;
            private CPolygon3D[,] mi_PolygonArray;
            private CColorScheme  mi_ColorScheme;

            public CColorScheme ColorScheme => mi_ColorScheme;

            /// <summary>
            /// The count of points in one column of the surface grid
            /// </summary>
            public int Cols => ms32_Cols;

            /// <summary>
            /// The count of points in one row of the surface grid
            /// </summary>
            public int Rows => ms32_Rows;

            /// <summary>
            /// Fill Mode:
            /// ------------
            /// Polygons are filled with a color from the ColorScheme.
            /// If you want only one color, set a ColorScheme which contains only one color.
            /// The Pen is used to draw the thin lines between the polygons (mostly black, 1 pixel)
            /// If Pen is null, no lines are drawn.
            /// 
            /// Line Mode:
            /// ------------
            /// Only the border lines of the polygons are drawn.
            /// The Pen is used to draw these lines. The Pen's color and width will be modified.
            /// 
            /// Missing Mode:
            /// --------------
            /// s32_Radius > 0 allows missing points.
            /// s32_Radius defines the radius of cicles that represent points which have not enough neigbours to draw a polygon.
            /// </summary>
            public CSurfaceData(int s32_Cols, int s32_Rows, EnumPolygonMode e_Mode, Pen i_Pen, CColorScheme i_ColorScheme, int s32_Radius = 0)
            {
                if (s32_Cols < 3 || s32_Rows < 3)
                {
                    throw new ArgumentException("CSurfaceData needs at least 3 columns and 3 rows");
                }

                if (e_Mode == EnumPolygonMode.Fill)
                {
                    if (i_ColorScheme == null)
                    {
                        throw new ArgumentException("In Fill mode you must specify a ColorScheme");
                    }

                    // The border pen is allowed to be immutable. It will not be changed.
                }
                else // Lines
                {
                    if (i_Pen == null)
                    {
                        throw new ArgumentException("In Line mode you must specify a Line Pen");
                    }

                    CheckPenMutable(i_Pen, i_ColorScheme);
                }

                mb_Fill        = e_Mode == EnumPolygonMode.Fill;
                mb_Missing     = s32_Radius > 0;
                ms32_Radius    = s32_Radius;
                ms32_Cols      = s32_Cols;
                ms32_Rows      = s32_Rows;
                mi_Pen         = i_Pen;
                mi_ColorScheme = i_ColorScheme;
                mi_PointArray  = new CPoint3D[s32_Cols, s32_Rows];
            }

            /// <summary>
            /// Here you can set a callback function which will be called with X,Y to calculate the Z values of the points.
            /// </summary>
            public void ExecuteFunction(DelRendererFunction f_Function, PointF k_Start, PointF k_End)
            {
                mb_Missing = false;

                double d_StepX = (k_End.X - k_Start.X) / (ms32_Cols - 1);
                double d_StepY = (k_End.Y - k_Start.Y) / (ms32_Rows - 1);

                for (int C = 0; C < ms32_Cols; C++)
                {
                    double d_X = k_Start.X + d_StepX * C;

                    for (int R = 0; R < ms32_Rows; R++)
                    {
                        double d_Y = k_Start.Y + d_StepY * R;
                        double d_Z = f_Function(d_X, d_Y);

                        SetPointAt(C, R, new CPoint3D(d_X, d_Y, d_Z));
                    }
                }
            }

            /// <summary>
            /// IMPORTANT: 
            /// The X coordinate of the point must be related to the column.
            /// The Y coordinate of the point must be related to the row.
            /// </summary>
            public void SetPointAt(int s32_Column, int s32_Row, CPoint3D i_Point3D)
            {
                if (mi_PolygonArray != null)
                {
                    throw new Exception("You cannot call CSurfaceData.SetPointAt() or ExecuteFunction() anymore after calling GetPolygonAt() "
                                      + "or Editor3DRenderer.AddRenderData(). To modify a point after the polygons have been created call "
                                      + "GetPointAt() and modify the X,Y,Z values of the returned point.");
                }

                mi_PointArray[s32_Column, s32_Row] = i_Point3D;
            }

            /// <summary>
            /// ATTENTION: 
            /// In mode 'Missing' null may be returned or polygons with only 3 corners!
            /// </summary>
            public CPoint3D GetPointAt(int s32_Column, int s32_Row) => mi_PointArray[s32_Column, s32_Row];

            /// <summary>
            /// ATTENTION: 
            /// The polygons have one row less than CSurfaceData.Rows and one column less than CSurfaceData.Cols
            /// </summary>
            public CPolygon3D GetPolygonAt(int s32_Column, int s32_Row)
            {
                CreatePolygons();
                return mi_PolygonArray[s32_Column, s32_Row];
            }

            private void CreatePolygons()
            {
                if (mi_PolygonArray != null)
                {
                    return;
                }

                CPolygon3D[,] i_TempArr = new CPolygon3D[ms32_Cols -1, ms32_Rows -1];

                List<CPoint3D> i_Valid = new List<CPoint3D>();
                for (int C=0; C < ms32_Cols -1; C++)
                {
                    for (int R=0; R < ms32_Rows -1; R++)
                    {
                        i_Valid.Clear();
                        if (mi_PointArray[C,   R]   != null) i_Valid.Add(mi_PointArray[C,   R]);
                        if (mi_PointArray[C,   R+1] != null) i_Valid.Add(mi_PointArray[C,   R+1]);
                        if (mi_PointArray[C+1, R+1] != null) i_Valid.Add(mi_PointArray[C+1, R+1]);
                        if (mi_PointArray[C+1, R]   != null) i_Valid.Add(mi_PointArray[C+1, R]);

                        if (i_Valid.Count < 4 && !mb_Missing)
                        {
                            throw new Exception("CSurfaceData: You must call CSurfaceData.SetPointAt() for all points!");
                        }

                        if (i_Valid.Count < 3)
                        {
                            continue; // A polygon needs at least 3 points
                        }
                                
                        i_TempArr[C, R] = new CPolygon3D(C, R, null, i_Valid.ToArray());
                    }
                }

                mi_PolygonArray = i_TempArr;
            }

            // =============================================================================

            /// <summary>
            /// Called from AddRenderData()
            /// </summary>
            public override void AddDrawObjects(Editor3DRenderer i_Inst)
            {
                CreatePolygons();

                bool b_Added = false;
                List<CPoint3D> i_Used = new List<CPoint3D>();

                foreach (CPolygon3D i_Poly3D in mi_PolygonArray)
                {
                    if (i_Poly3D == null)
                    {
                        continue;
                    }

                    i_Inst.AddDrawObject(new CPolygon(mb_Fill, i_Poly3D, mi_Pen, mi_ColorScheme));
                    b_Added = true;

                    foreach (CPoint3D i_Point3D in i_Poly3D.Points)
                    {
                        if (!i_Used.Contains(i_Point3D))
                        {
                            i_Used.Add(i_Point3D);
                        }
                    }
                }

                // Add all the remaining points as Scatter circles that are not part of a polygon.
                for (int C = 0; C < ms32_Cols; C++)
                {
                    for (int R = 0; R < ms32_Rows; R++)
                    {
                        CPoint3D i_Point3D = mi_PointArray[C, R];
                        if (i_Point3D == null || i_Used.Contains(i_Point3D))
                        {
                            continue;
                        }

                        CShape3D i_Shape3D = new CShape3D(C, R, i_Point3D, EnumScatterShape.Circle, ms32_Radius, null);
                        i_Inst.AddDrawObject(new CShape  (i_Shape3D, mi_ColorScheme));
                        b_Added = true;
                    }
                }

                if (!b_Added)
                {
                    throw new Exception("You cannot draw a completely empty SurfaceData");
                }
            }
        }

        #endregion

        #region

        public class CScatterData : CRenderData
        {
            private List<CShape3D> mi_Shapes3D  = new List<CShape3D>();
            private CColorScheme   mi_ColorScheme;

            public CShape3D[] AllShapes
            {
                get { return mi_Shapes3D.ToArray(); }
            }

            public CColorScheme ColorScheme
            => mi_ColorScheme;

            /// <summary>
            /// Constructor
            /// If all Scatter shapes contain a valid Brush, you can pass i_ColorScheme == null here
            /// </summary>
            public CScatterData(CColorScheme i_ColorScheme)
            {
                mi_ColorScheme = i_ColorScheme;
            }

            /// <summary>
            /// s32_Radius defines the size of the shape and i_Brush the color
            /// </summary>
            public CShape3D AddShape(CPoint3D i_Point, EnumScatterShape e_Shape, int s32_Radius, Brush i_Brush, object o_Tag = null)
            {
                CShape3D i_Shape3D = new CShape3D(-1, -1, i_Point, e_Shape, s32_Radius, i_Brush, o_Tag);
                mi_Shapes3D.Add(i_Shape3D);
                return i_Shape3D;
            }

            // =============================================================================

            /// <summary>
            /// Called from AddRenderData()
            /// </summary>
            public override void AddDrawObjects(Editor3DRenderer i_Inst)
            {
                foreach (CShape3D i_Shape3D in mi_Shapes3D)
                {
                    i_Inst.AddDrawObject(new CShape(i_Shape3D, mi_ColorScheme));
                }
            }
        }

        #endregion

        #region CLineData

        public class CLineData : CRenderData
        {
            private List<CLine3D> mi_Lines3D = new List<CLine3D>();
            private CColorScheme  mi_ColorScheme;

            public CLine3D[] AllLines => mi_Lines3D.ToArray();

            public CColorScheme ColorScheme => mi_ColorScheme;

            /// <summary>
            /// Constructor
            /// If you use only solid lines and specify a valid Pen, you can pass i_ColorScheme == null here
            /// </summary>
            public CLineData(CColorScheme i_ColorScheme) => mi_ColorScheme = i_ColorScheme;

            /// <summary>
            /// Add a line which will be drawn entirely in one color.
            /// </summary>
            public CLine3D AddSolidLine(CPoint3D i_Start, CPoint3D i_End, int s32_Width, Pen i_Pen, object o_Tag = null)
            {
                CheckPenMutable(i_Pen, mi_ColorScheme);

                CLine3D i_Line3D = new CLine3D(i_Start, i_End, s32_Width, i_Pen, 1, o_Tag);
                mi_Lines3D.Add(i_Line3D);
                return i_Line3D;
            }

            /// <summary>
            /// Add a line which will appear with multiple colors of the ColorScheme by drawing it in multiple parts.
            /// If s32_Parts = 50, the line is rendered in 50 parts where each part has it's own color depending on the Z coordinate.
            /// </summary>
            public CLine3D AddMultiColorLine(int s32_Parts, CPoint3D i_Start, CPoint3D i_End, int s32_Width, Pen i_Pen, object o_Tag = null)
            {
                if (s32_Parts < 3)
                {
                    throw new ArgumentException("Multi color lines require at least 3 parts");
                }

                if (mi_ColorScheme == null)
                {
                    throw new Exception("To create a multi-color line you must specify a ColorScheme");
                }

                CheckPenMutable(i_Pen, mi_ColorScheme);

                CLine3D i_Line3D = new CLine3D(i_Start, i_End, s32_Width, i_Pen, s32_Parts, o_Tag);
                mi_Lines3D.Add(i_Line3D);
                return i_Line3D;
            }

            /// <summary>
            /// Creates connected lines from the points in the given order
            /// </summary>
            public CLine3D[] AddConnectedLines(List<CPoint3D> i_Points, int s32_Width, Pen i_Pen)
            {
                CheckPenMutable(i_Pen, mi_ColorScheme);

                List<CLine3D> i_NewLines = new List<CLine3D>();

                CPoint3D i_Prev = null;
                for (int i=0; i<i_Points.Count; i++)
                {
                    CPoint3D i_Point = i_Points[i];
                    if (i_Prev != null)
                    {
                        CLine3D i_Line3D = new CLine3D(i_Prev, i_Point, s32_Width, i_Pen, 1);
                        i_NewLines.Add(i_Line3D);
                        mi_Lines3D.Add(i_Line3D);
                    }
                    i_Prev = i_Point;
                }
                return i_NewLines.ToArray();
            }

            // =============================================================================

            /// <summary>
            /// Called from AddRenderData()
            /// </summary>
            public override void AddDrawObjects(Editor3DRenderer i_Inst)
            {
                foreach (CLine3D i_Line3D in mi_Lines3D)
                {
                    i_Inst.AddDrawObject(new CLine(i_Line3D, mi_ColorScheme));
                }
            }
        }

        #endregion

        #region CPolygonData

        public class CPolygonData : CRenderData
        {
            private bool             mb_Fill;
            private Pen              mi_Pen;
            private CColorScheme     mi_ColorScheme;
            private List<CPolygon3D> mi_Polygons3D = new List<CPolygon3D>();

            public CPolygon3D[] AllPolygons => mi_Polygons3D.ToArray();

            public CColorScheme ColorScheme => mi_ColorScheme;

            /// <summary>
            /// Fill Mode:
            /// ------------
            /// Polygons are filled with a color from the ColorScheme.
            /// If you want only one color, set a ColorScheme which contains only one color.
            /// The Pen is used to draw the thin lines between the polygons (mostly black, 1 pixel)
            /// If Pen is null, no lines are drawn.
            /// 
            /// Line Mode:
            /// ------------
            /// Only the border lines of the polygons are drawn.
            /// The Pen is used to draw these lines. The Pen's color and width will be modified.
            /// </summary>
            public CPolygonData(EnumPolygonMode e_Mode, Pen i_Pen, CColorScheme i_ColorScheme)
            {
                if (e_Mode == EnumPolygonMode.Lines)
                {
                    if (i_Pen == null)
                    {
                        throw new ArgumentException("In Line mode you must specify a Line Pen");
                    }

                    CheckPenMutable(i_Pen, i_ColorScheme);
                }

                mb_Fill        = e_Mode == EnumPolygonMode.Fill;
                mi_Pen         = i_Pen;
                mi_ColorScheme = i_ColorScheme;
            }

            /// <summary>
            /// In contrast to other drawing libraries (like WPF or Direct3D) you can add polygons of any dimension here.
            /// A polygon can have any amount of corners (minimum 3).
            /// The Brush can be specified in Fill mode. To use a Brush from the ColorScheme set i_Brush = null.
            /// </summary>
            public CPolygon3D AddPolygon(Brush i_Brush, params CPoint3D[] i_Points3D)
            {
                CPolygon3D i_Polygon3D = new CPolygon3D(-1, -1, i_Brush, i_Points3D);               
                mi_Polygons3D.Add(i_Polygon3D);
                return i_Polygon3D;
            }

            // =============================================================================

            /// <summary>
            /// Called from AddRenderData()
            /// </summary>
            public override void AddDrawObjects(Editor3DRenderer i_Inst)
            {
                foreach (CPolygon3D i_Polygon3D in mi_Polygons3D)
                {
                    i_Inst.AddDrawObject(new CPolygon(mb_Fill, i_Polygon3D, mi_Pen, mi_ColorScheme));
                }
            }
        }

        #endregion

        #region CMessgData

        public class CMessgData
        {
            private string  ms_Text;
            private Brush   mi_Brush;
            private int     ms32_PosX;
            private int     ms32_PosY;
            private Font    mi_Font;
            private SizeF   mk_Size;

            /// <summary>
            /// Here you can change the text without loading all the render objects again.
            /// The change will become visible the next time you call Invalidate()
            /// </summary>
            public string Text
            {
                set
                {
                    ms_Text = value;
                    mk_Size = SizeF.Empty;
                }
            }

            /// <summary>
            /// Here you can change the text color without loading all the render objects again.
            /// The change will become visible the next time you call Invalidate()
            /// </summary>
            public Color TextColor
            {
                set { mi_Brush = new SolidBrush(value); }
            }

            /// <summary>
            /// If X is negative, it is displayed right  aligned at X pixels from the right
            /// If Y is negative, it is displayed bottom aligned at Y pixels from the bottom
            /// </summary>
            public CMessgData(string s_Text, int X, int Y, Color c_Color,
                              FontStyle e_FontStyle = FontStyle.Bold, 
                              int     s32_FontSize  = 9, 
                              string    s_FontFace  = "Tahoma")
            {
                ms_Text   = s_Text;
                ms32_PosX = X;
                ms32_PosY = Y;
                mi_Brush  = new SolidBrush(c_Color);
                mi_Font   = new Font(s_FontFace, s32_FontSize, e_FontStyle);
            }

            public void Draw(Graphics i_Graph, Rectangle k_Client)
            {
                if (string.IsNullOrEmpty(ms_Text))
                {
                    return;
                }

                float X = ms32_PosX;
                float Y = ms32_PosY;

                if (X < 0 || Y < 0)
                {
                    // Speed optimization: Measure the size only once.
                    if (mk_Size.IsEmpty)
                    {
                        mk_Size = i_Graph.MeasureString(ms_Text, mi_Font);
                    }

                    if (X < 0)
                    {
                        X += k_Client.Width - mk_Size.Width;
                    }
                    if (Y < 0)
                    {
                        Y += k_Client.Height - mk_Size.Height;
                    }
                }

                i_Graph.DrawString(ms_Text, mi_Font, mi_Brush, X, Y);
            }
        }

        #endregion

        #region CPoint2D

        // <summary>
        /// This class represents a point in the 2D space, in pixels.
        /// </summary>
        private class CPoint2D
        {
            public double md_X;
            public double md_Y;

            public CPoint2D()
            {
            }

            public CPoint2D(double X, double Y)
            {
                md_X = X;
                md_Y = Y;
            }

            public CPoint2D Clone()
            {
                return new CPoint2D(md_X, md_Y);
            }

            public PointF Coord
            {
                get { return new PointF((float)md_X, (float)md_Y); }
            }

            public bool IsValid
            {
                get
                {
                    // The screen will always be smaller than 9999 pixels
                    return (!Double.IsNaN(md_X) && Math.Abs(md_X) < 9999.9 &&
                            !Double.IsNaN(md_Y) && Math.Abs(md_Y) < 9999.9);
                }
            }

            /// <summary>
            /// Use the good old Pythagoras to calculate the pixel distance between this point and X, Y.
            /// </summary>
            public int CalcDistanceTo(int X, int Y)
            {
                int s32_DiffX = (int)md_X - X;
                int s32_DiffY = (int)md_Y - Y;
                return (int)Math.Sqrt(s32_DiffX * s32_DiffX + s32_DiffY * s32_DiffY);
            }

            // For debugging in Visual Studio
            public override string ToString() => string.Format("CPoint2D (X={0}, Y={1})", Editor3DRenderer.FormatDouble(md_X), Editor3DRenderer.FormatDouble(md_Y));
        }

        #endregion

        #region CPoint

        /// <summary>
        /// This class contains the 3D point and it's projection into the 2D space.
        /// </summary>
        private class CPoint
        {
            public  CPoint3D mi_P3D;
            public  CPoint2D mi_P2D;
            public  int      ms32_RadiusTip; // if 0 --> no tooltip

            public CPoint(double d_X, double d_Y, double d_Z)
            {
                mi_P3D = new CPoint3D(d_X, d_Y, d_Z);
                mi_P2D = new CPoint2D();
            }

            /// <summary>
            /// The radius defines at which distance of the mouse from the 2D point the tooltip pops up.
            /// Radius = 0 --> no tooltip
            /// </summary>
            public CPoint(CPoint3D i_Point3D, int s32_RadiusTip)
            {
                mi_P3D = i_Point3D;
                mi_P2D = new CPoint2D();

                if (s32_RadiusTip > 0)
                {
                    ms32_RadiusTip = s32_RadiusTip + TOOLTIP_RADIUS;
                }
            }

            /// <summary>
            /// Projects the 3D coordinates into the 2D space (pixels on the screen).
            /// </summary>
            public void Project3D(Editor3DRenderer i_Inst, EnumMirror e_Mirror)
            {
                mi_P2D = i_Inst.mi_Transform.Project3D(mi_P3D, e_Mirror);
            }

            /// <summary>
            /// For Debugging in Visual Studio
            /// </summary>
            public override string ToString() => string.Format("CPoint [{0} = {1}]", mi_P3D, mi_P2D);
        }

        #endregion

        #region CTooltip

        private class CTooltip
        {
            private Editor3DRenderer     mi_Inst    = null;
            private EnumTooltip     me_Mode    = EnumTooltip.All;
            private ToolTip      mi_Tooltip = new ToolTip();
            private List<CPoint> mi_Points  = new List<CPoint>();
            private CPoint       mi_Last    = null;

            public EnumTooltip Mode
            {
                get { return me_Mode;  }
                set => me_Mode = value;
            }

            // Constructor
            public CTooltip(Editor3DRenderer i_Inst)
            {
                mi_Inst = i_Inst;

                mi_Tooltip.AutoPopDelay = 30000; // The maximum that Windows allows are 32.767 seconds (0x7FFF milliseconds)
                mi_Tooltip.InitialDelay = 50;
                mi_Tooltip.ReshowDelay  = 50;
            }

            public void Clear()
            {
                mi_Points.Clear();
                mi_Last = null;
                Hide();
            }

            public void AddPoint(CPoint i_Point)
            {
                // ATTENTION adding a 
                // && !mi_Points.Contains(i_Point)
                // here would make this function 40 times slower!
                // The more points are already in mi_Points, the slower it would become.
                // Several points will be added multiple times here, but this does not affect the functioning of the tooltip.
                if (i_Point != null && i_Point.ms32_RadiusTip > 0)
                    mi_Points.Add(i_Point);
            }

            public void Hide()
            {
                mi_Tooltip.Hide(mi_Inst);
            }

            public void OnMouseMove(MouseEventArgs e)
            {
                if (me_Mode == EnumTooltip.Off)
                {
                    Hide();
                    return;
                }

                int s32_MouseX = e.X - mi_Inst.mi_Mouse.mk_OffMove.X - mi_Inst.mi_Mouse.mk_OffCoord.X;
                int s32_MouseY = e.Y - mi_Inst.mi_Mouse.mk_OffMove.Y - mi_Inst.mi_Mouse.mk_OffCoord.Y;
                
                int  s32_MinDist = int.MaxValue;
                CPoint i_Nearest = null;
                foreach (CPoint i_Point in mi_Points)
                {
                    int s32_Dist = i_Point.mi_P2D.CalcDistanceTo(s32_MouseX, s32_MouseY);
                    if (s32_Dist < s32_MinDist)
                    {
                        s32_MinDist = s32_Dist;
                        i_Nearest   = i_Point;
                    }
                }

                if (i_Nearest != null && s32_MinDist < i_Nearest.ms32_RadiusTip)
                {
                    if (mi_Last == i_Nearest)
                        return; // The mouse is still over the same point
                    
                    mi_Last = i_Nearest;

                    string s_TT = "";
                    if ((me_Mode & EnumTooltip.Coord) > 0)
                        s_TT = string.Format("X = {0}\nY = {1}\nZ = {2}\n", FormatDouble(i_Nearest.mi_P3D.X), 
                                                                            FormatDouble(i_Nearest.mi_P3D.Y), 
                                                                            FormatDouble(i_Nearest.mi_P3D.Z));
                
                    if ((me_Mode & EnumTooltip.UserText) > 0 && i_Nearest.mi_P3D.Tooltip != null)
                        s_TT += i_Nearest.mi_P3D.Tooltip;

                    s_TT = s_TT.Trim();
                    if (s_TT.Length > 0)
                    {
                        mi_Tooltip.Show(s_TT, mi_Inst, e.X + 10, e.Y + 10);
                        return;
                    }
                }

                mi_Last = null;
                Hide();
            }
        }

        #endregion

        #region CDrawObj

        /// <summary>
        /// Base class for CLine, CShape, CPolygon
        /// </summary>
        private abstract class CDrawObj : IComparable
        {
            public    Editor3DRenderer      mi_Inst;
            public    SmoothingMode me_SmoothMode;
            public    CPoint[]      mi_Points;
            public    CObject3D     mi_Object3D;   // This is a CLine3D, CShape3D or CPolygon3D
            public    double        md_Sort;       // sorting is important. Always draw first back, then front objects.
            public    bool          mb_IsAxis;     // This is a line from the coordinate system
            protected double        md_AvrgZ;      // 3D center of the Z coordinates of all points in this object
            protected bool          mb_IsValid;
            protected EnumMirror       me_Mirror;

            // --------------------------------------------------

            /// <summary>
            /// Set after conversion 3D --> 2D. If invalid coordinates are found (NaN or > 9999) this returns false.
            /// If projection results in lines of thousands of pixels length, the drawing will become extremely slow.
            /// Do not draw lines or polygons outside the screen area.
            /// </summary>
            public bool IsValid => mb_IsValid;

            /// <summary>
            /// The object is selected
            /// </summary>
            public bool Selected
            {
                get => mi_Object3D.Selected;
                set => mi_Object3D.Selected = value;
            }

            /// <summary>
            /// The type of this object
            /// </summary>
            public virtual EnumSelType SelType => throw new NotImplementedException();

            /// <summary>
            /// Calculates colors from color scheme
            /// </summary>
            public virtual void ProcessColors() => throw new NotImplementedException();

            /// <summary>
            /// Calculates the 2D screen coordinates for each 3D point.
            /// </summary>
            public virtual void Project3D() => throw new NotImplementedException();

            /// <summary>
            /// Draw into Graphics
            /// </summary>
            public virtual void Render(Graphics i_Graph) => throw new NotImplementedException();

            /// <summary>
            /// Check if a user click at mouse point X, Y matches this draw object
            /// </summary>
            public virtual CObject3D MatchesPoint2D(int X, int Y) => throw new NotImplementedException();

            /// <summary>
            /// Uses the center of a draw object (e.g. the middle of a line) to calculate in which order the draw objects are rendered.
            /// This is called for all user defined objects, but not for the coordinate system which has it's own logic.
            /// </summary>
            public void CalcSortOrder()
            {
                double d_AvrgX = 0.0;
                double d_AvrgY = 0.0;
                      md_AvrgZ = 0.0;

                foreach (CPoint i_Point in mi_Points)
                {
                     d_AvrgX += i_Point.mi_P3D.X;
                     d_AvrgY += i_Point.mi_P3D.Y;
                    md_AvrgZ += i_Point.mi_P3D.Z;
                }

                 d_AvrgX /= mi_Points.Length;
                 d_AvrgY /= mi_Points.Length;
                md_AvrgZ /= mi_Points.Length;

                if (mi_Object3D.Row > -1) // only Polygons and Scatter circles created by CSurfaceData
                {
                    int X = mi_Object3D.Column + 1;
                    int Y = mi_Object3D.Row    + 1;

                    // Mirror axis values increasing / decreasing
                    if (mi_Inst.AxisX.Mirror && (me_Mirror & EnumMirror.X) > 0) X = 5000 - mi_Object3D.Column;
                    if (mi_Inst.AxisY.Mirror && (me_Mirror & EnumMirror.Y) > 0) Y = 5000 - mi_Object3D.Row;

                    // In case of a surface grid the Z value must be ignored because sorting is ALWAYS based on the position in the grid.
                    // Using the Z value here may even result in wrong sort order.
                    md_Sort = mi_Inst.mi_Transform.ProjectXY(X, Y);
                }
                else
                {
                    double X =  d_AvrgX;
                    double Y =  d_AvrgY;
                    double Z = md_AvrgZ;

                    // Mirror axis values increasing / decreasing
                    if (mi_Inst.AxisX.Mirror && (me_Mirror & EnumMirror.X) > 0) X = mi_Inst.mi_Bounds.X.Max - (X - mi_Inst.mi_Bounds.X.Min);
                    if (mi_Inst.AxisY.Mirror && (me_Mirror & EnumMirror.Y) > 0) Y = mi_Inst.mi_Bounds.Y.Max - (Y - mi_Inst.mi_Bounds.Y.Min);
                    if (mi_Inst.AxisZ.Mirror && (me_Mirror & EnumMirror.Z) > 0) Z = mi_Inst.mi_Bounds.Z.Max - (Z - mi_Inst.mi_Bounds.Z.Min);

                    // In case of any other 3D object the Z value must also be included in the calculation to avoid artifacts.
                    // Demo Sphere shows that the Z value is required if you move Theta to an extreme.
                    X = (X - mi_Inst.mi_Transform.mi_Center3D.X) * mi_Inst.mi_Transform.md_NormalizeX;
                    Y = (Y - mi_Inst.mi_Transform.mi_Center3D.Y) * mi_Inst.mi_Transform.md_NormalizeY;
                    Z = (Z - mi_Inst.mi_Transform.mi_Center3D.Z) * mi_Inst.mi_Transform.md_NormalizeZ;

                    md_Sort = mi_Inst.mi_Transform.ProjectXY(X, Y, Z);
                }
            }

            /// <summary>
            /// Used for sorting all DrawObjects from back to front
            /// </summary>
            int IComparable.CompareTo(object o_Comp) => md_Sort.CompareTo(((CDrawObj)o_Comp).md_Sort);
        }

        #endregion

        #region CLine

        private class CLine : CDrawObj
        {
            private CLine3D mi_Line3D;       // object passed to and from the user
            private Pen     mi_Pen;
            private Brush   mi_Brush;        // assigned to Pen
            private float   mf_LineWidth;    // Linewidth with zoom factor
            private float   mf_SelSize;      // size of selection points

            // -------- coordinate axes --------
            public  double  md_Angle;                    // needed to calculate current rotation quadrant of coordinate axis
            public  EnumCoord  me_Line   = EnumCoord.Invalid;  // main      coordinate in coordinate direction
            public  EnumCoord  me_Offset = EnumCoord.Invalid;  // secondary coordinate in coordinate direction
            public  string  ms_Label;                    // Label for axis
            
            // ---------- multicolor -----------
            private CPoint[]     mi_ColorPoints;         // all points on the line that are drawn separately
            private Brush[]      mi_ColorBrushes;        // all Brushes which are assigned to the Pen
            private CColorScheme mi_ColorScheme;

            public override EnumSelType SelType => EnumSelType.Line;

            /// <summary>
            /// Constructor 1 for coordinate system.
            /// LineWidth is always 1.
            /// </summary>
            public CLine(Editor3DRenderer i_Inst, EnumCoord e_Line, EnumCoord e_Offset, EnumMirror e_Mirror)
            {
                if (e_Line == e_Offset) mi_Pen = i_Inst.mi_Axis[(int)e_Line]  .AxisPen;   // Main axis
                else                    mi_Pen = i_Inst.mi_Axis[(int)e_Offset].RasterPen; // Raster line

                mi_Inst       = i_Inst;
                me_Line       = e_Line;
                me_Offset     = e_Offset;
                mi_Brush      = mi_Pen.Brush;
                mi_Points     = new CPoint[2];
                mi_Points[0]  = new CPoint(0, 0, 0);
                mi_Points[1]  = new CPoint(0, 0, 0);
                mb_IsAxis     = true;
                me_Mirror     = e_Mirror;
                me_SmoothMode = SmoothingMode.AntiAlias;
            }

            /// <summary>
            /// Constructor 2 for user lines
            /// if i_Line3D.Pen == null --> Pen from ColorScheme is used
            /// if i_Line3D.Pen != null --> ColorScheme will be ignored, even if a ColorScheme is specified
            /// An indvidual LineWidth can be defined in each CLine3D.
            /// </summary>
            public CLine(CLine3D i_Line3D, CColorScheme i_ColorScheme)
            {
                if (i_Line3D.Pen == null && i_ColorScheme == null)
                {
                    throw new ArgumentException("You must specify a Pen or a ColorScheme");
                }

                mi_ColorScheme = i_ColorScheme;
                mi_Line3D      = i_Line3D;
                mi_Object3D    = i_Line3D;
                mi_Pen         = i_Line3D.Pen; // get user's Pen or null
                mi_Points      = new CPoint[2];
                mi_Points[0]   = new CPoint(i_Line3D.Points[0], 1);
                mi_Points[1]   = new CPoint(i_Line3D.Points[1], 1);
                mb_IsAxis      = false;
                me_Mirror      = EnumMirror.All;
                me_SmoothMode  = SmoothingMode.AntiAlias;

                if (mi_Pen != null)
                {
                    // The original Brush must be stored separately because the same Pen may be used for multiple instances of CLine
                    // Changing the color of one line would affect all the others.
                    mi_Brush = mi_Pen.Brush;
                }
                else
                {
                    mi_Pen   = new Pen(Brushes.Black); // color and width will be changed below
                    mi_Brush = null;                   // Brush will be taken from colorscheme
                }
                mi_Pen.StartCap = LineCap.Round;
                mi_Pen.EndCap   = LineCap.Round;

                // ---------- multi color ---------

                if (i_Line3D.ColorParts > 1)
                {
                    mi_ColorBrushes = new Brush [i_Line3D.ColorParts];
                    mi_ColorPoints  = new CPoint[i_Line3D.ColorParts];
                }
            }

            public override void ProcessColors()
            {
                // If the user has changed the Pen --> use the new Pen and it's Brush
                if (mi_Line3D.Pen != null)
                {
                    mi_Pen   = mi_Line3D.Pen;
                    mi_Brush = mi_Pen.Brush;

                    mi_Pen.StartCap = LineCap.Round;
                    mi_Pen.EndCap   = LineCap.Round;
                }

                if (mi_ColorPoints != null) // multicolor line
                {
                    double d_X = mi_Points[0].mi_P3D.X;
                    double d_Y = mi_Points[0].mi_P3D.Y;
                    double d_Z = mi_Points[0].mi_P3D.Z;

                    double d_DeltaX = (mi_Points[1].mi_P3D.X - d_X) / mi_ColorPoints.Length;
                    double d_DeltaY = (mi_Points[1].mi_P3D.Y - d_Y) / mi_ColorPoints.Length;
                    double d_DeltaZ = (mi_Points[1].mi_P3D.Z - d_Z) / mi_ColorPoints.Length;

                    mi_ColorPoints[0] = mi_Points[0]; // Set Start Point

                    CPoint i_Prev = mi_Points[0];
                    for (int i=1; i<mi_ColorPoints.Length; i++)
                    {
                        d_X += d_DeltaX;
                        d_Y += d_DeltaY;
                        d_Z += d_DeltaZ;

                        CPoint i_Point = new CPoint(new CPoint3D(d_X, d_Y, d_Z), 0);

                        double d_AvrgZ     = (i_Prev.mi_P3D.Z + i_Point.mi_P3D.Z) / 2.0;
                        double d_FactorZ   = mi_Inst.mi_Bounds.CalcFactorZ(d_AvrgZ);
                        int    s32_Index   = mi_ColorScheme.CalcIndex(d_FactorZ);
                        mi_ColorBrushes[i] = mi_ColorScheme.GetBrush(s32_Index);
                        mi_ColorPoints [i] = i_Point;

                        i_Prev = i_Point;
                    }

                    mi_ColorPoints[mi_ColorPoints.Length -1] = mi_Points[1]; // Set End Point
                }
                else // solid line
                {
                    if (mi_ColorScheme != null)
                    {
                        // Load missing Pen from ColorScheme which the user has not specified.
                        double d_FactorZ = mi_Inst.mi_Bounds.CalcFactorZ(md_AvrgZ);
                        int    s32_Index = mi_ColorScheme.CalcIndex(d_FactorZ);
                        mi_Brush         = mi_ColorScheme.GetBrush(s32_Index);
                    }
                }
            }

            public override void Project3D()
            {
                CPoint[] i_PointArr = (mi_ColorPoints != null) ? mi_ColorPoints : mi_Points;
                foreach (CPoint i_Point in i_PointArr)
                {
                    i_Point.Project3D(mi_Inst, me_Mirror);
                }

                mb_IsValid = mi_Points[0].mi_P2D.IsValid && mi_Points[1].mi_P2D.IsValid;

                if (!mb_IsAxis)
                {
                    mf_LineWidth = (float)(mi_Line3D.Width * mi_Inst.mi_Transform.md_Zoom);
                    // Diameter of circle for selected points
                    mf_SelSize   = (float)(Math.Max(6, mi_Line3D.Width * 2) * mi_Inst.mi_Transform.md_Zoom);
                }
            }

            public override void Render(Graphics i_Graph)
            {
                // b_LineSel depends on the selection of the line only. It does not matter if an end point is selected or not.
                bool b_LineSel = !mb_IsAxis && Selected && mi_Inst.mi_Selection.HighlightPen != null;

                if (mi_ColorPoints == null || b_LineSel) // draw solid line
                {                  
                    Pen i_DrawPen;
                    if (b_LineSel)
                    {
                        i_DrawPen = mi_Inst.mi_Selection.HighlightPen;
                    }
                    else
                    {
                         i_DrawPen       = mi_Pen;
                         i_DrawPen.Brush = mi_Brush; // mi_Brush = null for multicolor lines!
                    }
                    
                    // Axis lines have always 1 pixel width
                    if (!mb_IsAxis)
                        i_DrawPen.Width = mf_LineWidth;
                    
                    i_Graph.DrawLine(i_DrawPen, mi_Points[0].mi_P2D.Coord, mi_Points[1].mi_P2D.Coord);
                }
                else // multi color
                {
                    mi_Pen.Width = mf_LineWidth;

                    CPoint i_Prev = mi_ColorPoints[0];
                    for (int i=1; i<mi_ColorPoints.Length; i++)
                    {
                        CPoint i_Point = mi_ColorPoints [i];
                        mi_Pen.Brush   = mi_ColorBrushes[i];
                        i_Graph.DrawLine(mi_Pen, i_Prev.mi_P2D.Coord, i_Point.mi_P2D.Coord);

                        i_Prev = i_Point;
                    }
                }

                // Draw circle for selected points
                foreach (CPoint i_Point in mi_Points)
                {
                    if (!i_Point.mi_P3D.Selected)
                    {
                        continue;
                    }
                    
                    float X = (float)i_Point.mi_P2D.md_X - mf_SelSize / 2.0f;
                    float Y = (float)i_Point.mi_P2D.md_Y - mf_SelSize / 2.0f;
                    i_Graph.FillEllipse(mi_Inst.mi_Selection.HighlightBrush, X, Y, mf_SelSize, mf_SelSize);
                }
            }

            /// <summary>
            /// Check if a user click at X, Y matches this draw object
            /// </summary>
            public override CObject3D MatchesPoint2D(int X, int Y)
            {
                if (mb_IsAxis)
                {
                    return null; // do not allow to select axis lines
                }

                int s32_MaxDist = Math.Max(1, (int)mi_Pen.Width / 2) + SELECT_RADIUS;

                if (mi_Inst.Selection.SinglePoints)
                {
                    foreach (CPoint i_Point in mi_Points)
                    {
                        if (i_Point.mi_P2D.CalcDistanceTo(X, Y) <= s32_MaxDist)
                        {
                            return i_Point.mi_P3D;
                        }
                    }
                }
                else // select entire line
                {
                    if (IsPointOnLine(mi_Points[0].mi_P2D, mi_Points[1].mi_P2D, X, Y, s32_MaxDist))
                    {
                        return mi_Line3D;
                    }
                }
                    
                return null;
            }

            // ---------------- Coord System ---------------

            /// <summary>
            /// Used while creating coordinate system
            /// Check if 2 lines have the same coordinates.
            /// </summary>
            public bool CoordEquals(CLine i_Line) => mi_Points[0].mi_P3D.CoordEquals(i_Line.mi_Points[0].mi_P3D) && mi_Points[1].mi_P3D.CoordEquals(i_Line.mi_Points[1].mi_P3D);

            /// <summary>
            /// Used while creating coordinate system
            /// Calculate the angle of the 3 main axes on the screen in a range from 0 to 360 degree.
            /// </summary>
            public void CalcAngle2D()
            {
                double d_DX = mi_Points[1].mi_P2D.md_X - mi_Points[0].mi_P2D.md_X;
                double d_DY = mi_Points[1].mi_P2D.md_Y - mi_Points[0].mi_P2D.md_Y;
                md_Angle = Math.Atan2(d_DY, d_DX) * 180.0 / Math.PI;
                if (md_Angle < 0.0) md_Angle += 360.0;
            }

            // For debugging in Visual Studio
            public override string ToString()
            {
                string s_Dbg = string.Format("CLine from {0} to {1}", mi_Points[0], mi_Points[1]);
                if (mb_IsAxis)
                {
                    s_Dbg += string.Format(" (Axis {0}, {1})", me_Line, me_Offset);
                }

                return s_Dbg;
            }
        }

        #endregion

        #region CShape

        private class CShape : CDrawObj
        {
            private float         mf_Radius;   // radius   of shape adapted with Zoom factor
            private float         mf_Diameter; // diameter of shape adapted with Zoom factor
            private PointF        mk_TopLeft;  // top left corner in screen coordinates for all types of shapes
            private PointF[]      mk_Polygon;  // used for triangles or any future user objects
            private Brush         mi_Brush;
            private CShape3D      mi_Shape3D;
            private CColorScheme  mi_ColorScheme;

            public override EnumSelType SelType => EnumSelType.Shape;

            /// <summary>
            /// Constructor
            /// </summary>
            public CShape(CShape3D i_Shape3D, CColorScheme i_ColorScheme)
            {
                if (i_Shape3D.Brush == null && i_ColorScheme == null)
                {
                    throw new ArgumentException("You must specify a Brush or a ColorScheme");
                }

                mi_Shape3D     = i_Shape3D;
                mi_Object3D    = i_Shape3D;
                mi_Points      = new CPoint[1];
                mi_Points[0]   = new CPoint(i_Shape3D.Points[0], i_Shape3D.Radius);
                mi_ColorScheme = i_ColorScheme;
                me_SmoothMode  = SmoothingMode.AntiAlias;
                me_Mirror      = EnumMirror.All;
            }

            public override void ProcessColors()
            {
                // If the user has specified an individual brush for this Shape --> always use it
                mi_Brush = mi_Shape3D.Brush;

                // Otherwise use Brush from ColorScheme
                if (mi_Brush == null)
                {
                    double d_FactorZ = mi_Inst.mi_Bounds.CalcFactorZ(md_AvrgZ);
                    int    s32_Index = mi_ColorScheme.CalcIndex(d_FactorZ);
                    mi_Brush         = mi_ColorScheme.GetBrush (s32_Index);
                }
            }

            public override void Project3D()
            {
                mi_Points[0].Project3D(mi_Inst, me_Mirror);

                mb_IsValid  = mi_Points[0].mi_P2D.IsValid;
                mf_Radius   = (float)(mi_Shape3D.Radius * mi_Inst.mi_Transform.md_Zoom);
                mf_Diameter = mf_Radius * 2.0f;

                // Move coordinate from center to upper left corner of circle
                mk_TopLeft    = mi_Points[0].mi_P2D.Coord;
                mk_TopLeft.X -= mf_Radius;
                mk_TopLeft.Y -= mf_Radius;

                switch (mi_Shape3D.Shape)
                {
                    case EnumScatterShape.Triangle:
                        mk_Polygon = new PointF[3];
                        // top center
                        mk_Polygon[0].X = mk_TopLeft.X + mf_Radius;
                        mk_Polygon[0].Y = mk_TopLeft.Y;
                        // bottom left
                        mk_Polygon[1].X = mk_TopLeft.X;
                        mk_Polygon[1].Y = mk_TopLeft.Y + mf_Diameter;
                        // bottom right
                        mk_Polygon[2].X = mk_TopLeft.X + mf_Diameter;
                        mk_Polygon[2].Y = mk_TopLeft.Y + mf_Diameter;
                        break;

                    // case EnumScatterShape.Star:
                        // Here you can implement your own shapes
                        // break;
                }
            }

            public override void Render(Graphics i_Graph)
            {
                bool  b_DrawSel   = Selected && mi_Inst.mi_Selection.HighlightBrush != null;
                Brush i_DrawBrush = b_DrawSel ? mi_Inst.mi_Selection.HighlightBrush : mi_Brush;

                switch (mi_Shape3D.Shape)
                {
                    case EnumScatterShape.Circle:
                        i_Graph.FillEllipse  (i_DrawBrush, mk_TopLeft.X, mk_TopLeft.Y, mf_Diameter, mf_Diameter);
                        break;
                    case EnumScatterShape.Square:
                        i_Graph.FillRectangle(i_DrawBrush, mk_TopLeft.X, mk_TopLeft.Y, mf_Diameter, mf_Diameter);
                        break;
                    default:
                        i_Graph.FillPolygon  (i_DrawBrush, mk_Polygon);
                        break;
                }
            }

            /// <summary>
            /// Check if a user click at X, Y matches this draw object
            /// </summary>
            public override CObject3D MatchesPoint2D(int X, int Y)
            {
                int s32_MaxDist = (int)mf_Radius + SELECT_RADIUS;

                if (mi_Points[0].mi_P2D.CalcDistanceTo(X, Y) <= s32_MaxDist)
                {
                    return mi_Shape3D;
                }

                return null;
            }

            /// <summary>
            /// For Debugging in Visual Studio
            /// </summary>
            public override string ToString() => string.Format("CShape {0} at {1}, Diameter {2}", mi_Shape3D.Shape, mi_Points[0], FormatDouble(mf_Diameter));
        }

        #endregion

        #region CPolygon

        private class CPolygon : CDrawObj
        {
            private bool          mb_Fill;        // Fill / Line mode
            private float         mf_SelSize;     // size of selection points
            private PointF[]      mk_Screen;      // the 2D polygon corner points in screen coordinates
            private int           ms32_OrgWidth;  // original line width for Line Pen
            private float         mf_LineWidth;   // zoomed   line width for Line Pen
            private Pen           mi_LinePen;     // used in Line mode
            private Pen           mi_BorderPen;   // used in Fill mode (not zoomed)
            private Brush         mi_Brush;       // used in Fill mode
            private CPolygon3D    mi_Polygon3D;
            private CColorScheme  mi_ColorScheme;

            public override EnumSelType SelType => EnumSelType.Polygon;

            /// <summary>
            /// Constructor
            /// </summary>
            public CPolygon(bool b_Fill, CPolygon3D i_Polygon3D, Pen i_Pen, CColorScheme i_ColorScheme)
            {
                mi_Points = new CPoint[i_Polygon3D.Points.Length];
                for (int i=0; i<mi_Points.Length; i++)
                {
                    mi_Points[i] = new CPoint(i_Polygon3D.Points[i], 1);
                }

                mb_Fill        = b_Fill;
                mi_Polygon3D   = i_Polygon3D;
                mi_Object3D    = i_Polygon3D;
                mi_ColorScheme = i_ColorScheme;
                mk_Screen      = new PointF[mi_Points.Length];
                me_Mirror      = EnumMirror.All;

                if (b_Fill)
                {
                    mi_BorderPen = i_Pen;
                }
                else
                {
                    mi_LinePen = i_Pen;
                }

                if (i_Pen != null)
                {
                    ms32_OrgWidth = (int)i_Pen.Width;
                }

                // Drawing polygon border lines with antialias makes them very thick and black.
                // Do not smooth the lines when the polygons are filled with color and the lines are only separators.
                // But use smooth mode if only the lines are drawn.
                me_SmoothMode = (b_Fill) ? SmoothingMode.None : SmoothingMode.AntiAlias;
            }

            public override void ProcessColors()
            {
                // If the user has specified an individual brush for this Polygon --> always use it
                if (mi_Polygon3D.Brush != null)
                {
                    mi_Brush = mi_Polygon3D.Brush;
                }
                else if (mi_ColorScheme != null) // ColorScheme is never null in Fill mode
                {
                    double  d_FactorZ = mi_Inst.mi_Bounds.CalcFactorZ(md_AvrgZ);
                    int     s32_Index = mi_ColorScheme.CalcIndex(d_FactorZ);
                    mi_Brush          = mi_ColorScheme.GetBrush (s32_Index); // used for Fill and assigned to LinePen
                }
            }

            public override void Project3D()
            {
                foreach (CPoint i_Point in mi_Points)
                {
                    i_Point.Project3D(mi_Inst, me_Mirror);
                }

                // Line width for Line mode 
                mf_LineWidth = (float)(ms32_OrgWidth * mi_Inst.mi_Transform.md_Zoom);

                // Diameter of circle for selected points
                mf_SelSize = (float)(Math.Max(6, ms32_OrgWidth * 2) * mi_Inst.mi_Transform.md_Zoom);

                mb_IsValid = true;
                for (int i=0; i<mi_Points.Length; i++)
                {
                    if (mi_Points[i].mi_P2D.IsValid)
                    {
                        mk_Screen[i] = mi_Points[i].mi_P2D.Coord;
                    }
                    else
                    {
                        mb_IsValid = false;
                    }
                }
            }

            public override void Render(Graphics i_Graph)
            {
                // Fill polygon with solid color
                if (mb_Fill)
                {
                    Brush i_FillBrush = mi_Brush;
                    if (Selected && mi_Inst.mi_Selection.HighlightBrush != null)
                    {
                        i_FillBrush = mi_Inst.mi_Selection.HighlightBrush;
                    }

                    i_Graph.FillPolygon(i_FillBrush, mk_Screen);
                }

                Pen i_DrawPen;
                if (mb_Fill)
                {
                    i_DrawPen = mi_BorderPen;
                }
                else // Line mode
                {
                    i_DrawPen       = mi_LinePen;
                    i_DrawPen.Width = mf_LineWidth;

                    if (mi_Brush != null)
                    {
                        i_DrawPen.Brush = mi_Brush;
                    }
                }

                // Fill mode --> draw thin black border lines around the polygons
                // Line mode --> draw thicker lines around transparent polygons
                if (i_DrawPen != null)
                {
                    // ATTENTION: Graphics.DrawPolygon() with a Pen > 1 pixel is buggy in the .NET framework (artifacts)!
                    // The lines must be drawn one by one manually here.
                    int T = mk_Screen.Length - 1;
                    for (int F=0; F<mk_Screen.Length; F++)
                    {
                        i_Graph.DrawLine(i_DrawPen, mk_Screen[F], mk_Screen[T]);
                        T = F;
                    }    
                }

                // Draw selected points
                foreach (CPoint i_Point in mi_Points)
                {
                    if (!i_Point.mi_P3D.Selected)
                    {
                        continue;
                    }
                    
                    float X = (float)i_Point.mi_P2D.md_X - mf_SelSize / 2.0f;
                    float Y = (float)i_Point.mi_P2D.md_Y - mf_SelSize / 2.0f;
                    i_Graph.FillEllipse(mi_Inst.mi_Selection.HighlightBrush, X, Y, mf_SelSize, mf_SelSize);
                }
            }

            /// <summary>
            /// Check if a user click at X, Y matches this draw object
            /// </summary>
            public override CObject3D MatchesPoint2D(int X, int Y)
            {
                // ATTENTION: Selecting entire polygons makes only sense with eSurfaceMode.Fill
                // In line mode polygons are transparent and a click into the polygon would go to the background.
                if (!mb_Fill || mi_Inst.mi_Selection.SinglePoints)
                {
                    int s32_MaxDist = (int)mf_SelSize / 2 + SELECT_RADIUS;
                    foreach (CPoint i_Point in mi_Points)
                    {
                        if (i_Point.mi_P2D.CalcDistanceTo(X, Y) <= s32_MaxDist)
                        {
                            return i_Point.mi_P3D;
                        }
                    }
                }
                else // select entire polygon
                {
                    // Detect if the point is inside the polygon. Here SELECT_RADIUS is ignored. 
                    // But the user must only click into the middle of the polygon, which is easier than clicking a thin line.
                    bool b_Result = false;
                    int  k = mi_Points.Length - 1;
                    for (int i = 0; i < mi_Points.Length; i++)
                    {
                        CPoint2D i_Point1 = mi_Points[i].mi_P2D;
                        CPoint2D i_Point2 = mi_Points[k].mi_P2D;

                        if (i_Point1.md_Y < Y && i_Point2.md_Y >= Y || 
                            i_Point2.md_Y < Y && i_Point1.md_Y >= Y)
                        {
                            if (i_Point1.md_X + (Y - i_Point1.md_Y) /
                                (i_Point2.md_Y - i_Point1.md_Y) *
                                (i_Point2.md_X - i_Point1.md_X) < X)
                            {
                                b_Result = !b_Result;
                            }
                        }
                        k = i;
                    }
                    if (b_Result)
                    {
                        return mi_Polygon3D;
                    }
                }
                return null;
            }

            /// <summary>
            /// For debugging in Visual Studio
            /// </summary>
            public override string ToString() => string.Format("CPolygon ({0} points)", mk_Screen.Length);
        }

        #endregion

        #region CMouse 

        private class CMouse
        {
            public EnumMouseAction me_Action;     // left mouse button action
            public Point        mk_LastPos;    // last mouse location
            public Point        mk_OffMove;    // Mouse offset after moving the graph with the mouse
            public Point        mk_OffCoord;   // Offset caused by labels in coordinate system
            public TrackBar     mi_TrackRho;   // Rho trackbar (optional)
            public TrackBar     mi_TrackTheta; // Theta trackbar (optional)
            public TrackBar     mi_TrackPhi;   // Phi trackbar (optional)
            public double       md_Rho     = VALUES_RHO  .Default;
            public double       md_Theta   = VALUES_THETA.Default;
            public double       md_Phi     = VALUES_PHI  .Default;

            /// <summary>
            /// User has moved the TrackBar
            /// </summary>
            public void OnTrackBarScroll()
            {
                if (mi_TrackRho   != null) md_Rho   = mi_TrackRho  .Value;
                if (mi_TrackTheta != null) md_Theta = mi_TrackTheta.Value;
                if (mi_TrackPhi   != null) md_Phi   = mi_TrackPhi  .Value;
            }

            public bool OnMouseWheel(int s32_Delta)
            {
                if (me_Action != EnumMouseAction.None)
                {
                    return false;
                }

                me_Action = EnumMouseAction.Rho;
                OnMouseMove(0, s32_Delta / 2);
                me_Action = EnumMouseAction.None;
                return true;
            }

            /// <summary>
            /// User has dragged the mouse over the 3D control
            /// </summary>
            public void OnMouseMove(int s32_DiffX, int s32_DiffY)
            {
                if (me_Action == EnumMouseAction.Rho)
                {
                    md_Rho += s32_DiffY * VALUES_RHO.MouseFactor;
                    SetRho(md_Rho);
                }
                if (me_Action == EnumMouseAction.Theta || me_Action == EnumMouseAction.ThetaAndPhi)
                {
                    md_Theta -= s32_DiffY * VALUES_THETA.MouseFactor;
                    SetTheta(md_Theta);
                }
                if (me_Action == EnumMouseAction.Phi || me_Action == EnumMouseAction.ThetaAndPhi)
                {
                    md_Phi -= s32_DiffX * VALUES_PHI.MouseFactor;
                    SetPhi(md_Phi);
                }
            }

            public void SetRho(double d_Rho)
            {
                md_Rho = d_Rho;
                md_Rho = Math.Max(md_Rho, VALUES_RHO.Min);
                md_Rho = Math.Min(md_Rho, VALUES_RHO.Max);
                if (mi_TrackRho != null)
                {
                    mi_TrackRho.Value = (int)md_Rho;
                }
            }
            public void SetTheta(double d_Theta)
            {
                md_Theta = d_Theta;
                //md_Theta = Math.Max(md_Theta, VALUES_THETA.Min);
                //md_Theta = Math.Min(md_Theta, VALUES_THETA.Max);
                while (md_Theta > 360.0)
                {
                    md_Theta -= 360.0; // continuous rotation
                }
                while (md_Theta < 0.0)
                {
                    md_Theta += 360.0; // continuous rotation
                }

                if (mi_TrackTheta != null)
                {
                    mi_TrackTheta.Value = (int)md_Theta;
                }
            }
            public void SetPhi(double d_Phi)
            {
                md_Phi = d_Phi;
                while (md_Phi > 360.0)
                {
                    md_Phi -= 360.0; // continuous rotation
                }
                while (md_Phi < 0.0)
                {
                    md_Phi += 360.0; // continuous rotation
                }
                if (mi_TrackPhi != null)
                {
                    mi_TrackPhi.Value = (int)md_Phi;
                }
            }
        }

        #endregion

        #region CRange

        private class CRange
        {
            private double md_Min, md_Max;

            public double Min
            => md_Min;
            public double Max
            => md_Max;
            public double Range
            {
                get { return md_Max - md_Min; }
            }

            /// <summary>
            /// Constructor
            /// </summary>
            public CRange(double d_Min, double d_Max, bool b_IncludeZero, EnumRaster e_Raster)
            {
                md_Min = d_Min;
                md_Max = d_Max;

                if (md_Max == md_Min) 
                { 
                    md_Min -= 1.0; 
                    md_Max += 1.0; 
                }

                if (e_Raster == EnumRaster.Off)
                    return;

                if (b_IncludeZero)
                {
                    md_Min = Math.Min(0.0, md_Min); 
                    md_Max = Math.Max(0.0, md_Max); 
                }

                // Add 10 % excess to all axes
                if (md_Min < 0.0 || (md_Min > 0.0 && !b_IncludeZero)) md_Min -= Math.Abs(md_Min) * AXIS_EXCESS;
                if (md_Max > 0.0 || (md_Max < 0.0 && !b_IncludeZero)) md_Max += Math.Abs(md_Max) * AXIS_EXCESS;
            }
        }

        #endregion

        #region CBounds

        private class CBounds
        {
            private Editor3DRenderer mi_Inst;
            private CRange   mi_RangeX;
            private CRange   mi_RangeY;
            private CRange   mi_RangeZ;
            private double   md_MinX, md_MaxX, md_MinY, md_MaxY, md_MinZ, md_MaxZ;

            public CRange X 
            => mi_RangeX;
            public CRange Y
            => mi_RangeY;
            public CRange Z
            => mi_RangeZ;

            /// <summary>
            /// Constructor
            /// </summary>
            public CBounds(Editor3DRenderer i_Inst)
            {
                mi_Inst = i_Inst;
            }

            /// <summary>
            /// Also assigns mi_Inst to all draw objects
            /// </summary>
            public void Calculate()
            {
                md_MinX = double.PositiveInfinity;
                md_MaxX = double.NegativeInfinity;
                md_MinY = double.PositiveInfinity;
                md_MaxY = double.NegativeInfinity;
                md_MinZ = double.PositiveInfinity;
                md_MaxZ = double.NegativeInfinity;

                foreach (CDrawObj i_DrawObj in mi_Inst.mi_UserObjects)
                {
                    i_DrawObj.mi_Inst             = mi_Inst;
                    i_DrawObj.mi_Object3D.mi_Inst = mi_Inst;

                    foreach (CPoint i_Point in i_DrawObj.mi_Points)
                    {
                        CPoint3D i_Point3D = i_Point.mi_P3D;
                        i_Point3D.mi_Inst  = mi_Inst;

                        md_MinX = Math.Min(md_MinX, i_Point3D.X);
                        md_MaxX = Math.Max(md_MaxX, i_Point3D.X);
                        md_MinY = Math.Min(md_MinY, i_Point3D.Y);
                        md_MaxY = Math.Max(md_MaxY, i_Point3D.Y);
                        md_MinZ = Math.Min(md_MinZ, i_Point3D.Z);
                        md_MaxZ = Math.Max(md_MaxZ, i_Point3D.Z);
                    }
                }

                mi_RangeX = new CRange(md_MinX, md_MaxX, mi_Inst.AxisX.IncludeZero, mi_Inst.me_Raster);
                mi_RangeY = new CRange(md_MinY, md_MaxY, mi_Inst.AxisY.IncludeZero, mi_Inst.me_Raster);
                mi_RangeZ = new CRange(md_MinZ, md_MaxZ, mi_Inst.AxisZ.IncludeZero, mi_Inst.me_Raster);
            }

            /// <summary>
            /// Used to get the color from the ColorScheme
            /// </summary>
            public double CalcFactorZ(double d_Value)
            {
                return (d_Value - md_MinZ) / (md_MaxZ - md_MinZ);
            }
        }

        #endregion

        #region CQuadrant

        private class CQuadrant
        {
            public double md_SortXY;   // Sort order of raster in area XY  (red)
            public double md_SortXZ;   // Sort order of X axis and raster in area XZ (blue)
            public double md_SortYZ;   // Sort order of Y axis and raster in area YZ (green)
            public int    ms32_Quadrant;
            public bool   mb_BottomView;

            public void Calculate(double d_Phi, CLine i_AxisX, CLine i_AxisY, CLine i_AxisZ)
            {
                // Split rotation into 4 sections (0...3) which increment every 90° starting at 45°
                int s32_Section45 = (int)d_Phi + 45;
                if (s32_Section45 > 360) s32_Section45 -= 360;
                s32_Section45 = Math.Min(3, s32_Section45 / 90);

                // Theta elevation lets the camera watch the graph from the top or bottom
                switch (s32_Section45)
                {
                    case 0: mb_BottomView = i_AxisX.md_Angle < 180.0; break;
                    case 1: mb_BottomView = i_AxisY.md_Angle < 180.0; break;
                    case 2: mb_BottomView = i_AxisX.md_Angle > 180.0; break;
                    case 3: mb_BottomView = i_AxisY.md_Angle > 180.0; break;
                }

                // The quadrant changes when the 2D transformed Z axis is in line with the X or Y axis
                if (mb_BottomView)
                {
                    switch (s32_Section45)
                    {
                        case 0: ms32_Quadrant = i_AxisX.md_Angle + 180.0 < i_AxisZ.md_Angle ? 1 : 0; break;
                        case 1: ms32_Quadrant = i_AxisY.md_Angle + 180.0 < i_AxisZ.md_Angle ? 2 : 1; break;
                        case 2: ms32_Quadrant = i_AxisX.md_Angle         < i_AxisZ.md_Angle ? 3 : 2; break;
                        case 3: ms32_Quadrant = i_AxisY.md_Angle         < i_AxisZ.md_Angle ? 0 : 3; break;
                    }
                }
                else // Top View
                {
                    switch (s32_Section45)
                    {
                        case 0: ms32_Quadrant = i_AxisX.md_Angle         > i_AxisZ.md_Angle ? 1 : 0; break;
                        case 1: ms32_Quadrant = i_AxisY.md_Angle         > i_AxisZ.md_Angle ? 2 : 1; break;
                        case 2: ms32_Quadrant = i_AxisX.md_Angle + 180.0 > i_AxisZ.md_Angle ? 3 : 2; break;
                        case 3: ms32_Quadrant = i_AxisY.md_Angle + 180.0 > i_AxisZ.md_Angle ? 0 : 3; break;
                    }
                }

                md_SortXY = (mb_BottomView) ? 99999.9 : -99999.9;
                md_SortXZ = (ms32_Quadrant == 1 || ms32_Quadrant == 2) ? 99999.9 : -99999.9;
                md_SortYZ = (ms32_Quadrant == 0 || ms32_Quadrant == 1) ? 99999.9 : -99999.9;

                i_AxisX.md_Sort = md_SortXZ;
                i_AxisY.md_Sort = md_SortYZ;
                i_AxisZ.md_Sort = (ms32_Quadrant == 3) ? -99999.9 : 99999.9;

                // Debug.WriteLine(string.Format("Section: {0}  CQuadrant: {1}", s32_Section45, ms32_Quadrant));
            }
        }

        #endregion

        #region CTransform

        private class CTransform
        {
            // Camera distance. Smaller values result in ugly stretched egdes when rotating.
            private const double DISTANCE = 0.55;

            private double  md_sf;   // sf = sinus fi
            private double  md_st;   // st = sinus theta
            private double  md_cf;   // cf = cosinus fi
            private double  md_ct;   // ct = cosinus theta
            private double  md_Rho;
            // ----------------
            private double  md_FactX;
            private double  md_OffsX;
            private double  md_FactY;
            private double  md_OffsY;
            private double  md_Resize = 1.0;
            // ----------------
            public CPoint3D mi_Center3D = new CPoint3D(0,0,0);
            public double   md_NormalizeX;
            public double   md_NormalizeY;
            public double   md_NormalizeZ;
            public double   md_Zoom;
            // ----------------
            Size     mk_InitialSize = Size.Empty;
            Editor3DRenderer mi_Inst;

            public CTransform(Editor3DRenderer i_Inst)
            {
                mi_Inst = i_Inst;
            }

            public void SetCoefficients(CMouse i_Mouse)
            {
                md_Rho         =  i_Mouse.md_Rho;                           // Distance of viewer (zoom)
                double d_Theta =  i_Mouse.md_Theta       * Math.PI / 180.0; // Height   of viewer (elevation)
                double d_Phi   = (i_Mouse.md_Phi -180.0) * Math.PI / 180.0; // Rotation around center (-Pi ... +Pi)

                // Speed optimization: precalculate factors
                md_sf = Math.Sin(d_Phi);  
                md_cf = Math.Cos(d_Phi);  
                md_st = Math.Sin(d_Theta); // Theta = 0...pi --> st = 0 .. 1 .. 0
                md_ct = Math.Cos(d_Theta); // Theta = 0...pi --> ct = 1 .. 0 .. -1

                CalcZoom();
                mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
            }

            /// <summary>
            /// The initial size is needed to calculate the user resizing factor.
            /// To assure that it is correct it must be set when the control has already been created.
            /// Then it will be the size that was defined in Visual Studio Form Designer.
            /// </summary>
            public void SetInitialSize(Size k_Size)
            {
                mk_InitialSize = k_Size;
                SetSize(k_Size);
            }

            /// <summary>
            /// The control has been resized.
            /// This may be called with an invalid size before the control is created!
            /// </summary>
            public void SetSize(Size k_Size) // Control.ClientSize
            {
                if (mk_InitialSize == Size.Empty)
                    return;

                double d_Width  = k_Size.Width  * 0.0254 / 96.0; // 0.0254 meter = 1 inch. Screen has 96 DPI
                double d_Height = k_Size.Height * 0.0254 / 96.0;

                // linear transformation coefficients
                md_FactX =  k_Size.Width  / d_Width;
                md_FactY = -k_Size.Height / d_Height;
               
                md_OffsX =  md_FactX * d_Width  / 2.0;
                md_OffsY = -md_FactY * d_Height / 2.0;

                // -----------------------------------

                double d_ResizeX = (double)k_Size.Width  / mk_InitialSize.Width;
                double d_ResizeY = (double)k_Size.Height / mk_InitialSize.Height;
                md_Resize = Math.Min(d_ResizeX, d_ResizeY);

                md_FactX *= md_Resize;
                md_FactY *= md_Resize;

                CalcZoom();
                mi_Inst.me_Recalculate |= EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
            }

            // Required for correct painting order of polygons (always from back to front)
            public double ProjectXY(double X, double Y, double Z = 0.0)
            {
                return X * md_cf + Y * md_sf + Z * md_ct;
            }

            // Used to convert mouse movements back into the 3D space depending on the current rotation angle
            public double ReverseProject(double X, double Y, double Z)
            {
                if (mi_Inst.AxisX.Mirror) X = -X;
                if (mi_Inst.AxisY.Mirror) Y = -Y;
                if (mi_Inst.AxisZ.Mirror) Z = -Z;

                // If Theta has the correct range from 10 to 170 degree --> Sinus(Theta) will never become zero.
                // This can only happen if VALUES_THETA has been manipulated to invalid Min/Max values.
                double d_Divide = Math.Max(0.1, md_st);
                return (-X * md_sf + Y * md_cf + Z / d_Divide) / md_Zoom;
            }

            /// <summary>
            /// This approximates a zoom factor that depends on Rho and the resize window factor.
            /// Used to adapt the size of lines, shapes and selected points.
            /// </summary>
            private void CalcZoom()
            {
                md_Zoom = md_Resize * (1800.0 / (md_Rho + 300));
            }

            // Performs projection. Calculates 2D screen coordinates from 3D point.
            public CPoint2D Project3D(CPoint3D i_Point3D, EnumMirror e_Mirror)
            {
                double X = i_Point3D.X;
                double Y = i_Point3D.Y;
                double Z = i_Point3D.Z;

                // Mirror axis values increasing / decreasing
                if (mi_Inst.AxisX.Mirror && (e_Mirror & EnumMirror.X) > 0)
                {
                    X = mi_Inst.mi_Bounds.X.Max - (X - mi_Inst.mi_Bounds.X.Min);
                }
                if (mi_Inst.AxisY.Mirror && (e_Mirror & EnumMirror.Y) > 0)
                {
                    Y = mi_Inst.mi_Bounds.Y.Max - (Y - mi_Inst.mi_Bounds.Y.Min);
                }
                if (mi_Inst.AxisZ.Mirror && (e_Mirror & EnumMirror.Z) > 0)
                {
                    Z = mi_Inst.mi_Bounds.Z.Max - (Z - mi_Inst.mi_Bounds.Z.Min);
                }

                X = (X - mi_Center3D.X) * md_NormalizeX;
                Y = (Y - mi_Center3D.Y) * md_NormalizeY;
                Z = (Z - mi_Center3D.Z) * md_NormalizeZ;

                // 3D coordinates with center point in the middle of the screen
                // X positive to the right, X negative to the left
                // Y positive to the top,   Y negative to the bottom
                double xn = -md_sf *         X + md_cf         * Y;
                double yn = -md_cf * md_ct * X - md_sf * md_ct * Y + md_st * Z;
                double zn = -md_cf * md_st * X - md_sf * md_st * Y - md_ct * Z + md_Rho;

                zn = Math.Max(zn, 0.01); // avoid division by zero

                // Thales' theorem
                CPoint2D i_Point2D = new CPoint2D(xn * DISTANCE / zn,  yn * DISTANCE / zn);

                i_Point2D.md_X = i_Point2D.md_X * md_FactX + md_OffsX;
                i_Point2D.md_Y = i_Point2D.md_Y * md_FactY + md_OffsY;
                return i_Point2D;
            }
        }

        #endregion

        #region CDefault

        /// <summary>
        /// Stores defauls for Rho, Theta, Phi
        /// </summary>
        private class CDefault
        {
            public readonly double Min;
            public readonly double Max;
            public readonly double Default;
            public readonly double MouseFactor;

            public CDefault(double d_Min, double d_Max, double d_Default, double d_MouseFactor)
            {
                Min         = d_Min;
                Max         = d_Max;
                Default     = d_Default;
                MouseFactor = d_MouseFactor;
            }
        }

        #endregion


        // Limits and default values for mouse actions and trackbars.
        // ATTENTION: It is strongly recommended not to change the MIN, MAX values.
        // The mouse factor defines how much mouse movement you need for a change.
        // A movement of mouse by approx 1000 pixels on the screen results in getting from Min to Max or vice versa.
        static readonly CDefault VALUES_RHO   = new CDefault(300,   3000,  1350,    2   );
        static readonly CDefault VALUES_THETA = new CDefault( 0,    360,    70,    0.25); // degree
        static readonly CDefault VALUES_PHI   = new CDefault(  0,    360,   230,    0.25 ); // degree  (continuous rotation)

        // The coordinate axes are 10 % longer than the bounds of the X,Y,Z values
        const double AXIS_EXCESS = 0.1;

        // For any strange reason the graph is not centered vertically
        const int VERT_OFFSET = -30;

        // The maximum distance between mouse pointer and a 2D point to display the tooltip
        const int TOOLTIP_RADIUS = 6;

        // The maximum distance between mouse pointer and a 2D point to allow a match when selecting a 3D object.
        const int SELECT_RADIUS = 3;

        // Calculate 3-dimensional Z value from X,Y values
        public delegate double DelRendererFunction(double X, double Y);

        // IMPORTANT: Read the detailed comment of function SelectionCallback() at the end of this class.
        public delegate EnumInvalidate delSelectHandler(EnumSelEvent e_Event, Keys e_Modifiers, int s32_DeltaX, int s32_DeltaY, CObject3D i_Object);

        Pen[]                        mi_BorderPens      = new Pen[2];
        SolidBrush                   mi_TopLegendBrush  = null;
        EnumRaster                      me_Raster       = EnumRaster.Labels;
        CAxis[]                      mi_Axis            = new CAxis[3];
        CMouse                       mi_Mouse           = new CMouse();
        List<CMessgData>             mi_MessageData     = new List<CMessgData>();
        EnumRecalculate                 me_Recalculate  = EnumRecalculate.Nothing;
        EnumNormalize                   me_Normalize    = EnumNormalize.Separate;
        EnumLegendPos                   me_LegendPos    = EnumLegendPos.BottomLeft;
        List<CLine>                  mi_AxisLines       = new List<CLine>();    // 0, 3, or 45 axis lines of coordinate system
        List<CDrawObj>               mi_UserObjects     = new List<CDrawObj>(); // Draw objects from the user (CLine, CShape, CPolygon)
        List<CDrawObj>               mi_AllObjects      = new List<CDrawObj>(); // mi_UserObjects + mi_AxisLines
        CQuadrant                    mi_Quadrant        = new CQuadrant();
        Dictionary<int, CUserInput>  mi_UserInputs      = new Dictionary<int, CUserInput>();
        CTransform                   mi_Transform;
        CBounds                      mi_Bounds;
        CTooltip                     mi_Tooltip;
        CSelection                   mi_Selection;
        CObject3D                    mi_DragObject;


        /// <summary>
        /// See comment of enum EnumTooltip.
        /// This property can also be set in the Visual Studio Designer
        /// </summary>
        public EnumTooltip TooltipMode
        {
            get => mi_Tooltip.Mode;
            set => mi_Tooltip.Mode = value;
        }

        /// <summary>
        /// See comment of enum EnumLegendPos.
        /// This property can also be set in the Visual Studio Designer
        /// </summary>
        public EnumLegendPos LegendPos
        {
            get => me_LegendPos;
            set => me_LegendPos = value;
        }

        /// <summary>
        /// See comment of enum EnumNormalize.
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public EnumNormalize Normalize
        {
            get { return me_Normalize; }
            set
            {
                if (me_Normalize != value)
                {
                    me_Normalize = value;
                    me_Recalculate |= EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
                }
            }
        }

        /// <summary>
        /// See comment of enum EnumRaster
        /// This property can also be set in the Visual Studio Designer
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public EnumRaster Raster
        {
            set
            {
                if (me_Raster != value)
                {
                    me_Raster = value;
                    me_Recalculate |= EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
                }
            }
            get
            {
                return me_Raster;
            }
        }

        /// <summary>
        /// Sets the border color when the 3D Editor does not have the keyboard focus
        /// Setting BorderColor = Color.Empty turns off the border
        /// This change will become visible the next time you call Invalidate()
        /// This property can also be set in the Visual Studio Designer
        /// </summary>
        public Color BorderColorNormal
        {
            set
            {
                if (value.A > 0)
                {
                    mi_BorderPens[0] = new Pen(value, 1);
                }
                else
                {
                    mi_BorderPens[0] = null; // transparent color
                }
            }
            get
            {
                if (mi_BorderPens[0] != null)
                {
                    return mi_BorderPens[0].Color;
                }
                else
                {
                    return Color.Empty;
                }
            }
        }

        /// <summary>
        /// Sets the border color when the 3D Editor has the keyboard focus
        /// Setting BorderColorFocus = Color.Empty turns off the highlighting on focus.
        /// This change will become visible the next time you call Invalidate()
        /// This property can also be set in the Visual Studio Designer
        /// </summary>
        public Color BorderColorFocus
        {
            set
            {
                if (value.A > 0)
                {
                    mi_BorderPens[1] = new Pen(value, 1);
                }
                else
                {
                    mi_BorderPens[1] = mi_BorderPens[0];
                }
            }
            get
            {
                if (mi_BorderPens[1] != null)
                {
                    return mi_BorderPens[1].Color;
                }
                else
                {
                    return BorderColorNormal;
                }
            }
        }

        /// <summary>
        /// Show a legend with Rotation, Elevation and Distance at the top left
        /// Setting LegendColor = Color.Empty turns off the top legend
        /// This property can also be set in the Visual Studio Designer
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public Color TopLegendColor
        {
            set
            {
                mi_TopLegendBrush = new SolidBrush(value);
            }
            get
            {
                if (mi_TopLegendBrush != null)
                {
                    return mi_TopLegendBrush.Color;
                }
                else
                {
                    return Color.Empty;
                }
            }
        }

        /// <summary>
        /// returns the total count of loaded draw objects (lines, shapes and polygons)
        /// </summary>
        [Browsable(false)]
        public string ObjectStatistics
        {
            get 
            { 
                int s32_Lines    = 0;
                int s32_Shapes   = 0;
                int s32_Polygons = 0;
                foreach (CDrawObj i_Obj in mi_UserObjects)
                {
                    if (i_Obj is CLine)    s32_Lines ++;
                    if (i_Obj is CShape)   s32_Shapes ++;
                    if (i_Obj is CPolygon) s32_Polygons ++;
                }
                StringBuilder i_Out = new StringBuilder();
                if (s32_Lines    > 0) i_Out.Append(s32_Lines    + " Lines, ");
                if (s32_Shapes   > 0) i_Out.Append(s32_Shapes   + " Shapes, ");
                if (s32_Polygons > 0) i_Out.Append(s32_Polygons + " Polygons, ");
                return i_Out.ToString().TrimEnd(' ', ',');
            }
        }

        /// <summary>
        /// See comments for class CAxis
        /// The properties of the class CAxis can be expanded in the Visual Studio designer
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public CAxis AxisX
        {
            get { return mi_Axis[(int)EnumCoord.X]; }
        }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public CAxis AxisY
        {
            get { return mi_Axis[(int)EnumCoord.Y]; }
        }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public CAxis AxisZ
        {
            get { return mi_Axis[(int)EnumCoord.Z]; }
        }

        /// <summary>
        /// This property controls if and how the user can select draw objects / points
        /// The properties of the class CSelection can be expanded in the Visual Studio designer
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public CSelection Selection
        {
            get { return mi_Selection; }
        }


        /// <summary>
        /// b_ResetOffset = true --> reset the offset that the user has created with SHIFT + moving the 3D object
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public void SetCoefficients(double d_Rho, double d_Theta, double d_Phi, bool b_ResetOffset = true)
        {
            mi_Mouse.SetRho  (d_Rho);
            mi_Mouse.SetTheta(d_Theta);
            mi_Mouse.SetPhi  (d_Phi);

            if (b_ResetOffset)
            {
                mi_Mouse.mk_OffMove.X = 0;
                mi_Mouse.mk_OffMove.Y = 0;
            }

            mi_Transform.SetCoefficients(mi_Mouse);
        }

        /// <summary>
        /// Convert mouse movement in 2D space back into the 3D space depending on the current rotation angle and Min/Max values.
        /// </summary>
        public CPoint3D ReverseProject(int s32_MouseX, int s32_MouseY)
        {
            double d_FactX = mi_Transform.ReverseProject(mi_Bounds.X.Range, 0.0, 0.0);
            double d_FactY = mi_Transform.ReverseProject(0.0, mi_Bounds.Y.Range, 0.0);
            double d_FactZ = mi_Transform.ReverseProject(0.0, 0.0, mi_Bounds.Z.Range);

            return new CPoint3D(d_FactX * s32_MouseX / 300.0, 
                                d_FactY * s32_MouseX / 300.0, 
                                d_FactZ * s32_MouseY / 300.0);
        }

        /// <summary>
        /// Load one of the three pre-defined input control patterns
        /// </summary>
        public void SetUserInputs()
        {
            List<CUserInput> i_Inputs = new List<CUserInput>
            {
                new CUserInput(MouseButtons.Left, Keys.None, EnumMouseAction.ThetaAndPhi),
                new CUserInput(MouseButtons.Left, Keys.Control, EnumMouseAction.Rho),
                new CUserInput(MouseButtons.Left, Keys.Shift, EnumMouseAction.Move),
                new CUserInput(MouseButtons.Right, Keys.None, EnumMouseAction.Move),
                new CUserInput(MouseButtons.Left, Keys.Alt, EnumMouseAction.SelectObj),
                new CUserInput(MouseButtons.Left, Keys.Alt | Keys.Control, EnumMouseAction.Callback),
                new CUserInput(MouseButtons.Left, Keys.Alt | Keys.Shift, EnumMouseAction.Callback),
            };

            SetUserInputs(i_Inputs.ToArray());
        }

        /// <summary>
        /// Load fully user defined input control patterns.
        /// Each user input must define a unique combination of mouse button and modifier key(s).
        /// </summary>
        public void SetUserInputs(CUserInput[] i_Inputs)
        {
            mi_UserInputs.Clear();
            foreach (CUserInput i_Input in i_Inputs)
            {
                // throws if same UID has already been added
                mi_UserInputs.Add(i_Input.GetUID(), i_Input); 
            }
        }

        // ==================================================================================

        /// <summary>
        /// Constructor
        /// </summary>
        public Editor3DRenderer()
        {
            // avoid flicker
            SetStyle(ControlStyles.AllPaintingInWmPaint,  true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            mi_Bounds     = new CBounds   (this);
            mi_Transform  = new CTransform(this);
            mi_Tooltip    = new CTooltip  (this);
            mi_Selection  = new CSelection(this);

            // Load the default colors
            BackColor = Color.White;

            mi_Axis[(int)EnumCoord.X] = new CAxis(this, EnumCoord.X, Color.DarkBlue);
            mi_Axis[(int)EnumCoord.Y] = new CAxis(this, EnumCoord.Y, Color.DarkGreen);
            mi_Axis[(int)EnumCoord.Z] = new CAxis(this, EnumCoord.Z, Color.DarkRed);

            mi_BorderPens[0]  = new Pen       (Color.FromArgb(255, 0xB4, 0xB4, 0xB4), 1); // normal  border:  bright gray
            mi_BorderPens[1]  = new Pen       (Color.FromArgb(255, 0x33, 0x99, 0xFF), 1); // focused border: bright cyan
            mi_TopLegendBrush = new SolidBrush(Color.FromArgb(255, 0xC8, 0xC8, 0x96));    // beige

            mi_Transform.SetCoefficients(mi_Mouse);
            SetUserInputs();
        }

        // ==================================================================================

        /// <summary>
        /// Removes all content from the control.
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public void Clear()
        {
            mi_MessageData.Clear();
            mi_UserObjects.Clear();
            mi_AxisLines  .Clear();
            mi_AllObjects .Clear();
            AxisX.Reset();
            AxisY.Reset();
            AxisZ.Reset();
            mi_Mouse.mk_OffMove  = Point.Empty;
            mi_Mouse.mk_OffCoord = Point.Empty;
            me_Recalculate = EnumRecalculate.Nothing;
        }

        /// <summary>
        /// Adds a message to be shown, even if no 3D data is loaded.
        /// Messages which are null are allowed, they will be skipped.
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public void AddMessageData(params CMessgData[] i_Messages)
        {
            foreach (CMessgData i_Mesg in i_Messages)
            {
                if (i_Mesg != null)
                    mi_MessageData.Add(i_Mesg);
            }
        }

        /// <summary>
        /// Here you can add CSurfaceData, CScatterData, CPolygonData
        /// RenderData which are null are allowed, they will be skipped.
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public void AddRenderData(params CRenderData[] i_Render)
        {
            foreach (CRenderData i_Data in i_Render)
            {
                if (i_Data != null)
                {
                    i_Data.AddDrawObjects(this);
                    me_Recalculate |= EnumRecalculate.AddRemove | EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
                }
            }
        }

        /// <summary>
        /// This is called from CRenderData.AddDrawObjects()
        /// </summary>
        private void AddDrawObject(CDrawObj i_Obj)
        {
            mi_UserObjects.Add(i_Obj);
        }

        /// <summary>
        /// Removes one or multiple 3D objects: CLine3D, CShape3D or CPolygon3D. 
        /// ATTENTION: It is not possible to remove a CPoint3D which is part of one or multiple Lines/Shapes/Polygons
        /// This change will become visible the next time you call Invalidate()
        /// </summary>
        public void RemoveObjects(params CObject3D[] i_Objects)
        {
            foreach (CObject3D i_Object3D in i_Objects)
            {
                if (i_Object3D is CPoint3D)
                    throw new ArgumentException("You cannot remove a single point. Remove the 3D object that contains the point instead.");

                int s32_Found = -1;
                for (int D=0; D<mi_UserObjects.Count; D++)
                {
                    if (mi_UserObjects[D].mi_Object3D == i_Object3D)
                    {
                        s32_Found = D;
                        break;
                    }
                }

                if (s32_Found >= 0)
                {
                    CDrawObj i_DrawObj = mi_UserObjects[s32_Found];
                    mi_UserObjects.RemoveAt(s32_Found);
                    me_Recalculate |= EnumRecalculate.AddRemove | EnumRecalculate.CoordSystem | EnumRecalculate.Objects;
                }
            }
        }

        /// <summary>
        /// Search the object at the coordinate X, Y relative to to the upper left corner of the control.
        /// b_OnlyCanSelect = true  --> return only objects that can be selected by the user
        /// b_OnlyCanSelect = false --> return any object at the given location
        /// </summary>
        public CObject3D FindObjectAt(int X, int Y, bool b_OnlyCanSelect)
        {
            X -= (mi_Mouse.mk_OffMove.X + mi_Mouse.mk_OffCoord.X);
            Y -= (mi_Mouse.mk_OffMove.Y + mi_Mouse.mk_OffCoord.Y);
            
            // Search in reverse order. Last drawn objects are in foreground.
            // ATTENTION: mi_UserObjects cannot be used here because it is not sorted --> background polygons would be found.
            for (int i=mi_AllObjects.Count -1; i>=0; i--)
            {
                CDrawObj i_Draw = mi_AllObjects[i];

                if (i_Draw.mi_Object3D == null) 
                    continue; // a coordinate system line

                if (b_OnlyCanSelect && !i_Draw.mi_Object3D.CanSelect) 
                    continue; // user selection disabled for this object

                // MatchesPoint2D() returns a CPoint3D, CLine3D, CShape3D or CPolygon3D.
                CObject3D i_Found = i_Draw.MatchesPoint2D(X, Y);
                if (i_Found != null)
                    return i_Found;
            }
            return null;
        }

        
        // ========================================== PRIVATE ============================================

        /// <summary>
        /// This function normalizes the 3D ranges for the X,Y,Z coordinates.
        /// Otherwise a 3D range of X,Y from -10 to +10 will appear much smaller than a range from -100 to +100.
        /// It adapts the values so that rotation (phi) goes through the center of the X, Y pane.
        /// </summary>
        private void NormalizeRanges()
        {
            double d_RangeX = mi_Bounds.X.Range;
            double d_RangeY = mi_Bounds.Y.Range;
            double d_RangeZ = mi_Bounds.Z.Range;

            switch (me_Normalize)
            {
                case EnumNormalize.MaintainXY:
                    double d_RangeXY = (d_RangeX + d_RangeY) / 2.0; // average
                    d_RangeX = d_RangeXY;
                    d_RangeY = d_RangeXY;
                    break;

                case EnumNormalize.MaintainXYZ:
                    double d_RangeXYZ = (d_RangeX + d_RangeY + d_RangeZ) / 3.0; // average
                    d_RangeX = d_RangeXYZ;
                    d_RangeY = d_RangeXYZ;
                    d_RangeZ = d_RangeXYZ;
                    break;
            }

            mi_Transform.md_NormalizeX = 250.0 / d_RangeX; // Ranges will never be zero.
            mi_Transform.md_NormalizeY = 250.0 / d_RangeY;
            mi_Transform.md_NormalizeZ = 250.0 / d_RangeZ;

            mi_Transform.mi_Center3D.X = (mi_Bounds.X.Max + mi_Bounds.X.Min) / 2.0; // average
            mi_Transform.mi_Center3D.Y = (mi_Bounds.Y.Max + mi_Bounds.Y.Min) / 2.0;
            mi_Transform.mi_Center3D.Z = (mi_Bounds.Z.Max + mi_Bounds.Z.Min) / 2.0;
        }

        /// <summary>
        /// Fills mi_AxisLines with 3 main axis and 42 raster lines
        /// </summary>
        private void CreateCoordinateSystem(Graphics i_Graph)
        {
            mi_Mouse.mk_OffCoord = new Point(0, VERT_OFFSET);
            mi_AxisLines.Clear();

            if (me_Raster == EnumRaster.Off)
                return;

            CLine i_MainAxisX = new CLine(this, EnumCoord.X, EnumCoord.X, EnumMirror.Z);
            mi_AxisLines.Add(i_MainAxisX);

            i_MainAxisX.mi_Points[0].mi_P3D.X = mi_Bounds.X.Min;
            i_MainAxisX.mi_Points[1].mi_P3D.X = mi_Bounds.X.Max;
            // ------------
            i_MainAxisX.mi_Points[0].mi_P3D.Y = mi_Bounds.Y.Min; // X axis at minimum Y position
            i_MainAxisX.mi_Points[1].mi_P3D.Y = mi_Bounds.Y.Min; // X axis at minimum Y position

            // ---------------------------------------------------

            CLine i_MainAxisY = new CLine(this, EnumCoord.Y, EnumCoord.Y, EnumMirror.Z);
            mi_AxisLines.Add(i_MainAxisY);

            i_MainAxisY.mi_Points[0].mi_P3D.Y = mi_Bounds.Y.Min;
            i_MainAxisY.mi_Points[1].mi_P3D.Y = mi_Bounds.Y.Max;
            // ------------
            i_MainAxisY.mi_Points[0].mi_P3D.X = mi_Bounds.X.Min; // Y axis at minimum X position
            i_MainAxisY.mi_Points[1].mi_P3D.X = mi_Bounds.X.Min; // Y axis at minimum X position
            // ------------
            if (mi_Bounds.Z.Min < 0.0 && mi_Bounds.Z.Max > 0.0) 
                i_MainAxisY.ms_Label = "0"; // label for Z value zero (red)

            // ---------------------------------------------------

            CLine i_MainAxisZ = new CLine(this, EnumCoord.Z, EnumCoord.Z, EnumMirror.None);
            mi_AxisLines.Add(i_MainAxisZ);

            i_MainAxisZ.mi_Points[0].mi_P3D.Z = mi_Bounds.Z.Min;
            i_MainAxisZ.mi_Points[1].mi_P3D.Z = mi_Bounds.Z.Max;
            // ------------
            i_MainAxisZ.mi_Points[0].mi_P3D.X = mi_Bounds.X.Min; // Z axis start at minimum X position
            i_MainAxisZ.mi_Points[1].mi_P3D.X = mi_Bounds.X.Min; // Z axis start at minimum X position
            i_MainAxisZ.mi_Points[0].mi_P3D.Y = mi_Bounds.Y.Min; // Z axis start at minimum Y position
            i_MainAxisZ.mi_Points[1].mi_P3D.Y = mi_Bounds.Y.Min; // Z axis start at minimum Y position

            // ---------------------------------------------------

            foreach (CLine i_Axis in mi_AxisLines)
            {
                i_Axis.Project3D();
                i_Axis.CalcAngle2D(); // required to calculate the quadrant
            }

            // Calculate currently visible quadrant
            mi_Quadrant.Calculate(mi_Mouse.md_Phi, i_MainAxisX, i_MainAxisY, i_MainAxisZ);

            // Add raster lines in 6 different directions
            if (me_Raster >= EnumRaster.Raster)
            {
                for (int A=0; A<6; A++) // iterate Axes X,Y,Z twice
                {
                    int F = A;
                    int S = A;

                    // Combine X+Y, Y+Z, Z+X, Y+X, Z+Y, X+Z
                    if (A >= 3) F ++;
                    else        S ++;
                    
                    EnumCoord e_First  = (EnumCoord)(F % 3);
                    EnumCoord e_Second = (EnumCoord)(S % 3);

                    // Define which mirror operations are allowed for this raster line
                    EnumMirror e_Mirror = EnumMirror.None;
                    if (e_Second == EnumCoord.X) e_Mirror = EnumMirror.X;
                    if (e_Second == EnumCoord.Y) e_Mirror = EnumMirror.Y;
                    if (e_Second == EnumCoord.Z) e_Mirror = EnumMirror.Z;

                    CLine i_FirstLine = mi_AxisLines[(int)e_First];  // Main axis
                    CLine i_SecndLine = mi_AxisLines[(int)e_Second]; // Main axis

                    double d_SecndStart = i_SecndLine.mi_Points[0].mi_P3D.GetValue(e_Second);
                    double d_SecndEnd   = i_SecndLine.mi_Points[1].mi_P3D.GetValue(e_Second);

                    // Distance between raster lines
                    double d_Interval = CalculateInterval(d_SecndEnd - d_SecndStart);

                    int s32_Start = (int)(d_SecndStart / d_Interval) - 1;
                    int s32_End   = (int)(d_SecndEnd   / d_Interval) + 1;

                    for (int L=s32_Start; L<s32_End; L++) // iterate raster lines
                    {
                        double d_Offset = d_Interval * L;

                        if (d_Offset < d_SecndStart || d_Offset > d_SecndEnd) 
                            continue;

                        CLine i_Raster = new CLine(this, e_First, e_Second, e_Mirror);
                            
                        i_Raster.mi_Points[0].mi_P3D = i_FirstLine.mi_Points[0].mi_P3D.Clone();
                        i_Raster.mi_Points[1].mi_P3D = i_FirstLine.mi_Points[1].mi_P3D.Clone();

                        i_Raster.mi_Points[0].mi_P3D.SetValue(e_Second, d_Offset);
                        i_Raster.mi_Points[1].mi_P3D.SetValue(e_Second, d_Offset);

                        i_Raster.ms_Label = FormatDouble(d_Offset);

                        // Do not draw the raster line at value zero if it equals the main axis and the axis is not mirrored
                        if (L == 0 && !mi_Axis[(int)e_Second].Mirror && i_Raster.CoordEquals(mi_AxisLines[(int)e_First]))
                            continue;

                        if ((e_First == EnumCoord.X && e_Second == EnumCoord.Z) || // Blue
                            (e_First == EnumCoord.Z && e_Second == EnumCoord.X))
                        {
                            i_Raster.md_Sort = mi_Quadrant.md_SortXZ;
                        }
                        else if ((e_First == EnumCoord.Z && e_Second == EnumCoord.Y) || // Green
                                 (e_First == EnumCoord.Y && e_Second == EnumCoord.Z))
                        {
                            i_Raster.md_Sort = mi_Quadrant.md_SortYZ;
                        }
                        else // X + Y Red
                        {
                            i_Raster.md_Sort = mi_Quadrant.md_SortXY;

                            // Special case: XY raster lines must be shifted down to negative end of Z axis
                            i_Raster.mi_Points[0].mi_P3D.Z = i_MainAxisZ.mi_Points[0].mi_P3D.Z;
                            i_Raster.mi_Points[1].mi_P3D.Z = i_MainAxisZ.mi_Points[0].mi_P3D.Z;
                        }

                        i_Raster.Project3D();
                        mi_AxisLines.Add(i_Raster);
                    } // for (L)
                } // for (A)
            } // if (Raster)

            // Remove the green and blue main axes if Z value zero is outside the visible range
            if (mi_Bounds.Z.Min > 0.0 || mi_Bounds.Z.Max < 0.0) 
            {
                mi_AxisLines.Remove(i_MainAxisX);
                mi_AxisLines.Remove(i_MainAxisY);
            }

            // Move the graph to the left when labels are enabled
            if (me_Raster == EnumRaster.Labels)
            {
                int s32_LabelWidth = 0;
                foreach (CLine i_Line in mi_AxisLines)
                {
                    if (i_Line.me_Line == EnumCoord.Y && i_Line.me_Offset == EnumCoord.Z)
                    {
                        SizeF  k_Size  = i_Graph.MeasureString(i_Line.ms_Label, Font);
                        s32_LabelWidth = Math.Max(s32_LabelWidth, (int)k_Size.Width);
                    }
                }
                mi_Mouse.mk_OffCoord.X -= s32_LabelWidth / 2;
            }
        }

        /// <summary>
        /// Makes a color brigther
        /// </summary>
        private static Color BrightenColor(Color c_Color)
        {
            int s32_Red   = c_Color.R + (255 - c_Color.R) / 2;
            int s32_Green = c_Color.G + (255 - c_Color.G) / 2;
            int s32_Blue  = c_Color.B + (255 - c_Color.B) / 2;

            return Color.FromArgb(255, s32_Red, s32_Green, s32_Blue);
        }

        /// <summary>
        /// returns intervals of  0.1, 0.2, 0.5,  1, 2, 5,  10, 20, 50,  etc...
        /// The count of intervals which fit into the range is always between 5 and 10
        /// </summary>
        private static double CalculateInterval(double d_Range)
        {
            double d_Factor = Math.Pow(10.0, Math.Floor(Math.Log10(d_Range)));
            if (d_Range / d_Factor >= 5.0)
                return d_Factor;
            else if (d_Range / (d_Factor / 2.0) >= 5.0)
                return d_Factor / 2.0;
            else
                return d_Factor / 5.0;
        }

        // md_Label = 123.000 --> display "123"
        // md_Label =  15.700 --> display "15.7"  
        // md_Label =   4.260 --> display "4.26"
        // md_Label =   0.834 --> display "0.834"
        public static string FormatDouble(double d_Label)
        {
            return d_Label.ToString("0.000", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.');
        }


        /// <summary>
        /// Checks if the 2D point X,Y lies on the line between i_Start and i_End within s32_MaxDist
        /// All coordinates in pixels.
        /// </summary>
        private static bool IsPointOnLine(CPoint2D i_Start, CPoint2D i_End, int X, int Y, int s32_MaxDist)
        {
            double d_DeltaX = i_End.md_X - i_Start.md_X;
            double d_DeltaY = i_End.md_Y - i_Start.md_Y;

            int s32_StepsX = Math.Abs((int)d_DeltaX);
            int s32_StepsY = Math.Abs((int)d_DeltaY);
            int s32_Steps  = Math.Max(s32_StepsX, s32_StepsY);

            d_DeltaX /= s32_Steps;
            d_DeltaY /= s32_Steps;

            CPoint2D i_Point = i_Start.Clone();
            for (int S=0; S<=s32_Steps; S++)
            {
                if (i_Point.CalcDistanceTo(X, Y) <= s32_MaxDist)
                    return true;

                i_Point.md_X += d_DeltaX;
                i_Point.md_Y += d_DeltaY;
            }
            return false;
        }

        // =================================== DRAWING =====================================

        /// <summary>
        /// This is invoked by Invalidate() when the GUI thread becomes idle.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Stupidly the .NET framework draws a red cross if any exception occurres in OnPaint()
            try
            {
                Render(e.Graphics);
            }
            catch (Exception Ex)
            {
                e.Graphics.ResetTransform();
                e.Graphics.Clear(Color.DarkRed);
                e.Graphics.DrawString(Ex.Message + "\n" + Ex.StackTrace, new Font("Verdana", 8, FontStyle.Bold), Brushes.White, 10, 10);
                return;
            }

            DrawBorder(e.Graphics);
        }

        public Bitmap GetScreenshot()
        {
            Bitmap i_Bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            using (Graphics i_Graph = Graphics.FromImage(i_Bmp))
            {
                Render(i_Graph);
            }
            return i_Bmp;
        }

        private void Render(Graphics i_Graph)
        {
            i_Graph.Clear(BackColor);

            foreach (CMessgData i_Mesg in mi_MessageData)
            {
                i_Mesg.Draw(i_Graph, ClientRectangle);
            }

            // If there are no 3D objects --> only show the messages. Do not show an empty coordinate system.
            if (mi_UserObjects.Count == 0)
                return;

            // Speed optimization: Add points to tooltip only if required
            if ((me_Recalculate & EnumRecalculate.AddRemove) > 0)
            {
                mi_Tooltip.Clear();
                foreach (CDrawObj i_Object in mi_UserObjects)
                {
                    foreach (CPoint i_Point in i_Object.mi_Points)
                    {
                        mi_Tooltip.AddPoint(i_Point);
                    }
                }
            }

            // Speed optimization: Calculate coordinate system only if required
            if ((me_Recalculate & EnumRecalculate.CoordSystem) > 0)
            {
                // Calculate Min/Max for all UserObjects, assign mi_Inst to all user objects.
                mi_Bounds.Calculate();

                // Calculate factors for transformation
                NormalizeRanges();

                // Fills mi_AxisLines with 3 main axis and 42 raster lines
                CreateCoordinateSystem(i_Graph);
            }

            // Speed optimization: Calculate 3D objects only if required
            if ((me_Recalculate & EnumRecalculate.Objects) > 0)
            {
                foreach (CDrawObj i_Object in mi_UserObjects)
                {
                    // This must not be called for axes
                    i_Object.CalcSortOrder();

                    // This must not be called for axes
                    // reload Pens, Brushes from User objects or from ColorScheme
                    i_Object.ProcessColors();

                    // Project 3D --> 2D, calculate line width, shape radius,...
                    i_Object.Project3D();
                }
            }

            // Speed optimization: Merge lists only if at least one of them has changed
            if ((me_Recalculate & (EnumRecalculate.AddRemove | EnumRecalculate.CoordSystem)) > 0)
            {
                mi_AllObjects.Clear();
                mi_AllObjects.AddRange(mi_AxisLines);
                mi_AllObjects.AddRange(mi_UserObjects);
            }

            // Speed optimization: sort draw objects only if required
            if ((me_Recalculate & (EnumRecalculate.AddRemove | EnumRecalculate.CoordSystem | EnumRecalculate.Objects)) > 0)
            {
                // Sort draw order from background to foreground
                mi_AllObjects.Sort();
            }

            me_Recalculate = EnumRecalculate.Nothing;

            // ---------------------------------------------------

            // Draw axis legends in bottom left corner
            if (me_LegendPos == EnumLegendPos.BottomLeft)
            {
                int X = 4;
                int Y = ClientSize.Height - Font.Height - 4;
                for (int i=2; i>=0; i--)
                {
                    if (string.IsNullOrEmpty(mi_Axis[i].LegendText))
                        continue;

                    string s_Disp = string.Format("{0}: {1}", (EnumCoord)i, mi_Axis[i].LegendText);
                    i_Graph.DrawString(s_Disp, Font, mi_Axis[i].LegendBrush, X,  Y);
                    Y -= Font.Height;
                }
            }

            // Draw rotation legends at top
            if (mi_TopLegendBrush != null)
            {
                string[] s_Legend = new string[] { "Rotation:", "Elevation:", "Distance:" };
                string[] s_Value  = new string[] { string.Format("{0:+#;-#;0}°", (int)mi_Mouse.md_Phi),
                                                   string.Format("{0:+#;-#;0}°", (int)mi_Mouse.md_Theta),
                                                   string.Format("{0}",          (int)mi_Mouse.md_Rho) };

                SizeF k_Size = i_Graph.MeasureString(s_Legend[1], Font); // measure the widest string
                int X = 4;
                int Y = 3;
                for (int i=0; i<3; i++)
                {
                    i_Graph.DrawString(s_Legend[i], Font, mi_TopLegendBrush, X,  Y);
                    i_Graph.DrawString(s_Value [i], Font, mi_TopLegendBrush, X + k_Size.Width, Y);
                    Y += Font.Height;
                }
            }

            // ---------------------------------------------------

            // Set X, Y offset which user has set by mouse dragging with SHIFT key pressed
            i_Graph.TranslateTransform(mi_Mouse.mk_OffMove.X + mi_Mouse.mk_OffCoord.X, 
                                       mi_Mouse.mk_OffMove.Y + mi_Mouse.mk_OffCoord.Y);

            SmoothingMode e_Smooth = SmoothingMode.Invalid;

            foreach (CDrawObj i_DrawObj in mi_AllObjects)
            {
                if (!i_DrawObj.IsValid)
                    continue; // avoid overflow exception or hanging

                if (e_Smooth != i_DrawObj.me_SmoothMode) // avoid unneccessary calls into GDI+ (speed optimization)
                {
                    e_Smooth              = i_DrawObj.me_SmoothMode;
                    i_Graph.SmoothingMode = i_DrawObj.me_SmoothMode;
                }

                // Draw Line, Shape, Polygon
                i_DrawObj.Render(i_Graph);

                // Draw labels and legends
                CLine i_Line = i_DrawObj as CLine;
                if (i_Line         != null             &&
                    i_Line.me_Line != EnumCoord.Invalid   &&
                    mi_Quadrant.mb_BottomView == false && // no label in bottom view
                    mi_Quadrant.ms32_Quadrant == 3)       // showing labels makes sense only in quadrant 3 
                {
                    bool b_Legend = false;

                    // Draw axis legends at end of of main axis
                    if (me_LegendPos == EnumLegendPos.AxisEnd && i_Line.me_Line == i_Line.me_Offset)
                    {
                        CAxis i_Axis = mi_Axis[(int)i_Line.me_Line];
                        if (!string.IsNullOrEmpty(i_Axis.LegendText))
                        {
                            StringFormat i_Align = new StringFormat();
                            PointF       k_Pos   = i_Line.mi_Points[1].mi_P2D.Coord;
                            switch (i_Line.me_Line)
                            {
                                case EnumCoord.X:
                                    k_Pos.X += (float)mi_Transform.ProjectXY(5, -5);
                                    k_Pos.Y += (float)mi_Transform.ProjectXY(5, -Font.Height / 2 - 2);
                                    i_Align.Alignment = StringAlignment.Far;
                                    break;
                                case EnumCoord.Y:
                                    k_Pos.X += 5;
                                    k_Pos.Y -= Font.Height / 2;
                                    break;
                                case EnumCoord.Z:
                                    k_Pos.X -= 5;
                                    k_Pos.Y -= Font.Height + 5;
                                    break;
                            }

                            i_Graph.DrawString(i_Axis.LegendText, Font, i_Axis.LegendBrush, k_Pos, i_Align);
                            b_Legend = true; // do not draw a label if a legend has already been drawn (see Demo Sphere)
                        }
                    }
                    
                    // Draw labels of raster lines
                    if (me_Raster == EnumRaster.Labels && !b_Legend && !string.IsNullOrEmpty(i_Line.ms_Label))
                    {
                        Brush        i_Brush = null;
                        StringFormat i_Align = new StringFormat();
                        PointF       k_Pos   = i_Line.mi_Points[1].mi_P2D.Coord;

                        if (i_Line.me_Line == EnumCoord.Y)
                        {
                            if (i_Line.me_Offset == EnumCoord.X)
                            {
                                k_Pos.X += (float)mi_Transform.ProjectXY(5, -5);
                                k_Pos.Y += (float)mi_Transform.ProjectXY(-Font.Height / 2, 5);
                                i_Brush = AxisX.LegendBrush;
                            }
                            else // Y (Main axis) and Z (Raster)
                            {
                                k_Pos.X += 5;
                                k_Pos.Y -= Font.Height / 2;
                                i_Brush = AxisZ.LegendBrush;
                            }
                        }
                        else if (i_Line.me_Line == EnumCoord.X && i_Line.me_Offset == EnumCoord.Y)
                        {
                            k_Pos.X += (float)mi_Transform.ProjectXY(5, -5);
                            k_Pos.Y += (float)mi_Transform.ProjectXY(5, -Font.Height / 2);
                            i_Align.Alignment = StringAlignment.Far;
                            i_Brush = AxisY.LegendBrush;
                        }

                        if (i_Brush != null)
                            i_Graph.DrawString(i_Line.ms_Label, Font, i_Brush, k_Pos, i_Align);
                    }
                }
            }
        }

        // ============================================================================

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            // This control draws it's own border. See DrawBorder()
            BorderStyle = BorderStyle.None;

            // This is the size of the control defined in Visual Studio Form Designer
            mi_Transform.SetInitialSize(ClientSize);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // This may be called with an invalid size before the control is created!
            mi_Transform.SetSize(ClientSize);
            Invalidate(); // Windows will call OnPaint() when the GUI thread becomes idle.
        }

        // --------------------------------------------

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            DrawBorder(null);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            DrawBorder(null);
        }
        /// <summary>
        /// Draw a one pixel border around the control which may change color when the control has the focus.
        /// </summary>
        private void DrawBorder(Graphics i_Graphics)
        {
            Pen i_Pen = mi_BorderPens[Focused ? 1 : 0];
            if (i_Pen != null)
            {
                BorderStyle = BorderStyle.None;

                if (i_Graphics == null)
                    i_Graphics = Graphics.FromHwnd(Handle);

                i_Graphics.ResetTransform();
                Rectangle r_Rect = ClientRectangle;
                i_Graphics.DrawRectangle(i_Pen, r_Rect.X, r_Rect.Y, r_Rect.Width - 1, r_Rect.Height - 1);
            }
        }

        // ============================== MOUSE =====================================

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mi_Tooltip.Hide();
            mi_Mouse.mk_LastPos = e.Location;

            if (mi_AllObjects.Count == 0)
                return;
           
            int s32_UID = (int)ModifierKeys | (int)e.Button;
            
            CUserInput i_Input;
            if (mi_UserInputs.TryGetValue(s32_UID, out i_Input))
            {
                switch (i_Input.Action)
                {
                    case EnumMouseAction.SelectObj:
                    case EnumMouseAction.Callback:
                        OnSelMouseDown(e.X, e.Y, i_Input);
                        break;

                    default:
                        mi_Mouse.me_Action = i_Input.Action;
                        Cursor             = i_Input.Cursor;
                        break;
                }
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            int s32_DeltaX = e.X - mi_Mouse.mk_LastPos.X;
            int s32_DeltaY = e.Y - mi_Mouse.mk_LastPos.Y;
            mi_Mouse.mk_LastPos = e.Location;

            switch (mi_Mouse.me_Action)
            {
                case EnumMouseAction.Move:
                    mi_Tooltip.Hide();
                    mi_Mouse.mk_OffMove.X += s32_DeltaX;
                    mi_Mouse.mk_OffMove.Y += s32_DeltaY;
                    Invalidate(); // Windows will call OnPaint() when the GUI thread becomes idle.
                    break;

                case EnumMouseAction.Rho:
                case EnumMouseAction.Theta:
                case EnumMouseAction.Phi:
                case EnumMouseAction.ThetaAndPhi:
                    mi_Tooltip.Hide();
                    mi_Mouse.OnMouseMove(s32_DeltaX, s32_DeltaY);
                    mi_Transform.SetCoefficients(mi_Mouse);
                    Invalidate(); // Windows will call OnPaint() when the GUI thread becomes idle.
                    break;

                case EnumMouseAction.SelectObj:
                case EnumMouseAction.Callback:
                    int s32_UID = (int)ModifierKeys | (int)e.Button;
                    CUserInput i_Input;
                    if (mi_UserInputs.TryGetValue(s32_UID, out i_Input))
                    {
                        if (i_Input.Action == mi_Mouse.me_Action)
                        {
                            // Mouse.Y  coordinates have the zero point at top left
                            // Editor3DRenderer coordinates have the zero point at bottom left --> negate Y 
                            SelectionCallback(EnumSelEvent.MouseDrag, i_Input.Modifiers, s32_DeltaX, -s32_DeltaY, mi_DragObject);
                        }
                        else 
                        {
                            // The modifier keys have changed --> abort sending events to the callback
                            OnMouseExit(); 
                        }
                    }
                    break;

                case EnumMouseAction.None:
                    mi_Tooltip.OnMouseMove(e);
                    break;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            OnMouseExit();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            OnMouseExit();
        }
        private void OnMouseExit()
        {
            mi_Tooltip.Hide();
            Cursor = Cursors.Arrow;

            switch (mi_Mouse.me_Action)
            {
                case EnumMouseAction.SelectObj:
                case EnumMouseAction.Callback:
                    SelectionCallback(EnumSelEvent.MouseUp, Keys.None, 0, 0, mi_DragObject);
                    break;
            }

            mi_DragObject = null;
            mi_Mouse.me_Action = EnumMouseAction.None;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            mi_Tooltip.Hide();

            if (mi_Mouse.OnMouseWheel(-e.Delta))
            {
                mi_Transform.SetCoefficients(mi_Mouse);
                Invalidate(); // Windows will call OnPaint() when the GUI thread becomes idle.
            }
        }
        /// <summary>
        /// Select 3D object or call selection callback function
        /// </summary>
        private void OnSelMouseDown(int X, int Y, CUserInput i_Input)
        {
            if (!mi_Selection.Enabled)
                return;

            CObject3D i_Found = FindObjectAt(X, Y, true);

            if (mi_Selection.Callback != null)
            {
                // Start dragging even if i_Found == null
                mi_DragObject      = i_Found;
                mi_Mouse.me_Action = i_Input.Action;
                Cursor             = i_Input.Cursor;

                SelectionCallback(EnumSelEvent.MouseDown, i_Input.Modifiers, 0, 0, mi_DragObject);
                return;
            }

            // No callback assigned --> toggle selection of 3D object.
            if (i_Found != null && i_Input.Action == EnumMouseAction.SelectObj)
            {
                // Not multiselect --> remove all current selections
                if (!mi_Selection.MultiSelect)
                     mi_Selection.DeSelectAll();

                i_Found.Selected = !i_Found.Selected; // toggle selection

                Invalidate(); // Windows will call OnPaint() when the GUI thread becomes idle.
            }
        }

        // ========================== SELECTION CALLBACK ===============================

        /// <summary>
        /// Selection.Callback is called on the mouse events Down, Move and Up if CUserInput.Action = Callback or SelectObj
        /// The callback must never throw an exception.
        /// i_Object may be CPoint3D                       if Selection.SinglePoints = true
        /// i_Object may be CShape3D, CLine3D, CPolygon3D  if Selection.SinglePoints = false
        /// i_Object may be null if the user has clicked a location without a 3D object.
        /// In this case the callback can call Selection.GetSelectedObjects() / GetSelectedPoints() to obtain the previous selections.
        /// The callback is responsible for selecting / deselecting the desired objects.
        /// If the callback does not change the selection status, the 3D object will never be selected / deselected.
        /// The callback is allowed to show a MessageBox to the user.
        /// </summary>
        private void SelectionCallback(EnumSelEvent e_Event, Keys e_Modifiers, int s32_DeltaX, int s32_DeltaY, CObject3D i_Object)
        {
            if (!mi_Selection.Enabled || mi_Selection.Callback == null)
                return;
            try
            {
                EnumInvalidate e_Invalidate = mi_Selection.Callback(e_Event, e_Modifiers, s32_DeltaX, s32_DeltaY, i_Object);

                if (e_Invalidate == EnumInvalidate.CoordSystem)
                    me_Recalculate |= EnumRecalculate.CoordSystem;

                if (e_Invalidate != EnumInvalidate.NoChange)
                    Invalidate(); // Windows will call OnPaint() when the GUI thread becomes idle.
            }
            catch (Exception Ex)
            {
                MessageBox.Show(TopLevelControl, "Your callback function has crashed:\n\n" + Ex.Message + "\n\n" + Ex.StackTrace, 
                                "Bug Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}