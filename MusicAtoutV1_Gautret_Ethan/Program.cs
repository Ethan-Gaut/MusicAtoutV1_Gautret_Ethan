using MusicAtoutV1_Gautret_Ethan.Models;

namespace MusicAtoutV1_Gautret_Ethan
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
            ModelProjet.init();
            Application.Run(new FConnexion());
        }
    }
}