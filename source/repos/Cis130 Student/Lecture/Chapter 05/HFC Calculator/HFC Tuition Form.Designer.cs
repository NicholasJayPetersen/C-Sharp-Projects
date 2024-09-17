
namespace HFC_Calculator
{
    partial class frmTuitionCalculator
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
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTuitionInformation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpResidency = new System.Windows.Forms.GroupBox();
            this.rdoInternational = new System.Windows.Forms.RadioButton();
            this.rdoOutOfState = new System.Windows.Forms.RadioButton();
            this.rdoOutOfDistrict = new System.Windows.Forms.RadioButton();
            this.rdoDearbornDistrict = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourseLabFees = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalulate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpResidency.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCreditHours
            // 
            this.txtCreditHours.Location = new System.Drawing.Point(137, 414);
            this.txtCreditHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.Size = new System.Drawing.Size(148, 29);
            this.txtCreditHours.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Credit &hours:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTuitionInformation);
            this.groupBox1.Location = new System.Drawing.Point(482, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HFC Tuition Information";
            // 
            // txtTuitionInformation
            // 
            this.txtTuitionInformation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTuitionInformation.Location = new System.Drawing.Point(6, 24);
            this.txtTuitionInformation.Multiline = true;
            this.txtTuitionInformation.Name = "txtTuitionInformation";
            this.txtTuitionInformation.ReadOnly = true;
            this.txtTuitionInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTuitionInformation.Size = new System.Drawing.Size(443, 161);
            this.txtTuitionInformation.TabIndex = 0;
            this.txtTuitionInformation.TabStop = false;
            this.txtTuitionInformation.Text = "\t";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.grpResidency);
            this.groupBox2.Controls.Add(this.grpGender);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCourseLabFees);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCreditHours);
            this.groupBox2.Controls.Add(this.txtStudentID);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 500);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HFC Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select one:";
            // 
            // grpResidency
            // 
            this.grpResidency.Controls.Add(this.rdoInternational);
            this.grpResidency.Controls.Add(this.rdoOutOfState);
            this.grpResidency.Controls.Add(this.rdoOutOfDistrict);
            this.grpResidency.Controls.Add(this.rdoDearbornDistrict);
            this.grpResidency.Location = new System.Drawing.Point(6, 311);
            this.grpResidency.Name = "grpResidency";
            this.grpResidency.Size = new System.Drawing.Size(375, 96);
            this.grpResidency.TabIndex = 10;
            this.grpResidency.TabStop = false;
            this.grpResidency.Text = "Residency";
            // 
            // rdoInternational
            // 
            this.rdoInternational.AutoSize = true;
            this.rdoInternational.Location = new System.Drawing.Point(200, 55);
            this.rdoInternational.Name = "rdoInternational";
            this.rdoInternational.Size = new System.Drawing.Size(116, 25);
            this.rdoInternational.TabIndex = 3;
            this.rdoInternational.TabStop = true;
            this.rdoInternational.Text = "In&ternational";
            this.rdoInternational.UseVisualStyleBackColor = true;
            // 
            // rdoOutOfState
            // 
            this.rdoOutOfState.AutoSize = true;
            this.rdoOutOfState.Location = new System.Drawing.Point(200, 28);
            this.rdoOutOfState.Name = "rdoOutOfState";
            this.rdoOutOfState.Size = new System.Drawing.Size(109, 25);
            this.rdoOutOfState.TabIndex = 1;
            this.rdoOutOfState.TabStop = true;
            this.rdoOutOfState.Text = "&Out of state";
            this.rdoOutOfState.UseVisualStyleBackColor = true;
            // 
            // rdoOutOfDistrict
            // 
            this.rdoOutOfDistrict.AutoSize = true;
            this.rdoOutOfDistrict.Location = new System.Drawing.Point(23, 55);
            this.rdoOutOfDistrict.Name = "rdoOutOfDistrict";
            this.rdoOutOfDistrict.Size = new System.Drawing.Size(123, 25);
            this.rdoOutOfDistrict.TabIndex = 2;
            this.rdoOutOfDistrict.TabStop = true;
            this.rdoOutOfDistrict.Text = "O&ut of district";
            this.rdoOutOfDistrict.UseVisualStyleBackColor = true;
            // 
            // rdoDearbornDistrict
            // 
            this.rdoDearbornDistrict.AutoSize = true;
            this.rdoDearbornDistrict.Location = new System.Drawing.Point(23, 28);
            this.rdoDearbornDistrict.Name = "rdoDearbornDistrict";
            this.rdoDearbornDistrict.Size = new System.Drawing.Size(145, 25);
            this.rdoDearbornDistrict.TabIndex = 0;
            this.rdoDearbornDistrict.TabStop = true;
            this.rdoDearbornDistrict.Text = "Dearborn &district";
            this.rdoDearbornDistrict.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(137, 16);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(244, 56);
            this.grpGender.TabIndex = 1;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(30, 25);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(62, 25);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "&Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 461);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Course/La&b fees:";
            // 
            // txtCourseLabFees
            // 
            this.txtCourseLabFees.Location = new System.Drawing.Point(137, 458);
            this.txtCourseLabFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseLabFees.Name = "txtCourseLabFees";
            this.txtCourseLabFees.Size = new System.Drawing.Size(148, 29);
            this.txtCourseLabFees.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last &name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(137, 148);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(244, 29);
            this.txtLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "&First name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(137, 113);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(244, 29);
            this.txtFirstName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(137, 78);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(244, 29);
            this.txtStudentID.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(304, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(185, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalulate
            // 
            this.btnCalulate.Location = new System.Drawing.Point(64, 15);
            this.btnCalulate.Name = "btnCalulate";
            this.btnCalulate.Size = new System.Drawing.Size(88, 38);
            this.btnCalulate.TabIndex = 3;
            this.btnCalulate.Text = "&Calculate";
            this.btnCalulate.UseVisualStyleBackColor = true;
            this.btnCalulate.Click += new System.EventHandler(this.btnCalulate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(489, 221);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(452, 158);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCalulate);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(488, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 67);
            this.panel1.TabIndex = 6;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Location = new System.Drawing.Point(484, 407);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(451, 35);
            this.lblStaffName.TabIndex = 7;
            this.lblStaffName.Text = "Staff name:";
            // 
            // frmTuitionCalculator
            // 
            this.AcceptButton = this.btnCalulate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 524);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTuitionCalculator";
            this.Text = "HFC Tuition Calculator";
            this.Load += new System.EventHandler(this.frmTuition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpResidency.ResumeLayout(false);
            this.grpResidency.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreditHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTuitionInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourseLabFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnCalulate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpResidency;
        private System.Windows.Forms.RadioButton rdoInternational;
        private System.Windows.Forms.RadioButton rdoOutOfState;
        private System.Windows.Forms.RadioButton rdoOutOfDistrict;
        private System.Windows.Forms.RadioButton rdoDearbornDistrict;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStaffName;
    }
}

