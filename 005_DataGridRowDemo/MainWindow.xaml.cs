using System.Windows;
using System.Windows.Controls;

namespace DataGridRowDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM VM { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            VM = DataContext as MainVM;
        }

        private void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            if (e.Row.Item is DataModel model)
            {
                e.Row.IsEnabled = model.IsEnbled;
                model.PropertyChanged += Model_PropertyChanged;
            }
        }

        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            int num = 0;
            for (int i = 1; i < VM.ListDataModel.Count; i++)
            {
                num += VM.ListDataModel[i].Number;
            }
            if (VM.ListDataModel[0].Number != num)
            {
                VM.ListDataModel[0].Number = num;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM.ListDataModel.Add(new DataModel { Name = $"New{VM.ListDataModel.Count}", Number = 25 });
            Model_PropertyChanged(null, null);
        }
    }
}