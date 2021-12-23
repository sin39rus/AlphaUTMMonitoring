using AlphaUTMMon.Forms;
using AMcore.Core;

namespace AlphaUTMMon
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
#if DEBUG
            Application.Run(new MainForm(new BL(new DataBaseMock())));
#else
            throw new NotImplementedException();
#endif
        }
    }
}