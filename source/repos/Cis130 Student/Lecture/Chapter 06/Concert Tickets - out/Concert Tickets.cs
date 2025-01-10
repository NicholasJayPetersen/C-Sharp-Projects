using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concert_Tickets___out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //local variables
            const decimal decSTANDARD = 62.50m;      //stanadard ticket price
            const decimal decVIP = 102.75m;          //VIP ticket price
            decimal decDiscount = 0, decSubtotal, decTotalDue;
            int intTickets;


            //make sure a valid integer is entered for tickets
            if (int.TryParse(txtTickets.Text, out intTickets) == true)
            {
                if (radStandard.Checked == true)    //Standard tickets have been selected
                {
                    decSubtotal = intTickets * decSTANDARD;
                }
                else
                {
                    decSubtotal = intTickets * decVIP;
                }

                //Call method to get correct discount amount
                AssignDiscount(intTickets, decSubtotal, ref decDiscount);

                //apply discount to subtotal
                decTotalDue = decSubtotal - decDiscount;


                //display output
                lblSubtotal.Text = decSubtotal.ToString("c");
                lblDiscount.Text = decDiscount.ToString("c");
                lblTotalDue.Text = decTotalDue.ToString("c");
            }
            else
            {
                //invalid input entered for tickets
                MessageBox.Show("Number of tickets is required, please try again.", "Concert Tickets", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTickets.Focus();
                txtTickets.SelectAll();

            }

        }

        private void AssignDiscount(int intNum, decimal decSubtotal, ref decimal decDiscount)
        {
            switch (intNum)
            {
                case 1:
                    decDiscount = decSubtotal * .01m;
                    break;
                case 2:
                    decDiscount = decSubtotal * .01m;
                    break;
                case 3:
                    decDiscount = decSubtotal * .01m;
                    break;
                case 4:
                    decDiscount = decSubtotal * .02m;
                    break;
                case 5:
                    decDiscount = decSubtotal * .02m;
                    break;
                default:
                    decDiscount = decSubtotal * .10m;
                    break;


            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}
