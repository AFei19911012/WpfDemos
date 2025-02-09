namespace Editor3D
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/24 23:19:44
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/24 23:19:44                     BigWang         首次编写         
	///
    public enum EnumSelEvent
    {
        MouseDown, // Inform selection callback function that the pre-defined mouse button goes down
        MouseDrag, // Inform selection callback function that the mouse is moved while the pre-defined mouse button is down
        MouseUp,   // Inform selection callback function that the pre-defined mouse button goes up
    }
}