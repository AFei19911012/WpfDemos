using System.Windows;
using System.Windows.Controls;
using WindowsInput;
using Button = System.Windows.Controls.Button;

namespace InputSimulatorDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InputSimulator Simulator { get; set; } = new InputSimulator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb.Focus();

            string btn = (sender as Button).Content.ToString();
            if (btn.EndsWith("数字"))
            {
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_1);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_2);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_3);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.DECIMAL);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_4);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_5);
            }
            else if (btn.EndsWith("字母"))
            {
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_B);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_I);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_G);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SPACE);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_W);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_A);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_N);
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_G);
            }
            else if (btn.EndsWith("文本"))
            {
                Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                Simulator.Keyboard.TextEntry("Hello, Big Wang");
            }
            else
            {
                Task.Run(() =>
                {
                    Simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                    Simulator.Keyboard.TextEntry("现在，移动鼠标，然后点击左键");

                    Thread.Sleep(1000);

                    
                    Dispatcher.Invoke(() =>
                    {
                        double x = Left + 200;
                        double y = Top + 100;

                        double dh = 65535 / SystemParameters.PrimaryScreenHeight;
                        double dw = 65535 / SystemParameters.PrimaryScreenWidth;

                        Simulator.Mouse.MoveMouseTo(x * dw, y * dh);
                        Simulator.Mouse.RightButtonClick();
                    });
                });
                
            }
        }
    }
}