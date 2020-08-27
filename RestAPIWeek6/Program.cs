using RestAPILibrary;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPIWeek6
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task  Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Calling the Api
            await GetApiData.MergePage();
            //injecting the dependencied into the form
            Application.Run(new Form1(Config.MyForm));
        }
    }
}
