using SoftCircuits.ExpressionEvaluator;
using System.Windows;

namespace ExpressionEvaluatorDemo
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
            ExpressionEvaluator eval = new ExpressionEvaluator();
            Variable v;
            // 数字
            v = eval.Evaluate("2 + 2");        // Returns 4  (Integer)
            v = eval.Evaluate("2 + 3 * 5");    // Returns 17 (Integer)
            v = eval.Evaluate("(2 + 3) * 5");  // Returns 25 (Integer)

            // 字符串
            v = eval.Evaluate("\"2\" & \"2\"");  // Returns 22 (String)
            v = eval.Evaluate("'2' & '2'");      // Returns 22 (String)
            v = eval.Evaluate("\"2\" + \"2\"");  // Returns 4  (Integer)

            // 符号
            eval.EvaluateSymbol += Eval_EvaluateSymbol;
            v = eval.Evaluate("two + two");            // Returns 4  (Integer)
            v = eval.Evaluate("two + three * five");   // Returns 17 (Integer)
            v = eval.Evaluate("(two + three) * five"); // Returns 25 (Integer)

            // 方程
            eval.EvaluateFunction += Eval_EvaluateFunction;
            v = eval.Evaluate("add(2, 2)");               // Returns 4  (Integer)
            v = eval.Evaluate("2 + multiply(3, 5)");      // Returns 17 (Integer)
            v = eval.Evaluate("multiply(add(2, 3), 5)");  // Returns 25 (Integer)
        }

        private void Eval_EvaluateSymbol(object sender, SymbolEventArgs e)
        {
            switch (e.Name.ToUpper())
            {
                case "TWO":
                    e.Result.SetValue(2);
                    break;
                case "THREE":
                    e.Result.SetValue(3);
                    break;
                case "FIVE":
                    e.Result.SetValue(5);
                    break;
                default:
                    e.Status = SymbolStatus.UndefinedSymbol;
                    break;
            }
        }

        private void Eval_EvaluateFunction(object sender, FunctionEventArgs e)
        {
            switch (e.Name.ToUpper())
            {
                case "ADD":
                    if (e.Parameters.Length == 2)
                        e.Result.SetValue(e.Parameters[0] + e.Parameters[1]);
                    else
                        e.Status = FunctionStatus.WrongParameterCount;
                    break;
                case "MULTIPLY":
                    if (e.Parameters.Length == 2)
                        e.Result.SetValue(e.Parameters[0] * e.Parameters[1]);
                    else
                        e.Status = FunctionStatus.WrongParameterCount;
                    break;
                default:
                    e.Status = FunctionStatus.UndefinedFunction;
                    break;
            }
        }
    }
}