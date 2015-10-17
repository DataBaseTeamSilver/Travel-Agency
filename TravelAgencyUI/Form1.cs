namespace TravelAgency.UI
{
    using System;
    using System.Windows.Forms;
    using Logic;
    using Data;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void SaveDataFromExcelToSQL(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DialogResult result1 = MessageBox.Show("Do you want to save the data to SQL?", "Exit", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    var path = this.openFileDialog1.InitialDirectory + this.openFileDialog1.FileName;
                    ReadExcelFromZip excelReader = new ReadExcelFromZip();
                    excelReader.SelectExcelFilesFromZip(path);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void CreatePDFReport(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to create the report?", "Exit", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
                PdfGenerator pdfGenerator = new PdfGenerator();

                pdfGenerator.GeneratePdfReports(dbContext);
            }
            else
            {
                this.Close();
            }
        }
    }
}