using Produtos_Agrícolas.Classes;
using Produtos_Agrícolas.Telas;

namespace Produtos_Agrícolas
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
            Application.Run(Menu.menu);
        }
    }
}