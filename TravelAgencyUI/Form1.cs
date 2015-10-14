namespace TravelAgency.UI
{
    using System;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.IO.Compression;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void SearchZip(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                var extractPath = "../../../extract";
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
        }

        private void ReadExcelData(OleDbConnection conn, string sheetName)
        {
            Console.WriteLine("Reading data...");
            var excelDbCommand = new OleDbCommand(@"SELECT * FROM [" + sheetName + "]", conn);

            using (var oleDbDataAdapter = new OleDbDataAdapter(excelDbCommand))
            {
                DataSet ds = new DataSet();
                oleDbDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoSize = true;
            }
        }
    }
}