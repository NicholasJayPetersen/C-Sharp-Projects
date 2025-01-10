using System.Drawing.Printing;
using System.Drawing.Text;
namespace Assignment_02
{
    public partial class frmGarageSales : Form
    {   // class level variables
        string strSubdivision;

        public frmGarageSales()
        {
            InitializeComponent();
        }

        decimal decAgeInYears;
        decimal decCondition;
        decimal decOriginalPrice;
        decimal decDiscountRate;
        decimal decDiscountAmount;
        decimal decSalesTax;
        decimal decSubtotal;
        decimal decTotal;
        int intQuantity;
        string strPaymentType;
        List<string> lstLineItems = new List<string>();
        int intLoopCount;

        const decimal TAX_RATE = 0.06m;
        const decimal AGE_OR_COND_DISCOUNT = 0.20m;
        const decimal CLOTHING_DISCOUNT = 0.10m;
        const decimal CASH_DISCOUNT = 0.05m;

        private void frmGarageSales_Load(object sender, EventArgs e)
        {
            InputBoxForm.InputBox("Subdivision", "Enter the subdivision: ", ref strSubdivision);
            this.Text = "Garage Sale - " + strSubdivision;

            lstItemCategory.Items.Add("Electronics");
            lstItemCategory.Items.Add("Clothing");
            lstItemCategory.Items.Add("Furniture");
            lstItemCategory.Items.Add("Games");
            lstItemCategory.Items.Add("Tools");
            lstItemCategory.SelectedIndex = 1;

            rdoCash.Checked = true;

            txtFirstName.Focus();
        }

        private void tolbtnClearForm_Click(object sender, EventArgs e)
        {
            //Clear accumulators after coding the calculate button
            txtFirstName.Clear();
            txtLastName.Clear();
            txtOriginalPrice.Clear();
            txtQuantity.Clear();
            txtTransactions.Clear();

            lstItemCategory.SelectedIndex = 1;

            rdoCard.Checked = true;
            nudAgeInYears.Value = 1;
            nudCondition.Value = 1;

            stplblClothingTotalSales.Text = "0.00";
            stplblElectronicsTotalSales.Text = "0.00";
            stplblFurnitureTotalSales.Text = "0.00";
            stplblTotalGameSales.Text = "0.00";
            stplblTotalToolSales.Text = "0.00";

            decAgeInYears = 0;
            decCondition = 0;
            decOriginalPrice = 0;
            decDiscountRate = 0;
            decDiscountAmount = 0;
            decSalesTax = 0;
            decSubtotal = 0;
            decTotal = 0;
            intQuantity = 0;
            strPaymentType = "";
            intLoopCount = 0;
        }

        private void tolbtnCalculate_Click(object sender, EventArgs e)
        {
            //Pull Values from form and parse if needed
            decimal.TryParse(txtOriginalPrice.Text, out decOriginalPrice);
            int.TryParse(txtQuantity.Text, out intQuantity);
            decAgeInYears = nudAgeInYears.Value;
            decCondition = nudCondition.Value;
            if (rdoCash.Checked)
            {
                strPaymentType = "Cash";
            }
            else
            {
                strPaymentType = "Card";
            }

            //Determine dicount rate using descion statements
            if (decAgeInYears > 10 || decCondition < 5)
            {
                decDiscountRate = AGE_OR_COND_DISCOUNT;
            }

            if (lstItemCategory.Text == "Clothing")
            {
                decDiscountRate += CLOTHING_DISCOUNT;
            }
            if (strPaymentType == "Cash")
            {
                decDiscountRate += CASH_DISCOUNT;
            }

            //Calculate the category totals
            decDiscountAmount= decOriginalPrice * intQuantity - decDiscountRate;
            decSubtotal = decDiscountAmount + decSubtotal;
            decSalesTax = decSubtotal * TAX_RATE;
            decTotal = Math.Round(decSubtotal + decSalesTax, 2);

            //Accumulate by category. Take the old category total and add the new total. Then udpate the text field.
            decimal decOldTotal;
            switch (lstItemCategory.Text)
            {
                case "Electronics":
                    decimal.TryParse(stplblElectronicsTotalSales.Text, out decOldTotal);
                    stplblElectronicsTotalSales.Text = (decOldTotal + decTotal).ToString();
                    break;
                case "Clothing":
                    decimal.TryParse(stplblClothingTotalSales.Text, out decOldTotal);
                    stplblClothingTotalSales.Text = (decOldTotal + decTotal).ToString();
                    break;
                case "Furniture":
                    decimal.TryParse(stplblFurnitureTotalSales.Text, out decOldTotal);
                    stplblFurnitureTotalSales.Text = (decOldTotal + decTotal).ToString();
                    break;
                case "Games":
                    decimal.TryParse(stplblTotalGameSales.Text, out decOldTotal);
                    stplblTotalGameSales.Text = (decOldTotal + decTotal).ToString();
                    break;
                case "Tools":
                    decimal.TryParse(stplblTotalToolSales.Text, out decOldTotal);
                    stplblTotalToolSales.Text = (decOldTotal + decTotal).ToString();
                    break;

            }
            //Update transaction box
            //add new items to list
            lstLineItems.Add("Category: " + lstItemCategory.Text + " Age: " + nudAgeInYears.Value + " Condition: " + nudCondition.Value);
            lstLineItems.Add("The original Price is $" + txtOriginalPrice.Text + " with a quanitity of " + txtQuantity.Text + ". Special discounts recieved: " + (decDiscountRate * 100) + "%");
            lstLineItems.Add("Paid with " + strPaymentType + " in the amount of $" + Math.Round((decSubtotal + decSalesTax), 2));

            
            //get current items in the transaction box
            string[] arrTransactions = txtTransactions.Lines;

            //put new transactions in a separate array
            string[] arrNewTransactions = lstLineItems.ToArray();
            string[] arrCombined = arrTransactions.Concat(arrNewTransactions).ToArray();

            //output text to textbox
            txtTransactions.Lines = arrCombined;

            //clear the list for the next transaction
            lstLineItems.Clear();

            //increment loop counter so underline will appear when name is changed
            intLoopCount++;

        }

        //use text changed event to handle multiple customers by updating the first item in the list when name changed
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lstLineItems.Clear();

            //adds an underscore if not the first time clicking calculate
            //adds transation details header line
            if (intLoopCount > 0)
            {
                lstLineItems.Add("_");
                lstLineItems.Add("");
                lstLineItems[1] = txtFirstName.Text + " " + txtLastName.Text + "'s Transcation Details:";
            }

            else
            {
                lstLineItems.Add("");
                lstLineItems[0] = txtFirstName.Text + " " + txtLastName.Text + "'s Transcation Details:";
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lstLineItems.Clear();

            //adds an underscore if not the first time clicking calculate
            //adds transation details header line
            if (intLoopCount > 0)
            {
                lstLineItems.Add("_");
                lstLineItems.Add("");
                lstLineItems[1] = txtFirstName.Text + " " + txtLastName.Text + "'s Transcation Details:";
            }

            else
            {
                lstLineItems.Add("");
                lstLineItems[0] = txtFirstName.Text + " " + txtLastName.Text + "'s Transcation Details:";
            }
        }

        private void tolbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
