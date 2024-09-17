	    // Declare local variables
            decimal decSubtotal;
            decimal decDiscountPercent=.20M;
            decimal decDiscountAmount;
            decimal decInvoiceTotal;

            //Get the input data for subtotal
            decSubtotal=Decimal.Parse(txtInvoiceSubtotal.Text);

            //Perform calculations for Discount Amount and Invoice Total
            decDiscountAmount = decSubtotal * decDiscountPercent;
            decInvoiceTotal = ? - decDiscountAmount;

            //Display output
            lblDiscountAmount.Text = decDiscountAmount.ToString();
            lblInvoiceTotal.Text = ?
             