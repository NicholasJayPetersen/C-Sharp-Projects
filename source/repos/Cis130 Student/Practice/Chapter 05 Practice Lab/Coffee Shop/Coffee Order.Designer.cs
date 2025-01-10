
namespace Coffee_Shop
{
    partial class frmCoffeeOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lstDonutQty = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lstCoffeeQty = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rdoPickup = new System.Windows.Forms.RadioButton();
            rdoDeliver = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            lblSubtotal = new System.Windows.Forms.Label();
            lblTaxAmount = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lblPricing = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnExit = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnCalculate = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(223, 24);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(377, 32);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextChanged += frmCoffeeOrder_TextChanged;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(34, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 31);
            label1.TabIndex = 0;
            label1.Text = "C&ustomer name:";
            // 
            // lstDonutQty
            // 
            lstDonutQty.FormattingEnabled = true;
            lstDonutQty.ItemHeight = 25;
            lstDonutQty.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            lstDonutQty.Location = new System.Drawing.Point(223, 227);
            lstDonutQty.Name = "lstDonutQty";
            lstDonutQty.Size = new System.Drawing.Size(81, 79);
            lstDonutQty.TabIndex = 8;
            lstDonutQty.SelectedIndexChanged += frmCoffeeOrder_TextChanged;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(34, 227);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(183, 31);
            label2.TabIndex = 7;
            label2.Text = "Quantity of &donuts:";
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(330, 227);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(183, 31);
            label3.TabIndex = 9;
            label3.Text = "Quantity of co&ffees:";
            // 
            // lstCoffeeQty
            // 
            lstCoffeeQty.FormattingEnabled = true;
            lstCoffeeQty.ItemHeight = 25;
            lstCoffeeQty.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            lstCoffeeQty.Location = new System.Drawing.Point(519, 227);
            lstCoffeeQty.Name = "lstCoffeeQty";
            lstCoffeeQty.Size = new System.Drawing.Size(81, 79);
            lstCoffeeQty.TabIndex = 10;
            lstCoffeeQty.SelectedIndexChanged += frmCoffeeOrder_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoPickup);
            groupBox1.Controls.Add(rdoDeliver);
            groupBox1.Location = new System.Drawing.Point(225, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(374, 70);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new System.Drawing.Point(220, 21);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new System.Drawing.Size(94, 29);
            rdoPickup.TabIndex = 1;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "&Pick-up";
            rdoPickup.UseVisualStyleBackColor = true;
            rdoPickup.Click += frmCoffeeOrder_TextChanged;
            // 
            // rdoDeliver
            // 
            rdoDeliver.AutoSize = true;
            rdoDeliver.Location = new System.Drawing.Point(29, 21);
            rdoDeliver.Name = "rdoDeliver";
            rdoDeliver.Size = new System.Drawing.Size(98, 29);
            rdoDeliver.TabIndex = 0;
            rdoDeliver.TabStop = true;
            rdoDeliver.Text = "Deliver&y";
            rdoDeliver.UseVisualStyleBackColor = true;
            rdoDeliver.Click += frmCoffeeOrder_TextChanged;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(33, 65);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(160, 31);
            label4.TabIndex = 2;
            label4.Text = "&Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(222, 62);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(377, 32);
            txtAddress.TabIndex = 3;
            txtAddress.TextChanged += frmCoffeeOrder_TextChanged;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(33, 103);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(160, 31);
            label5.TabIndex = 4;
            label5.Text = "Ph&one:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(222, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(377, 32);
            txtPhone.TabIndex = 5;
            txtPhone.TextChanged += frmCoffeeOrder_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(402, 336);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(86, 25);
            label6.TabIndex = 12;
            label6.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblSubtotal.Location = new System.Drawing.Point(513, 335);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new System.Drawing.Size(86, 25);
            lblSubtotal.TabIndex = 13;
            // 
            // lblTaxAmount
            // 
            lblTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTaxAmount.Location = new System.Drawing.Point(513, 372);
            lblTaxAmount.Name = "lblTaxAmount";
            lblTaxAmount.Size = new System.Drawing.Size(86, 25);
            lblTaxAmount.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(402, 373);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 25);
            label8.TabIndex = 14;
            label8.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTotal.Location = new System.Drawing.Point(513, 410);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(86, 25);
            lblTotal.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(402, 411);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(56, 25);
            label9.TabIndex = 16;
            label9.Text = "Total:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPricing);
            groupBox2.Location = new System.Drawing.Point(44, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(297, 132);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pricing";
            // 
            // lblPricing
            // 
            lblPricing.Location = new System.Drawing.Point(21, 29);
            lblPricing.Name = "lblPricing";
            lblPricing.Size = new System.Drawing.Size(258, 87);
            lblPricing.TabIndex = 0;
            lblPricing.Text = "Donuts are .99 a piece       Coffee is $1.10";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnCalculate);
            groupBox3.Location = new System.Drawing.Point(45, 464);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(554, 74);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(448, 21);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(100, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(141, 21);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(100, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(20, 21);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(100, 34);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // frmCoffeeOrder
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(633, 549);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(lblTotal);
            Controls.Add(label9);
            Controls.Add(lblTaxAmount);
            Controls.Add(label8);
            Controls.Add(lblSubtotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(lstCoffeeQty);
            Controls.Add(label2);
            Controls.Add(lstDonutQty);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            Font = new System.Drawing.Font("Segoe UI", 14F);
            Name = "frmCoffeeOrder";
            Text = "Coffee Order Form";
            Load += frmCoffeeOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDonutQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCoffeeQty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPickup;
        private System.Windows.Forms.RadioButton rdoDeliver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPricing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
    }
}

