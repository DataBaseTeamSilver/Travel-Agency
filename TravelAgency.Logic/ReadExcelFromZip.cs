namespace TravelAgency.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.IO.Compression;
    using Data;
    using Model;

    public class ReadExcelFromZip
    {
        private static string extractPath = "../../../ExcelFiles";

        public void SelectExcelFilesFromZip(string path)
        {
            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Update))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".xlsx"))
                    {
                        entry.ExtractToFile(Path.Combine(extractPath, entry.Name));
                        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(extractPath, entry.Name) + ";Extended Properties='Excel 12.0 xml;HDR=Yes';";

                        OleDbConnection connection = new OleDbConnection(connectionString);

                        using (connection)
                        {
                            connection.Open();
                            var excelSchema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();

                            this.ReadExcelData(connection, sheetName);
                        }
                    }
                }
            }
        }

        private void ReadExcelData(OleDbConnection conn, string sheetName)
        {
            Console.WriteLine("Reading data...");
            var excelDbCommand = new OleDbCommand(@"SELECT * FROM [" + sheetName + "]", conn);

            using (var oleDbDataAdapter = new OleDbDataAdapter(excelDbCommand))
            {
                DataSet ds = new DataSet();
                oleDbDataAdapter.Fill(ds);
                var destinations = new List<Destination>();
                using (var reader = ds.CreateDataReader())
                {
                    while (reader.Read())
                    {
                        var destination = new Destination();
                        destination.Country = reader["Country"].ToString();
                        destination.Distance = double.Parse(reader["Distance"].ToString());
                        destination.LuxuryFactor = int.Parse(reader["LuxuryFactor"].ToString());
                        destinations.Add(destination);
                    }
                }

                var db = new TravelAgencyDbContext();
                foreach (var destination in destinations)
                {
                    db.Destinations.Add(destination);
                }

                db.SaveChanges();
            }
        }
    }
}