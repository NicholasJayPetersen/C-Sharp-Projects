using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class frmCoffeeOrder : Form
    {
        public frmCoffeeOrder()
        {
            InitializeComponent();
        }

        const decimal COFFEE_PRICE = 1.10m;
        const decimal DONUT_PRICE = 0.99m;
        const decimal TAX_RATE = 0.06m;

        string strEmployeeName;
        int intDonutQty;
        int intCoffeeQty;
        decimal decSubtotal;
        decimal decTax;
        decimal decTotal;

        private void frmCoffeeOrder_Load(object sender, EventArgs e)
        {
            InputBoxForm.InputBox("Employee", "Enter employee Name:", ref strEmployeeName);
            this.Text = "Order Taken By: " + strEmployeeName;

            lstCoffeeQty.SelectedIndex = 0;
            lstDonutQty.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            lblSubtotal.Text = "";
            lblTaxAmount.Text = "";
            lblTotal.Text = "";
            rdoDeliver.Checked = false;
            rdoPickup.Checked = false;
            lstCoffeeQty.SelectedIndex = 0;
            lstDonutQty.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int.TryParse(lstDonutQty.Text, out intDonutQty);
            int.TryParse(lstCoffeeQty.Text, out intCoffeeQty);

            decSubtotal = (COFFEE_PRICE * intCoffeeQty) + (DONUT_PRICE * intDonutQty);
            decTax = TAX_RATE * decSubtotal;
            decTotal = decTax + decSubtotal;

            lblSubtotal.Text = decSubtotal.ToString("c");
            lblTaxAmount.Text = decTax.ToString("c");
            lblTotal.Text = decTotal.ToString("c");
        }

        private void frmCoffeeOrder_TextChanged(object sender, EventArgs e)
        {
            lblSubtotal.Text = "";
            lblTaxAmount.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
