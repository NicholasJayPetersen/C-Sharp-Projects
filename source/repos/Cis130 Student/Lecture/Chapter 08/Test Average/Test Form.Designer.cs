
namespace Test_Average
{
    partial class frmTestScores
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
            averageScoreDescriptionLabel = new System.Windows.Forms.Label();
            lowScoreDescriptionLabel = new System.Windows.Forms.Label();
            highScoreDescriptionLabel = new System.Windows.Forms.Label();
            lstTestScores = new System.Windows.Forms.ListBox();
            testScoresDescriptionLabel = new System.Windows.Forms.Label();
            lblHighScore = new System.Windows.Forms.Label();
            lblLowScore = new System.Windows.Forms.Label();
            lblAverageScore = new System.Windows.Forms.Label();
            btnGetScores = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnSearchScore = new System.Windows.Forms.Button();
            btnSortAscending = new System.Windows.Forms.Button();
            btnSortDescending = new System.Windows.Forms.Button();
            txtSearchScore = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // averageScoreDescriptionLabel
            // 
            averageScoreDescriptionLabel.AutoSize = true;
            averageScoreDescriptionLabel.Location = new System.Drawing.Point(281, 208);
            averageScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            averageScoreDescriptionLabel.Name = "averageScoreDescriptionLabel";
            averageScoreDescriptionLabel.Size = new System.Drawing.Size(137, 25);
            averageScoreDescriptionLabel.TabIndex = 6;
            averageScoreDescriptionLabel.Text = "Average Score:";
            // 
            // lowScoreDescriptionLabel
            // 
            lowScoreDescriptionLabel.AutoSize = true;
            lowScoreDescriptionLabel.Location = new System.Drawing.Point(292, 138);
            lowScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lowScoreDescriptionLabel.Name = "lowScoreDescriptionLabel";
            lowScoreDescriptionLabel.Size = new System.Drawing.Size(126, 25);
            lowScoreDescriptionLabel.TabIndex = 4;
            lowScoreDescriptionLabel.Text = "Lowest Score:";
            // 
            // highScoreDescriptionLabel
            // 
            highScoreDescriptionLabel.AutoSize = true;
            highScoreDescriptionLabel.Location = new System.Drawing.Point(288, 71);
            highScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            highScoreDescriptionLabel.Name = "highScoreDescriptionLabel";
            highScoreDescriptionLabel.Size = new System.Drawing.Size(132, 25);
            highScoreDescriptionLabel.TabIndex = 2;
            highScoreDescriptionLabel.Text = "Highest Score:";
            // 
            // lstTestScores
            // 
            lstTestScores.FormattingEnabled = true;
            lstTestScores.ItemHeight = 25;
            lstTestScores.Location = new System.Drawing.Point(53, 60);
            lstTestScores.Margin = new System.Windows.Forms.Padding(6);
            lstTestScores.Name = "lstTestScores";
            lstTestScores.Size = new System.Drawing.Size(217, 179);
            lstTestScores.TabIndex = 1;
            // 
            // testScoresDescriptionLabel
            // 
            testScoresDescriptionLabel.AutoSize = true;
            testScoresDescriptionLabel.Location = new System.Drawing.Point(53, 29);
            testScoresDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            testScoresDescriptionLabel.Name = "testScoresDescriptionLabel";
            testScoresDescriptionLabel.Size = new System.Drawing.Size(180, 25);
            testScoresDescriptionLabel.TabIndex = 0;
            testScoresDescriptionLabel.Text = "List of all test scores";
            // 
            // lblHighScore
            // 
            lblHighScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblHighScore.Location = new System.Drawing.Point(431, 60);
            lblHighScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new System.Drawing.Size(182, 42);
            lblHighScore.TabIndex = 3;
            lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowScore
            // 
            lblLowScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLowScore.Location = new System.Drawing.Point(431, 129);
            lblLowScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblLowScore.Name = "lblLowScore";
            lblLowScore.Size = new System.Drawing.Size(182, 42);
            lblLowScore.TabIndex = 5;
            lblLowScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageScore
            // 
            lblAverageScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblAverageScore.Location = new System.Drawing.Point(431, 198);
            lblAverageScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new System.Drawing.Size(182, 42);
            lblAverageScore.TabIndex = 7;
            lblAverageScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetScores
            // 
            btnGetScores.Location = new System.Drawing.Point(24, 333);
            btnGetScores.Margin = new System.Windows.Forms.Padding(6);
            btnGetScores.Name = "btnGetScores";
            btnGetScores.Size = new System.Drawing.Size(138, 44);
            btnGetScores.TabIndex = 10;
            btnGetScores.Text = "&Get Scores";
            btnGetScores.UseVisualStyleBackColor = true;
            btnGetScores.Click += btnGetScores_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(730, 333);
            btnExit.Margin = new System.Windows.Forms.Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(138, 44);
            btnExit.TabIndex = 14;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnSortDescending_Click;
            // 
            // btnSearchScore
            // 
            btnSearchScore.Location = new System.Drawing.Point(172, 333);
            btnSearchScore.Margin = new System.Windows.Forms.Padding(6);
            btnSearchScore.Name = "btnSearchScore";
            btnSearchScore.Size = new System.Drawing.Size(152, 44);
            btnSearchScore.TabIndex = 11;
            btnSearchScore.Text = "S&earch Score";
            btnSearchScore.UseVisualStyleBackColor = true;
            btnSearchScore.Click += btnSearchScore_Click;
            // 
            // btnSortAscending
            // 
            btnSortAscending.Location = new System.Drawing.Point(336, 333);
            btnSortAscending.Margin = new System.Windows.Forms.Padding(6);
            btnSortAscending.Name = "btnSortAscending";
            btnSortAscending.Size = new System.Drawing.Size(183, 44);
            btnSortAscending.TabIndex = 12;
            btnSortAscending.Text = "Sort &Ascending";
            btnSortAscending.UseVisualStyleBackColor = true;
            btnSortAscending.Click += btnSortAscending_Click;
            // 
            // btnSortDescending
            // 
            btnSortDescending.Location = new System.Drawing.Point(530, 333);
            btnSortDescending.Margin = new System.Windows.Forms.Padding(6);
            btnSortDescending.Name = "btnSortDescending";
            btnSortDescending.Size = new System.Drawing.Size(183, 44);
            btnSortDescending.TabIndex = 13;
            btnSortDescending.Text = "Sort &Descending";
            btnSortDescending.UseVisualStyleBackColor = true;
            btnSortDescending.Click += btnSortDescending_Click;
            // 
            // txtSearchScore
            // 
            txtSearchScore.Location = new System.Drawing.Point(431, 265);
            txtSearchScore.Margin = new System.Windows.Forms.Padding(6);
            txtSearchScore.Name = "txtSearchScore";
            txtSearchScore.Size = new System.Drawing.Size(180, 32);
            txtSearchScore.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(277, 271);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 25);
            label1.TabIndex = 8;
            label1.Text = "&Search Score:";
            // 
            // frmTestScores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(898, 403);
            Controls.Add(label1);
            Controls.Add(txtSearchScore);
            Controls.Add(btnSortDescending);
            Controls.Add(btnSortAscending);
            Controls.Add(btnSearchScore);
            Controls.Add(btnExit);
            Controls.Add(btnGetScores);
            Controls.Add(lblAverageScore);
            Controls.Add(lblLowScore);
            Controls.Add(lblHighScore);
            Controls.Add(averageScoreDescriptionLabel);
            Controls.Add(lowScoreDescriptionLabel);
            Controls.Add(highScoreDescriptionLabel);
            Controls.Add(lstTestScores);
            Controls.Add(testScoresDescriptionLabel);
            Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "frmTestScores";
            Text = "Test Average";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label averageScoreDescriptionLabel;
        private System.Windows.Forms.Label lowScoreDescriptionLabel;
        private System.Windows.Forms.Label highScoreDescriptionLabel;
        private System.Windows.Forms.ListBox lstTestScores;
        private System.Windows.Forms.Label testScoresDescriptionLabel;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblLowScore;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Button btnGetScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchScore;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.TextBox txtSearchScore;
        private System.Windows.Forms.Label label1;
    }
}

