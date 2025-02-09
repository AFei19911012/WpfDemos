namespace Editor3D
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/24 23:22:13
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/24 23:22:13                     BigWang         首次编写         
	///
    public enum EnumTooltip
    {
        Off = 0x0, // Tooltip is disabled
        UserText = 0x1, // Show user defined tooltip text that has been set in CPoint3D.Tooltip
        Coord = 0x2, // Show coordinates X,Y,Z of CPoint3D
        All = 0x3, // Show all
    }
}