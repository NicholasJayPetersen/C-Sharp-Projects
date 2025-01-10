namespace CIS_Textbooks
{
    partial class DisplayAllForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCISCourse = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lblTextInformation = new Label();
            SuspendLayout();
            // 
            // lstCISCourse
            // 
            lstCISCourse.FormattingEnabled = true;
            lstCISCourse.ItemHeight = 28;
            lstCISCourse.Location = new Point(30, 50);
            lstCISCourse.Name = "lstCISCourse";
            lstCISCourse.Size = new Size(186, 396);
            lstCISCourse.TabIndex = 0;
            lstCISCourse.SelectedIndexChanged += lstCISCourse_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 1;
            label1.Text = "CIS class:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 50);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "Textbook:";
            // 
            // lblTextInformation
            // 
            lblTextInformation.BorderStyle = BorderStyle.FixedSingle;
            lblTextInformation.Location = new Point(378, 49);
            lblTextInformation.Name = "lblTextInformation";
            lblTextInformation.Size = new Size(491, 227);
            lblTextInformation.TabIndex = 3;
            // 
            // DisplayAllForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 480);
            Controls.Add(lblTextInformation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstCISCourse);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayAllForm";
            Text = "Display All Textbooks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCISCourse;
        private Label label1;
        private Label label2;
        private Label lblTextInformation;
    }
}