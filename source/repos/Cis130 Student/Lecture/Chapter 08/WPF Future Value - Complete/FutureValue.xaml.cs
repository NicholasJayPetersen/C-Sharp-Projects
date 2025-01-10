using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Future_Value___Complete
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtMonthlyInvestment.Focus();
        }


        //**********************************************************
        // Value Returning Methods (Functions)
        //**********************************************************
        private bool IsValidData()
        {

            bool success = true;
            string errorMessage = "";

            // Validate the Monthly Investment text box - decimal and within 1 to 1,000
            errorMessage += IsDecimal(txtMonthlyInvestment.Text, "Monthly investment");
            errorMessage += IsWithinRange(txtMonthlyInvestment.Text, "Monthly investment", 1, 1000);

            // Validate the Yearly Interest Rate text box - decimal and within 1 to 20
            errorMessage += IsDecimal(txtInterestRate.Text, "Interest rate");
            errorMessage += IsWithinRange(txtInterestRate.Text, "Interest rate", 1, 20);

            // Validate the Number of Years text box - integer within 1 to 40
            errorMessage += IsInt32(txtYears.Text, "Number of years");
            errorMessage += IsWithinRange(txtYears.Text, "Number of years", 1, 40);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;

        }


        public string IsPresent(string value, string name)
        {
            string msg = "";
            // Check if value is empty
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }

        public string IsDecimal(string value, string name)
        {
            string msg = "";
            //Check if value is a decimal, code discard value for output
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n";
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
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


            lblFutureValue.Content = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }
    }
}