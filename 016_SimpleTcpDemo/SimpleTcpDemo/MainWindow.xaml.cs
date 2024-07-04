using SimpleTCP;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;

namespace SimpleTcpDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SimpleTcpServer Server { get; set; }
        private SimpleTcpClient Client { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Server = new SimpleTcpServer
            {
                Delimiter = 0x13,
                StringEncoder = Encoding.UTF8,
            };

            Client = new SimpleTcpClient
            {
                Delimiter = 0x13,
                StringEncoder = Encoding.UTF8,
            };

            Server.ClientConnected += ClientConnected;
            Server.ClientDisconnected += ClientDisconnected;
            Server.DataReceived += ServerDataReceived;

            Client.DataReceived += ClientDataReceived;
        }

        private void ClientDataReceived(object sender, Message e)
        {
            PrintLog("Message from server: " + e.MessageString);
            //PrintLog("Message from server: " + Encoding.UTF8.GetString(e.Data));
        }

        private void ServerDataReceived(object sender, Message e)
        {
            PrintLog("Message from client: " + e.MessageString);
        }

        private void ClientDisconnected(object sender, TcpClient e)
        {
            PrintLog("Client disconnected: " + e.Client.RemoteEndPoint.ToString());
        }

        private void ClientConnected(object sender, TcpClient e)
        {
            PrintLog("Client connected: " + e.Client.RemoteEndPoint.ToString());
        }



        private void PrintLog(string msg)
        {
            Dispatcher.Invoke(() =>
            {
                lb.Items.Add(msg);
            });
        }

        private void OnStartServer(object sender, RoutedEventArgs e)
        {
            if (!Server.IsStarted)
            {
                Server.Start(IPAddress.Parse("127.0.0.1"), 502);
            }
        }

        private void OnServerSendMessage(object sender, RoutedEventArgs e)
        {
            Server.Broadcast("Hello, client!");
        }


        private void OnConnectServer(object sender, RoutedEventArgs e)
        {
            Client.Connect("127.0.0.1", 502);
        }

        private void OnClientSendMessage(object sender, RoutedEventArgs e)
        {
            Client.Write("Hello, server!");
        }
    }
}