using System.Net.NetworkInformation;

namespace OmronFinsTcp
{
    partial class BasicClass
    {
        //检查PLC链接状况
        internal static bool PingCheck(string ip, int timeOut)
        {
            Ping ping = new Ping();
            PingReply pr = ping.Send(ip, timeOut);
            if (pr.Status == IPStatus.Success)
                return true;
            else
                return false;
        }
    }
}
