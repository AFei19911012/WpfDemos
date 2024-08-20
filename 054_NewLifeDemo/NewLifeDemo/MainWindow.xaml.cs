using NewLife;
using NewLife.Remoting;
using System.Diagnostics;
using System.Text;
using System.Windows;

namespace NewLifeDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void TestServer()
        {
            // 实例化RPC服务端，指定端口，同时在Tcp/Udp/IPv4/IPv6上监听
            var svr = new ApiServer(1234);
            // 注册服务控制器
            svr.Register<MyController>();
            svr.Register<UserController>();

            // 指定编码器
            svr.Encoder = new JsonEncoder();
            svr.Start();
        }

        async void TestClient()
        {
            var client = new MyClient("tcp://127.0.0.1:1234");

            // 指定编码器
            client.Encoder = new JsonEncoder();
            client.Open();


            // 标准服务，Json
            var n = await client.AddAsync(1245, 3456);
            Debug.WriteLine("Add: {0}", n);

            // 高速服务，二进制
            var buf = "Hello".GetBytes();
            var pk = await client.RC4Async(buf);
            Debug.WriteLine(pk.ToHex());

            // 返回对象
            var user = await client.FindUserAsync(123, true);
            Debug.WriteLine("FindUser: ID={0} Name={1} Enable={2} CreateTime={3}", user.ID, user.Name, user.Enable, user.CreateTime);
        }


        private void OnServer(object sender, RoutedEventArgs e)
        {
            TestServer();
        }

        private void OnClient(object sender, RoutedEventArgs e)
        {
            TestClient();
        }
    }
}