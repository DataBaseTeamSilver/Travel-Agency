namespace TravelAgency.UI
{
    using System;
    using System.Windows.Forms;
    using Data;
<<<<<<< HEAD
    using TravelAgencyUI;
    using System.Linq;
=======
    using Model;
    using System.Data.Entity;
    using Data.Migrations;
    using XMLGenerator;
>>>>>>> origin/master

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            ////Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());
            ////var db = new TravelAgencyDbContext();

            ////db.SaveChanges();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
