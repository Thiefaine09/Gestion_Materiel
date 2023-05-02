using GestionMatériel.Utils;

namespace GestionMatériel
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
            // see https://aka.ms/applicationconfiguration.//

            //class global au projet
            Global.Init = new Initialise();
            //
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPricipale());
        }
    }
}