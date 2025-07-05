using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBody
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tampilkan splash screen terlebih dahulu
            frmSplashScreen splashScreen = new frmSplashScreen();
            splashScreen.ShowDialog();

            frmLogin login = new frmLogin();
            login.ShowDialog();

            frmLoginLoading loginLoading = new frmLoginLoading();
            loginLoading.ShowDialog();

            Application.Run(new frmMain());
        }
    }
}
