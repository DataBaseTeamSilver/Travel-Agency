namespace TravelAgency.UI
{
    using System;
    using System.Windows.Forms;
    using Data;
    using Model;
    using System.Data.Entity;
    using Data.Migrations;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TarvelAgencyDbContext, Configuration>());
            var db = new TarvelAgencyDbContext();

            db.SaveChanges();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
