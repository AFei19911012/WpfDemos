using System.Drawing.Drawing2D;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace WpfPlot3DDemo.Plot3D
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/23 0:41:52
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/23 0:41:52                     BigWang         首次编写         
	///
    public class Surface3DRenderer
    {
        private double Sf { get; set; }
        private double Cf { get; set; }
        private double St { get; set; }
        private double Ct { get; set; }
        private double R { get; set; }
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
        private double D { get; set; }


        public double ScreenWidth { get; set; } = 0;
        public double ScreenHeight { get; set; } = 0;
        public double ObsX { get; set; } = 60;
        public double ObsY { get; set; } = 45;
        public double ObsZ { get; set; } = 30;
        public double X0s { get; set; } = 0;
        public double Y0s { get; set; } = 0;

        public double ScreenDistance { get; set; } = 1;
        public double Density { get; set; } = 0.5;
        public Color PenColor { get; set; } = Color.Black;
        public PointF StartPoint { get; set; } = new PointF(0, 0);
        public PointF EndPoint { get; set; } = new PointF(10, 10);
        public ColorSchema ColorSchema { get; set; } = ColorSchema.Hsv;


        public delegate double RendererFunction(double x, double y);
        public RendererFunction Function;

       

        public Surface3DRenderer(double screenWidth, double screenHeight)
        {
            if (screenWidth * screenHeight == 0)
            {
                return;
            }
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            CalTransformationsCoeficients();
        }

        private PointF CalCoordinate(double x, double y, double z)
        {
            double xn = -Sf * x + Cf * y;
            double yn = -Cf * Ct * x - Sf * Ct * y + St * z;
            double zn = -Cf * St * x - Sf * St * y - Ct * z + R;
            if (zn == 0)
            {
                zn = 0.01;
            }
            // Tales' theorem
            return new PointF((float)(A * xn * ScreenDistance / zn + B), (float)(C * yn * ScreenDistance / zn + D));
        }

        public void CalTransformationsCoeficients()
        {
            if (ScreenWidth * ScreenHeight == 0)
            {
                return;
            }
            double screenWidth = ScreenWidth;
            double screenHeight = ScreenHeight;
            double obsX = ObsX;
            double obsY = ObsY;
            double obsZ = ObsZ;
            double xs0 = X0s;
            double ys0 = Y0s;
            double r1;
            double a;

            // 0.0257 m = 1 inch. Screen has 96 px/inch
            var screenWidthPhys = screenWidth * 0.0257 / 96;
            var screenHeightPhys = screenHeight * 0.0257 / 96;

            r1 = obsX * obsX + obsY * obsY;
            // distance in XY plane
            a = Math.Sqrt(r1);
            // distance from observator to center
            R = Math.Sqrt(r1 + obsZ * obsZ);
            // rotation matrix coeficients calculation
            if (a != 0)
            {
                // sin(fi)
                Sf = obsY / a;
                // cos(fi)
                Cf = obsX / a;
            }
            else
            {
                Sf = 0;
                Cf = 1;
            }
            // sin(teta)
            St = a / R;
            // cos(teta)
            Ct = obsZ / R;

            // linear tranfrormation coeficients
            A = screenWidth / screenWidthPhys;
            B = xs0 + A * screenWidthPhys / 2.0;
            C = -(double)screenHeight / screenHeightPhys;
            D = ys0 - C * screenHeightPhys / 2.0;
        }

        public void RenderSurface(Graphics graphics)
        {
            if (Function == null)
            {
                return;
            }
            SolidBrush[] brushes = new SolidBrush[ColorSchema.Length];
            for (int i = 0; i < brushes.Length; i++)
            {
                brushes[i] = new SolidBrush(ColorSchema[i]);
            }

            double z1;
            double z2;
            PointF[] polygon = new PointF[4];
            double xi = StartPoint.X;
            double yi;
            double minZ = double.PositiveInfinity;
            double maxZ = double.NegativeInfinity;
            double[,] mesh = new double[(int)((EndPoint.X - StartPoint.X) / Density + 1), (int)((EndPoint.Y - StartPoint.Y) / Density + 1)];
            PointF[,] meshF = new PointF[mesh.GetLength(0), mesh.GetLength(1)];
            for (int x = 0; x < mesh.GetLength(0); x++)
            {
                yi = StartPoint.Y;
                for (int y = 0; y < mesh.GetLength(1); y++)
                {
                    double zz = Function(xi, yi);
                    mesh[x, y] = zz;
                    meshF[x, y] = CalCoordinate(xi, yi, zz);
                    yi += Density;

                    if (minZ > zz)
                    {
                        minZ = zz;
                    }
                    if (maxZ < zz)
                    {
                        maxZ = zz;
                    }
                }
                xi += Density;
            }

            double cc = (maxZ - minZ) / (brushes.Length - 1.0);

            using (Pen pen = new(PenColor))
            {
                for (int x = 0; x < mesh.GetLength(0) - 1; x++)
                {
                    for (int y = 0; y < mesh.GetLength(1) - 1; y++)
                    {
                        z1 = mesh[x, y];
                        z2 = mesh[x, y + 1];

                        polygon[0] = meshF[x, y];
                        polygon[1] = meshF[x, y + 1];
                        polygon[2] = meshF[x + 1, y + 1];
                        polygon[3] = meshF[x + 1, y];

                        // 细节
                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.FillPolygon(brushes[(int)(((z1 + z2) / 2.0 - minZ) / cc)], polygon);
                        // 网格线
                        if (!PenColor.Equals(Color.Transparent))
                        {
                            graphics.SmoothingMode = SmoothingMode.AntiAlias;
                            graphics.DrawPolygon(pen, polygon);
                        }
                    }
                }
            }

            for (int i = 0; i < brushes.Length; i++)
            {
                brushes[i].Dispose();
            }
        }
    }
}