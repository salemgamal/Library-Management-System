
using Library.DataAccess.Models;
using Library.Presentation.Forms.Authentication_Forms;
using Library.Presentation.Forms.Librarian_Forms;

namespace Library.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Welcome());
        }
    }
}