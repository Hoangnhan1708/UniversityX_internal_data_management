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
            //string connectionString = "Data Source=localhost;User Id=Hann;Password=Hann;";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            //Application.Run(new SinhVien_Form(connectionString));
            Application.Run(new Login_Form());
        }
    }
}