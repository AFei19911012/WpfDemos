using Kitware.VTK;

namespace VtkWpfDemo
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2025 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2025/2/9 16:09:15
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2025/2/9 16:09:15                     BigWang         首次编写         
    ///
    public class Data3DModel
    {
        public vtkPoints Points { get; set; } = new vtkPoints();

        public int Width { get; set; }
        public int Height { get; set; }
        public double MinZ { get; set; }
        public double MaxZ { get; set; }
    }
}