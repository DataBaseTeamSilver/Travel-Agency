namespace TravelAgencyUI
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TravelAgency.Logic;
    using TravelAgency.Model;

    public partial class FirstPage : Form
    {
        public List<Destination> destinations = new List<Destination>();
        public FirstPage()
        {
            this.InitializeComponent();
        }

        private void Button4Click(object sender, System.EventArgs e)
        {
        }

        private void LoadXmlFromZip(object sender, System.EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = this.openFileDialog1.InitialDirectory + this.openFileDialog1.FileName;
                ReadExcelFromZip excelReader = new ReadExcelFromZip();
                destinations = excelReader.SelectExcelFilesFromZip(path);
                HideLoadDataButtons();
                button7.Show();
            }
        }

        private void ShowImportButtons()
        {
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
        }

        private void HideLoadDataButtons()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var import = new ImportToSQL();
            import.ImportFromExcelToSQL(destinations);
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}