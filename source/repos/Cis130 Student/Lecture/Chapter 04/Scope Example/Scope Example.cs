using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scope_Example
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            int intSales = 500;

            lblSales.Text = intSales.ToString();
        }

        private void btn3Percent_Click(object sender, EventArgs e)
        {


            decimal decCommissionAmount;

            //Compute 3% commission
            decCommissionAmount = intsales * .03;

            //display commission amount
            lblCommissionAmount.Text = decCommissionAmount.ToString();


        }

        private void btn5Percent_Click(object sender, EventArgs e)
        {
            decimal decCommissionAmount;

            //Compute 5% commission
            decCommissionAmount = intsales * .05;

            //display commission amount
            lblCommissionAmount.Text = decCommissionAmount.ToString();
        }
    }
}
