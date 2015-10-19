namespace TravelAgencyUI
{
    using System;
    using System.Windows.Forms;
    using TravelAgency.Logic;

    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var travelAgency = new CreateTravelAgencyDb();
            var result = travelAgency.CreateTravelAgencyDbFromModel();
            MessageBox.Show(result);
            

            FirstPage firtsPage = new FirstPage();
            firtsPage.Show();
        }

        private void Startup_Load(object sender, EventArgs e)
        {

        }
    }
}
