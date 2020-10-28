using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundSwitcher
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
            var app = new BackgroundSwitcher();
            app.Run(Environment.GetCommandLineArgs());
        }
    }
    public class BackgroundSwitcher : WindowsFormsApplicationBase {
        protected override void OnCreateMainForm() {
            MainForm = new MainForm();
        }
        protected override void OnCreateSplashScreen() {
            SplashScreen = new Splash();
        }
    }
}
