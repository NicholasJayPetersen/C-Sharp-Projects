
namespace Lights
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picLightOn = new System.Windows.Forms.PictureBox();
            this.picLightOff = new System.Windows.Forms.PictureBox();
            this.btnSwitchLight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOff)).BeginInit();
            this.SuspendLayout();
            // 
            // picLightOn
            // 
            this.picLightOn.Image = ((System.Drawing.Image)(resources.GetObject("picLightOn.Image")));
            this.picLightOn.Location = new System.Drawing.Point(12, 22);
            this.picLightOn.Name = "picLightOn";
            this.picLightOn.Size = new System.Drawing.Size(245, 365);
            this.picLightOn.TabIndex = 0;
            this.picLightOn.TabStop = false;
            this.picLightOn.Visible = false;
            // 
            // picLightOff
            // 
            this.picLightOff.Image = ((System.Drawing.Image)(resources.GetObject("picLightOff.Image")));
            this.picLightOff.Location = new System.Drawing.Point(12, 22);
            this.picLightOff.Name = "picLightOff";
            this.picLightOff.Size = new System.Drawing.Size(245, 365);
            this.picLightOff.TabIndex = 1;
            this.picLightOff.TabStop = false;
            // 
            // btnSwitchLight
            // 
            this.btnSwitchLight.Location = new System.Drawing.Point(12, 393);
            this.btnSwitchLight.Name = "btnSwitchLight";
            this.btnSwitchLight.Size = new System.Drawing.Size(82, 48);
            this.btnSwitchLight.TabIndex = 2;
            this.btnSwitchLight.Text = "&Switch Light";
            this.btnSwitchLight.UseVisualStyleBackColor = true;
            this.btnSwitchLight.Click += new System.EventHandler(this.btnSwitchLight_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(175, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStateLabel
            // 
            this.lblStateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStateLabel.Location = new System.Drawing.Point(95, 393);
            this.lblStateLabel.Name = "lblStateLabel";
            this.lblStateLabel.Size = new System.Drawing.Size(74, 48);
            this.lblStateLabel.TabIndex = 5;
            this.lblStateLabel.Text = "OFF";
            this.lblStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSwitchLight;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.lblStateLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSwitchLight);
            this.Controls.Add(this.picLightOff);
            this.Controls.Add(this.picLightOn);
            this.Name = "Form1";
            this.Text = "Light Bulb";
            ((System.ComponentModel.ISupportInitialize)(this.picLightOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLightOn;
        private System.Windows.Forms.PictureBox picLightOff;
        private System.Windows.Forms.Button btnSwitchLight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStateLabel;
    }
}

