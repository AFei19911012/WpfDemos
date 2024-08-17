namespace McProtocolDemo.McProtocol
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/11 2:11:44
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/11 2:11:44                     BigWang         首次编写         
	///
    /// <summary>
    /// PLC 连接通用接口
    /// </summary>
    public interface IPlc : IDisposable
    {
        int Open();
        int Close();
        int SetBitDevice(string iDeviceName, int iSize, int[] iData);
        int SetBitDevice(PlcDeviceType iType, int iAddress, int iSize, int[] iData);
        int GetBitDevice(string iDeviceName, int iSize, int[] oData);
        int GetBitDevice(PlcDeviceType iType, int iAddress, int iSize, int[] oData);
        int WriteDeviceBlock(string iDeviceName, int iSize, int[] iData);
        int WriteDeviceBlock(PlcDeviceType iType, int iAddress, int iSize, int[] iData);
        int ReadDeviceBlock(string iDeviceName, int iSize, int[] oData);
        int ReadDeviceBlock(PlcDeviceType iType, int iAddress, int iSize, int[] oData);
        int SetDevice(string iDeviceName, int iData);
        int SetDevice(PlcDeviceType iType, int iAddress, int iData);
        int GetDevice(string iDeviceName, out int oData);
        int GetDevice(PlcDeviceType iType, int iAddress, out int oData);
    }
}