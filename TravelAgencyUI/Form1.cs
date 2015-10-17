namespace TravelAgency.UI
{
    using System;
    using System.Windows.Forms;
    using Data;
    using Logic;

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
                var path = this.openFileDialog1.InitialDirectory + this.openFileDialog1.FileName;
                ReadExcelFromZip excelReader = new ReadExcelFromZip();
                excelReader.SelectExcelFilesFromZip(path);
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            PdfGenerator pdfGenerator = new PdfGenerator();

            pdfGenerator.GeneratePdfReports(dbContext);
        }

        private void Button3Click(object sender, EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            XMLGenerator xmlGenerator = new XMLGenerator();

            xmlGenerator.XmlGenerate(dbContext);
        }
    }
}