﻿namespace TravelAgency.UI
{
    using System;
    using System.Windows.Forms;
    using Data;
    using Model;
    using System.Data.Entity;
    using Data.Migrations;
    using XMLGenerator;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());
            var db = new TravelAgencyDbContext();

            db.SaveChanges();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
