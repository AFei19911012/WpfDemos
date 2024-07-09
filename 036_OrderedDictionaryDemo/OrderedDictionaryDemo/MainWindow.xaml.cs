using SoftCircuits.Collections;
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

namespace OrderedDictionaryDemo
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
            OrderedDictionary<int, string> dictionary = new()
            {
                [101] = "Bob Smith",
                [127] = "Gary Wilson",
                [134] = "Ann Carpenter",
                [187] = "Bill Jackson",
                [214] = "Cheryl Hansen",
            };

            lb.Items.Add("初始化字典");
            foreach (var item in dictionary)
            {
                lb.Items.Add($"{item.Key} - {item.Value}");
            }

            lb.Items.Add("");
            lb.Items.Add("通过序号访问");
            lb.Items.Add($"dictionary.ByIndex[3]: {dictionary.ByIndex[3]}");

            // 添加键值对
            dictionary = new();
            dictionary.Add(101, "Bob Smith");
            dictionary.Add(127, "Gary Wilson");
            dictionary.Add(187, "Bill Jackson");
            dictionary.Add(214, "Cheryl Hansen");
            dictionary.Insert(2, 134, "Ann Carpenter");

            // 移除
            dictionary.Remove(134); // Removes 134 - Add Carpenter
            dictionary.RemoveAt(2); // Removes 187 - Bill Jackson

            lb.Items.Add("dictionary.Remove(134)");
            lb.Items.Add("dictionary.RemoveAt(2)");

            lb.Items.Add("");
            lb.Items.Add("当前字典");
            foreach (var item in dictionary)
            {
                lb.Items.Add($"{item.Key} - {item.Value}");
            }
        }
    }
}