namespace TravelAgencyUI
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Xml;
    using TravelAgency.Data;
    using TravelAgency.Logic;
    using TravelAgency.Logic.ImportData;
    using TravelAgency.Model;

    public partial class FirstPage : Form
    {
        private IEnumerable<Destination> destinations = new List<Destination>();
        private IEnumerable<Guide> guides = new List<Guide>();

        public FirstPage()
        {
            this.InitializeComponent();
        }

        private void Button4Click(object sender, System.EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            ReadFromXml xmlReader = new ReadFromXml();
            this.guides = xmlReader.ImportFromXmlIntoSql("../../../Data files/Guides.xml");
            HideLoadDataButtons();
            button13.Show();
            button11.Show();
        }

        private void LoadXmlFromZip(object sender, System.EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = this.openFileDialog1.InitialDirectory + this.openFileDialog1.FileName;
                ReadExcelFromZip excelReader = new ReadExcelFromZip();
                this.destinations = excelReader.SelectExcelFilesFromZip(path);
                HideLoadDataButtons();
                ShowImportLabel();
                button7.Show();
            }
        }

        private void ShowImportLabel()
        {
            label1.Visible = true;
        }


        private void HideLoadDataButtons()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            loadDataLabel.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var import = new ImportDestinationsToSQL();
            import.ImportDataToSQL(this.destinations);
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            ImportToSQL inputNewGuides = new ImportGuidesToSQL();
            inputNewGuides.ImportDataToSQL(this.guides);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var mongoGenerator = new MongoDBGenerator();
            mongoGenerator.InputGuides(this.guides);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideLoadDataButtons();
            button8.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var excursionsGenerator = new CreateSampleExcursions();
            excursionsGenerator.AddFirstTenExcursions();

            MessageBox.Show("Added 10 Excursion to the Database");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var excursionsGenerator = new CreateSampleExcursions();
            excursionsGenerator.AddRandomNumberOfExcursion(1000);

            MessageBox.Show("Added 1000 Random Excursion to the Database");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideLoadDataButtons();
            button16.Show();
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var travelAgency = new TravelAgencyDbContext();
            var transports = new MongoDBImporter();
            transports.ImportData(travelAgency);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            PdfGenerator pdfGenerator = new PdfGenerator();

            pdfGenerator.GeneratePdfReports(dbContext);
        }
    }
}
