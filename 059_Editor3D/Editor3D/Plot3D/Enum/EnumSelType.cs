namespace Editor3D
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2024/8/24 23:21:42
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/8/24 23:21:42                     BigWang         首次编写         
    ///

    /// <summary>
    /// These flags are used to filter the 3D objects that are selected.
    /// </summary>
    public enum EnumSelType
    {
        Line = 0x1,
        Shape = 0x2,
        Polygon = 0x4,
        All = 0x7,
    }
}