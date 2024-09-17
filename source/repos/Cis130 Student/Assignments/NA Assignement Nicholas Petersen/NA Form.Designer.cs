namespace NA_Assignement_Nicholas_Petersen
{
    partial class frmNA
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
            lblHelloWorld = new Label();
            lblName = new Label();
            lblFood = new Label();
            tmrWorld = new System.Windows.Forms.Timer(components);
            tmrName = new System.Windows.Forms.Timer(components);
            tmrFood = new System.Windows.Forms.Timer(components);
            tmrExit = new System.Windows.Forms.Timer(components);
            btnShow = new Button();
            btnHide = new Button();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHelloWorld.Location = new Point(111, 53);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(159, 32);
            lblHelloWorld.TabIndex = 0;
            lblHelloWorld.Text = "Hello World!";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(201, 167);
            lblName.Name = "lblName";
            lblName.Size = new Size(362, 32);
            lblName.TabIndex = 1;
            lblName.Text = "My name is Nicholas Petersen.";
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFood.Location = new Point(395, 285);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(307, 32);
            lblFood.TabIndex = 2;
            lblFood.Text = "My favorite food is tacos!";
            // 
            // tmrWorld
            // 
            tmrWorld.Interval = 1000;
            tmrWorld.Tick += tmrWorld_Tick;
            // 
            // tmrName
            // 
            tmrName.Interval = 4000;
            tmrName.Tick += tmrName_Tick;
            // 
            // tmrFood
            // 
            tmrFood.Interval = 7000;
            tmrFood.Tick += tmrFood_Tick;
            // 
            // tmrExit
            // 
            tmrExit.Interval = 15000;
            tmrExit.Tick += tmrExit_Tick;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(201, 370);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 3;
            btnShow.Text = "&Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(488, 370);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(75, 23);
            btnHide.TabIndex = 4;
            btnHide.Text = "&Hide";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // frmNA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(lblFood);
            Controls.Add(lblName);
            Controls.Add(lblHelloWorld);
            Name = "frmNA";
            Text = "NA Assignment - Nicholas Petersen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloWorld;
        private Label lblName;
        private Label lblFood;
        private System.Windows.Forms.Timer tmrWorld;
        private System.Windows.Forms.Timer tmrName;
        private System.Windows.Forms.Timer tmrFood;
        private System.Windows.Forms.Timer tmrExit;
        private Button btnShow;
        private Button btnHide;
    }
}
