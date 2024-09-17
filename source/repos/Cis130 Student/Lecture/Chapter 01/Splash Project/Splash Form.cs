namespace Splash_Project
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrExit_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
