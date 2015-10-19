namespace TravelAgencyUI
{
    using System.Windows.Forms;
    using TravelAgency.Logic;

    public partial class FirstPage : Form
    {
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
                excelReader.SelectExcelFilesFromZip(path);
            }
        }
    }
}