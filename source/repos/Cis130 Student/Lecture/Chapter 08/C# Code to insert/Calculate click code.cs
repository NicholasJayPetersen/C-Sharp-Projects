            if (IsValidData() == false)
                return;
                
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