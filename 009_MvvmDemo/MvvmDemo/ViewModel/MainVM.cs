using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ICSharpCode.AvalonEdit;
using MvvmDemo.Model;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using MessageBox = HandyControl.Controls.MessageBox;

namespace MvvmDemo.ViewModel
{
    public class MainVM : ViewModelBase
    {
		private int _FontSize = 18;
		public int FontSize
		{
			get => _FontSize;
			set => Set(ref _FontSize, value);
		}

		private bool _IsChecked = true;
		public bool IsChecked
		{
			get => _IsChecked;
			set => Set(ref _IsChecked, value);
		}


        private ModuleType _CurModule = ModuleType.None;
        public ModuleType CurModule
        {
            get => _CurModule;
            set => Set(ref _CurModule, value);
        }

        private string _ShowingText;
        public string ShowingText
        {
            get => _ShowingText;
            set => Set(ref _ShowingText, value);
        }



        private ObservableCollection<DataModel> _DataList;
		public ObservableCollection<DataModel> DataList
		{
			get => _DataList;
			set => Set(ref _DataList, value);
		}


        public MainVM()
        {
			DataList = new ObservableCollection<DataModel>()
			{
				new DataModel(1, "name_1", "content_1"),
                new DataModel(2, "name_2", "content_2"),
                new DataModel(3, "name_3", "content_3"),
            };
        }


        private TextEditor Edit_Xaml { get; set; }
        private TextEditor Edit_XamlCs { get; set; }
        public TextEditor Edit_VM { get; set; }


        public RelayCommand<RoutedEventArgs> CmdLoaded => new Lazy<RelayCommand<RoutedEventArgs>>(() => new RelayCommand<RoutedEventArgs>(Loaded)).Value;
        private void Loaded(RoutedEventArgs e)
        {
            Edit_Xaml = (e.Source as MainWindow).Edit_Xaml;
            Edit_XamlCs = (e.Source as MainWindow).Edit_XamlCs;
            //Edit_VM = (e.Source as MainWindow).Edit_VM;

            //Edit_Xaml.Load("../MvvmDemo/MainWindow.xaml");
            //Edit_XamlCs.Load("../MvvmDemo/MainWindow.xaml.cs");
            //Edit_VM.Load("../MvvmDemo/ViewModel/MainVM.cs");

            Edit_Xaml.Load("Code/MainWindow.xaml");
            Edit_XamlCs.Load("Code/MainWindow.xaml.cs");
            Edit_VM.Load("Code/MainVM.cs");
        }

        private string GetCode(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            return reader.ReadToEnd();
        }

        public RelayCommand<MouseEventArgs> CmdMouseMove => new RelayCommand<MouseEventArgs>(MouseMove);
        private void MouseMove(MouseEventArgs e)
        {
            // 显示鼠标所在位置
            System.Windows.Point point = e.GetPosition(e.Device.Target);
            ShowingText = point.X + ", " + point.Y;
        }


        public RelayCommand CmdSwitchModule => new Lazy<RelayCommand>(() => new RelayCommand(OnSwitchModule)).Value;
        private void OnSwitchModule()
        {
            MessageBox.Show("当前模板：" + CurModule);
        }

        public RelayCommand<string> CmdWithParameter => new Lazy<RelayCommand<string>>(() => new RelayCommand<string>(WithParameter)).Value;
        private void WithParameter(string para)
        {
            CurModule = ModuleType.None;
            MessageBox.Show("当前点击：" + para);
        }

    }
}