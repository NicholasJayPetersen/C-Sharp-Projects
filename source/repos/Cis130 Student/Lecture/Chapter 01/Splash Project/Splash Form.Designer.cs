namespace Splash_Project
{
    partial class frmSplash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            lblName = new Label();
            lblMessage = new Label();
            picRedTree = new PictureBox();
            pictureBox1 = new PictureBox();
            tmrExit = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picRedTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblName.Location = new Point(529, 258);
            lblName.Name = "lblName";
            lblName.Size = new Size(135, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Red Tree Inn";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            lblMessage.Location = new Point(529, 307);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(207, 25);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "A relaxing place to stay!";
            // 
            // picRedTree
            // 
            picRedTree.Image = (Image)resources.GetObject("picRedTree.Image");
            picRedTree.Location = new Point(12, 8);
            picRedTree.Name = "picRedTree";
            picRedTree.Size = new Size(448, 409);
            picRedTree.SizeMode = PictureBoxSizeMode.StretchImage;
            picRedTree.TabIndex = 2;
            picRedTree.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(621, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tmrExit
            // 
            tmrExit.Enabled = true;
            tmrExit.Interval = 5000;
            tmrExit.Tick += tmrExit_Tick;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 429);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(picRedTree);
            Controls.Add(lblMessage);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)picRedTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblMessage;
        private PictureBox picRedTree;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrExit;
    }
}
