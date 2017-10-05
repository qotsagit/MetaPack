using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetaPack.Views;
using System.Globalization;
using System.Threading;

namespace MetaPack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            CultureInfo ci = new CultureInfo("en-GB");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
