using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   
            //do not perform calculations and exit the event if data not valid.
            if(isValid() != true) { return; }
                
                    // Use the input, it has been validated
                    decimal monthlyInvestment =
                        Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate =
                        Convert.ToDecimal(txtInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);
                    

                    lblFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                
            
        }

        public bool isValid()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += IsDecimal(txtMonthlyInvestment.Text, "Monthly Investment");
            errorMessage += IsWithinRange(txtMonthlyInvestment.Text, "Monthly Investment", 1, 1000);

            errorMessage += IsDecimal(txtInterestRate.Text, "Interest Rate");
            errorMessage += IsWithinRange(txtInterestRate.Text, "Interest Rate", 1, 20);

            errorMessage += IsInt32(txtYears.Text, "Years");
            errorMessage += IsWithinRange(txtYears.Text, "Years", 1, 40);

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
                success = false;
                return success;
            }

            return success;
        }


        public string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + "must be a decimal value. \n";
            }

            return msg;
        }
        

        
        public string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }

        public string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment,
           decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
