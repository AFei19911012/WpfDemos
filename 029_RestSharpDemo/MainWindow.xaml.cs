using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestSharpDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 创建客户端对象
            var client = new RestClient("https://sapi.k780.com");
            // 添加参数
            client.AddDefaultParameter("app", "weather.today");
            client.AddDefaultParameter("weaId", "1");
            client.AddDefaultParameter("appkey", "10003");
            client.AddDefaultParameter("sign", "b59bc3ef6191eb9f747dd4e83c99f2a4");
            client.AddDefaultParameter("format", "json");

            // Post 请求
            var request = new RestRequest
            {
                Method = Method.Post,
            };
            // 执行
            var response = client.Execute(request);
            JObject json = JsonConvert.DeserializeObject<JObject>(response.Content);

            lb.Items.Clear();
            lb.Items.Add("Post:");
            lb.Items.Add(json.ToString());

            // 默认 Method.Get
            request = new RestRequest();
            request.AddHeader("Content-type", "application/json; charset=UTF-8");
            request.AddHeader("content-encoding", "gzip");
            response = client.Execute(request);
            json = JsonConvert.DeserializeObject<JObject>(response.Content);

            lb.Items.Add("");
            lb.Items.Add("Get:");
            lb.Items.Add(json.ToString());
        }
    }
}