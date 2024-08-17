using System.IO;
using System.Net.Sockets;

namespace McProtocol.Async
{
    public class McProtocolTcp : McProtocolApp
    {
        private TcpClient Client { get; set; }
        private NetworkStream Stream { get; set; }

        // コンストラクタ
        public override bool Connected
        {
            get
            {
                return Client.Connected;
            }
        }

        public McProtocolTcp() : this("127.0.0.1", 6000, McFrame.MC3E)
        {

        }

        public McProtocolTcp(string iHostName, int iPortNumber, McFrame frame) : base(iHostName, iPortNumber, frame)
        {
            CommandFrame = frame;
            Client = new TcpClient();
        }

        async override protected Task<int> DoConnect()
        {
            if (!Client.Connected)
            {
                // Keep Alive
                var ka = new List<byte>(sizeof(uint) * 3);
                ka.AddRange(BitConverter.GetBytes(1u));
                ka.AddRange(BitConverter.GetBytes(45000u));
                ka.AddRange(BitConverter.GetBytes(5000u));
                Client.Client.IOControl(IOControlCode.KeepAliveValues, ka.ToArray(), null);
                Client.Connect(HostName, PortNumber);
                Stream = Client.GetStream();
            }
            return 0;
        }

        override protected void DoDisconnect()
        {
            TcpClient c = Client;
            if (c.Connected)
            {
                c.Close();
            }
        }

        private readonly object balanceLock = new object();
        async override protected Task<byte[]> Execute(byte[] iCommand)
        {
            lock (balanceLock)
            {
                List<byte> list = new List<byte>();

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
                    }
                    while (ns.DataAvailable);

                    return ms.ToArray();
                }
            }
        }
    }
}
