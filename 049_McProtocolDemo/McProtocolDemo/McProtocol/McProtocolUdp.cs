using System.IO;
using System.Net;
using System.Net.Sockets;

namespace McProtocolDemo.McProtocol
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/11 2:13:25
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/11 2:13:25                     BigWang         首次编写         
	///
    public class McProtocolUdp : McProtocolApp
    {
        public McProtocolUdp(int iPortNumber) : this("", iPortNumber)
        {

        }
        public McProtocolUdp(string iHostName, int iPortNumber) : base(iHostName, iPortNumber)
        {
            Client = new UdpClient(iPortNumber);
        }

        override protected void DoConnect()
        {
            UdpClient c = Client;
            c.Connect(HostName, PortNumber);
        }

        override protected void DoDisconnect()
        {
            // UDP不做处理
        }

        override protected byte[] Execute(byte[] iCommand)
        {
            UdpClient c = Client;
            // 送信
            c.Send(iCommand, iCommand.Length);

            using (var ms = new MemoryStream())
            {
                IPAddress ip = IPAddress.Parse(HostName);
                var ep = new IPEndPoint(ip, PortNumber);
                do
                {
                    // 受信
                    byte[] buff = c.Receive(ref ep);
                    ms.Write(buff, 0, buff.Length);
                } while (0 < c.Available);
                return ms.ToArray();
            }
        }

        private UdpClient Client { get; set; }
    }
}