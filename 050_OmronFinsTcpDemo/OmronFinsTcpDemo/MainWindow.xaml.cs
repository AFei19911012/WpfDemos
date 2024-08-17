using OmronFinsTcp;
using System.Windows;

namespace OmronFinsTcpDemo
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
            EtherNetPLC ENT = new EtherNetPLC();
            var re = ENT.Link("127.0.0.1", 6000);

            // 读 short
            var result = ENT.ReadWord("D100", out short data1);
            ENT.ReadWords("D100", 2, out short[] datas1);

            // 写 short
            ENT.WriteWord("D100", 100);
            ENT.WriteWords("D100", 2, [100, 101]);

            // 读 bool
            ENT.GetBitState("D10.0", out short data2);
            ENT.GetBitStates("D10.1", out bool[] datas2, 2);
            // 写 bool
            ENT.SetBitState("D10.1", BitState.ON);

            // 读 float
            ENT.ReadReal("D200", out float data3);
            // 写 float
            ENT.WriteReal("D200", 12.3f);

            // 读 int
            ENT.ReadInt32("D300", out int data4);
            ENT.WriteInt32("D300", 300);
        }
    }
}