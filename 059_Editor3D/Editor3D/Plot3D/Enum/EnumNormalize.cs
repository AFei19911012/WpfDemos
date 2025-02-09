namespace Editor3D
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2024/8/24 23:09:36
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/8/24 23:09:36                     BigWang         首次编写         
    ///

    /// <summary>
    /// If a function has an asymetric range for X and Y as demo "Callback" a separate normalization 
    /// would always lead to a square X,Y pane which would be a distortion for the relation between X and Y values.
    /// MaintainXY  guarantees that the relation between X and Y values is maintained.
    /// MaintainXYZ additionally guarantees that the relation between X, Y and Z values is maintained.
    /// </summary>
    public enum EnumNormalize
    {
        Separate,    // Normalize X,Y,Z separately (use this for discrete values)
        MaintainXY,  // Normalize X,Y   without changing their relation (use this for math functions)
        MaintainXYZ, // Normalize X,Y,Z without changing their relation (use this for math functions)
    }
}