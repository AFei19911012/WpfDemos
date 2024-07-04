using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows;
using System.Windows.Shapes;

namespace ZipDemo
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

        private void PrintLog(string msg)
        {
            lb.Items.Add(msg);
        }

        private void OnCreateEmptyZip(object sender, RoutedEventArgs e)
        {
            PrintLog("创建一个空的 zip 文件，并添加一个文本");
            string filename = "demo.zip";
            string fileNew = "Readme.txt";
            using FileStream fs = new FileStream(filename, FileMode.Create);
            using ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Create);
            // 创建一个空的文件
            ZipArchiveEntry entry = archive.CreateEntry(fileNew);
            using StreamWriter writer = new StreamWriter(entry.Open());
            writer.WriteLine("测试文本");
            writer.WriteLine("========================");
        }

        private void OnAddFile(object sender, RoutedEventArgs e)
        {
            string filename = "demo.zip";
            string fileAdd = "New.txt";
            using FileStream fs = new FileStream(filename, FileMode.Open);
            using ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Update);
            // 写入
            ZipArchiveEntry entry = archive.CreateEntry(fileAdd, CompressionLevel.Optimal);
            entry.Comment = "Added by BigWang";
            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes("第一行"));
            using (Stream writer = entry.Open())
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(writer);
                writer.Flush();
            }

            using (StreamWriter writer = new StreamWriter(entry.Open()))
            {
                writer.WriteLine("第二行");
                writer.WriteLine("========================");
            }
            PrintLog("添加了一个新文本");
        }

        private void OnDeleteFile(object sender, RoutedEventArgs e)
        {
            string filename = "demo.zip";
            string fileDelete = "New.txt";
            using FileStream fs = new FileStream(filename, FileMode.Open);
            using ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Update);
            // 删除
            var entry = archive.Entries.Where(r => r.FullName == fileDelete).ToList();
            if (entry != null && entry.Count > 0)
            {
                entry.ForEach(r => r.Delete());
            }
            PrintLog("删除了新添加的文本");
        }

        private void OnReadFile(object sender, RoutedEventArgs e)
        {
            string filename = "demo.zip";
            string fileRead = "Readme.txt";
            using FileStream fs = new FileStream(filename, FileMode.Open);
            using ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Read);
            ZipArchiveEntry entry = archive.GetEntry(fileRead);
            if (entry != null)
            {
                using StreamReader reader = new StreamReader(entry.Open());
                string msg = reader.ReadLine();
                while (!string.IsNullOrEmpty(msg))
                {
                    PrintLog("读取到内容：" + msg);
                    msg = reader.ReadLine();
                }
            }
        }
    }
}