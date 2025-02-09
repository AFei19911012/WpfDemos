namespace Editor3D
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2024/8/24 23:24:43
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/8/24 23:24:43                     BigWang         首次编写         
    ///

    /// <summary>
    /// These are the possible return values of the Selection callback. 
    /// See description of SelectionCallback() at the end of this class.
    /// </summary>
    public enum EnumInvalidate
    {
        NoChange,    // The callback has not modified anything --> do nothing.
        Invalidate,  // Calls Invalidate() to redraw what is required depending on the flags in me_Recalculate.
        CoordSystem, // The coordinate system will be recalculated, then Invalidate() is called.
                     // Use this option after moving a 3D object with the mouse.
    }
}