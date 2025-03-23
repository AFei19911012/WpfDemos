using System;
using System.Linq;
using System.Windows;

namespace TreeViewEx
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            new Application().Run(new MainWindow());
        }
    }
}
