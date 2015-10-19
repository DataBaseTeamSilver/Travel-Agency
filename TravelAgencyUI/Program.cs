namespace TravelAgency.UI
{
    using System;
    using System.Data.Entity;
    using System.Windows.Forms;
    using Data;
    using Data.Migrations;
    using TravelAgencyUI;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startup());
        }
    }
}
