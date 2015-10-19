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
        public void WritteDestinationInExcel(string[,] reports)
        {
            //string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Destinations.xlsx;Extended Properties='Excel 12.0 xml;HDR=Yes';";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../ExcelFiles/IncomeReports.xlsx;Extended Properties='Excel 12.0 xml;HDR=Yes';";

            var db = new TravelAgencyDbContext();

            var destinations = db.Destinations.ToList();

            OleDbConnection dbConn = new OleDbConnection(connectionString);

            using (dbConn)
            {
                dbConn.Open();
                //CreateExcelFile(dbConn, destinations);
                CreateExcelReports(dbConn, reports);
            }
        }

        private void CreateExcelReports(OleDbConnection dbConn, string[,] reports)
        {
            var excelSchema = dbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();
            var reportCount = reports.GetLength(0);

            for (int i = 0; i < reportCount; i++)
            {
                var currentReportName = reports[i,0];
                var currentReportIncome = reports[i,1];
                var insertCommand = new OleDbCommand(@"INSERT INTO [" + sheetName + "] ([Excursion], [Income]) VALUES (@name, @income)", dbConn);
                insertCommand.Parameters.AddWithValue("@name", currentReportName);
                insertCommand.Parameters.AddWithValue("@income", currentReportIncome);
                insertCommand.ExecuteNonQuery();
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
