namespace Editor3D
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2024/8/24 23:17:25
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/8/24 23:17:25                     BigWang         首次编写         
    ///

    /// <summary>
    /// These flags define which axes are allowed to be mirrored.
    /// For user objects option "All" is used.
    /// Coordinate system axes and raster lines are mirrored individually.
    /// </summary>
    public enum EnumMirror
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 4,
        XY = X | Y,
        XZ = X | Z,
        YZ = Y | Z,
        All = X | Y | Z,
    }
}