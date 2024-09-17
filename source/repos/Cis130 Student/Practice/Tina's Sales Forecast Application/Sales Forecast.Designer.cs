
namespace Tina_s_Sales_Forecast_Application
{
    partial class frmSalesForecast
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtEmployeeName = new TextBox();
            lblEmployeeName = new Label();
            lblPreviousSales = new Label();
            txtPreviousSales = new TextBox();
            txtGrowthRate = new TextBox();
            lblGrowthRate = new Label();
            lblProjectedSales = new Label();
            lblSalesForecast = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            btnExit = new Button();
            tolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 0;
            label1.Text = "Sales Forecast Calculator";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(205, 79);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(180, 29);
            txtEmployeeName.TabIndex = 2;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(67, 82);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(124, 21);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Employee &name:";
            // 
            // lblPreviousSales
            // 
            lblPreviousSales.AutoSize = true;
            lblPreviousSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreviousSales.Location = new Point(67, 117);
            lblPreviousSales.Name = "lblPreviousSales";
            lblPreviousSales.Size = new Size(111, 21);
            lblPreviousSales.TabIndex = 3;
            lblPreviousSales.Text = "&Previous sales:";
            lblPreviousSales.Click += lblPreviousSales_Click;
            // 
            // txtPreviousSales
            // 
            txtPreviousSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreviousSales.Location = new Point(205, 114);
            txtPreviousSales.Name = "txtPreviousSales";
            txtPreviousSales.Size = new Size(180, 29);
            txtPreviousSales.TabIndex = 4;
            // 
            // txtGrowthRate
            // 
            txtGrowthRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrowthRate.Location = new Point(205, 149);
            txtGrowthRate.Name = "txtGrowthRate";
            txtGrowthRate.Size = new Size(180, 29);
            txtGrowthRate.TabIndex = 6;
            // 
            // lblGrowthRate
            // 
            lblGrowthRate.AutoSize = true;
            lblGrowthRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrowthRate.Location = new Point(67, 152);
            lblGrowthRate.Name = "lblGrowthRate";
            lblGrowthRate.Size = new Size(96, 21);
            lblGrowthRate.TabIndex = 5;
            lblGrowthRate.Text = "Growth &rate:";
            // 
            // lblProjectedSales
            // 
            lblProjectedSales.AutoSize = true;
            lblProjectedSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjectedSales.Location = new Point(67, 210);
            lblProjectedSales.Name = "lblProjectedSales";
            lblProjectedSales.Size = new Size(116, 21);
            lblProjectedSales.TabIndex = 7;
            lblProjectedSales.Text = "Projected sales:";
            // 
            // lblSalesForecast
            // 
            lblSalesForecast.BorderStyle = BorderStyle.FixedSingle;
            lblSalesForecast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesForecast.Location = new Point(205, 209);
            lblSalesForecast.Name = "lblSalesForecast";
            lblSalesForecast.Size = new Size(180, 29);
            lblSalesForecast.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(67, 306);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(119, 41);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "&Submit";
            tolTip.SetToolTip(btnSubmit, "Calcutes the forcast using the given information");
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(192, 306);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 41);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            tolTip.SetToolTip(btnClear, "Empties out the information in the form");
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(317, 306);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 41);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            tolTip.SetToolTip(btnExit, "Quits the application");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmSalesForecast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(482, 391);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(lblSalesForecast);
            Controls.Add(lblProjectedSales);
            Controls.Add(lblGrowthRate);
            Controls.Add(txtGrowthRate);
            Controls.Add(txtPreviousSales);
            Controls.Add(lblPreviousSales);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtEmployeeName);
            Controls.Add(label1);
            Name = "frmSalesForecast";
            Text = "Tina's Sales Forecast";
            Load += frmSalesForecast_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declare Variables
            string strEmployeeName = txtEmployeeName.Text;
            decimal decPreviousSales = decimal.Parse(txtPreviousSales.Text);
            decimal decGrowthRate = decimal.Parse(txtGrowthRate.Text) / 100;
            decimal decSalesForecast;

            //make calculations
            decSalesForecast = decPreviousSales * (1 + decGrowthRate);

            //output the result to the sales forecast label
            lblSalesForecast.Text = decSalesForecast.ToString();
        }

        #endregion

        private Label label1;
        private TextBox txtEmployeeName;
        private Label lblEmployeeName;
        private Label lblPreviousSales;
        private TextBox txtPreviousSales;
        private TextBox txtGrowthRate;
        private Label lblGrowthRate;
        private Label lblProjectedSales;
        private Label lblSalesForecast;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnExit;
        private ToolTip tolTip;
    }
}
