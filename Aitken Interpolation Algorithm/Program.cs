using System;
using System.Windows.Forms;

namespace Aitken_Interpolation_Algorithm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Graph());
        }
    }
}
