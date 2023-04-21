namespace HumanResourcesApplication
{
    internal static class Program
    {

        public static string WorkersFilePath = Path.Combine(Environment.CurrentDirectory, "Workers.txt");
        public static string DepartmentsFilePath = Path.Combine(Environment.CurrentDirectory, "Departments.txt");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}