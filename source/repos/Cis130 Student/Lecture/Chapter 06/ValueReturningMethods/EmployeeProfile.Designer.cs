
namespace ValueReturningMethods
{
    partial class frmEmployeeProfile
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
            this.txtEmployeename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.grpDepartments = new System.Windows.Forms.GroupBox();
            this.chkPurchasing = new System.Windows.Forms.CheckBox();
            this.chkHumanResources = new System.Windows.Forms.CheckBox();
            this.chkSales = new System.Windows.Forms.CheckBox();
            this.chkFinance = new System.Windows.Forms.CheckBox();
            this.chkOperations = new System.Windows.Forms.CheckBox();
            this.chkMarketing = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkGeneralManagement = new System.Windows.Forms.CheckBox();
            this.grpGender.SuspendLayout();
            this.grpDepartments.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmployeename
            // 
            this.txtEmployeename.Location = new System.Drawing.Point(244, 34);
            this.txtEmployeename.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmployeename.Name = "txtEmployeename";
            this.txtEmployeename.Size = new System.Drawing.Size(369, 34);
            this.txtEmployeename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Employee name:";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(244, 90);
            this.grpGender.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpGender.Name = "grpGender";
            this.grpGender.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpGender.Size = new System.Drawing.Size(372, 93);
            this.grpGender.TabIndex = 2;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(207, 41);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(92, 32);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "&Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(35, 41);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(73, 32);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "&Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "D&ate of hire:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(301, 641);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 50);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Checked = false;
            this.dtpHireDate.Location = new System.Drawing.Point(244, 213);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.ShowCheckBox = true;
            this.dtpHireDate.Size = new System.Drawing.Size(364, 34);
            this.dtpHireDate.TabIndex = 14;
            // 
            // grpDepartments
            // 
            this.grpDepartments.Controls.Add(this.chkPurchasing);
            this.grpDepartments.Controls.Add(this.chkHumanResources);
            this.grpDepartments.Controls.Add(this.chkSales);
            this.grpDepartments.Controls.Add(this.chkFinance);
            this.grpDepartments.Controls.Add(this.chkOperations);
            this.grpDepartments.Controls.Add(this.chkMarketing);
            this.grpDepartments.Controls.Add(this.label3);
            this.grpDepartments.Controls.Add(this.chkGeneralManagement);
            this.grpDepartments.Location = new System.Drawing.Point(82, 283);
            this.grpDepartments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDepartments.Name = "grpDepartments";
            this.grpDepartments.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDepartments.Size = new System.Drawing.Size(574, 346);
            this.grpDepartments.TabIndex = 15;
            this.grpDepartments.TabStop = false;
            // 
            // chkPurchasing
            // 
            this.chkPurchasing.AutoSize = true;
            this.chkPurchasing.Location = new System.Drawing.Point(346, 243);
            this.chkPurchasing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkPurchasing.Name = "chkPurchasing";
            this.chkPurchasing.Size = new System.Drawing.Size(126, 32);
            this.chkPurchasing.TabIndex = 20;
            this.chkPurchasing.Text = "&Purchasing";
            this.chkPurchasing.UseVisualStyleBackColor = true;
            // 
            // chkHumanResources
            // 
            this.chkHumanResources.AutoSize = true;
            this.chkHumanResources.Location = new System.Drawing.Point(346, 194);
            this.chkHumanResources.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkHumanResources.Name = "chkHumanResources";
            this.chkHumanResources.Size = new System.Drawing.Size(185, 32);
            this.chkHumanResources.TabIndex = 19;
            this.chkHumanResources.Text = "&Human Resources";
            this.chkHumanResources.UseVisualStyleBackColor = true;
            // 
            // chkSales
            // 
            this.chkSales.AutoSize = true;
            this.chkSales.Location = new System.Drawing.Point(346, 144);
            this.chkSales.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkSales.Name = "chkSales";
            this.chkSales.Size = new System.Drawing.Size(75, 32);
            this.chkSales.TabIndex = 18;
            this.chkSales.Text = "&Sales";
            this.chkSales.UseVisualStyleBackColor = true;
            // 
            // chkFinance
            // 
            this.chkFinance.AutoSize = true;
            this.chkFinance.Location = new System.Drawing.Point(60, 293);
            this.chkFinance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkFinance.Name = "chkFinance";
            this.chkFinance.Size = new System.Drawing.Size(97, 32);
            this.chkFinance.TabIndex = 17;
            this.chkFinance.Text = "&Finance";
            this.chkFinance.UseVisualStyleBackColor = true;
            // 
            // chkOperations
            // 
            this.chkOperations.AutoSize = true;
            this.chkOperations.Location = new System.Drawing.Point(60, 243);
            this.chkOperations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkOperations.Name = "chkOperations";
            this.chkOperations.Size = new System.Drawing.Size(128, 32);
            this.chkOperations.TabIndex = 16;
            this.chkOperations.Text = "&Operations";
            this.chkOperations.UseVisualStyleBackColor = true;
            // 
            // chkMarketing
            // 
            this.chkMarketing.AutoSize = true;
            this.chkMarketing.Location = new System.Drawing.Point(60, 194);
            this.chkMarketing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkMarketing.Name = "chkMarketing";
            this.chkMarketing.Size = new System.Drawing.Size(121, 32);
            this.chkMarketing.TabIndex = 15;
            this.chkMarketing.Text = "Mar&keting";
            this.chkMarketing.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 80);
            this.label3.TabIndex = 13;
            this.label3.Text = "Please check departments you have worked in: (At least one must be selected)";
            // 
            // chkGeneralManagement
            // 
            this.chkGeneralManagement.AutoSize = true;
            this.chkGeneralManagement.Location = new System.Drawing.Point(60, 144);
            this.chkGeneralManagement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkGeneralManagement.Name = "chkGeneralManagement";
            this.chkGeneralManagement.Size = new System.Drawing.Size(219, 32);
            this.chkGeneralManagement.TabIndex = 14;
            this.chkGeneralManagement.Text = "&General Management";
            this.chkGeneralManagement.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeProfile
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 706);
            this.Controls.Add(this.grpDepartments);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeename);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEmployeeProfile";
            this.Text = "Employee Profile";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpDepartments.ResumeLayout(false);
            this.grpDepartments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.GroupBox grpDepartments;
        private System.Windows.Forms.CheckBox chkPurchasing;
        private System.Windows.Forms.CheckBox chkHumanResources;
        private System.Windows.Forms.CheckBox chkSales;
        private System.Windows.Forms.CheckBox chkFinance;
        private System.Windows.Forms.CheckBox chkOperations;
        private System.Windows.Forms.CheckBox chkMarketing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkGeneralManagement;
    }
}

