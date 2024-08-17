using System.IO;
using System.Net.Sockets;

namespace McProtocolDemo.McProtocol
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/11 2:12:53
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/11 2:12:53                     BigWang         首次编写         
	///
    public class McProtocolTcp : McProtocolApp
    {
        public McProtocolTcp() : this("", 0)
        {

        }

        public McProtocolTcp(string iHostName, int iPortNumber) : base(iHostName, iPortNumber)
        {
            Client = new TcpClient();
        }

        override protected void DoConnect()
        {
            TcpClient c = Client;
            if (!c.Connected)
            {
                // Keep Alive
                var ka = new List<byte>(sizeof(uint) * 3);
                ka.AddRange(BitConverter.GetBytes(1u));
                ka.AddRange(BitConverter.GetBytes(45000u));
                ka.AddRange(BitConverter.GetBytes(5000u));
                c.Client.IOControl(IOControlCode.KeepAliveValues, ka.ToArray(), null);
                c.Connect(HostName, PortNumber);
                Stream = c.GetStream();
            }
        }

        override protected void DoDisconnect()
        {
            TcpClient c = Client;
            if (c.Connected)
            {
                c.Close();
            }
        }

        override protected byte[] Execute(byte[] iCommand)
        {
            NetworkStream ns = Stream;
            ns.Write(iCommand, 0, iCommand.Length);
            ns.Flush();

            using (var ms = new MemoryStream())
            {
                var buff = new byte[256];
                do
                {
                    int sz = ns.Read(buff, 0, buff.Length);
                    if (sz == 0)
                    {
                        throw new Exception("连接已断开");
                    }
                    ms.Write(buff, 0, sz);
                } while (ns.DataAvailable);
                return ms.ToArray();
            }
        }

        private TcpClient Client { get; set; }

        private NetworkStream Stream { get; set; }
    }
}