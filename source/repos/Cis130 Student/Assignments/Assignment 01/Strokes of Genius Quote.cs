using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_01
{
    public partial class frmStrokesOfGeniusQuote : Form

    {
        //declare unchanging values as constants
        const decimal BRUSH_COST = 11.50m;
        const decimal FINISH_PAINT_COST = 54m;
        const decimal PRIMTER_PAINT_COST = 35.50m;
        const decimal TRIM_TAPE_COST = 5.60m;
        const decimal SENIOR_HOURS_COST = 30m;
        const decimal JUNIOR_HOURS_COST = 17.50m;
        const decimal SALES_TAX = 0.065m;


        public frmStrokesOfGeniusQuote()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            //parse form data to integer type
            int intBrushes; int.TryParse(txtBrushes.Text, out intBrushes);
            int intFinishPaint; int.TryParse(txtFinishPaint.Text, out intFinishPaint);
            int intPrimerPaint; int.TryParse(txtPrimerPaint.Text, out intPrimerPaint);
            int intTrimTape; int.TryParse(txtTrimTape.Text, out intTrimTape);
            int intSeniorHours; int.TryParse(txtSeniorHours.Text, out intSeniorHours);
            int intJuniorHours; int.TryParse(txtJuniorHours.Text, out intJuniorHours);

            decimal subtotal;
            decimal tax;
            decimal labor;
            decimal total;

            //calculate
            subtotal = Math.Round((intBrushes * BRUSH_COST) + (intFinishPaint * FINISH_PAINT_COST) +
                        (intPrimerPaint * PRIMTER_PAINT_COST) + (intTrimTape * TRIM_TAPE_COST), 2);

            tax = Math.Round(subtotal * SALES_TAX, 2);
            labor = Math.Round((intSeniorHours * SENIOR_HOURS_COST) + (intJuniorHours * JUNIOR_HOURS_COST), 2);
            total = Math.Round(subtotal + tax + labor, 2);

            //output the results
            lblSupplies.Text = subtotal.ToString();
            lblSalesTax.Text = tax.ToString();
            lblLabor.Text = labor.ToString();
            lblTotal.Text = total.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //emtpy out text boxes
            txtCustomerName.Text = "";
            txtCustomerAddr.Text = "";
            txtBrushes.Text = "";
            txtFinishPaint.Text = "";
            txtPrimerPaint.Text = "";
            txtTrimTape.Text = "";
            txtSeniorHours.Text = "";
            txtJuniorHours.Text = "";
            txtQuoteBreakdown.Text = "";
            lblSupplies.Text = "";
            lblSalesTax.Text = "";
            lblLabor.Text = "";
            lblTotal.Text = "";

            //set cursor to first input
            txtCustomerName.Focus();

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //Clear the labels for the results group
            lblSupplies.Text = "";
            lblSalesTax.Text = "";
            lblLabor.Text = "";
            lblTotal.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the app
            this.Close();
        }

        private void frmStrokesOfGeniusQuote_Load(object sender, EventArgs e)
        {
            this.Text = "Quote - Strokes Of Genius";
        }
    }
}
