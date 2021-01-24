using Grapecity.Internship.Assignments.CalculatorWinForm.Controls;
using System;
using System.Windows.Forms;

namespace Grapecity.Internship.Assignments.CalculatorWinForm
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
            Application.Run(new CalculatorForm() );
        }
    }
}
