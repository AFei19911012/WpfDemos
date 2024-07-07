using IniFile;
using System.IO;
using System.Windows;

namespace IniFileDemo
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
            string filename = "Settings.ini";

            lb.Items.Add("新建 ini 文件");

            // 创建 ini 文件
            var ini = new Ini
            {
                new Section("Section Name1")
                {
                    new Property("Property1 Name", "A string value"),
                    new Property("Property2 Name", 10),
                },

                new Section("Section Name2")
                {
                    ["Property1 Name"] = "A string value",
                    ["Property2 Name"] = 10
                }
            };
            ini.SaveTo(filename);

            // 加载 ini
            ini = new Ini(filename);
            // 获取 Section 数量
            lb.Items.Add($"ini 文件包含 {ini.Count} 个 Section");

            // 添加新的 Section
            var section = new Section("New section")
            {
                ["Name"] = "BigWang",
                ["Price"] = (decimal)123.45,
            };
            ini.Add(section);
            lb.Items.Add("新增一个 New section");

            // 给 Section 添加备注
            section.AddComment("这是备注");
            section.Items.Add(new Comment("这是备注."));

            // 给 Property 添加备注
            var pro = section.First();
            pro.Items.Add(new Comment("这是备注"));

            // 给 Section 添加空白行
            section.AddBlankLine();
            section.Items.Add(new BlankLine());

            // 获取所有备注
            var comments1 = section.Comments;
            var comments2 = pro.Comments;
            var comments3 = pro.Items.OfType<Comment>();

            // 写入
            section["Pi"] = 3.14d;
            section.Add(new Property("SendMail", true));
            section["HasDiscount"] = true;
            section["Today"] = DateTime.Now;

            // 读取
            string name = section["Name"];
            decimal price = section["Price"];
            DateTime today = section["Today"].AsDateTime("yyyy/MM/dd");
            lb.Items.Add($"[{section.Name}] Name: {name}");
            lb.Items.Add($"[{section.Name}] Price: {price}");
            lb.Items.Add($"[{section.Name}] Today: {today}");

            // 全局设置
            Ini.Config
                .AllowHashForComments(setAsDefault: true)
                .SetSectionPaddingDefaults(insideLeft: 1, insideRight: 1)
                .SetPropertyPaddingDefaults(left: 2)
                .SetBooleanStrings(trueString: "YES", falseString: "NO")
                .SetDateFormats(dateFormat: "M/dd/yy");

            // 格式
            ini.Format();
            ini.Format(new IniFormatOptions
            {
                EnsureBlankLineBetweenSections = true,
                RemoveSuccessiveBlankLines = true
            });
            ini.SaveTo(filename);

            // 打印所有信息
            var txt = File.ReadAllText(filename);
            lb.Items.Add(txt);
        }
    }
}