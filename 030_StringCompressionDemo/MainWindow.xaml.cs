using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows;

namespace StringCompressionDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Count { get; set; } = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string info = Guid.NewGuid().ToString();
            for (int i = 0; i < Count - 1; i++)
            {
                info += Guid.NewGuid();
            }
            //string info = string.Concat(Enumerable.Repeat(info, Count));
            string info_comp = CompressString(info);
            string info_decomp = DecompressString(info_comp);
            lb.Items.Add("源字符串：" + info);
            lb.Items.Add("压缩后字符串：" + info_comp);
            lb.Items.Add("解压缩后字符串：" + info_decomp);
            lb.Items.Add("");
            Count += 5;
        }

        private string CompressString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            using var memoryStream = new MemoryStream();
            using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true))
            {
                deflateStream.Write(buffer, 0, buffer.Length);
                deflateStream.Close();
            }
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        private string DecompressString(string compressedText)
        {
            byte[] buffer = Convert.FromBase64String(compressedText);
            using var memoryStream = new MemoryStream(buffer);
            using var deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress);
            using var reader = new StreamReader(deflateStream);
            return reader.ReadToEnd();
        }
    }
}