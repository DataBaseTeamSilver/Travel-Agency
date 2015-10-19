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
    using TravelAgency.Logic.MySQL;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());

            var db = new TravelAgencyDbContext();


            var importer = new MySqlImporter();
            importer.UpdateDatabase(db);
            var reader = new ReadFromSQLite();
            var excelReportsToAdd = new ExcelReport(reader);
            var reports = excelReportsToAdd.GenerateReports(db);

            var excelWriter = new WritteDataToExcel();

            excelWriter.WritteDestinationInExcel(reports);
            //var reader = new ReadFromSQLite();
            //reader.ReadDataFromSQLLite();

            //var test = new CreateSampleExcursions();
            //test.AddRandomNumberOfExcursion(200);
        }        
    }
}
