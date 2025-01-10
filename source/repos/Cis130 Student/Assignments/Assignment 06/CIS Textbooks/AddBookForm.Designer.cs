namespace CIS_Textbooks
{
    partial class AddBookForm
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
            txtCourseNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label4 = new Label();
            txtPublisher = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            txtISBN = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtCourseNumber
            // 
            txtCourseNumber.Location = new Point(244, 40);
            txtCourseNumber.Name = "txtCourseNumber";
            txtCourseNumber.Size = new Size(88, 34);
            txtCourseNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 43);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "&CIS course number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 100);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 2;
            label2.Text = "&Textbook title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(244, 97);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(425, 34);
            txtTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 159);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 4;
            label3.Text = "Textbook &author:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(244, 156);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(214, 34);
            txtAuthor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 218);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 6;
            label4.Text = "&Publisher";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(244, 215);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(214, 34);
            txtPublisher.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 280);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 8;
            label5.Text = "&ISBN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(244, 314);
            label6.Name = "label6";
            label6.Size = new Size(321, 21);
            label6.TabIndex = 10;
            label6.Text = "(ISBN format: 13 digits  000-0-000000-00-0)";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(594, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 54);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(246, 276);
            txtISBN.Mask = "000-0-000000-00-0";
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(251, 34);
            txtISBN.TabIndex = 9;
            // 
            // AddBookForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 392);
            Controls.Add(btnAdd);
            Controls.Add(txtISBN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPublisher);
            Controls.Add(label3);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(txtCourseNumber);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBookForm";
            Text = "Add Textbook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCourseNumber;
        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtAuthor;
        private Label label4;
        private TextBox txtPublisher;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private MaskedTextBox txtISBN;
    }
}