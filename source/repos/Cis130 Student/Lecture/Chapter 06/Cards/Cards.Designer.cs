
namespace Cards
{
    partial class frmCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCards));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picKingClubs = new System.Windows.Forms.PictureBox();
            this.picTenHearts = new System.Windows.Forms.PictureBox();
            this.picAceSpades = new System.Windows.Forms.PictureBox();
            this.lstCardList = new System.Windows.Forms.ListBox();
            this.btnShowCard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKingClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAceSpades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picKingClubs);
            this.panel1.Controls.Add(this.picTenHearts);
            this.panel1.Controls.Add(this.picAceSpades);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 201);
            this.panel1.TabIndex = 0;
            // 
            // picKingClubs
            // 
            this.picKingClubs.Image = ((System.Drawing.Image)(resources.GetObject("picKingClubs.Image")));
            this.picKingClubs.Location = new System.Drawing.Point(260, 0);
            this.picKingClubs.Name = "picKingClubs";
            this.picKingClubs.Size = new System.Drawing.Size(124, 201);
            this.picKingClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKingClubs.TabIndex = 2;
            this.picKingClubs.TabStop = false;
            this.picKingClubs.Visible = false;
            // 
            // picTenHearts
            // 
            this.picTenHearts.Image = ((System.Drawing.Image)(resources.GetObject("picTenHearts.Image")));
            this.picTenHearts.Location = new System.Drawing.Point(130, 0);
            this.picTenHearts.Name = "picTenHearts";
            this.picTenHearts.Size = new System.Drawing.Size(124, 201);
            this.picTenHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTenHearts.TabIndex = 1;
            this.picTenHearts.TabStop = false;
            this.picTenHearts.Visible = false;
            // 
            // picAceSpades
            // 
            this.picAceSpades.Image = ((System.Drawing.Image)(resources.GetObject("picAceSpades.Image")));
            this.picAceSpades.Location = new System.Drawing.Point(0, 0);
            this.picAceSpades.Name = "picAceSpades";
            this.picAceSpades.Size = new System.Drawing.Size(124, 201);
            this.picAceSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAceSpades.TabIndex = 0;
            this.picAceSpades.TabStop = false;
            this.picAceSpades.Visible = false;
            // 
            // lstCardList
            // 
            this.lstCardList.FormattingEnabled = true;
            this.lstCardList.ItemHeight = 15;
            this.lstCardList.Location = new System.Drawing.Point(86, 260);
            this.lstCardList.Name = "lstCardList";
            this.lstCardList.Size = new System.Drawing.Size(231, 94);
            this.lstCardList.TabIndex = 1;
            // 
            // btnShowCard
            // 
            this.btnShowCard.Location = new System.Drawing.Point(86, 377);
            this.btnShowCard.Name = "btnShowCard";
            this.btnShowCard.Size = new System.Drawing.Size(102, 47);
            this.btnShowCard.TabIndex = 2;
            this.btnShowCard.Text = "Show Card";
            this.btnShowCard.UseVisualStyleBackColor = true;
            this.btnShowCard.Click += new System.EventHandler(this.btnShowCard_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(215, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a card:";
            // 
            // frmCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowCard);
            this.Controls.Add(this.lstCardList);
            this.Controls.Add(this.panel1);
            this.Name = "frmCards";
            this.Text = "Cards";
            this.Load += new System.EventHandler(this.frmCards_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picKingClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAceSpades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picKingClubs;
        private System.Windows.Forms.PictureBox picTenHearts;
        private System.Windows.Forms.PictureBox picAceSpades;
        private System.Windows.Forms.ListBox lstCardList;
        private System.Windows.Forms.Button btnShowCard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

