using IniFileParser;
using System.Windows;

namespace IniFileParserDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            string filename = "test.ini";

            // 写入
            IniFile file = new IniFile();
            file.SetSetting(IniFile.DefaultSectionName, "Name", "Bob Smith");
            file.SetSetting(IniFile.DefaultSectionName, "Age", 34);
            file.SetSetting(IniFile.DefaultSectionName, "Rating", 123.45);
            file.SetSetting(IniFile.DefaultSectionName, "Active", true);
            file.Save(filename);

            lb.Items.Add("新建 ini 文件并写入");
            lb.Items.Add("读取 ini 文件");
            // 读取
            file.Load(filename);
            string name = file.GetSetting(IniFile.DefaultSectionName, "Name", string.Empty);
            int age = file.GetSetting(IniFile.DefaultSectionName, "Age", 0);
            double rating = file.GetSetting(IniFile.DefaultSectionName, "Rating", 0.0);
            bool active = file.GetSetting(IniFile.DefaultSectionName, "Active", false);

            lb.Items.Add($"[{IniFile.DefaultSectionName}] Name: {name}");
            lb.Items.Add($"[{IniFile.DefaultSectionName}] Age: {age}");
            lb.Items.Add($"[{IniFile.DefaultSectionName}] Rating: {rating}");
            lb.Items.Add($"[{IniFile.DefaultSectionName}] Active: {active}");

            lb.Items.Add("");
            lb.Items.Add("获取 ini 所有 Section 和 Setting");

            foreach (var item in file.GetSections())
            {
                lb.Items.Add(item);
                foreach (var s in file.GetSectionSettings(item.ToString()))
                {
                    lb.Items.Add($"  {s.Name}: {s.Value}");
                }
            }


        }
    }
}