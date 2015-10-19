namespace TravelAgency.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.OleDb;
    using Data;
    using Data.Migrations;
    using Logic;
    using Model;
    using Logic.MySQL;

    public class Startup
    {
        public static void Main()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());

            //var db = new TravelAgencyDbContext();

            var reader = new ReadFromSQLite();
            var t= reader.GetData();
            foreach (var item in t.Keys)
            {
                Console.WriteLine(t[item]);
            }

            //var test = new CreateSampleExcursions();
            //test.AddRandomNumberOfExcursion(200);
        }        
    }
}
