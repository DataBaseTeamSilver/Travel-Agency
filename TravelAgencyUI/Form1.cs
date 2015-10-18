namespace TravelAgency.UI
{
    using System;
    using System.Windows.Forms;
    using Data;
    using Logic;
    using Model;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.FillDropbox();
        }

        private void FillDropbox()
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            DropboxInport inport = new DropboxInport(dbContext);

            this.comboBox1.DataSource = inport.GetDestination();
            this.comboBox2.DataSource = inport.GetGuides();
            this.comboBox3.DataSource = inport.GetTransports();
            //this.comboBox1.AutoCompleteSource = listToInport;
        }

        private void SaveDataFromExcelToSQLButtonHandler(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = this.openFileDialog1.InitialDirectory + this.openFileDialog1.FileName;
                ReadExcelFromZip excelReader = new ReadExcelFromZip();
                excelReader.SelectExcelFilesFromZip(path);
            }
        }

        private void GeneratePdfButtonHandler(object sender, EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            PdfGenerator pdfGenerator = new PdfGenerator();

            pdfGenerator.GeneratePdfReports(dbContext);
        }

        private void GenerateXmlButtonHandler(object sender, EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            XMLGenerator xmlGenerator = new XMLGenerator();

            var cb1Value = this.comboBox1.SelectedValue.ToString();
            var cb2Value = this.comboBox2.SelectedValue.ToString();
            var cb3Value = this.comboBox3.SelectedValue.ToString();
            xmlGenerator.XmlGenerate(dbContext, cb1Value, cb2Value, cb3Value);
        }

        private void GenerateDataFromXmlButtonHandler(object sender, EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            ReadFromXml xmlReader = new ReadFromXml();

            xmlReader.ImportFromXmlIntoSql(dbContext);
        }
    }
}