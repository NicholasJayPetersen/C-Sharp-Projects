namespace Tina_s_Sales_Forecast_Application
{
    public partial class frmSalesForecast : Form
    {
        public frmSalesForecast()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Clear();
            txtPreviousSales.Clear();
            txtGrowthRate.Clear();
            lblSalesForecast.Text = "";
            txtEmployeeName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPreviousSales_Click(object sender, EventArgs e)
        {

        }

        private void frmSalesForecast_Load(object sender, EventArgs e)
        {

        }
    }
}
