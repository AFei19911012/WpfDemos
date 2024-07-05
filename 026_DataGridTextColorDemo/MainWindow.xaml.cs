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

namespace DataGridTextColorDemo
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
            var data = new List<DataModel>
            {
                new DataModel { Value = 1.2, Result = "OK", StrValue = "100%" },
                new DataModel { Value = 5, Result = "NG", StrValue = "80%" },
                new DataModel { Value = 2, Result = "OK", StrValue = "10%"},
                new DataModel { Value = 4.2, Result = "NG", StrValue = "60%"},
            };
            dg.ItemsSource = data;
        }
    }

    public class DataModel
    {
        public double Value { get; set; }
        public string Result { get; set; }
        public string StrValue { get; set; }
    }
}