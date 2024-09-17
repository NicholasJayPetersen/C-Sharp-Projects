
namespace Scope_Example
{
    partial class frmSales
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
            this.lblSales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCommissionAmount = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btn3Percent = new System.Windows.Forms.Button();
            this.btn5Percent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSales.Location = new System.Drawing.Point(137, 28);
            this.lblSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(170, 32);
            this.lblSales.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commission:";
            // 
            // lblCommissionAmount
            // 
            this.lblCommissionAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommissionAmount.Location = new System.Drawing.Point(137, 91);
            this.lblCommissionAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommissionAmount.Name = "lblCommissionAmount";
            this.lblCommissionAmount.Size = new System.Drawing.Size(170, 32);
            this.lblCommissionAmount.TabIndex = 3;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(12, 183);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(111, 52);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Display Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btn3Percent
            // 
            this.btn3Percent.Location = new System.Drawing.Point(129, 183);
            this.btn3Percent.Name = "btn3Percent";
            this.btn3Percent.Size = new System.Drawing.Size(111, 52);
            this.btn3Percent.TabIndex = 5;
            this.btn3Percent.Text = "3% Commission";
            this.btn3Percent.UseVisualStyleBackColor = true;
            this.btn3Percent.Click += new System.EventHandler(this.btn3Percent_Click);
            // 
            // btn5Percent
            // 
            this.btn5Percent.Location = new System.Drawing.Point(253, 183);
            this.btn5Percent.Name = "btn5Percent";
            this.btn5Percent.Size = new System.Drawing.Size(111, 52);
            this.btn5Percent.TabIndex = 6;
            this.btn5Percent.Text = "5% Commission";
            this.btn5Percent.UseVisualStyleBackColor = true;
            this.btn5Percent.Click += new System.EventHandler(this.btn5Percent_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 252);
            this.Controls.Add(this.btn5Percent);
            this.Controls.Add(this.btn3Percent);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCommissionAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSales);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSales";
            this.Text = "Scope Example";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCommissionAmount;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btn3Percent;
        private System.Windows.Forms.Button btn5Percent;
    }
}

