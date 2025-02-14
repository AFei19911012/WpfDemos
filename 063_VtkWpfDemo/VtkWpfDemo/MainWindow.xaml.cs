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
        private vtkScalarBarActor colorbar;
        private vtkCamera camera;

        private int[] InitClickPos { get; set; }
        private bool CanMove { get; set; }
        private double[] CurWinCenter { get; set; }


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
            interactor.MiddleButtonPressEvt += new vtkObject.vtkObjectEventHandler(OnMiddleButtonPressEvt);
            interactor.MouseMoveEvt += new vtkObject.vtkObjectEventHandler(OnMouseMoveEvt);

            style = vtkInteractorStyleTrackballCamera.New();
            //style.MouseWheelBackwardEvt += new vtkObject.vtkObjectEventHandler(OnMouseWheelBackwardEvt);
            //style.MouseWheelForwardEvt += new vtkObject.vtkObjectEventHandler(OnMouseWheelForwardEvt);
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

        private void OnMiddleButtonPressEvt(vtkObject sender, vtkObjectEventArgs e)
        {
            camera?.SetPosition(0, 0, 0);
            camera?.SetFocalPoint(0, 0, -1);
            camera?.SetViewUp(0, 1, 0);
            camera?.SetWindowCenter(0, 0);
            render?.ResetCamera();
            renWin?.Render();
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

        private vtkRenderer ShowPointCloud(vtkPoints points)
        {
            vtkPolyData polydata = vtkPolyData.New();
            polydata.SetPoints(points);

            //vtkVertexGlyphFilter glyph = vtkVertexGlyphFilter.New();
            //glyph.SetInputData(polydata);
            //glyph.Update();

            // 下采样
            vtkVoxelGrid voxel = vtkVoxelGrid.New();
            voxel.SetConfigurationStyleToManual();
            voxel.SetDivisions(200, 200, 1);
            voxel.SetInputData(polydata);
            voxel.Update();

            // 三角网格(点数少适用，W/S切换显示)
            vtkDelaunay2D delaunay = vtkDelaunay2D.New();
            delaunay.SetInputData(voxel.GetOutput());
            delaunay.Update();

            double[] minmax = points.GetBounds();
            vtkLookupTable lut = CreateLookupTable(minmax[4], minmax[5]);
            vtkUnsignedCharArray colormap = CreateColormap(voxel.GetOutput().GetPoints(), lut);
            voxel.GetOutput().GetPointData().SetScalars(colormap);

            vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
            glyphFilter.SetInputData(voxel.GetOutput());
            glyphFilter.Update();

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetLookupTable(lut);

            // 图片纹理
            if (texture != null)
            {
                mapper.ScalarVisibilityOff();
                vtkTextureMapToPlane texturemap = vtkTextureMapToPlane.New();
                texturemap.SetInputConnection(delaunay.GetOutputPort());
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
            //vtkTransform trans = vtkTransform.New();
            //trans.RotateZ(-90);
            //trans.RotateY(180);
            //actor.SetUserTransform(trans);

            vtkRenderer out_render = vtkRenderer.New();
            out_render.AddActor(actor);
            if (texture == null)
            {
                colorbar = CreateColorbar(lut);
                out_render.AddActor(colorbar);
            }
            
            out_render.SetBackground(0.1, 0.2, 0.4);

            return out_render;
        }

        private vtkRenderer ShowImageData(Data3DModel model)
        {
            int w = model.Width;
            int h = model.Height;
            vtkImageData imageData = vtkImageData.New();
            double[] minmax = model.Points.GetBounds();
            double z = minmax[5] - minmax[4];
            double y = minmax[3] - minmax[2];
            double x = minmax[1] - minmax[0];
            imageData.SetDimensions(w, h, 1);
            imageData.SetSpacing(x / z, y / z, 1);
            imageData.AllocateScalars(11, 1);
            vtkDataArray scalars = imageData.GetPointData().GetScalars();
            double scale = Math.Sqrt(w / x * w / x + h / y * h / y);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    int index = i * h + j;
                    var values = model.Points.GetPoint(index);
                    scalars.SetTuple1(index, scale * values[2]);
                }
            }

            // 降采样，数据量大了不行
            vtkImageShrink3D shrink3D = vtkImageShrink3D.New();
            shrink3D.SetInputData(imageData);
            shrink3D.SetShrinkFactors(4, 4, 1);
            shrink3D.Update();

            vtkGreedyTerrainDecimation decimation = vtkGreedyTerrainDecimation.New();
            decimation.SetInputData(shrink3D.GetOutput());
            decimation.Update();

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputData(decimation.GetOutput());
            mapper.SetScalarRange(scale * model.MinZ, scale * model.MaxZ);
            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetInterpolationToFlat();
            //actor.GetProperty().EdgeVisibilityOn();
            //actor.GetProperty().SetEdgeColor(1, 0, 0);

            vtkLookupTable lut = CreateLookupTable(minmax[4], minmax[5]);

            vtkRenderer out_render = vtkRenderer.New();
            out_render.AddActor(actor);
            out_render.AddActor(CreateColorbar(lut));
            out_render.SetViewport(0, 0, 1.0, 1.0);
            out_render.GradientBackgroundOn();
            out_render.SetBackground(0.1, 0.2, 0.3);
            out_render.SetBackground2(0.8, 0.8, 0.8);
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
                renWin.RemoveRenderer(render);
                render = ShowPointCloud(model.Points);
                renWin.AddRenderer(render);
                renWin.Render();

                // 相机
                camera = render.GetActiveCamera();
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

                actor = vtkActor.New();
                actor.SetMapper(mapper);
                actor.SetTexture(texture);

                renWin.RemoveRenderer(render);
                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.2, 0.3, 0.3);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();
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

                // 下采样
                vtkShrinkPolyData shrink = vtkShrinkPolyData.New();
                shrink.SetInputConnection(stl.GetOutputPort());
                shrink.SetShrinkFactor(0.7);

                vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
                mapper.SetInputConnection(shrink.GetOutputPort());

                vtkActor actor = vtkActor.New();
                actor.SetMapper(mapper);

                renWin.RemoveRenderer(render);
                render = vtkRenderer.New();
                render.AddActor(actor);
                render.SetBackground(0.1, 0.2, 0.4);
                render.ResetCamera();
                renWin.AddRenderer(render);
                renWin.Render();
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

                // 下采样
                vtkDecimatePro decimate = vtkDecimatePro.New();
                decimate.SetInputData(stl.GetOutput());
                decimate.SetTargetReduction(0.5);
                decimate.Update();

                vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                glyphFilter.SetInputData(decimate.GetOutput());
                glyphFilter.Update();

                var bounds = stl.GetOutput().GetBounds();

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

                // 下采样
                vtkCleanPolyData clean = vtkCleanPolyData.New();
                clean.SetInputData(stl.GetOutput());
                clean.SetTolerance(0.01);
                clean.Update();

                vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                glyphFilter.SetInputData(clean.GetOutput());
                glyphFilter.Update();

                var bounds = stl.GetOutput().GetBounds();

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
            }
        }

        private void VtkVoxelGrid_Click(object sender, RoutedEventArgs e)
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

                var count = stl.GetOutput().GetNumberOfPoints();

                // 下采样
                vtkVoxelGrid voxel = vtkVoxelGrid.New();
                voxel.SetConfigurationStyleToManual();
                voxel.SetDivisions(40, 40, 1);
                voxel.SetInputData(stl.GetOutput());
                // 以下两种是其他模式
                //voxel.SetLeafSize(0.01, 0.01, 0.01);
                //voxel.SetNumberOfPointsPerBin(1);
                voxel.Update();

                vtkVertexGlyphFilter glyphFilter = vtkVertexGlyphFilter.New();
                glyphFilter.SetInputData(voxel.GetOutput());
                glyphFilter.Update();

                var bounds = stl.GetOutput().GetBounds();

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
            }
        }

        private void VtkSurfaceReconstructionFilter_Click(object sender, RoutedEventArgs e)
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

                var count = stl.GetOutput().GetNumberOfPoints();

                // 曲面重建
                vtkSurfaceReconstructionFilter surf = vtkSurfaceReconstructionFilter.New();
                surf.SetInputData(stl.GetOutput());
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

                var bounds = stl.GetOutput().GetBounds();

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
            }
        }
    }
}