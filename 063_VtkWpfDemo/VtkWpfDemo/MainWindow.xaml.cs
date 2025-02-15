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
        private vtkTexture texture;
        private vtkActor actor;
        private vtkCamera camera;

        private int[] InitClickPos { get; set; }
        private bool CanMove { get; set; }
        private double[] CurWinCenter { get; set; }
        private DateTime PreClickTime { get; set; } = DateTime.Now;


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
            //interactor.MiddleButtonPressEvt += new vtkObject.vtkObjectEventHandler(OnMiddleButtonPressEvt);
            interactor.MouseMoveEvt += new vtkObject.vtkObjectEventHandler(OnMouseMoveEvt);
            interactor.LeftButtonPressEvt += new vtkObject.vtkObjectEventHandler(OnLeftButtonPressEvt);

            style = vtkInteractorStyleTrackballCamera.New();
            //style.MouseWheelBackwardEvt += new vtkObject.vtkObjectEventHandler(OnMouseWheelBackwardEvt);
            //style.MouseWheelForwardEvt += new vtkObject.vtkObjectEventHandler(OnMouseWheelForwardEvt);
            style.MiddleButtonPressEvt += new vtkObject.vtkObjectEventHandler(OnMiddleButtonPressEvt);
            style.RightButtonPressEvt += new vtkObject.vtkObjectEventHandler(OnRightButtonPressEvt);
            style.RightButtonReleaseEvt += new vtkObject.vtkObjectEventHandler(OnRightButtonReleaseEvt);
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

            actor = vtkLODActor.New();
            actor.SetMapper(mapper);
            render.AddActor(actor);
            render.AddActor(sphereActor);
            render.SetViewport(0, 0, 1.0, 1.0);
            render.GradientBackgroundOn();
            render.SetBackground(0.2, 0.3, 0.3);
            render.SetBackground2(0.8, 0.8, 0.8);
            //renWin.SetSize(512, 512);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }

        private void OnLeftButtonPressEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            // 模拟下双击事件 两次点击间隔时间
            // 重置视图相机
            if ((DateTime.Now - PreClickTime).TotalMilliseconds < 300)
            {
                camera?.SetPosition(0, 0, 0);
                camera?.SetFocalPoint(0, 0, -1);
                camera?.SetViewUp(0, 1, 0);
                camera?.SetWindowCenter(0, 0);
                render?.ResetCamera();
                renWin?.Render();
            }

            // 更新上次点击时间
            PreClickTime = DateTime.Now;
        }

        private void OnMiddleButtonPressEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            // 禁掉鼠标中键
            return;
        }

        private void OnMouseWheelForwardEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            camera.Zoom(1.25);
            renWin.Render();
        }
        private void OnMouseWheelBackwardEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            camera.Zoom(0.8);
            renWin.Render();
        }

        private void OnRightButtonPressEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            InitClickPos = renWin.GetInteractor().GetEventPosition();
            CanMove = true;
            CurWinCenter = camera.GetWindowCenter();
        }

        private void OnMouseMoveEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            var pos = renWin.GetInteractor().GetEventPosition();
            interactor.GetPicker().Pick(pos[0], pos[1], 0, render);
            // 世界坐标
            var posWorld = interactor.GetPicker().GetPickPosition();

            if (CanMove == true)
            {
                var winSize = renWin.GetSize();
                var dx = 1.0 * (pos[0] - InitClickPos[0]) / winSize[0];
                var dy = 1.0 * (pos[1] - InitClickPos[1]) / winSize[1];
                // [-1, 1]
                camera.SetWindowCenter(CurWinCenter[0] - dx * 2, CurWinCenter[1] - dy * 2);
                renWin.Render();
            }
        }

        private void OnRightButtonReleaseEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            CanMove = false;
        }

        private vtkScalarBarActor CreateColorbar(vtkLookupTable lut)
        {
            vtkScalarBarActor scalarBar = vtkScalarBarActor.New();
            scalarBar.SetLookupTable(lut);
            scalarBar.SetHeight(0.3);
            scalarBar.SetWidth(0.08);
            scalarBar.SetNumberOfLabels(5);
            scalarBar.SetPosition(0.9, 0.65);
            scalarBar.GetLabelTextProperty().SetFontSize(4);
            scalarBar.SetTextPositionToPrecedeScalarBar();
            //scalarBar.SetTitle("Point Cloud");
            return scalarBar;
        }

        private vtkLookupTable CreateLookupTable(double mini, double maxi, int number = 256)
        {
            vtkNamedColors colors = vtkNamedColors.New();
            vtkColorSeries colorSeries = vtkColorSeries.New();
            colorSeries.SetNumberOfColors(8);
            colorSeries.SetColorSchemeName("Hawaii");
            colorSeries.SetColor(0, colors.GetColor3ub("turquoise_blue"));
            colorSeries.SetColor(1, colors.GetColor3ub("sea_green_medium"));
            colorSeries.SetColor(2, colors.GetColor3ub("sap_green"));
            colorSeries.SetColor(3, colors.GetColor3ub("green_dark"));
            colorSeries.SetColor(4, colors.GetColor3ub("tan"));
            colorSeries.SetColor(5, colors.GetColor3ub("beige"));
            colorSeries.SetColor(6, colors.GetColor3ub("light_beige"));
            colorSeries.SetColor(7, colors.GetColor3ub("bisque"));
            vtkLookupTable lut = vtkLookupTable.New();
            colorSeries.BuildLookupTable(lut, 0);

            // 黑白效果
            //lut.SetHueRange(0, 0);
            //lut.SetSaturationRange(0, 0);
            //lut.SetValueRange(0.2, 1.0);

            //lut.SetHueRange(0.7, 0);
            //lut.SetSaturationRange(1.0, 0);
            //lut.SetValueRange(0.5, 1.0);

            // 红到蓝
            //lut.SetHueRange(0.0, 0.667);
            // 蓝到红
            lut.SetHueRange(0.667, 0.0);

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

        private void TextureMap_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "选择图片文件",
                Filter = "图片文件|*.jpg;*.bmp;*.png",
                InitialDirectory = Environment.CurrentDirectory,
            };
            if (dlg.ShowDialog() == true)
            {
                //vtkJPEGReader jpg = vtkJPEGReader.New();
                //jpg.SetFileName(dlg.FileName);
                //jpg.Update();
                vtkImageReader2 reader = vtkImageReader2Factory.CreateImageReader2(dlg.FileName);
                reader.SetFileName(dlg.FileName);
                reader.Update();

                //vtkImageFlip flipX = vtkImageFlip.New();
                //flipX.SetInputConnection(reader.GetOutputPort());
                //flipX.SetFilteredAxes(0);
                //flipX.Update();

                //vtkImageFlip flipXY = vtkImageFlip.New();
                //flipXY.SetInputConnection(flipX.GetOutputPort());
                //flipXY.SetFilteredAxes(2);
                //flipXY.Update();

                var dim = reader.GetOutput().GetDimensions();
                if (dim[0] > dim[1])
                {
                    texture = vtkTexture.New();
                    texture.SetInputConnection(reader.GetOutputPort());
                    texture.InterpolateOn();
                    texture.Update();
                }
                else
                {
                    vtkImageReslice reslice = vtkImageReslice.New();
                    reslice.SetInputConnection(reader.GetOutputPort());
                    reslice.SetResliceAxesDirectionCosines(0, 1, 0, -1, 0, 0, 0, 0, 1);  // 旋转矩阵
                    reslice.Update();

                    texture = vtkTexture.New();
                    texture.SetInputConnection(reslice.GetOutputPort());
                    texture.InterpolateOn();
                    texture.Update();
                }

                vtkPoints points = vtkPoints.New();
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        double x = 0.1 * i;
                        double y = 0.1 * j;
                        points.InsertNextPoint(i, j, Math.Exp((x - 1) * (x - 1) + (y - 1) * (y - 1)));
                    }
                }

                vtkPolyData polyData = vtkPolyData.New();
                polyData.SetPoints(points);

                // 点云
                vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                glyphFilter.SetInputData(polyData);
                glyphFilter.Update();

                vtkDelaunay2D delaunay = vtkDelaunay2D.New();
                delaunay.SetInputData(glyphFilter.GetOutput());
                delaunay.Update();

                // 平面
                vtkPlaneSource plane = vtkPlaneSource.New();
                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.ScalarVisibilityOff();
                vtkTextureMapToPlane texturemap = vtkTextureMapToPlane.New();
                texturemap.SetInputConnection(delaunay.GetOutputPort());
                mapper.SetInputConnection(texturemap.GetOutputPort());

                actor = vtkActor.New();
                actor.SetMapper(mapper);
                actor.SetTexture(texture);
                renWin.RemoveRenderer(render);
                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.1, 0.2, 0.4);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();

                // 相机
                camera = render.GetActiveCamera();
            }
        }

        private void VtkShrinkPolyData_Click(object sender, RoutedEventArgs e)
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
                stl.Update();

                vtkPoints points = vtkPoints.New();
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        double x = 0.1 * i;
                        double y = 0.1 * j;
                        points.InsertNextPoint(i, j, Math.Exp((x - 1) * (x - 1) + (y - 1) * (y - 1)));
                    }
                }
                vtkPolyData polyData = vtkPolyData.New();
                polyData.SetPoints(points);
                vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                glyphFilter.SetInputData(polyData);
                glyphFilter.Update();

                // 下采样
                vtkShrinkPolyData shrink = vtkShrinkPolyData.New();
                // 必须先执行 stl.Update()
                shrink.SetInputData(stl.GetOutput());
                // 这种方式不用执行 stl.Update()
                //shrink.SetInputConnection(stl.GetOutputPort());
                shrink.SetShrinkFactor(0.5);
                shrink.Update();

                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.SetInputConnection(shrink.GetOutputPort());

                vtkActor actor = vtkActor.New();
                actor.SetMapper(mapper);
                actor.GetProperty().SetPointSize(2f);

                renWin.RemoveRenderer(render);
                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.1, 0.2, 0.4);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();

                // 相机
                camera = render.GetActiveCamera();
            }
        }

        private void VtkElevationFilter_Click(object sender, RoutedEventArgs e)
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
                stl.Update();

                var bounds = stl.GetOutput().GetBounds();

                // 加这个就显示点云
                vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                glyphFilter.SetInputData(stl.GetOutput());
                glyphFilter.Update();

                vtkElevationFilter colorIt = vtkElevationFilter.New();
                colorIt.SetInputConnection(stl.GetOutputPort());
                colorIt.SetLowPoint(0, 0, bounds[4]);
                colorIt.SetHighPoint(0, 0, bounds[5]);

                vtkColorTransferFunction colorFun = vtkColorTransferFunction.New();
                // 蓝 → 红 → 绿
                colorFun.AddRGBPoint(0.0, 0, 0, 1);
                colorFun.AddRGBPoint(0.5, 1, 0, 0);
                colorFun.AddRGBPoint(1.0, 0, 1, 0);

                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.SetInputConnection(colorIt.GetOutputPort());
                mapper.SetLookupTable(colorFun);

                vtkActor actor = vtkActor.New();
                actor.SetMapper(mapper);
                actor.GetProperty().SetPointSize(2f);

                renWin.RemoveRenderer(render);
                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.1, 0.2, 0.4);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();

                // 相机
                camera = render.GetActiveCamera();
            }
        }

        private void VtkDecimatePro_Click(object sender, RoutedEventArgs e)
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
                stl.Update();

                //vtkPoints points = vtkPoints.New();
                //for (int i = 0; i < 20; i++)
                //{
                //    for (int j = 0; j < 20; j++)
                //    {
                //        double x = 0.1 * i;
                //        double y = 0.1 * j;
                //        points.InsertNextPoint(i, j, Math.Exp((x - 1) * (x - 1) + (y - 1) * (y - 1)));
                //    }
                //}
                //vtkPolyData polyData = vtkPolyData.New();
                //polyData.SetPoints(points);
                //vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                //glyphFilter.SetInputData(polyData);
                //glyphFilter.Update();

                // 下采样
                vtkDecimatePro decimate = vtkDecimatePro.New();
                decimate.SetInputData(stl.GetOutput());
                decimate.SetTargetReduction(0.9);
                decimate.Update();

                var bounds = decimate.GetOutput().GetBounds();

                vtkElevationFilter colorIt = vtkElevationFilter.New();
                colorIt.SetInputData(decimate.GetOutput());
                colorIt.SetLowPoint(0, 0, bounds[4]);
                colorIt.SetHighPoint(0, 0, bounds[5]);

                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.SetInputConnection(colorIt.GetOutputPort());

                vtkActor actor = vtkActor.New();
                actor.SetMapper(mapper);
                actor.GetProperty().SetPointSize(2f);

                renWin.RemoveRenderer(render);
                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.1, 0.2, 0.4);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();

                // 相机
                camera = render.GetActiveCamera();
            }
        }

        private void VtkCleanPolyData_Click(object sender, RoutedEventArgs e)
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
                stl.Update();

                vtkPoints points = vtkPoints.New();
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        double x = 0.1 * i;
                        double y = 0.1 * j;
                        points.InsertNextPoint(i, j, Math.Exp((x - 1) * (x - 1) + (y - 1) * (y - 1)));
                    }
                }
                vtkPolyData polyData = vtkPolyData.New();
                polyData.SetPoints(points);
                vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                glyphFilter.SetInputData(polyData);
                glyphFilter.Update();

                // 下采样
                vtkCleanPolyData clean = vtkCleanPolyData.New();
                clean.SetInputData(glyphFilter.GetOutput());
                clean.SetTolerance(0.05);
                clean.Update();

                var bounds = clean.GetOutput().GetBounds();

                vtkElevationFilter colorIt = vtkElevationFilter.New();
                colorIt.SetInputData(clean.GetOutput());
                colorIt.SetLowPoint(0, 0, bounds[4]);
                colorIt.SetHighPoint(0, 0, bounds[5]);

                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.SetInputConnection(colorIt.GetOutputPort());

                vtkActor actor = vtkActor.New();
                actor.SetMapper(mapper);
                actor.GetProperty().SetPointSize(2f);

                renWin.RemoveRenderer(render);
                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.1, 0.2, 0.4);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();

                // 相机
                camera = render.GetActiveCamera();
            }
        }

        private void VtkVoxelGrid_Click(object sender, RoutedEventArgs e)
        {
            vtkXMLPolyDataReader reader = vtkXMLPolyDataReader.New();
            reader.SetFileName(@"Files\laser.vtp");
            reader.Update();

            // 下采样
            vtkVoxelGrid voxel = vtkVoxelGrid.New();
            voxel.SetInputData(reader.GetOutput());
            voxel.SetConfigurationStyleToManual();
            voxel.SetDivisions(300, 300, 1);
            // 差不多效果
            //voxel.SetConfigurationStyleToLeafSize();
            //voxel.SetLeafSize(0.1, 0.1, 1);
            // 搞不清楚怎么设置
            //voxel.SetNumberOfPointsPerBin(1);
            voxel.Update();

            vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
            glyphFilter.SetInputData(voxel.GetOutput());
            glyphFilter.Update();

            var bounds = voxel.GetOutput().GetBounds();

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputData(glyphFilter.GetOutput());
            colorIt.SetLowPoint(0, 0, bounds[4]);
            colorIt.SetHighPoint(0, 0, bounds[5]);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(colorIt.GetOutputPort());

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetPointSize(2f);

            renWin.RemoveRenderer(render);
            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            render.ResetCamera();
            renWin.AddRenderer(render);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }

        private void VtkPoissonDiskSampler_Click(object sender, RoutedEventArgs e)
        {
            vtkXMLPolyDataReader reader = vtkXMLPolyDataReader.New();
            reader.SetFileName(@"Files\laser.vtp");
            reader.Update();

            // 下采样
            vtkPoissonDiskSampler poisson = vtkPoissonDiskSampler.New();
            poisson.SetInputData(reader.GetOutput());
            // 设置最小点间距，值越大点越少
            poisson.SetRadius(0.2);
            poisson.Update();

            var count = poisson.GetOutput().GetNumberOfPoints();

            vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
            glyphFilter.SetInputData(poisson.GetOutput());
            glyphFilter.Update();

            var bounds = poisson.GetOutput().GetBounds();

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputData(glyphFilter.GetOutput());
            colorIt.SetLowPoint(0, 0, bounds[4]);
            colorIt.SetHighPoint(0, 0, bounds[5]);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(colorIt.GetOutputPort());

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetPointSize(2f);

            renWin.RemoveRenderer(render);
            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            render.ResetCamera();
            renWin.AddRenderer(render);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }

        private void VtkDelaunay2D_Click(object sender, RoutedEventArgs e)
        {
            vtkXMLPolyDataReader reader = vtkXMLPolyDataReader.New();
            reader.SetFileName(@"Files\laser.vtp");
            reader.Update();

            // 下采样
            vtkPoissonDiskSampler poisson = vtkPoissonDiskSampler.New();
            poisson.SetInputData(reader.GetOutput());
            // 设置最小点间距，值越大点越少
            poisson.SetRadius(0.3);
            poisson.Update();

            // 表面重建 三角剖分
            vtkDelaunay2D delaunay = vtkDelaunay2D.New();
            delaunay.SetInputData(poisson.GetOutput());
            delaunay.Update();

            var bounds = poisson.GetOutput().GetBounds();

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputData(delaunay.GetOutput());
            colorIt.SetLowPoint(0, 0, bounds[4]);
            colorIt.SetHighPoint(0, 0, bounds[5]);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(colorIt.GetOutputPort());

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetPointSize(2f);

            renWin.RemoveRenderer(render);
            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            render.ResetCamera();
            renWin.AddRenderer(render);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }

        private void VtkSurfaceReconstructionFilter_Click(object sender, RoutedEventArgs e)
        {
            vtkPoints points = vtkPoints.New();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    double x = 0.1 * i;
                    double y = 0.1 * j;
                    points.InsertNextPoint(i, j, Math.Exp((x - 1) * (x - 1) + (y - 1) * (y - 1)));
                }
            }

            vtkPolyData polyData = vtkPolyData.New();
            polyData.SetPoints(points);


            vtkXMLPolyDataReader reader = vtkXMLPolyDataReader.New();
            reader.SetFileName(@"Files\laser.vtp");
            reader.Update();

            // 下采样
            vtkPoissonDiskSampler poisson = vtkPoissonDiskSampler.New();
            poisson.SetInputData(reader.GetOutput());
            // 设置最小点间距，值越大点越少
            poisson.SetRadius(0.3);
            poisson.Update();

            // 曲面重建
            vtkSurfaceReconstructionFilter surf = vtkSurfaceReconstructionFilter.New();
            surf.SetInputData(poisson.GetOutput());
            surf.Update();
            vtkContourFilter cf = vtkContourFilter.New();
            cf.SetInputConnection(surf.GetOutputPort());
            cf.SetValue(0, 0.0);
            cf.Update();
            vtkReverseSense reverse = vtkReverseSense.New();
            reverse.SetInputConnection(cf.GetOutputPort());
            reverse.ReverseCellsOn();
            reverse.ReverseNormalsOn();
            reverse.Update();

            var bounds = poisson.GetOutput().GetBounds();

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputData(reverse.GetOutput());
            colorIt.SetLowPoint(0, 0, bounds[4]);
            colorIt.SetHighPoint(0, 0, bounds[5]);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(colorIt.GetOutputPort());

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetPointSize(2f);

            renWin.RemoveRenderer(render);
            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            render.ResetCamera();
            renWin.AddRenderer(render);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }

        private void VtkSmoothPolyDataFilter_Click(object sender, RoutedEventArgs e)
        {
            vtkMinimalStandardRandomSequence rand = vtkMinimalStandardRandomSequence.New();
            rand.SetSeed(8775070);
            vtkPoints points = vtkPoints.New();
            for (int i = -20; i < 20; i++)
            {
                for (int j = -20; j < 20; j++)
                {
                    double z = rand.GetRangeValue(-1, 1) + 0.05 * i * i + 0.05 * j * j;
                    rand.Next();
                    points.InsertNextPoint(i, j, z);
                }
            }

            vtkPolyData polyData = vtkPolyData.New();
            polyData.SetPoints(points);

            vtkXMLPolyDataReader reader = vtkXMLPolyDataReader.New();
            reader.SetFileName(@"Files\laser.vtp");
            reader.Update();

            // 下采样
            vtkPoissonDiskSampler poisson = vtkPoissonDiskSampler.New();
            poisson.SetInputData(reader.GetOutput());
            // 设置最小点间距，值越大点越少
            poisson.SetRadius(0.3);
            poisson.Update();

            // 表面重建 三角剖分
            vtkDelaunay2D delaunay = vtkDelaunay2D.New();
            delaunay.SetInputData(poisson.GetOutput());
            delaunay.Update();

            vtkSmoothPolyDataFilter smooth = vtkSmoothPolyDataFilter.New();
            smooth.SetInputData(delaunay.GetOutput());
            smooth.SetNumberOfIterations(15);
            smooth.SetRelaxationFactor(0.1);
            smooth.FeatureEdgeSmoothingOff();
            smooth.BoundarySmoothingOn();
            smooth.Update();

            var bounds = smooth.GetOutput().GetBounds();

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputData(smooth.GetOutput());
            colorIt.SetLowPoint(0, 0, bounds[4]);
            colorIt.SetHighPoint(0, 0, bounds[5]);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(colorIt.GetOutputPort());

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetPointSize(2f);

            renWin.RemoveRenderer(render);
            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            render.ResetCamera();
            renWin.AddRenderer(render);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }

        private void VtkExtractSurface_Click(object sender, RoutedEventArgs e)
        {
            vtkMinimalStandardRandomSequence rand = vtkMinimalStandardRandomSequence.New();
            rand.SetSeed(8775070);
            vtkPoints points = vtkPoints.New();
            for (int i = -20; i < 20; i++)
            {
                for (int j = -20; j < 20; j++)
                {
                    double z = rand.GetRangeValue(-1, 1) + 0.05 * i * i + 0.05 * j * j;
                    rand.Next();
                    points.InsertNextPoint(i, j, z);
                }
            }

            vtkPolyData polyData = vtkPolyData.New();
            polyData.SetPoints(points);

            vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
            glyphFilter.SetInputData(polyData);
            glyphFilter.Update();

            vtkPCANormalEstimation normals = vtkPCANormalEstimation.New();
            normals.SetInputData(glyphFilter.GetOutput());
            normals.SetFlipNormals(true);
            normals.SetNormalOrientationToGraphTraversal();
            normals.Update();

            var bounds = glyphFilter.GetOutput().GetBounds();
            vtkSignedDistance distance = vtkSignedDistance.New();
            distance.SetInputData(normals.GetOutput());
            distance.SetBounds(bounds[0], bounds[1], bounds[2], bounds[3], bounds[4], bounds[5]);
            distance.SetRadius(5);
            distance.SetDimensions(20, 20, 20);
            distance.Update();

            vtkExtractSurface surface = vtkExtractSurface.New();
            surface.SetInputData(distance.GetOutput());
            surface.SetRadius(distance.GetRadius());
            surface.Update();

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputData(surface.GetOutput());
            colorIt.SetLowPoint(0, 0, bounds[4]);
            colorIt.SetHighPoint(0, 0, bounds[5]);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(colorIt.GetOutputPort());

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetPointSize(2f);

            renWin.RemoveRenderer(render);
            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            render.ResetCamera();
            renWin.AddRenderer(render);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }

        private void VtkImageData_Click(object sender, RoutedEventArgs e)
        {
            vtkXMLPolyDataReader reader = vtkXMLPolyDataReader.New();
            reader.SetFileName(@"Files\laser.vtp");
            reader.Update();

            vtkPolyData polyData = reader.GetOutput();
            int w = 3240;
            int h = 3200;
            vtkImageData imageData = vtkImageData.New();
            double[] bounds = polyData.GetBounds();
            double z = bounds[5] - bounds[4];
            double y = bounds[3] - bounds[2];
            double x = bounds[1] - bounds[0];
            imageData.SetDimensions(w, h, 1);
            // 最后显示的图像xyz方向比例要合适
            imageData.SetSpacing(x, y, 1);
            imageData.AllocateScalars(11, 1);
            vtkDataArray scalars = imageData.GetPointData().GetScalars();
            // 这个参数也很重要，可以表征高度，值越大越高，可以认为xy方向步长为1
            double scale = 2000;
            int index = 0;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var values = polyData.GetPoint(index);
                    scalars.SetTuple1(index, scale * values[2]);
                    index++;
                }
            }

            // 下采样，数据量大了不行
            vtkImageShrink3D shrink3D = vtkImageShrink3D.New();
            shrink3D.SetInputData(imageData);
            shrink3D.SetShrinkFactors(10, 10, 1);
            shrink3D.Update();

            vtkGreedyTerrainDecimation decimation = vtkGreedyTerrainDecimation.New();
            decimation.SetInputData(shrink3D.GetOutput());
            decimation.Update();

            vtkElevationFilter colorIt = vtkElevationFilter.New();
            colorIt.SetInputData(decimation.GetOutput());
            colorIt.SetLowPoint(0, 0, scale * bounds[4]);
            colorIt.SetHighPoint(0, 0, scale * bounds[5]);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(colorIt.GetOutputPort());
            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetInterpolationToFlat();
            renWin.RemoveRenderer(render);
            render = vtkRenderer.New();
            render.AddActor(actor);
            render.SetBackground(0.1, 0.2, 0.4);
            render.ResetCamera();
            renWin.AddRenderer(render);
            renWin.Render();

            // 相机
            camera = render.GetActiveCamera();
        }
    }
}