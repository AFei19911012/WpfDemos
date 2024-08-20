using NewLife;
using NewLife.Data;
using NewLife.Log;
using NewLife.Net;
using NewLife.Net.Handlers;
using System.IO;
using System.Text;
using System.Windows;

namespace TransferFileTcpDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string SrcFile { get; set; } = @"client\test.xaml";
        private string DstFolder { get; set; } = @"server";

        private NetServer Server { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // 彻底关闭日志
            XTrace.Log = Logger.Null;
        }

        private void OnStart(object sender, RoutedEventArgs e)
        {
            

            Server = new NetServer
            {
                Log = XTrace.Log,
                SessionLog = XTrace.Log,
                SocketLog = XTrace.Log,
                Port = 123,
                ProtocolType = NetType.Tcp
            };

            Server.Received += Server_Received;
            // 解决粘包，引入 StandardCodec
            Server.Add<StandardCodec>();
            Server.Start();
        }

        private async void Server_Received(object? sender, ReceivedEventArgs e)
        {
            //接收文件
            var session = sender as NetSession;
            if (e.Message is not Packet pk)
            {
                return;
            }

            // 文件状态 1 字节
            var fileState = int.Parse(Encoding.UTF8.GetString(pk.ReadBytes(0, 1)));
            // 文件总长度 10 字节
            var headinfo = int.Parse(Encoding.UTF8.GetString(pk.ReadBytes(1, 10)));
            // 文件名长度 8 字节
            var fileNameLength = int.Parse(Encoding.UTF8.GetString(pk.ReadBytes(11, 8)));
            // 文件名
            var fileName = Encoding.UTF8.GetString(pk.ReadBytes(19, fileNameLength));
            // 位置偏移量 10 字节
            var offset = int.Parse(Encoding.UTF8.GetString(pk.ReadBytes(19 + fileNameLength, 10)));
            // 数据内容
            var data = pk.ReadBytes(29 + fileNameLength, pk.Count - (29 + fileNameLength));
            if (data.Length == 0)
            {
                return;
            }

            await Task.Run(async () =>
            {
                var writeData = data;
                // 数据写入文件
                using var filestream = new FileStream($"{DstFolder}\\{fileName}", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                filestream.Seek(offset, SeekOrigin.Begin);
                await filestream.WriteAsync(writeData);
                await filestream.FlushAsync();
            });
        }

        private void OnSend(object sender, RoutedEventArgs e)
        {
            Task.Run(async () =>
            {
                await Task.Delay(10000);
                var TcpClient = new NetUri($"tcp://127.0.0.1:123");
                var Netclient = TcpClient.CreateRemote();
                Netclient.Log = XTrace.Log;
                Netclient.LogSend = false;
                Netclient.LogReceive = false;
                Netclient.Add<StandardCodec>();
                Netclient.Received += (s, ee) =>
                {
                    if (ee.Message is not Packet pk1)
                    {
                        return;
                    }
                    XTrace.WriteLine("收到服务器：{0}", pk1.ToStr());
                };
                if (!File.Exists(SrcFile))
                {
                    return;
                }

                byte[] data;
                using (var streamReader = new FileStream(SrcFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    if (streamReader.CanRead)
                    {
                        data = new byte[streamReader.Length];
                        await streamReader.ReadAsync(data.AsMemory(0, (int)streamReader.Length));
                    }
                    else
                    {
                        XTrace.Log.Error($"{SrcFile}不可访问");
                        return;
                    }
                }

                // 新文件发送
                var fileState = Encoding.UTF8.GetBytes("0");
                // 总长度
                var headinfo = new byte[10];
                headinfo = Encoding.UTF8.GetBytes(data.Length.ToString());
                // 文件名长度
                var filename = Path.GetFileName(SrcFile);
                var fileNameLength = new byte[8];
                fileNameLength = Encoding.UTF8.GetBytes(Encoding.UTF8.GetBytes(filename).Length.ToString());
                // 文件名
                var fileNameByte = new byte[filename.Length];
                fileNameByte = Encoding.UTF8.GetBytes(filename);
                // 偏移量
                var offset = 0;
                // 单次发送大小
                var sendLength = 4096 * 100;
                Netclient.Open();
                while (data.Length > offset)
                {
                    if (offset > 0)
                    {
                        fileState = Encoding.UTF8.GetBytes("1");//追加文件
                    }
                    if (sendLength > data.Length - offset)
                    {
                        sendLength = data.Length - offset;
                        fileState = Encoding.UTF8.GetBytes("2");//最后一次发送
                    }
                    var offsetByte = new byte[10];//偏移位置byte
                    offsetByte = Encoding.UTF8.GetBytes(offset.ToString());
                    // 一次发送总 byte
                    var sendData = new byte[1 + 10 + 8 + fileNameByte.Length + 10 + sendLength];
                    // 文件状态 0 第一次 1 追加文件 2 最后一次发送
                    Array.Copy(fileState, 0, sendData, 0, fileState.Length);
                    // 文件总长度
                    Array.Copy(headinfo, 0, sendData, 1, headinfo.Length);
                    // 文件名长度
                    Array.Copy(fileNameLength, 0, sendData, 11, fileNameLength.Length);
                    // 文件名信息
                    Array.Copy(fileNameByte, 0, sendData, 19, fileNameByte.Length);
                    // 此次内容偏移量
                    Array.Copy(offsetByte, 0, sendData, 19 + fileNameByte.Length, offsetByte.Length);
                    // 一次发送的内容 offsetByte 为 10 byte
                    Array.Copy(data, offset, sendData, 29 + fileNameByte.Length, sendLength);
                    offset += sendLength;
                    var pk = new Packet(sendData);
                    Netclient.SendMessage(pk);
                }
                Netclient.Close("发送完成，关闭连接。");
            });
        }
    }
}