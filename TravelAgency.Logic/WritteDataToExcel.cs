namespace TravelAgency.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Linq;

    using Data;
    using Model;

    public class WritteDataToExcel
    {
        public void WritteDestinationInExcel()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Destinations.xlsx;Extended Properties='Excel 12.0 xml;HDR=Yes';";

            var db = new TravelAgencyDbContext();

            var destinations = db.Destinations.ToList();

            OleDbConnection dbConn = new OleDbConnection(connectionString);

            using (dbConn)
            {
                dbConn.Open();
                CreateExcelFile(dbConn, destinations);
            }
        }

        private static void CreateExcelFile(OleDbConnection dbConn, List<Destination> destinations)
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
