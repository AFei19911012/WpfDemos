using SoftCircuits.WinSettings;
using System.Windows;

namespace WinSettingsDemo
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
            // ini 文件读写
            string ini_filename = "test.ini";
            MyIniSettings ini = new MyIniSettings(ini_filename)
            {
                UserName = "Big Wang",
                Password = "admin"
            };
            ini.Save();

            MyIniSettings new_ini = new MyIniSettings(ini_filename);
            new_ini.Load();

            // xml 文件读写
            string xml_filename = "test.xml";
            MyXmlSettings xml = new MyXmlSettings(xml_filename)
            {
                UserName = "Big Wang",
                Password = "admin"
            };
            xml.Save();

            MyXmlSettings new_xml = new MyXmlSettings(xml_filename);
            new_xml.Load();
        }
    }

    public class MyIniSettings : IniSettings
    {
        // Define properties to be saved to file
        public string EmailHost { get; set; }
        public int EmailPort { get; set; }

        // The following properties will be encrypted
        [EncryptedSetting]
        public string UserName { get; set; }
        [EncryptedSetting]
        public string Password { get; set; }

        // The following property will not be saved to file
        // Non-public properties are also not saved to file
        [ExcludedSetting]
        public DateTime Created { get; set; }

        public MyIniSettings(string filename) : base(filename, "Password123")
        {
            // Set initial, default property values
            EmailHost = string.Empty;
            EmailPort = 0;
            UserName = string.Empty;
            Password = string.Empty;

            Created = DateTime.Now;
        }
    }

    public class MyXmlSettings : XmlSettings
    {
        // Define properties to be saved to file
        public string EmailHost { get; set; }
        public int EmailPort { get; set; }

        // The following properties will be encrypted
        [EncryptedSetting]
        public string UserName { get; set; }
        [EncryptedSetting]
        public string Password { get; set; }

        // The following property will not be saved to file
        // Non-public properties are also not saved to file
        [ExcludedSetting]
        public DateTime Created { get; set; }

        public MyXmlSettings(string filename) : base(filename, "Password123")
        {
            // Set initial, default property values
            EmailHost = string.Empty;
            EmailPort = 0;
            UserName = string.Empty;
            Password = string.Empty;

            Created = DateTime.Now;
        }
    }

    public class MyRegistrySettings : RegistrySettings
    {
        // Define properties to be saved to file
        public string EmailHost { get; set; }
        public int EmailPort { get; set; }

        // The following properties will be encrypted
        [EncryptedSetting]
        public string UserName { get; set; }
        [EncryptedSetting]
        public string Password { get; set; }

        // The following property will not be saved to file
        // Non-public properties are also not saved to file
        [ExcludedSetting]
        public DateTime Created { get; set; }

        public MyRegistrySettings(string companyName, string applicationName, RegistrySettingsType settingsType)
            : base(companyName, applicationName, settingsType, "Password123")
        {
            // Set initial, default property values
            EmailHost = string.Empty;
            EmailPort = 0;
            UserName = string.Empty;
            Password = string.Empty;

            Created = DateTime.Now;
        }
    }
}