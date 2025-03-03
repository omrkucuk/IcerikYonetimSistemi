using IcerikUretimSistemi.UI.Forms;
using IcerikUretimSistemi.UI.Forms.Controls;
using Microsoft.Build.Framework.Profiler;

namespace IcerikUretimSistemi
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
            Application.Run(new SignUpForm());
        }
    }
}