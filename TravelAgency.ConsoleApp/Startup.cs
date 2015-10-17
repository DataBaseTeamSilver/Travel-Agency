namespace TravelAgency.ConsoleApp
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;
    using Model;
    using System.Data.OleDb;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Logic;

    public class Startup
    {
        public static void Main()
        {
            var test = new JsonExporter();
            test.GenerateJsonFiles();

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());
            var db = new TravelAgencyDbContext();
            /*
            var transport = new Transport
            {
                CompanyName = "Lufthansa",
                Type = TransportType.Airplane
            };

            db.Transports.Add(transport);

            db.SaveChanges();
            
            var destinations = db.Destinations.ToList();

            Console.WriteLine(destinations.Count);

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Destinations.xlsx;Extended Properties='Excel 12.0 xml;HDR=Yes';";

            OleDbConnection dbConn = new OleDbConnection(connectionString);

            using (dbConn)
            {
                dbConn.Open();
                WritteDestinationsToExel(dbConn, destinations);
            }   
            */
        }

        private static void WritteDestinationsToExel(OleDbConnection dbConn, List<Destination> destinations)
        {
            var excelSchema = dbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();
            Console.WriteLine("Writting data...");

            foreach (var item in destinations)
            {
                var insertCommand = new OleDbCommand(@"INSERT INTO [" + sheetName + "] ([Country], [Distance], [LuxuryFactor]) VALUES (@country, @distance, @luxuryFactor)", dbConn);
                insertCommand.Parameters.AddWithValue("@country", item.Country);
                insertCommand.Parameters.AddWithValue("@distance", item.Distance);
                insertCommand.Parameters.AddWithValue("@luxuryFactor", item.LuxuryFactor);
                insertCommand.ExecuteNonQuery();
            }           
        }
    }
}
