namespace Assignment_01
{
    partial class frmStrokesOfGeniusQuote
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
            txtCustomerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCustomerAddr = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtTrimTape = new TextBox();
            label5 = new Label();
            txtPrimerPaint = new TextBox();
            label4 = new Label();
            txtFinishPaint = new TextBox();
            label3 = new Label();
            txtBrushes = new TextBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            txtJuniorHours = new TextBox();
            label12 = new Label();
            txtSeniorHours = new TextBox();
            txtQuoteBreakdown = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            lblTotal = new Label();
            label17 = new Label();
            lblLabor = new Label();
            label15 = new Label();
            lblSalesTax = new Label();
            label13 = new Label();
            lblSupplies = new Label();
            label8 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(166, 22);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(539, 29);
            txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Customer &name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 61);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer &address:";
            // 
            // txtCustomerAddr
            // 
            txtCustomerAddr.Location = new Point(166, 53);
            txtCustomerAddr.Name = "txtCustomerAddr";
            txtCustomerAddr.Size = new Size(539, 29);
            txtCustomerAddr.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTrimTape);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrimerPaint);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFinishPaint);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBrushes);
            groupBox1.Location = new Point(27, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 184);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paint Supply Quantities";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 141);
            label6.Name = "label6";
            label6.Size = new Size(176, 21);
            label6.TabIndex = 6;
            label6.Text = "&Trim tape (5.60 per roll):";
            // 
            // txtTrimTape
            // 
            txtTrimTape.Location = new Point(251, 141);
            txtTrimTape.Name = "txtTrimTape";
            txtTrimTape.Size = new Size(73, 29);
            txtTrimTape.TabIndex = 7;
            txtTrimTape.TextChanged += TextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 106);
            label5.Name = "label5";
            label5.Size = new Size(226, 21);
            label5.TabIndex = 4;
            label5.Text = "&Primer paint (35.50 per gallon):";
            // 
            // txtPrimerPaint
            // 
            txtPrimerPaint.Location = new Point(251, 106);
            txtPrimerPaint.Name = "txtPrimerPaint";
            txtPrimerPaint.Size = new Size(73, 29);
            txtPrimerPaint.TabIndex = 5;
            txtPrimerPaint.TextChanged += TextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 71);
            label4.Name = "label4";
            label4.Size = new Size(220, 21);
            label4.TabIndex = 2;
            label4.Text = "&Finish paint (54.00 per gallon):";
            // 
            // txtFinishPaint
            // 
            txtFinishPaint.Location = new Point(251, 71);
            txtFinishPaint.Name = "txtFinishPaint";
            txtFinishPaint.Size = new Size(73, 29);
            txtFinishPaint.TabIndex = 3;
            txtFinishPaint.TextChanged += TextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 36);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 0;
            label3.Text = "&Brushes (11.50 per brush):";
            // 
            // txtBrushes
            // 
            txtBrushes.Location = new Point(251, 36);
            txtBrushes.Name = "txtBrushes";
            txtBrushes.Size = new Size(73, 29);
            txtBrushes.TabIndex = 1;
            txtBrushes.TextChanged += TextBox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtJuniorHours);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSeniorHours);
            groupBox2.Location = new Point(399, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 184);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Number of Painters";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 71);
            label11.Name = "label11";
            label11.Size = new Size(186, 21);
            label11.TabIndex = 2;
            label11.Text = "&Junior painters(17.50/hr):";
            // 
            // txtJuniorHours
            // 
            txtJuniorHours.Location = new Point(226, 68);
            txtJuniorHours.Name = "txtJuniorHours";
            txtJuniorHours.Size = new Size(58, 29);
            txtJuniorHours.TabIndex = 3;
            txtJuniorHours.TextChanged += TextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 36);
            label12.Name = "label12";
            label12.Size = new Size(192, 21);
            label12.TabIndex = 0;
            label12.Text = "&Senior painters (30.00/hr):";
            // 
            // txtSeniorHours
            // 
            txtSeniorHours.Location = new Point(226, 28);
            txtSeniorHours.Name = "txtSeniorHours";
            txtSeniorHours.Size = new Size(58, 29);
            txtSeniorHours.TabIndex = 1;
            txtSeniorHours.TextChanged += TextBox_TextChanged;
            // 
            // txtQuoteBreakdown
            // 
            txtQuoteBreakdown.Location = new Point(27, 321);
            txtQuoteBreakdown.Multiline = true;
            txtQuoteBreakdown.Name = "txtQuoteBreakdown";
            txtQuoteBreakdown.Size = new Size(1061, 120);
            txtQuoteBreakdown.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 297);
            label7.Name = "label7";
            label7.Size = new Size(142, 21);
            label7.TabIndex = 7;
            label7.Text = "Project description:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(lblLabor);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(lblSalesTax);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(lblSupplies);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(711, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(377, 184);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Project Quote";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Location = new Point(261, 143);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 35);
            lblTotal.TabIndex = 7;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 152);
            label17.Name = "label17";
            label17.Size = new Size(129, 21);
            label17.TabIndex = 6;
            label17.Text = "Total project cost:";
            // 
            // lblLabor
            // 
            lblLabor.BorderStyle = BorderStyle.FixedSingle;
            lblLabor.Location = new Point(261, 105);
            lblLabor.Name = "lblLabor";
            lblLabor.Size = new Size(104, 35);
            lblLabor.TabIndex = 5;
            lblLabor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 114);
            label15.Name = "label15";
            label15.Size = new Size(85, 21);
            label15.TabIndex = 4;
            label15.Text = "Labor cost:";
            // 
            // lblSalesTax
            // 
            lblSalesTax.BorderStyle = BorderStyle.FixedSingle;
            lblSalesTax.Location = new Point(261, 68);
            lblSalesTax.Name = "lblSalesTax";
            lblSalesTax.Size = new Size(104, 35);
            lblSalesTax.TabIndex = 3;
            lblSalesTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 77);
            label13.Name = "label13";
            label13.Size = new Size(190, 21);
            label13.TabIndex = 2;
            label13.Text = "Paint supplies tax amount:";
            // 
            // lblSupplies
            // 
            lblSupplies.BorderStyle = BorderStyle.FixedSingle;
            lblSupplies.Location = new Point(261, 30);
            lblSupplies.Name = "lblSupplies";
            lblSupplies.Size = new Size(104, 35);
            lblSupplies.TabIndex = 1;
            lblSupplies.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 39);
            label8.Name = "label8";
            label8.Size = new Size(189, 21);
            label8.TabIndex = 0;
            label8.Text = "Subtotal of paint supplies:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(222, 459);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(217, 48);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate &Bid";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(445, 459);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(217, 48);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear Entries";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(668, 459);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(217, 48);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmStrokesOfGeniusQuote
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 519);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox3);
            Controls.Add(label7);
            Controls.Add(txtQuoteBreakdown);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(txtCustomerAddr);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmStrokesOfGeniusQuote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "This.Load Event";
            Load += frmStrokesOfGeniusQuote_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private Label label1;
        private Label label2;
        private TextBox txtCustomerAddr;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtBrushes;
        private Label label6;
        private TextBox txtTrimTape;
        private Label label5;
        private TextBox txtPrimerPaint;
        private Label label4;
        private TextBox txtFinishPaint;
        private GroupBox groupBox2;
        private Label label11;
        private TextBox txtJuniorHours;
        private Label label12;
        private TextBox txtSeniorHours;
        private TextBox txtQuoteBreakdown;
        private Label label7;
        private GroupBox groupBox3;
        private Label lblLabor;
        private Label label15;
        private Label lblSalesTax;
        private Label label13;
        private Label lblSupplies;
        private Label label8;
        private Label lblTotal;
        private Label label17;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
