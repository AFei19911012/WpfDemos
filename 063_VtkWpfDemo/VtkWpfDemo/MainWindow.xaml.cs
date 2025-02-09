using Kitware.VTK;
using System.Windows;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace VtkWpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private vtkRenderWindow renWin;
        private vtkRenderer render;
        private vtkRenderWindowInteractor interactor;
        private vtkInteractorStyleTrackballCamera style;
        private Data3DModel model;
        private vtkTexture texture;
        private vtkActor actor;


        public MainWindow()
        {
            InitializeComponent();

            vtk_render.Load += Vtk_render_Load;
        }

        private void Vtk_render_Load(object sender, EventArgs e)
        {
            renWin = vtk_render.RenderWindow;
            render = renWin.GetRenderers().GetFirstRenderer();

            interactor = vtkRenderWindowInteractor.New();
            interactor.SetRenderWindow(renWin);
            interactor.MouseMoveEvt += new vtkObject.vtkObjectEventHandler(OnMouseMoveEvt);
            style = vtkInteractorStyleTrackballCamera.New();
            style.RightButtonPressEvt += new vtkObject.vtkObjectEventHandler(OnRightButtonPressEvt);
            renWin.GetInteractor().SetInteractorStyle(style);
            interactor.SetInteractorStyle(style);

            vtkFileOutputWindow output = new vtkFileOutputWindow();
            output.SetFileName(@"log\vtk.log");
            // 弹窗警告
            vtkOutputWindow.SetInstance(output);

            // 绘制一些东西
            vtkSphereSource sphere = vtkSphereSource.New();
            sphere.SetThetaResolution(12);
            sphere.SetPhiResolution(12);
            vtkConeSource cone = vtkConeSource.New();
            vtkGlyph3D glyph = vtkGlyph3D.New();
            glyph.SetInputConnection(sphere.GetOutputPort());
            glyph.SetSourceConnection(cone.GetOutputPort());
            glyph.SetVectorModeToUseNormal();
            glyph.SetScaleModeToScaleByVector();
            glyph.SetScaleFactor(0.25);

            vtkTransform trans = vtkTransform.New();
            trans.Scale(1, 1.5, 2);
            trans.Translate(1, 1, 0);
            vtkTransformFilter transformFilter = vtkTransformFilter.New();
            transformFilter.SetInputConnection(sphere.GetOutputPort());
            transformFilter.SetTransform(trans);

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputConnection(transformFilter.GetOutputPort());
            colorIt.SetLowPoint(0, 0, -1);
            colorIt.SetHighPoint(0, 0, 1);

            // 颜色
            vtkLookupTable lut = vtkLookupTable.New();
            lut.SetHueRange(0.667, 0);
            lut.SetSaturationRange(1, 1);
            lut.SetValueRange(1, 1);

            vtkDataSetMapper sphereMapper = vtkDataSetMapper.New();
            sphereMapper.SetLookupTable(lut);
            sphereMapper.SetInputConnection(colorIt.GetOutputPort());
            vtkActor sphereActor = vtkActor.New();
            sphereActor.SetMapper(sphereMapper);
            sphereActor.GetProperty().SetInterpolationToFlat();


            vtkAppendPolyData polyData = vtkAppendPolyData.New();
            polyData.AddInputConnection(glyph.GetOutputPort());
            polyData.AddInputConnection(sphere.GetOutputPort());

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(polyData.GetOutputPort());

            vtkLODActor actor = vtkLODActor.New();
            actor.SetMapper(mapper);

            render.AddActor(actor);
            render.AddActor(sphereActor);
            render.SetViewport(0, 0, 1.0, 1.0);
            render.GradientBackgroundOn();
            render.SetBackground(0.2, 0.3, 0.3);
            render.SetBackground2(0.8, 0.8, 0.8);
            //renWin.SetSize(512, 512);
            renWin.Render();
        }

        private void OnRightButtonPressEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            vtkTransform trans = vtkTransform.New();
            trans.RotateZ(-90);
            trans.RotateY(180);
            actor.SetUserTransform(trans);

            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            renWin.AddRenderer(render);
            renWin.Render();
        }

        private void OnMouseMoveEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            var pos = renWin.GetInteractor().GetEventPosition();
            interactor.GetPicker().Pick(pos[0], pos[1], 0, render);
            // 世界坐标
            var posWorld = interactor.GetPicker().GetPickPosition();
        }


        private vtkScalarBarActor CreateColorbar(vtkLookupTable lut)
        {
            vtkScalarBarActor scalarBar = vtkScalarBarActor.New();
            scalarBar.SetLookupTable(lut);
            scalarBar.SetHeight(0.3);
            scalarBar.SetWidth(0.1);
            scalarBar.SetNumberOfLabels(5);
            scalarBar.SetPosition(0.9, 0.65);
            scalarBar.GetLabelTextProperty().SetFontSize(4);
            scalarBar.SetTextPositionToPrecedeScalarBar();
            //scalarBar.SetTitle("Point Cloud");
            return scalarBar;
        }

        private vtkLookupTable CreateLookupTable(double mini, double maxi, int number = 256)
        {
            //vtkNamedColors colors = vtkNamedColors.New();
            //vtkColorSeries colorSeries = vtkColorSeries.New();
            //colorSeries.SetNumberOfColors(8);
            //colorSeries.SetColorSchemeName("Hawaii");
            //colorSeries.SetColor(0, colors.GetColor3ub("turquoise_blue"));
            //colorSeries.SetColor(1, colors.GetColor3ub("sea_green_medium"));
            //colorSeries.SetColor(2, colors.GetColor3ub("sap_green"));
            //colorSeries.SetColor(3, colors.GetColor3ub("green_dark"));
            //colorSeries.SetColor(4, colors.GetColor3ub("tan"));
            //colorSeries.SetColor(5, colors.GetColor3ub("beige"));
            //colorSeries.SetColor(6, colors.GetColor3ub("light_beige"));
            //colorSeries.SetColor(7, colors.GetColor3ub("bisque"));
            vtkLookupTable lut = vtkLookupTable.New();
            //colorSeries.BuildLookupTable(lut, 0);
            lut.SetNanColor(1, 0, 0, 1);

            // 黑白效果
            //lut.SetHueRange(0, 0);
            //lut.SetSaturationRange(0, 0);
            //lut.SetValueRange(0.2, 1.0);

            //lut.SetHueRange(0.7, 0);
            //lut.SetSaturationRange(1.0, 0);
            //lut.SetValueRange(0.5, 1.0);

            //// 红到蓝
            //lut.SetHueRange(0.0, 0.667);
            //// 蓝到红
            ////lut.SetHueRange(0.667, 0.0);

            lut.SetNumberOfColors(number);
            lut.SetTableRange(mini, maxi);
            lut.Build();

            return lut;
        }

        private vtkUnsignedCharArray CreateColormap(vtkPoints points, vtkLookupTable lut)
        {
            vtkUnsignedCharArray colormap = vtkUnsignedCharArray.New();
            colormap.SetNumberOfComponents(3);
            for (int i = 0; i < points.GetNumberOfPoints(); i++)
            {
                var value = points.GetPoint(i);
                var color = lut.GetColor(value[2]);
                double r = 255 * color[0];
                double g = 255 * color[1];
                double b = 255 * color[2];
                colormap.InsertNextTuple3(r, g, b);
            }
            return colormap;
        }

        private vtkRenderer ShowPointCloud(vtkPoints points)
        {
            vtkPolyData polydata = vtkPolyData.New();
            polydata.SetPoints(points);
            vtkVertexGlyphFilter glyph = vtkVertexGlyphFilter.New();
            glyph.SetInputData(polydata);
            glyph.Update();

            double[] minmax = points.GetBounds();

            vtkShrinkPolyData shrink = vtkShrinkPolyData.New();
            shrink.SetInputConnection(glyph.GetOutputPort());
            shrink.Update();

            vtkLookupTable lut = CreateLookupTable(minmax[4], minmax[5]);
            vtkUnsignedCharArray colormap = CreateColormap(shrink.GetOutput().GetPoints(), lut);
            shrink.GetOutput().GetPointData().SetScalars(colormap);

            vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
            glyphFilter.SetInputData(shrink.GetOutput());
            glyphFilter.Update();

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetLookupTable(lut);

            // 图片纹理
            if (texture != null)
            {
                mapper.ScalarVisibilityOff();
                vtkTextureMapToPlane texturemap = vtkTextureMapToPlane.New();
                texturemap.SetInputConnection(glyphFilter.GetOutputPort());
                mapper.SetInputConnection(texturemap.GetOutputPort());
            }
            else
            {
                mapper.SetInputConnection(glyphFilter.GetOutputPort());
            }
            mapper.SetScalarRange(minmax[4], minmax[5]);

            actor = vtkActor.New();
            actor.SetMapper(mapper);
            if (texture != null)
            {
                actor.SetTexture(texture);
            }
            vtkTransform trans = vtkTransform.New();
            trans.RotateZ(-90);
            trans.RotateY(180);
            actor.SetUserTransform(trans);

            vtkRenderer out_render = vtkRenderer.New();
            out_render.AddActor(actor);
            out_render.AddActor(CreateColorbar(lut));
            out_render.SetBackground(0.1, 0.2, 0.4);

            return out_render;
        }

        private void LoadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "选择3D图文件",
                Filter = "3D图文件|*.dlt",
                InitialDirectory = Environment.CurrentDirectory,
            };
            if (dlg.ShowDialog() == true)
            {
                model = DataIoHelper.ReadDlt(dlg.FileName);
                render = ShowPointCloud(model.Points);
                renWin.AddRenderer(render);
                renWin.Render();
            }
        }

        private void LoadStlFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "选择3D图文件",
                Filter = "3D图文件|*.stl",
                InitialDirectory = Environment.CurrentDirectory,
            };
            if (dlg.ShowDialog() == true)
            {
                vtkSTLReader stl = vtkSTLReader.New();
                stl.SetFileName(dlg.FileName);

                // 数据压缩
                vtkShrinkPolyData shrink = vtkShrinkPolyData.New();
                shrink.SetInputConnection(stl.GetOutputPort());
                shrink.SetShrinkFactor(0.5);

                vtkElevationFilter colorIt = vtkElevationFilter.New();
                colorIt.SetInputConnection(shrink.GetOutputPort());
                colorIt.SetLowPoint(0, 0, -1);
                colorIt.SetHighPoint(0, 0, 1);

                vtkLookupTable lut = CreateLookupTable(-1, 1);
                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.SetInputConnection(colorIt.GetOutputPort());

                vtkLODActor actor = vtkLODActor.New();
                actor.SetMapper(mapper);

                render = vtkRenderer.New();
                render.AddActor(actor);
                render.AddActor(CreateColorbar(lut));
                render.SetBackground(0.1, 0.2, 0.4);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();
            }
        }

        private void TextureMap_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "选择图片文件",
                Filter = "图片文件|*.jpg",
                InitialDirectory = Environment.CurrentDirectory,
            };
            if (dlg.ShowDialog() == true)
            {
                vtkJPEGReader jpg = vtkJPEGReader.New();
                jpg.SetFileName(dlg.FileName);
                jpg.Update();

                //vtkImageFlip flipX = vtkImageFlip.New();
                //flipX.SetInputConnection(jpg.GetOutputPort());
                //flipX.SetFilteredAxes(0);
                //flipX.Update();

                //vtkImageFlip flipXY = vtkImageFlip.New();
                //flipXY.SetInputConnection(flipX.GetOutputPort());
                //flipXY.SetFilteredAxes(2);
                //flipXY.Update();

                texture = vtkTexture.New();
                texture.SetInputConnection(jpg.GetOutputPort());
                texture.InterpolateOn();
                texture.Update();


                vtkPlaneSource plane = vtkPlaneSource.New();
                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.SetInputConnection(plane.GetOutputPort());

                vtkActor actor = vtkActor.New();
                actor.SetMapper(mapper);
                actor.SetTexture(texture);

                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.2, 0.3, 0.3);
                render.ResetCamera();

                vtkCamera camera = vtkCamera.New();
                camera.SetPosition(0, 0, 2);
                camera.SetFocalPoint(0, 0, 0);
                camera.Azimuth(0);
                camera.Elevation(0);
                render.SetActiveCamera(camera);

                renWin.AddRenderer(render);
                renWin.Render();
            }
        }
    }
}