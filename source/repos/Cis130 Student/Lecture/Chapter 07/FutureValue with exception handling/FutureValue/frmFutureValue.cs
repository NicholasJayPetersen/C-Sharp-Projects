﻿using Microsoft.VisualBasic;
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
            try
            {
                decimal monthlyInvestment =
                    Convert.ToDecimal(txtMonthlyInvestment.Text);
                decimal yearlyInterestRate =
                    Convert.ToDecimal(txtInterestRate.Text);
                int years = Convert.ToInt32(txtYears.Text);

                decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                int months = years * 12;

                decimal futureValue = CalculateFutureValue(
                    monthlyInvestment, monthlyInterestRate, months);
                lblFutureValue.Text = futureValue.ToString("c");
                txtMonthlyInvestment.Focus();
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for all entries", "Error");
            }

            catch (OverflowException)
            {
                MessageBox.Show("Please enter a smaller number.", "Error");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, ex.Message.GetType().ToString());
            }



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
