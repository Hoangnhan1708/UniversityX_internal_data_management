using ExecuteSQLFromFile;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Data Source=localhost;User Id=QLBanHang;Password=12345;DBA Privilege=SYSDBA;";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Home_Form(connectionString));
        }
    }
}