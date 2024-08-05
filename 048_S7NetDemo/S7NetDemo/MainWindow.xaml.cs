using S7.Net;
using System.Windows;

namespace S7NetDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int DB2 { get; set; } = 2;
        private int DB4 { get; set; } = 4;
        private short TestServerPort { get; set; } = 102;
        private string TestServerIp { get; set; } = "127.0.0.1";
        private Plc SiemensPlc { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            // 创建 Plc
            SiemensPlc = new Plc(CpuType.S71200, TestServerIp, TestServerPort, 0, 2);
        }

        private void OnOpenPlc(object sender, RoutedEventArgs e)
        {
            // 启动
            SiemensPlc.Open();
        }

        private void OnReadWrite(object sender, RoutedEventArgs e)
        {
            if (SiemensPlc.IsConnected)
            {
                // Int16   DB1.10
                ushort val1 = 40000;
                SiemensPlc.Write("DB1.DBW10", val1);
                ushort result1 = (ushort)SiemensPlc.Read("DB1.DBW10");
                short val2 = -100;
                SiemensPlc.Write("DB1.DBW20", val2.ConvertToUshort());
                short result2 = ((ushort)SiemensPlc.Read("DB1.DBW20")).ConvertToShort();

                // int32  DB1.30
                uint val3 = 1000;
                SiemensPlc.Write("DB1.DBD30", val3);
                uint result3 = (uint)SiemensPlc.Read("DB1.DBD30");
                int val4 = -60000;
                SiemensPlc.Write("DB1.DBD40", val4);
                int result4 = ((uint)SiemensPlc.Read("DB1.DBD40")).ConvertToInt();

                // real  DB1.30
                float val5 = 1234567;
                SiemensPlc.Write("DB1.DBD50", val5.ConvertToUInt());
                float result5 = ((uint)SiemensPlc.Read("DB1.DBD50")).ConvertToFloat();
                float val6 = 12.34567f;
                SiemensPlc.Write("DB1.DBD60", val6.ConvertToUInt());
                float result6 = ((uint)SiemensPlc.Read("DB1.DBD60")).ConvertToFloat();

                // bool  DB2.0.5
                bool val7 = true;
                SiemensPlc.Write("DB2.DBX0.5", val7);
                bool result7 = (bool)SiemensPlc.Read("DB2.DBX0.5");
                bool val8 = true;
                SiemensPlc.Write("DB2.DBX8192.7", val8);
                bool result8 = (bool)SiemensPlc.Read("DB2.DBX8192.7");

                // byte  DB2.2048
                byte[] val9 = [0x12, 0x34];
                SiemensPlc.Write("DB2.DBB2048", val9[0]);
                SiemensPlc.Write("DB2.DBB2049", val9[1]);
                byte result4b0 = (byte)SiemensPlc.Read("DB2.DBB2048");
                byte result4b1 = (byte)SiemensPlc.Read("DB2.DBB2049");

                // bool  DB1.0.0
                SiemensPlc.Write("DB1.DBX0.0", false);
                var boolVariable = (bool)SiemensPlc.Read("DB1.DBX0.0");
                SiemensPlc.Write("DB1.DBX0.0", true);
                boolVariable = (bool)SiemensPlc.Read("DB1.DBX0.0");
                SiemensPlc.Write("DB1.DBX0.0", 0);
                boolVariable = (bool)SiemensPlc.Read("DB1.DBX0.0");
                SiemensPlc.Write("DB1.DBX0.0", 1);
                boolVariable = (bool)SiemensPlc.Read("DB1.DBX0.0");
                SiemensPlc.Write("DB1.DBX0.7", 1);
                boolVariable = (bool)SiemensPlc.Read("DB1.DBX0.7");
                SiemensPlc.Write("DB1.DBX0.7", 0);
                boolVariable = (bool)SiemensPlc.Read("DB1.DBX0.7");
                SiemensPlc.Write("DB1.DBX658.7", 1);
                boolVariable = (bool)SiemensPlc.Read("DB1.DBX658.7");
            }
        }

        private void OnClosePlc(object sender, RoutedEventArgs e)
        {
            SiemensPlc?.Close();
        }
    }
}