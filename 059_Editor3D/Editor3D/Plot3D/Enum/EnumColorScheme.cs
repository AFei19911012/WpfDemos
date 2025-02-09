namespace Editor3D
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/24 23:08:09
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/24 23:08:09                     BigWang         首次编写         
	///
    public enum EnumColorScheme
    {
        Autumn = 0,
        Cool,
        Copper,
        Hot,
        Hsv,
        Monochrome,
        Pink,
        Rainbow_Sweep,  // This creates a 100% cyclic rainbow with 1536 colors. The end color is the same as the start color.
        Rainbow_Bright, // This creates a rainbow without magenta with 1024 colors. It goes from blue to red.
        Rainbow_Dark,   // This is similar to RainbowBright, but darker and only with 64 colors.
        Spring,
        Summer,
        Winter,
    }
}