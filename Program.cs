using System;
using System.Windows.Forms;
using WinFormsApp2;

namespace WinFormsApp2
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}
