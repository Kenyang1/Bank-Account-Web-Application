using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            // Set the default text rendering for the application

            Application.SetCompatibleTextRenderingDefault(false);
            // Initial balance for the account
            decimal balance = 0;

            // Run the application with the MainForm
            Application.Run( new MainForm());
        }
    }
}
