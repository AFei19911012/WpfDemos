using McProtocol.Async;
using System.Windows;

namespace McProtocolDemo
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            McProtocolTcp mcProtocolTcp = new McProtocolTcp();
            await mcProtocolTcp.Open();

            // 读取 short
            var data1 = await mcProtocolTcp.ReadDeviceBlock("D100", 2);
            var data2 = await mcProtocolTcp.ReadDeviceBlock(PlcDeviceType.D, 100, 2);

            // 读取 bool
            var data4 = await mcProtocolTcp.GetBitDevice("M10", 2);
            var data5 = await mcProtocolTcp.GetBitDevice(PlcDeviceType.M, 10, 2);

            // 读取 float
            var data6 = await mcProtocolTcp.ReadDeviceBlock(PlcDeviceType.D, 102, 2);
            var d1 = ShortToBytes((short)data6[0]);
            var d2 = ShortToBytes((short)data6[1]);
            var d = BitConverter.ToSingle([d1[0], d1[1], d2[0], d2[1]], 0);
        }

        private byte[] ShortToBytes(short shortNumber)
        {
            // 低字节
            byte lowByte = (byte)(shortNumber & 0xFF);
            // 高字节
            byte highByte = (byte)((shortNumber >> 8) & 0xFF);
            return [lowByte, highByte];
        }
    }
}