
namespace TripCost
{
    partial class frmTripCost
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
            this.txtCarTankCapacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGallonsLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGasCostPerGallon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMilesDriven = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCostOfTrip = new System.Windows.Forms.Label();
            this.lblMilesPerGallon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCarTankCapacity
            // 
            this.txtCarTankCapacity.Location = new System.Drawing.Point(266, 14);
            this.txtCarTankCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarTankCapacity.Name = "txtCarTankCapacity";
            this.txtCarTankCapacity.Size = new System.Drawing.Size(148, 26);
            this.txtCarTankCapacity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car gas tank capacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gallons left in tank after trip:";
            // 
            // txtGallonsLeft
            // 
            this.txtGallonsLeft.Location = new System.Drawing.Point(266, 47);
            this.txtGallonsLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGallonsLeft.Name = "txtGallonsLeft";
            this.txtGallonsLeft.Size = new System.Drawing.Size(148, 26);
            this.txtGallonsLeft.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost of gas per gallon to fill-up:";
            // 
            // txtGasCostPerGallon
            // 
            this.txtGasCostPerGallon.Location = new System.Drawing.Point(266, 116);
            this.txtGasCostPerGallon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGasCostPerGallon.Name = "txtGasCostPerGallon";
            this.txtGasCostPerGallon.Size = new System.Drawing.Size(148, 26);
            this.txtGasCostPerGallon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miles driven on trip:";
            // 
            // txtMilesDriven
            // 
            this.txtMilesDriven.Location = new System.Drawing.Point(266, 83);
            this.txtMilesDriven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMilesDriven.Name = "txtMilesDriven";
            this.txtMilesDriven.Size = new System.Drawing.Size(148, 26);
            this.txtMilesDriven.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(149, 232);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 29);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gas cost of trip:";
            // 
            // lblCostOfTrip
            // 
            this.lblCostOfTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCostOfTrip.Location = new System.Drawing.Point(262, 188);
            this.lblCostOfTrip.Name = "lblCostOfTrip";
            this.lblCostOfTrip.Size = new System.Drawing.Size(87, 28);
            this.lblCostOfTrip.TabIndex = 11;
            this.lblCostOfTrip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMilesPerGallon
            // 
            this.lblMilesPerGallon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMilesPerGallon.Location = new System.Drawing.Point(262, 160);
            this.lblMilesPerGallon.Name = "lblMilesPerGallon";
            this.lblMilesPerGallon.Size = new System.Drawing.Size(87, 28);
            this.lblMilesPerGallon.TabIndex = 9;
            this.lblMilesPerGallon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Miles per gallon:";
            // 
            // frmTripCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 288);
            this.Controls.Add(this.lblMilesPerGallon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCostOfTrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGasCostPerGallon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMilesDriven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGallonsLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarTankCapacity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTripCost";
            this.Text = "Mileage Cost of Trip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCarTankCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGallonsLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGasCostPerGallon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMilesDriven;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCostOfTrip;
        private System.Windows.Forms.Label lblMilesPerGallon;
        private System.Windows.Forms.Label label8;
    }
}

