namespace Editor3D
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2024/8/24 23:18:41
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/8/24 23:18:41                     BigWang         首次编写         
    ///

    /// <summary>
    /// Mouse operations
    /// </summary>
    public enum EnumMouseAction
    {
        None = 0,
        Move,        // Move             the coordinate system with the mouse
        Theta,       // Elevate          the coordinate system with the mouse
        Phi,         // Rotate           the coordinate system with the mouse
        ThetaAndPhi, // Elevate + Rotate the coordinate system with the mouse
        Rho,         // Zoom in / out
        SelectObj,   // Select a 3D object or call the selection callback function if defined
        Callback,    // Call the selection callback function if defined
    }
}