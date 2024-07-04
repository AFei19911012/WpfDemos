using System.Text;
using System.Windows;
using WatsonTcp;

namespace WatsonTcpDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WatsonTcpServer Server { get; set; } = new WatsonTcpServer("127.0.0.1", 502);
        private WatsonTcpClient Client { get; set; } = new WatsonTcpClient("127.0.0.1", 502);
        private Guid ClientGuid { get; set; } = Guid.Empty;

        public MainWindow()
        {
            InitializeComponent();

            Server.Events.ClientConnected += ClientConnected;
            Server.Events.ClientDisconnected += ClientDisconnected;
            Server.Events.MessageReceived += MessageReceivedFromClient;
            Server.Callbacks.SyncRequestReceivedAsync = SyncRequestReceived;

            Client.Events.ServerConnected += ServerConnected;
            Client.Events.ServerDisconnected += ServerDisconnected;
            Client.Events.MessageReceived += MessageReceivedFromServer;
            Client.Callbacks.SyncRequestReceivedAsync = SyncRequestReceived;
        }

        private void PrintLog(string msg)
        {
            Dispatcher.BeginInvoke(() =>
            {
                lb.Items.Add(msg);
            });
        }

        private void ClientConnected(object sender, ConnectionEventArgs args)
        {
            ClientGuid = args.Client.Guid;
            PrintLog("Client connected: " + args.Client.ToString());
        }
        private void ClientDisconnected(object sender, DisconnectionEventArgs args)
        {
            ClientGuid = Guid.Empty;
            PrintLog("Client disconnected: " + args.Client.ToString() + ": " + args.Reason.ToString());
        }
        private void MessageReceivedFromClient(object sender, MessageReceivedEventArgs args)
        {
            PrintLog("Message from " + args.Client.ToString() + ": " + Encoding.UTF8.GetString(args.Data));
            if (args.Metadata != null)
            {
                foreach (var item in args.Metadata)
                {
                    PrintLog("Metadata from client: key = " + item.Key + ", value = " + item.Value);
                }
            }
        }

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        private async Task<SyncResponse> SyncRequestReceived(SyncRequest req)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            PrintLog(Encoding.UTF8.GetString(req.Data));
            return new SyncResponse(req, "Hello back at you!");
        }

        private void ServerConnected(object sender, ConnectionEventArgs args)
        {
            PrintLog("Server connected");
        }

        private void ServerDisconnected(object sender, DisconnectionEventArgs args)
        {
            PrintLog("Server disconnected");
        }

        private void MessageReceivedFromServer(object sender, MessageReceivedEventArgs args)
        {
            PrintLog("Message from server: " + Encoding.UTF8.GetString(args.Data));
            if (args.Metadata != null)
            {
                foreach (var item in args.Metadata)
                {
                    PrintLog("Metadata from server: key = " + item.Key + ", value = " + item.Value);
                }
            }
        }


        private void OnStartServer(object sender, RoutedEventArgs e)
        {
            if (!Server.IsListening)
            {
                Server.Start();
            }
        } 

        private async void OnServerSendText(object sender, RoutedEventArgs e)
        {
            await Server.SendAsync(ClientGuid, "Hello, client!");
        }

        private async void OnServerSendMetadata(object sender, RoutedEventArgs e)
        {
            Dictionary<string, object> md = new Dictionary<string, object>
            {
                { "foo", "bar" }
            };
            await Server.SendAsync(ClientGuid, "Hello, client!  Here's some metadata!", md);
        }

        private async void OnServerSendAndResponse(object sender, RoutedEventArgs e)
        {
            try
            {
                SyncResponse resp = await Server.SendAndWaitAsync(5000, ClientGuid, "Hey, say hello back within 5 seconds!");
                PrintLog("My friend says: " + Encoding.UTF8.GetString(resp.Data));
            }
            catch (TimeoutException)
            {
                PrintLog("Too slow...");
            }
        }

        private void OnConnectServer(object sender, RoutedEventArgs e)
        {
            if (!Client.Connected)
            {
                Client.Connect();
            }
        }

        private async void OnClientSendText(object sender, RoutedEventArgs e)
        {
            await Client.SendAsync("Hello, server!");
        }

        private async void OnClientSendMetadata(object sender, RoutedEventArgs e)
        {
            Dictionary<string, object> md = new Dictionary<string, object>
            {
                { "foo", "bar" }
            };
            await Client.SendAsync("Hello, server!  Here's some metadata!", md);
        }

        private async void OnClientSendAndResponse(object sender, RoutedEventArgs e)
        {
            try
            {
                SyncResponse resp = await Client.SendAndWaitAsync(5000, "Hey, say hello back within 5 seconds!");
                PrintLog("My friend says: " + Encoding.UTF8.GetString(resp.Data));
            }
            catch (TimeoutException)
            {
                PrintLog("Too slow...");
            }
        }
    }
}