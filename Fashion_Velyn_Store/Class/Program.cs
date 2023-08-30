using System;
using System.Windows.Forms;

namespace Fashion_Velyn_Store.Class
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());
            //Application.Run(new Main());
        }
    }
}
