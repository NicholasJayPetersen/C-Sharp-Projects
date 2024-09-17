
namespace Dice_Example
{
    partial class frmDice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDice));
            this.picFirstDie = new System.Windows.Forms.PictureBox();
            this.picSecondDie = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picThree = new System.Windows.Forms.PictureBox();
            this.picFour = new System.Windows.Forms.PictureBox();
            this.picFive = new System.Windows.Forms.PictureBox();
            this.picSix = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).BeginInit();
            this.SuspendLayout();
            // 
            // picFirstDie
            // 
            this.picFirstDie.Location = new System.Drawing.Point(23, 22);
            this.picFirstDie.Name = "picFirstDie";
            this.picFirstDie.Size = new System.Drawing.Size(122, 113);
            this.picFirstDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirstDie.TabIndex = 0;
            this.picFirstDie.TabStop = false;
            // 
            // picSecondDie
            // 
            this.picSecondDie.Location = new System.Drawing.Point(202, 22);
            this.picSecondDie.Name = "picSecondDie";
            this.picSecondDie.Size = new System.Drawing.Size(122, 113);
            this.picSecondDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecondDie.TabIndex = 1;
            this.picSecondDie.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(124, 171);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(102, 28);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picOne
            // 
            this.picOne.Image = ((System.Drawing.Image)(resources.GetObject("picOne.Image")));
            this.picOne.Location = new System.Drawing.Point(53, 293);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(81, 77);
            this.picOne.TabIndex = 3;
            this.picOne.TabStop = false;
            // 
            // picTwo
            // 
            this.picTwo.Image = ((System.Drawing.Image)(resources.GetObject("picTwo.Image")));
            this.picTwo.Location = new System.Drawing.Point(140, 293);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(81, 77);
            this.picTwo.TabIndex = 4;
            this.picTwo.TabStop = false;
            // 
            // picThree
            // 
            this.picThree.Image = ((System.Drawing.Image)(resources.GetObject("picThree.Image")));
            this.picThree.Location = new System.Drawing.Point(227, 293);
            this.picThree.Name = "picThree";
            this.picThree.Size = new System.Drawing.Size(81, 77);
            this.picThree.TabIndex = 5;
            this.picThree.TabStop = false;
            // 
            // picFour
            // 
            this.picFour.Image = ((System.Drawing.Image)(resources.GetObject("picFour.Image")));
            this.picFour.Location = new System.Drawing.Point(314, 293);
            this.picFour.Name = "picFour";
            this.picFour.Size = new System.Drawing.Size(81, 77);
            this.picFour.TabIndex = 6;
            this.picFour.TabStop = false;
            // 
            // picFive
            // 
            this.picFive.Image = ((System.Drawing.Image)(resources.GetObject("picFive.Image")));
            this.picFive.Location = new System.Drawing.Point(401, 293);
            this.picFive.Name = "picFive";
            this.picFive.Size = new System.Drawing.Size(81, 77);
            this.picFive.TabIndex = 7;
            this.picFive.TabStop = false;
            // 
            // picSix
            // 
            this.picSix.Image = ((System.Drawing.Image)(resources.GetObject("picSix.Image")));
            this.picSix.Location = new System.Drawing.Point(488, 293);
            this.picSix.Name = "picSix";
            this.picSix.Size = new System.Drawing.Size(81, 77);
            this.picSix.TabIndex = 8;
            this.picSix.TabStop = false;
            // 
            // frmDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 223);
            this.Controls.Add(this.picSix);
            this.Controls.Add(this.picFive);
            this.Controls.Add(this.picFour);
            this.Controls.Add(this.picThree);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picOne);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picSecondDie);
            this.Controls.Add(this.picFirstDie);
            this.Name = "frmDice";
            this.Text = "Rolling Dice";
            ((System.ComponentModel.ISupportInitialize)(this.picFirstDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFirstDie;
        private System.Windows.Forms.PictureBox picSecondDie;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.PictureBox picThree;
        private System.Windows.Forms.PictureBox picFour;
        private System.Windows.Forms.PictureBox picFive;
        private System.Windows.Forms.PictureBox picSix;
    }
}

