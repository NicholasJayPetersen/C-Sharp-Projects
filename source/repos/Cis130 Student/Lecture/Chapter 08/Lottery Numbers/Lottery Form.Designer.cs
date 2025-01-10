
namespace Lottery_Numbers
{
    partial class frmLottery
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblFourth = new System.Windows.Forms.Label();
            this.lblFifth = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstLotteryNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirst.Location = new System.Drawing.Point(26, 19);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(77, 50);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecond.Location = new System.Drawing.Point(114, 19);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(77, 50);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThird
            // 
            this.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThird.Location = new System.Drawing.Point(202, 19);
            this.lblThird.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(77, 50);
            this.lblThird.TabIndex = 2;
            this.lblThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFourth
            // 
            this.lblFourth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFourth.Location = new System.Drawing.Point(290, 19);
            this.lblFourth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFourth.Name = "lblFourth";
            this.lblFourth.Size = new System.Drawing.Size(77, 50);
            this.lblFourth.TabIndex = 3;
            this.lblFourth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFifth
            // 
            this.lblFifth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFifth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFifth.Location = new System.Drawing.Point(378, 19);
            this.lblFifth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFifth.Name = "lblFifth";
            this.lblFifth.Size = new System.Drawing.Size(77, 50);
            this.lblFifth.TabIndex = 4;
            this.lblFifth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(97, 112);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 73);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "&Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 112);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 73);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstLotteryNumbers
            // 
            this.lstLotteryNumbers.FormattingEnabled = true;
            this.lstLotteryNumbers.ItemHeight = 28;
            this.lstLotteryNumbers.Location = new System.Drawing.Point(557, 22);
            this.lstLotteryNumbers.Margin = new System.Windows.Forms.Padding(6);
            this.lstLotteryNumbers.Name = "lstLotteryNumbers";
            this.lstLotteryNumbers.Size = new System.Drawing.Size(222, 144);
            this.lstLotteryNumbers.TabIndex = 5;
            // 
            // frmLottery
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 213);
            this.Controls.Add(this.lstLotteryNumbers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblFifth);
            this.Controls.Add(this.lblFourth);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLottery";
            this.Text = "Lottery Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblFourth;
        private System.Windows.Forms.Label lblFifth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstLotteryNumbers;
    }
}

