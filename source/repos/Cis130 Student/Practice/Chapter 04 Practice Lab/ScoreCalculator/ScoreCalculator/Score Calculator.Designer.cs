namespace ScoreCalculator
{
    partial class frmScoreCalculator
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
            label1 = new System.Windows.Forms.Label();
            txtScore = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblScoreTotal = new System.Windows.Forms.Label();
            lblScoreCount = new System.Windows.Forms.Label();
            lblAverage = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Location = new System.Drawing.Point(89, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "&Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new System.Drawing.Point(162, 31);
            txtScore.Name = "txtScore";
            txtScore.Size = new System.Drawing.Size(75, 32);
            txtScore.TabIndex = 1;
            txtScore.TextChanged += txtScore_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label2.Location = new System.Drawing.Point(44, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Score total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(34, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "Score count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(66, 178);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 25);
            label4.TabIndex = 6;
            label4.Text = "Average:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(272, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(123, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(113, 230);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(123, 42);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear Scores";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(272, 230);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(123, 42);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblScoreTotal.Location = new System.Drawing.Point(162, 70);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new System.Drawing.Size(74, 36);
            lblScoreTotal.TabIndex = 3;
            // 
            // lblScoreCount
            // 
            lblScoreCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblScoreCount.Location = new System.Drawing.Point(163, 119);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new System.Drawing.Size(74, 36);
            lblScoreCount.TabIndex = 5;
            // 
            // lblAverage
            // 
            lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblAverage.Location = new System.Drawing.Point(163, 167);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new System.Drawing.Size(74, 36);
            lblAverage.TabIndex = 7;
            // 
            // frmScoreCalculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(442, 316);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 14F);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmScoreCalculator";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Score Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
    }
}

