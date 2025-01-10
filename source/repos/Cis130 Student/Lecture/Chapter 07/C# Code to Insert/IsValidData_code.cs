
            bool success = true;
            string errorMessage = "";

            // Validate the Monthly Investment text box - decimal and within 1 to 1,000
            errorMessage += IsDecimal(txtMonthlyInvestment.Text, "Monthly investment");
            errorMessage += IsWithinRange(txtMonthlyInvestment.Text, "Monthly investment", ?, ?);

            // Validate the Yearly Interest Rate text box - decimal and within 1 to 20
            errorMessage += IsDecimal(txtInterestRate.Text, "Interest rate");
            errorMessage += IsWithinRange(txtInterestRate.Text, "Interest rate", ?, ?);

            // Validate the Number of Years text box - integer within 1 to 40
            

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return ?;
                