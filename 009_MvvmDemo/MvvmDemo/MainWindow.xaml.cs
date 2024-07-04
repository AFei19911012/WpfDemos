using MvvmDemo.Model;
using MvvmDemo.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace MvvmDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM VM { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //VM = DataContext as MainVM;

            VM = new MainVM();
            VM.Edit_VM = Edit_VM;

            DataContext = VM;

            Binding binding = new Binding
            {
                Source = slider,
                Path = new PropertyPath("Value"),
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            TB_Binding.SetBinding(TextBox.TextProperty, binding);
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock txt =  (TextBlock)sender;
            txt.Text = "Mouse Enter";
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock txt = (TextBlock)sender;
            txt.Text = "MvvmDemo";
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Title = "MvvmDemo New";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string txt = (sender as Button).Content.ToString();
            if (txt.Contains("Name"))
            {
                VM.DataList[0].Name = txt;
                VM.DataList.Add(new DataModel(VM.DataList[0]));
            }
            else if (txt.Contains("Description"))
            {
                VM.DataList[0].Description = txt;
            }
        }
    }
}