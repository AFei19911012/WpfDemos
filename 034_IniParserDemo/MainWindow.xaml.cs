using IniParser;
using IniParser.Model;
using IniParser.Parser;
using System.Windows;

namespace IniParserDemo
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
            var iniStr = @"[Section]
                    # Backslash Bcomment
                    Key=Value";
            var iniParser = new IniDataParser();
            // 用 # 标识备注
            iniParser.Configuration.CommentString = "#";
            IniData iniData = iniParser.Parse(iniStr);
            lb.Items.Add(iniData);

            // 保存
            FileIniDataParser parser = new FileIniDataParser();
            parser.Parser.Configuration.CommentString = "#";
            // 保存为 ini
            parser.WriteFile("test.ini", iniData);

            // 读取 ini
            IniData data = parser.ReadFile("TestIniFile.ini");
            lb.Items.Add("");
            lb.Items.Add(data);

            // 修改
            data["GeneralConfiguration"]["setMaxErrors"] = "10";

            // 新增
            data.Sections.AddSection("UI");
            data.Sections.GetSectionData("UI").Comments.Add("This is a new comment for the section");
            data.Sections.GetSectionData("UI").Keys.AddKey("fullscreen", "true");
            data.Sections.GetSectionData("UI").Keys.GetKeyData("fullscreen").Comments.Add("new key comment");

            data.Sections.AddSection("TestSection");
            KeyData key = new KeyData("TestKey");
            key.Value = "TestValue";
            key.Comments.Add("This is a comment");
            data["TestSection"].SetKeyData(key);
            lb.Items.Add("");
            lb.Items.Add(data);

            // 获取备注
            var comments1 = data.Sections.GetSectionData("UI").Comments;
            var comments2 = data["UI"].GetKeyData("fullscreen").Comments;
            foreach (var comment in comments1)
            {
                lb.Items.Add(comment);
            }
            foreach (var item in comments2)
            {
                lb.Items.Add(item);
            }

            // 获取值
            int number = int.Parse(data["GeneralConfiguration"]["setMaxErrors"]);
            bool useFullScreen = bool.Parse(data["UI"]["fullscreen"]);
            lb.Items.Add(number);
            lb.Items.Add(useFullScreen);

            // 保存
            parser.WriteFile("NewTestIniFile.ini", data);

            // 合并
            IniData data1 = parser.ReadFile("test.ini");
            IniData data2 = parser.ReadFile("TestIniFile.ini");
            data1.Merge(data2);
            //data1["Key"].Merge(data2["Key"]);
            lb.Items.Add("");
            lb.Items.Add(data1);

            // 流
            var streamParser = new StreamIniDataParser();
            string tempPath = "test.ini.stream";
            using var sw = new System.IO.StreamWriter(tempPath);
            streamParser.WriteData(sw, data);
            sw.Close();
            string msg = System.IO.File.ReadAllText(tempPath);
            lb.Items.Add("");
            lb.Items.Add(msg);
        }
    }
}