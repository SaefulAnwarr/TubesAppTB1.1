using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesAppTB1._1
{
    internal static class Program
    {
        public static string gerai = "";
        public static string jnsken = "";
        public static int jmlhban = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPemesananLayanan());
        }
    }
}
