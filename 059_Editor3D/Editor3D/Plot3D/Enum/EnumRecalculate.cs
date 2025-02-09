namespace Editor3D
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2024/8/24 23:22:46
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/8/24 23:22:46                     BigWang         首次编写         
    ///

    // This enum is to get the maximum speed out of your CPU.
    // Re-calculation is done only if required.
    public enum EnumRecalculate
    {
        Nothing = 0x0, // repaint objects after changed selection      --> recalculate nothing
        Objects = 0x1, // Projection, Brush, LineWidth,... has changed --> recalculate 3D objects
        CoordSystem = 0x2, // The coordinate system must be recalculated   --> recalculate Min/Max and Coord System
        AddRemove = 0x4, // Draw Objects have been added or removed      --> refresh lists and recalculate all
    }
}