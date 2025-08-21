using NLua;
using System.Windows;

namespace NLuaDemo
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
            // 创建 Lua 环境
            using var lua = new Lua();
            //lua.State.Encoding = Encoding.UTF8;
            lua.DoString("name = 'BigWang'");
            string name = (string)lua["name"];

            // 创建 Lua 环境
            using Lua state = new Lua();
            // 计算简单表达式
            var v1 = state.DoString("return 1 + 2 * (2 + 3)")[0];
            // 赋值给 Lua
            double val = 12;
            state["x"] = val;
            var res = (double)state.DoString("return 1 + x * (2 + 3)")[0];
            // 检索全局值
            state.DoString(" y = 1 + x * (2 + 3)");
            double y = (double)state["y"];

            // 检索 Lua 函数
            state.DoString(@"
                     function ScriptFunc(val1, val2)
                        if val1 > val2 then
                            return val1 + 1
                        else
                            return val2 - 1
                        end
                     end
                    ");
            var scriptFunc = state["ScriptFunc"] as LuaFunction;
            var re = (long)scriptFunc.Call(3, 5).First();

            // 调用 C# 函数
            Calculator cal = new Calculator();
            state["cal"] = cal;
            state.DoString("res1 = cal:Add(1, 2)");
            var res1 = state["res"];

            // 注册 CLR 对象方法到 Lua
            lua.RegisterFunction("Add", cal, cal.GetType().GetMethod("Add"));
            // 注册 CLR 静态方法到 Lua
            lua.RegisterFunction("HelloLua", null, typeof(Calculator).GetMethod("HelloLua"));
            lua.DoString("res = Add(2, 3)");
            var res2 = lua["res"];
            lua.DoString("HelloLua()");
        }

        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public static void HelloLua()
            {
                MessageBox.Show("Hello, Lua!");
            }
        }
    }
}