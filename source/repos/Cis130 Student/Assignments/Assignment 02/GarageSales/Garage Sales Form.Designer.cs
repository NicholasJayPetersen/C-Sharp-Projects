namespace Assignment_02
{
    partial class frmGarageSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGarageSales));
            tolCommands = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            tolbtnCalculate = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tolbtnClearForm = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tolbtnExit = new ToolStripButton();
            grpItemCharacteristics = new GroupBox();
            label5 = new Label();
            nudCondition = new NumericUpDown();
            label4 = new Label();
            nudAgeInYears = new NumericUpDown();
            label3 = new Label();
            lstItemCategory = new ListBox();
            grpCustomer = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            grpPurchasing = new GroupBox();
            label9 = new Label();
            rdoCard = new RadioButton();
            label8 = new Label();
            rdoCash = new RadioButton();
            label7 = new Label();
            txtQuantity = new TextBox();
            label6 = new Label();
            txtOriginalPrice = new TextBox();
            txtTransactions = new TextBox();
            staTotals = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            stplblElectronicsTotalSales = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            stplblClothingTotalSales = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            stplblFurnitureTotalSales = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            stplblTotalGameSales = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            stplblTotalToolSales = new ToolStripStatusLabel();
            tolCommands.SuspendLayout();
            grpItemCharacteristics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCondition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAgeInYears).BeginInit();
            grpCustomer.SuspendLayout();
            grpPurchasing.SuspendLayout();
            staTotals.SuspendLayout();
            SuspendLayout();
            // 
            // tolCommands
            // 
            tolCommands.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tolCommands.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, tolbtnCalculate, toolStripSeparator2, tolbtnClearForm, toolStripSeparator3, tolbtnExit });
            tolCommands.Location = new Point(0, 0);
            tolCommands.Name = "tolCommands";
            tolCommands.Size = new Size(985, 28);
            tolCommands.TabIndex = 0;
            tolCommands.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // tolbtnCalculate
            // 
            tolbtnCalculate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnCalculate.Image = (Image)resources.GetObject("tolbtnCalculate.Image");
            tolbtnCalculate.ImageTransparentColor = Color.Magenta;
            tolbtnCalculate.Name = "tolbtnCalculate";
            tolbtnCalculate.Size = new Size(77, 25);
            tolbtnCalculate.Text = "Calculate";
            tolbtnCalculate.Click += tolbtnCalculate_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // tolbtnClearForm
            // 
            tolbtnClearForm.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnClearForm.Image = (Image)resources.GetObject("tolbtnClearForm.Image");
            tolbtnClearForm.ImageTransparentColor = Color.Magenta;
            tolbtnClearForm.Name = "tolbtnClearForm";
            tolbtnClearForm.Size = new Size(50, 25);
            tolbtnClearForm.Text = "Clear";
            tolbtnClearForm.Click += tolbtnClearForm_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // tolbtnExit
            // 
            tolbtnExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnExit.Image = (Image)resources.GetObject("tolbtnExit.Image");
            tolbtnExit.ImageTransparentColor = Color.Magenta;
            tolbtnExit.Name = "tolbtnExit";
            tolbtnExit.Size = new Size(38, 25);
            tolbtnExit.Text = "Exit";
            tolbtnExit.Click += tolbtnExit_Click;
            // 
            // grpItemCharacteristics
            // 
            grpItemCharacteristics.Controls.Add(label5);
            grpItemCharacteristics.Controls.Add(nudCondition);
            grpItemCharacteristics.Controls.Add(label4);
            grpItemCharacteristics.Controls.Add(nudAgeInYears);
            grpItemCharacteristics.Controls.Add(label3);
            grpItemCharacteristics.Controls.Add(lstItemCategory);
            grpItemCharacteristics.Location = new Point(13, 130);
            grpItemCharacteristics.Margin = new Padding(4);
            grpItemCharacteristics.Name = "grpItemCharacteristics";
            grpItemCharacteristics.Padding = new Padding(4);
            grpItemCharacteristics.Size = new Size(456, 272);
            grpItemCharacteristics.TabIndex = 2;
            grpItemCharacteristics.TabStop = false;
            grpItemCharacteristics.Text = "Item Characteristics";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 192);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 42);
            label5.TabIndex = 4;
            label5.Text = "Condition (1 - 10):\r\n1 is poor, 10 excellent\r\n";
            // 
            // nudCondition
            // 
            nudCondition.Location = new Point(173, 205);
            nudCondition.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCondition.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCondition.Name = "nudCondition";
            nudCondition.Size = new Size(120, 29);
            nudCondition.TabIndex = 5;
            nudCondition.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 2;
            label4.Text = "Age in years:";
            // 
            // nudAgeInYears
            // 
            nudAgeInYears.Location = new Point(173, 154);
            nudAgeInYears.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudAgeInYears.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAgeInYears.Name = "nudAgeInYears";
            nudAgeInYears.Size = new Size(120, 29);
            nudAgeInYears.TabIndex = 3;
            nudAgeInYears.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 0;
            label3.Text = "Category:";
            // 
            // lstItemCategory
            // 
            lstItemCategory.FormattingEnabled = true;
            lstItemCategory.ItemHeight = 21;
            lstItemCategory.Location = new Point(173, 29);
            lstItemCategory.Name = "lstItemCategory";
            lstItemCategory.Size = new Size(273, 109);
            lstItemCategory.TabIndex = 1;
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(label2);
            grpCustomer.Controls.Add(label1);
            grpCustomer.Controls.Add(txtLastName);
            grpCustomer.Controls.Add(txtFirstName);
            grpCustomer.Location = new Point(12, 31);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(958, 92);
            grpCustomer.TabIndex = 1;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 2;
            label2.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(612, 29);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(273, 29);
            txtLastName.TabIndex = 3;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(125, 29);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(273, 29);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // grpPurchasing
            // 
            grpPurchasing.Controls.Add(label9);
            grpPurchasing.Controls.Add(rdoCard);
            grpPurchasing.Controls.Add(label8);
            grpPurchasing.Controls.Add(rdoCash);
            grpPurchasing.Controls.Add(label7);
            grpPurchasing.Controls.Add(txtQuantity);
            grpPurchasing.Controls.Add(label6);
            grpPurchasing.Controls.Add(txtOriginalPrice);
            grpPurchasing.Location = new Point(466, 130);
            grpPurchasing.Margin = new Padding(4);
            grpPurchasing.Name = "grpPurchasing";
            grpPurchasing.Padding = new Padding(4);
            grpPurchasing.Size = new Size(504, 272);
            grpPurchasing.TabIndex = 3;
            grpPurchasing.TabStop = false;
            grpPurchasing.Text = "Purchasing";
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 127);
            label9.Name = "label9";
            label9.Size = new Size(490, 141);
            label9.TabIndex = 7;
            label9.Text = resources.GetString("label9.Text");
            // 
            // rdoCard
            // 
            rdoCard.AutoSize = true;
            rdoCard.Location = new Point(332, 99);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(58, 25);
            rdoCard.TabIndex = 6;
            rdoCard.TabStop = true;
            rdoCard.Text = "card";
            rdoCard.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 97);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 4;
            label8.Text = "Payment:";
            // 
            // rdoCash
            // 
            rdoCash.AutoSize = true;
            rdoCash.Location = new Point(253, 99);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(59, 25);
            rdoCash.TabIndex = 5;
            rdoCash.TabStop = true;
            rdoCash.Text = "cash";
            rdoCash.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(129, 62);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 2;
            label7.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(251, 63);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 29);
            txtQuantity.TabIndex = 3;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 25);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 0;
            label6.Text = "Original price:";
            // 
            // txtOriginalPrice
            // 
            txtOriginalPrice.Location = new Point(251, 26);
            txtOriginalPrice.Margin = new Padding(4);
            txtOriginalPrice.Name = "txtOriginalPrice";
            txtOriginalPrice.Size = new Size(110, 29);
            txtOriginalPrice.TabIndex = 1;
            txtOriginalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTransactions
            // 
            txtTransactions.Location = new Point(12, 409);
            txtTransactions.Multiline = true;
            txtTransactions.Name = "txtTransactions";
            txtTransactions.ReadOnly = true;
            txtTransactions.ScrollBars = ScrollBars.Vertical;
            txtTransactions.Size = new Size(958, 249);
            txtTransactions.TabIndex = 4;
            txtTransactions.TabStop = false;
            // 
            // staTotals
            // 
            staTotals.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, stplblElectronicsTotalSales, toolStripStatusLabel3, stplblClothingTotalSales, toolStripStatusLabel4, stplblFurnitureTotalSales, toolStripStatusLabel5, stplblTotalGameSales, toolStripStatusLabel6, stplblTotalToolSales });
            staTotals.Location = new Point(0, 664);
            staTotals.Name = "staTotals";
            staTotals.Size = new Size(985, 22);
            staTotals.TabIndex = 5;
            staTotals.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(62, 17);
            toolStripStatusLabel1.Text = "Total Sales";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(64, 17);
            toolStripStatusLabel2.Text = "Electronics";
            // 
            // stplblElectronicsTotalSales
            // 
            stplblElectronicsTotalSales.Name = "stplblElectronicsTotalSales";
            stplblElectronicsTotalSales.Size = new Size(28, 17);
            stplblElectronicsTotalSales.Text = "0.00";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(53, 17);
            toolStripStatusLabel3.Text = "Clothing";
            // 
            // stplblClothingTotalSales
            // 
            stplblClothingTotalSales.Name = "stplblClothingTotalSales";
            stplblClothingTotalSales.Size = new Size(28, 17);
            stplblClothingTotalSales.Text = "0.00";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(55, 17);
            toolStripStatusLabel4.Text = "Furniture";
            // 
            // stplblFurnitureTotalSales
            // 
            stplblFurnitureTotalSales.Name = "stplblFurnitureTotalSales";
            stplblFurnitureTotalSales.Size = new Size(28, 17);
            stplblFurnitureTotalSales.Text = "0.00";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(43, 17);
            toolStripStatusLabel5.Text = "Games";
            // 
            // stplblTotalGameSales
            // 
            stplblTotalGameSales.Name = "stplblTotalGameSales";
            stplblTotalGameSales.Size = new Size(28, 17);
            stplblTotalGameSales.Text = "0.00";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(35, 17);
            toolStripStatusLabel6.Text = "Tools";
            // 
            // stplblTotalToolSales
            // 
            stplblTotalToolSales.Name = "stplblTotalToolSales";
            stplblTotalToolSales.Size = new Size(28, 17);
            stplblTotalToolSales.Text = "0.00";
            // 
            // frmGarageSales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 686);
            ControlBox = false;
            Controls.Add(staTotals);
            Controls.Add(txtTransactions);
            Controls.Add(grpPurchasing);
            Controls.Add(grpCustomer);
            Controls.Add(grpItemCharacteristics);
            Controls.Add(tolCommands);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmGarageSales";
            Text = "Garage Sales";
            Load += frmGarageSales_Load;
            tolCommands.ResumeLayout(false);
            tolCommands.PerformLayout();
            grpItemCharacteristics.ResumeLayout(false);
            grpItemCharacteristics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCondition).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAgeInYears).EndInit();
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpPurchasing.ResumeLayout(false);
            grpPurchasing.PerformLayout();
            staTotals.ResumeLayout(false);
            staTotals.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tolCommands;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tolbtnCalculate;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tolbtnClearForm;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tolbtnExit;
        private GroupBox grpItemCharacteristics;
        private GroupBox grpCustomer;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private ListBox lstItemCategory;
        private GroupBox grpPurchasing;
        private Label label4;
        private NumericUpDown nudAgeInYears;
        private Label label5;
        private NumericUpDown nudCondition;
        private Label label7;
        private TextBox txtQuantity;
        private Label label6;
        private TextBox txtOriginalPrice;
        private Label label9;
        private RadioButton rdoCard;
        private Label label8;
        private RadioButton rdoCash;
        private TextBox txtTransactions;
        private StatusStrip staTotals;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel stplblElectronicsTotalSales;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel stplblClothingTotalSales;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel stplblFurnitureTotalSales;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel stplblTotalGameSales;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel stplblTotalToolSales;
    }
}
