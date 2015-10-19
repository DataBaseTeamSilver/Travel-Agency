namespace TravelAgencyUI
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Xml;
    using TravelAgency.Data;
    using TravelAgency.Logic;
    using TravelAgency.Logic.Dropbox;
    using TravelAgency.Logic.ImportData;
    using TravelAgency.Logic.MySQL;
    using TravelAgency.Model;

    public partial class FirstPage : Form
    {
        private IEnumerable<Destination> destinations = new List<Destination>();
        private IEnumerable<Guide> guides = new List<Guide>();

        public FirstPage()
        {
            this.InitializeComponent();
            this.FillDropbox();
        }

        private void ReadExcelFromZip(object sender, System.EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = this.openFileDialog1.InitialDirectory + this.openFileDialog1.FileName;
                ReadExcelFromZip excelReader = new ReadExcelFromZip();
                this.destinations = excelReader.SelectExcelFilesFromZip(path);
                this.HideLoadDataButtons();
                this.ShowImportLabel();
                importFromExcelToSqlButton.Show();
                this.backButton.Visible = true;
            }
        }

        private void ImportExcelDataToSql(object sender, EventArgs e)
        {
            try
            {
                var import = new ImportDestinationsToSQL();
                import.ImportDataToSQL(this.destinations);
                MessageBox.Show("Excel data loaded to SQL successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Excel data couldn't be loaded to SQL!");
            }
        }

        private void ReadFromXML(object sender, System.EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            ReadFromXml xmlReader = new ReadFromXml();
            this.guides = xmlReader.ImportFromXmlIntoSql("../../../Data files/Guides.xml");
            this.HideLoadDataButtons();
            importFormXmlToSqlButton.Show();
            loadFromXmlToMongoDbButton.Show();
            this.backButton.Visible = true;
        }

        private void ImportFromXmlToSql(object sender, EventArgs e)
        {
            try
            {
                ImportToSQL inputNewGuides = new ImportGuidesToSQL();
                inputNewGuides.ImportDataToSQL(this.guides);
                MessageBox.Show("XML data loaded to SQL successfull!");
            }
            catch (Exception)
            {
                MessageBox.Show("XML data couldn't be loaded to SQL!");
            }
        }

        private void ImportFromXmlToMongo(object sender, EventArgs e)
        {
            try
            {
                var mongoGenerator = new MongoDBGenerator();
                mongoGenerator.InputGuides(this.guides);
                MessageBox.Show("XML data loaded successfully to MongoDb!");
            }
            catch (Exception)
            {
                MessageBox.Show("XML data couldn't be loaded to MongoDb!");
            }
        }

        private void ReadFromMongoDb(object sender, EventArgs e)
        {
            this.HideLoadDataButtons();
            importFromMongoDbToSqlButton.Show();
            this.backButton.Visible = true;
        }

        private void ImportFromMongoToSQL(object sender, EventArgs e)
        {
            try
            {
                var travelAgency = new TravelAgencyDbContext();
                var transports = new MongoDBImporter();
                transports.ImportData(travelAgency);
                MessageBox.Show("The data from MongoDb was successfully loaded to SQL!");
            }
            catch (Exception)
            {
                MessageBox.Show("The data from MongoDb couldn't be loaded to SQL!");
            }
        }

        private void ReadFromSQL(object sender, EventArgs e)
        {
            this.HideLoadDataButtons();
            importFromSqlToPdfButton.Visible = true;
            importFromSqlToXmlButton.Visible = true;
            importFromSqlToJsonButton.Visible = true;
            destinationsComboBox.Visible = true;
            guidesComboBox.Visible = true;
            transportsComboBox.Visible = true;
            this.backButton.Visible = true;
        }

        private void FillDropbox()
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            DropboxImport inport = new DropboxImport(dbContext);

            this.destinationsComboBox.DataSource = inport.GetDestination();
            this.guidesComboBox.DataSource = inport.GetGuides();
            this.transportsComboBox.DataSource = inport.GetTransports();
            ////this.comboBox1.AutoCompleteSource = listToInport;
        }

        private void ImportFromSqlToXml(object sender, EventArgs e)
        {
            TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
            XMLGenerator xmlGenerator = new XMLGenerator();
            this.GenerateXmlButtonHandler(sender, e);
        }

        private void GenerateXmlButtonHandler(object sender, EventArgs e)
        {
            try
            {
                TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
                XMLGenerator xmlGenerator = new XMLGenerator();

                var cb1Value = this.destinationsComboBox.SelectedValue.ToString();
                var cb2Value = this.guidesComboBox.SelectedValue.ToString();
                var cb3Value = this.transportsComboBox.SelectedValue.ToString();
                xmlGenerator.XmlGenerate(dbContext, cb1Value, cb2Value, cb3Value);
                MessageBox.Show("XML document was generated successfully with the data from SQL!");
            }
            catch (Exception)
            {
                MessageBox.Show("XML document couldn't be generated!");
            }
        }

        private void ImportFromSqlToPdf(object sender, EventArgs e)
        {
            try
            {
                TravelAgencyDbContext dbContext = new TravelAgencyDbContext();
                PdfGenerator pdfGenerator = new PdfGenerator();
                pdfGenerator.GeneratePdfReports(dbContext);
                MessageBox.Show("PDF report  was successfully generated with the data from SQL!");
            }
            catch (Exception)
            {
                MessageBox.Show("PDF report couldn't be generated!");
            }
        }

        private void ImportFromSqlToJson(object sender, EventArgs e)
        {
            try
            {
                var exporter = new JsonGenerator();
                exporter.GenerateJsonFiles();
                MessageBox.Show("JSON report was successfully generated with the data from SQL!");
            }
            catch (Exception)
            {
                MessageBox.Show("JSON report couldn't be generated!");
            }
        }

        private void ReadFromMySqlAndSQLite(object sender, EventArgs e)
        {
            this.HideLoadDataButtons();
            importToExcelButton.Visible = true;
            this.backButton.Visible = true;
        }

        private void ImportFromMySqlAndSqliteToExcel(object sender, EventArgs e)
        {
            try
            {
                var db = new TravelAgencyDbContext();
                var reader = new ReadFromSQLite();
                var excelReportsToAdd = new ExcelReport(reader);
                var reports = excelReportsToAdd.GenerateReports(db);
                var excelWriter = new WritteDataToExcel();
                excelWriter.WritteDestinationInExcel(reports);
                MessageBox.Show("Excel report was succesfully generated with the data from MySQL and SQLite1");
            }
            catch (Exception)
            {
                MessageBox.Show("Excel report couldn't be generated!");
            }
        }

        private void AddExcursions(object sender, EventArgs e)
        {
            var excursionsGenerator = new CreateSampleExcursions();
            excursionsGenerator.AddFirstTenExcursions();

            MessageBox.Show("Added 10 Excursion to the Database");
        }

        private void Add1000RandomExcursions(object sender, EventArgs e)
        {
            var excursionsGenerator = new CreateSampleExcursions();
            excursionsGenerator.AddRandomNumberOfExcursion(1000);

            MessageBox.Show("Added 1000 Random Excursion to the Database");
        }

        private void ShowImportLabel()
        {
            label1.Visible = true;
        }

        private void HideLoadDataButtons()
        {
            excelZipButton.Visible = false;
            exportFromMngoDbButton.Visible = false;
            exportFromSqlServerButton.Visible = false;
            exportXmlFileButton.Visible = false;
            readFromMySqlAndSqliteButton.Visible = false;
            loadDataLabel.Visible = false;
            label1.Visible = true;
        }

        private void ShowAllLoadButtons()
        {
            excelZipButton.Visible = true;
            exportFromMngoDbButton.Visible = true;
            exportFromSqlServerButton.Visible = true;
            exportXmlFileButton.Visible = true;
            readFromMySqlAndSqliteButton.Visible = true;
            loadDataLabel.Visible = true;
            label1.Visible = false;
            this.backButton.Visible = false;
        }

        private void HideAllImportButtons()
        {
            importFormXmlToSqlButton.Visible = false;
            importFromExcelToSqlButton.Visible = false;
            importFromMongoDbToSqlButton.Visible = false;
            importFromSqlToJsonButton.Visible = false;
            importFromSqlToPdfButton.Visible = false;
            importFromSqlToXmlButton.Visible = false;
            importToExcelButton.Visible = false;
            loadFromXmlToMongoDbButton.Visible = false;
            destinationsComboBox.Visible = false;
            guidesComboBox.Visible = false;
            transportsComboBox.Visible = false;
            label1.Visible = false;
            loadDataLabel.Visible = true;
        }

        private void Back(object sender, EventArgs e)
        {
            this.ShowAllLoadButtons();
            this.HideAllImportButtons();
        }
    }
}
