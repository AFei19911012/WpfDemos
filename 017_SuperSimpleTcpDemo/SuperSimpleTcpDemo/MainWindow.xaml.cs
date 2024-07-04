using SuperSimpleTcp;
using System.Text;
using System.Windows;

namespace SuperSimpleTcpDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SimpleTcpServer Server { get; set; } = new SimpleTcpServer("127.0.0.1", 502);
        private SimpleTcpClient Client { get; set; } = new SimpleTcpClient("127.0.0.1", 502);
        private string ClientGuid { get; set; } = "";

        public MainWindow()
        {
            InitializeComponent();

            Server.Events.ClientConnected += ClientConnected;
            Server.Events.ClientDisconnected += ClientDisconnected;
            Server.Events.DataReceived += DataReceived;

            Client.Events.Connected += Connected;
            Client.Events.Disconnected += Disconnected;
            Client.Events.DataReceived += DataReceived;
        }

        private void PrintLog(string msg)
        {
            Dispatcher.Invoke(() =>
            {
                lb.Items.Add(msg);
            });
        }

        private void Disconnected(object? sender, ConnectionEventArgs e)
        {
            PrintLog($"*** Server {e.IpPort} disconnected");
        }

        private void Connected(object? sender, ConnectionEventArgs e)
        {
            PrintLog($"*** Server {e.IpPort} connected");
        }

        private void DataReceived(object? sender, DataReceivedEventArgs e)
        {
            PrintLog($"[{e.IpPort}] {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}");
        }

        private void ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"[{e.IpPort}] client disconnected: {e.Reason}");
            ClientGuid = "";
        }

        private void ClientConnected(object? sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"[{e.IpPort}] client connected");
            ClientGuid = e.IpPort;
        }

        private void OnStartServer(object sender, RoutedEventArgs e)
        {
            if (!Server.IsListening)
            {
                Server.Start();
            }
        }

        private async void OnServerSendMessage(object sender, RoutedEventArgs e)
        {
            Server.Send(ClientGuid, "Hello, client!");

            await Server.SendAsync(ClientGuid, "Hello, client!");
        }

        private void OnConnectServer(object sender, RoutedEventArgs e)
        {
            if (!Client.IsConnected)
            {
                Client.Connect();
            }
        }

        private async void OnClientSendMessage(object sender, RoutedEventArgs e)
        {
            Client.Send("Hello, server!");

            await Client.SendAsync("Hello, server!");
        }
    }
}