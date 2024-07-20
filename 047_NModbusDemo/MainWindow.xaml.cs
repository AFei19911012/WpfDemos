using NModbus.Device;
using System.Windows;

namespace NModbusDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ModbusTcpClient client;
        private ModbusTcpServer server;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintLog(string info)
        {
            Dispatcher.BeginInvoke(() =>
            {
                lb.Items.Add(info);
            });
        }

        private void OnStartServer(object sender, RoutedEventArgs e)
        {
            server = new ModbusTcpServer("127.0.0.1", 502);
            server.Start();
            server.ModbusSlaveRequestReceived += OnModbusSlaveRequestReceived;
            PrintLog("服务器创建完成");
        }

        private void OnModbusSlaveRequestReceived(object sender, ModbusSlaveRequestEventArgs e)
        {
            string str = "";
            foreach (var item in e.Message.MessageFrame)
            {
                str += item.ToString("x2").PadLeft(2, '0').ToUpper() + "  ";
            }
            PrintLog("Received：" + str);
        }

        private void OnWriteToClient(object sender, RoutedEventArgs e)
        {
            server?.WriteInt16(0, 1);
            server?.WriteInt16(3, [1, 2, 3, 4, 5]);

            server?.WriteBool(10, true);
            server?.WriteBool(13, [true, true, true, true, true]);

            server?.WriteFloat(20, 3.14159f);
            server?.WriteFloat(23, [1.2f, 2.3f, 3.4f]);

            server?.WriteString(30, "test test test test");

            server?.WriteCoilInputs(300, true);
            server?.WriteCoilInputs(301, [true, true]);

            server?.WriteInputRegisters(400, 10);
            server?.WriteInputRegisters(401, [20, 30]);
        }

        private void OnReadFromClient(object sender, RoutedEventArgs e)
        {
            if (server != null)
            {
                var res = server.ReadInt16(0);
                PrintLog("服务器读取 0：" + res);

                var ress = server.ReadInt16(3, 5);
                string str = "";
                foreach (var item in ress)
                {
                    str += item + " ";
                }
                PrintLog("服务器读取 3-5：" + str);

                var b = server.ReadBool(10);
                PrintLog("服务器读取 10：" + b);

                var bs = server.ReadBool(13, 5);
                str = "";
                foreach (var item in bs)
                {
                    str += item + " ";
                }
                PrintLog("服务器读取 13-15：" + str);

                var f = server.ReadFloat(20);
                PrintLog("服务器读取 20：" + f);

                var fs = server.ReadFloat(23, 3);
                str = "";
                foreach (var item in fs)
                {
                    str += item + " ";
                }
                PrintLog("服务器读取 23：" + str);

                str = server.ReadString(30);
                PrintLog("服务器读取 30：" + str);
            }
        }

        private void OnStopServer(object sender, RoutedEventArgs e)
        {
            server.Stop();
        }


        private void OnConnectServer(object sender, RoutedEventArgs e)
        {
            client = new ModbusTcpClient("127.0.0.1", 502);
            client.Connect();
        }

        private void OnWriteToServer(object sender, RoutedEventArgs e)
        {
            client.WriteInt16(1, 1);
            client.WriteInt16(5, [5, 6]);
            client.WriteBool(10, true);
            client.WriteBool(15, [true, true]);
            client.WriteFloat(20, 1.2f);
            client.WriteString(30, "abc abc");
        }

        private void OnReadFromServer(object sender, RoutedEventArgs e)
        {
            var va1 = client.ReadInt16(1);
            var va2 = client.ReadInt16(5);
            var va3 = client.ReadBool(10);
            var va4 = client.ReadBool(15);
            var va5 = client.ReadFloat(20);
            var va7 = client.ReadString(30);
        }

        private void OnDisconnectToServer(object sender, RoutedEventArgs e)
        {
            client.Close();
        }
    }
}