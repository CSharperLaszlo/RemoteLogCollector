namespace RemoteConnectionToLinux
{
   

    public static class Program
    {
        private static MainWindow _instance = new MainWindow();

        public static MainWindow Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }    

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(Instance);
        }
    }
}