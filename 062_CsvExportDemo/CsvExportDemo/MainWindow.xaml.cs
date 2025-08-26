using System.Windows;

namespace CsvExportDemo
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
            Init();
        }

        private void Init()
        {
            var myExport = new CsvExport();

            myExport.AddRow();
            myExport["Region"] = "Los Angeles, USA";
            myExport["Sales"] = 100000;
            myExport["Date Opened"] = new DateTime(2003, 12, 31);
            myExport.AddRow();
            myExport["Region"] = "Canberra \"in\" Australia";
            myExport["Sales"] = 50000;
            myExport["Date Opened"] = new DateTime(2005, 1, 1, 9, 30, 0);
            myExport.AddRow();
            myExport["Region"] = "Canberra \"in\" Australia";
            myExport["Sales"] = 50000;
            myExport["Date Opened"] = new DateTime(2005, 1, 1, 1, 30, 0);
            myExport.ExportToFile("Somefile.csv");

            var myExport1 = new CsvExport(",", false);
            myExport1.AddRow();
            myExport1["Region"] = "Los Angeles";
            myExport1["Sales"] = 100000;
            myExport1["Date Opened"] = new DateTime(2003, 12, 31);
            myExport1.AddRow();
            myExport1["Region"] = "Canberra \"in\" Australia";
            myExport1["Sales"] = 50000;
            myExport1["Date Opened"] = new DateTime(2005, 1, 1, 9, 30, 0);
            myExport1.ExportToFileAppend("Somefile.csv");


            var list = new List<Foo>
            {
                new Foo { Region = "Los Angeles", Sales = 123321, DateOpened = DateTime.Now },
                new Foo { Region = "Canberra in Australia", Sales = 123321, DateOpened = DateTime.Now },
            };

            var myExport2 = new CsvExport();
            myExport2.AddRows(list);
            string myCsv = myExport2.Export();
            byte[] myCsvData = myExport2.ExportToBytes();
        }
    }

    public class Foo
    {
        public string Region { get; set; }
        public int Sales { get; set; }
        public DateTime DateOpened { get; set; }
    }
}