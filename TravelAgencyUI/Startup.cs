namespace TravelAgencyUI
{
    using System;
    using System.Windows.Forms;
    using TravelAgency.Logic;

    public partial class Startup : Form
    {
        public Startup()
        {
            this.InitializeComponent();
        }

        private void EnterWithCreatingDatabase(object sender, EventArgs e)
        {
            var travelAgency = new CreateTravelAgencyDb();
            var result = travelAgency.CreateTravelAgencyDbFromModel();
            MessageBox.Show(result);

            this.Visible = false;
            this.LoadFirstPage();           
        }

        private void EnterWithoutCreatingDatabase(object sender, EventArgs e)
        {
            this.Visible = false;
            this.LoadFirstPage();
        }

        private void LoadFirstPage()
        {
            FirstPage firtsPage = new FirstPage();
            firtsPage.Show();
        }
    }
}
