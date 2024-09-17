namespace NA_Assignement_Nicholas_Petersen
{
    public partial class frmNA : Form
    {
        public frmNA()
        {
            InitializeComponent();
        }


        private void tmrWorld_Tick(object sender, EventArgs e)
        {
            lblHelloWorld.Visible = true;
        }

        private void tmrName_Tick(object sender, EventArgs e)
        {
            lblName.Visible = true;
        }

        private void tmrFood_Tick(object sender, EventArgs e)
        {
            lblFood.Visible = true;
        }

        private void tmrExit_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Visible = true;
            lblName.Visible = true;
            lblFood.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Visible = false;
            lblName.Visible = false;
            lblFood.Visible = false;
        }
    }
   
}
