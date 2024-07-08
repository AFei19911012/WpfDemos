using System.Windows;
using TextParsing;

namespace ParsingHelperDemo
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
            string txt = "The quick brown fox jumps over the lazy dog.";
            lb.Items.Add(txt);
            lb.Items.Add("ParsingHelper helper = new ParsingHelper(txt)");
            ParsingHelper helper = new ParsingHelper(txt);
            lb.Items.Add($"helper.Peek(): {helper.Peek()}");
            lb.Items.Add($"helper.Get(): {helper.Get()}");
            lb.Items.Add($"helper.Get(): {helper.Get()}");

            // 回到起始点
            helper.Reset();

            // 整个文本
            lb.Items.Add($"helper.Text: {helper.Text}");
            // 下标
            lb.Items.Add($"helper.Index: {helper.Index}");
            // 是否文末
            lb.Items.Add($"helper.EndOfText: {helper.EndOfText}");
            // 剩余文本长度
            lb.Items.Add($"helper.Remaining: {helper.Remaining}");

            // 打印字符
            lb.Items.Add("");
            lb.Items.Add("逐个打印字符");
            while (!helper.EndOfText)
            {
                lb.Items.Add(helper.Peek());
                helper++;
                // helper.Next();
            }

            // 移动位置到下一个不在指定条件里的字符
            txt = "abcdefg123hij";
            lb.Items.Add("");
            lb.Items.Add("移动到下一个非数字位置");
            lb.Items.Add(txt);
            helper = new ParsingHelper(txt);
            helper.Skip('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            lb.Items.Add(helper.Get());

            // 移动位置到不满足条件的字符
            helper.Reset();
            helper.SkipWhile(c => c != '3');
            lb.Items.Add(helper.Get());

            // 移动位置到指定字符
            helper.Reset();
            helper.SkipTo("123");
            lb.Items.Add(helper.Get());

            // 分割字符串
            helper = new ParsingHelper("The quick brown fox jumps over the lazy dog.");
            List<string> words = helper.ParseTokens(' ', '.').ToList();
            foreach (var item in words)
            {
                lb.Items.Add(item);
            }

            // 正则表达式
            helper = new ParsingHelper("Jim Jack Sally Jennifer Bob Gary Jonathan Bill");
            IEnumerable<string> results = helper.ParseTokensRegEx(@"\b[J]\w+");
            foreach (var item in results)
            {
                lb.Items.Add($"{item}");
            }
        }
    }
}