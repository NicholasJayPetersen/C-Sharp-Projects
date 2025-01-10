namespace Assignment_03_Treasure_Chest
{
    partial class frmTreasureChest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreasureChest));
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtPlayerAge = new TextBox();
            label1 = new Label();
            txtPlayerName = new TextBox();
            groupBox2 = new GroupBox();
            lblGuessNumber = new Label();
            label16 = new Label();
            cboNumber = new ComboBox();
            label4 = new Label();
            tabTreasure = new TabControl();
            tabTreasureChests = new TabPage();
            panel1 = new Panel();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            picChest15 = new PictureBox();
            picChest14 = new PictureBox();
            picChest13 = new PictureBox();
            picChest12 = new PictureBox();
            picChest11 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            picChest10 = new PictureBox();
            picChest09 = new PictureBox();
            picChest08 = new PictureBox();
            picChest07 = new PictureBox();
            picChest06 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            picChest05 = new PictureBox();
            picChest04 = new PictureBox();
            picChest03 = new PictureBox();
            picChest02 = new PictureBox();
            picChest01 = new PictureBox();
            tabGuessSequence = new TabPage();
            lstOpenedTreasureChests = new ListBox();
            label14 = new Label();
            btnOpenChest = new Button();
            label15 = new Label();
            txtGuess = new TextBox();
            lblMessage = new Label();
            picMoneyBag = new PictureBox();
            picNothing = new PictureBox();
            mnuTreasure = new MenuStrip();
            mnuStart = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabTreasure.SuspendLayout();
            tabTreasureChests.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChest15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest09).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest08).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest07).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest06).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest05).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest04).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChest01).BeginInit();
            tabGuessSequence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMoneyBag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNothing).BeginInit();
            mnuTreasure.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPlayerAge);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPlayerName);
            groupBox1.Location = new Point(7, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 117);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 66);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Player age:";
            // 
            // txtPlayerAge
            // 
            txtPlayerAge.Location = new Point(165, 59);
            txtPlayerAge.Name = "txtPlayerAge";
            txtPlayerAge.Size = new Size(209, 32);
            txtPlayerAge.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Player  name:";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(165, 21);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(209, 32);
            txtPlayerName.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblGuessNumber);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(cboNumber);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(397, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 117);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Game Options/Results";
            // 
            // lblGuessNumber
            // 
            lblGuessNumber.BackColor = Color.FromArgb(255, 255, 192);
            lblGuessNumber.BorderStyle = BorderStyle.FixedSingle;
            lblGuessNumber.Location = new Point(210, 66);
            lblGuessNumber.Name = "lblGuessNumber";
            lblGuessNumber.Size = new Size(56, 34);
            lblGuessNumber.TabIndex = 3;
            lblGuessNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(54, 70);
            label16.Name = "label16";
            label16.Size = new Size(137, 25);
            label16.TabIndex = 2;
            label16.Text = "Guess number:";
            // 
            // cboNumber
            // 
            cboNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNumber.FormattingEnabled = true;
            cboNumber.Location = new Point(210, 21);
            cboNumber.MaxDropDownItems = 10;
            cboNumber.Name = "cboNumber";
            cboNumber.Size = new Size(161, 33);
            cboNumber.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 28);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 0;
            label4.Text = "Number of guesses:";
            // 
            // tabTreasure
            // 
            tabTreasure.Controls.Add(tabTreasureChests);
            tabTreasure.Controls.Add(tabGuessSequence);
            tabTreasure.Location = new Point(7, 211);
            tabTreasure.Name = "tabTreasure";
            tabTreasure.SelectedIndex = 0;
            tabTreasure.Size = new Size(553, 443);
            tabTreasure.TabIndex = 4;
            // 
            // tabTreasureChests
            // 
            tabTreasureChests.Controls.Add(panel1);
            tabTreasureChests.Location = new Point(4, 34);
            tabTreasureChests.Name = "tabTreasureChests";
            tabTreasureChests.Padding = new Padding(3);
            tabTreasureChests.Size = new Size(545, 405);
            tabTreasureChests.TabIndex = 0;
            tabTreasureChests.Text = "Treasure Chests";
            tabTreasureChests.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(picChest15);
            panel1.Controls.Add(picChest14);
            panel1.Controls.Add(picChest13);
            panel1.Controls.Add(picChest12);
            panel1.Controls.Add(picChest11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(picChest10);
            panel1.Controls.Add(picChest09);
            panel1.Controls.Add(picChest08);
            panel1.Controls.Add(picChest07);
            panel1.Controls.Add(picChest06);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(picChest05);
            panel1.Controls.Add(picChest04);
            panel1.Controls.Add(picChest03);
            panel1.Controls.Add(picChest02);
            panel1.Controls.Add(picChest01);
            panel1.Location = new Point(5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 403);
            panel1.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(459, 263);
            label17.Name = "label17";
            label17.Size = new Size(32, 25);
            label17.TabIndex = 41;
            label17.Text = "15";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(353, 263);
            label18.Name = "label18";
            label18.Size = new Size(32, 25);
            label18.TabIndex = 40;
            label18.Text = "14";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(246, 263);
            label19.Name = "label19";
            label19.Size = new Size(32, 25);
            label19.TabIndex = 39;
            label19.Text = "13";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(142, 263);
            label20.Name = "label20";
            label20.Size = new Size(32, 25);
            label20.TabIndex = 38;
            label20.Text = "12";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(32, 263);
            label21.Name = "label21";
            label21.Size = new Size(32, 25);
            label21.TabIndex = 37;
            label21.Text = "11";
            // 
            // picChest15
            // 
            picChest15.Location = new Point(425, 291);
            picChest15.Name = "picChest15";
            picChest15.Size = new Size(100, 91);
            picChest15.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest15.TabIndex = 36;
            picChest15.TabStop = false;
            // 
            // picChest14
            // 
            picChest14.Location = new Point(319, 291);
            picChest14.Name = "picChest14";
            picChest14.Size = new Size(100, 91);
            picChest14.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest14.TabIndex = 35;
            picChest14.TabStop = false;
            // 
            // picChest13
            // 
            picChest13.Location = new Point(213, 291);
            picChest13.Name = "picChest13";
            picChest13.Size = new Size(100, 91);
            picChest13.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest13.TabIndex = 34;
            picChest13.TabStop = false;
            // 
            // picChest12
            // 
            picChest12.Location = new Point(107, 291);
            picChest12.Name = "picChest12";
            picChest12.Size = new Size(100, 91);
            picChest12.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest12.TabIndex = 33;
            picChest12.TabStop = false;
            // 
            // picChest11
            // 
            picChest11.Location = new Point(1, 291);
            picChest11.Name = "picChest11";
            picChest11.Size = new Size(100, 91);
            picChest11.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest11.TabIndex = 32;
            picChest11.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(459, 130);
            label9.Name = "label9";
            label9.Size = new Size(32, 25);
            label9.TabIndex = 19;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(353, 130);
            label10.Name = "label10";
            label10.Size = new Size(32, 25);
            label10.TabIndex = 18;
            label10.Text = "09";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(246, 130);
            label11.Name = "label11";
            label11.Size = new Size(32, 25);
            label11.TabIndex = 17;
            label11.Text = "08";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(142, 130);
            label12.Name = "label12";
            label12.Size = new Size(32, 25);
            label12.TabIndex = 16;
            label12.Text = "07";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 130);
            label13.Name = "label13";
            label13.Size = new Size(32, 25);
            label13.TabIndex = 15;
            label13.Text = "06";
            // 
            // picChest10
            // 
            picChest10.Location = new Point(425, 158);
            picChest10.Name = "picChest10";
            picChest10.Size = new Size(100, 91);
            picChest10.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest10.TabIndex = 14;
            picChest10.TabStop = false;
            // 
            // picChest09
            // 
            picChest09.Location = new Point(319, 158);
            picChest09.Name = "picChest09";
            picChest09.Size = new Size(100, 91);
            picChest09.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest09.TabIndex = 13;
            picChest09.TabStop = false;
            // 
            // picChest08
            // 
            picChest08.Location = new Point(213, 158);
            picChest08.Name = "picChest08";
            picChest08.Size = new Size(100, 91);
            picChest08.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest08.TabIndex = 12;
            picChest08.TabStop = false;
            // 
            // picChest07
            // 
            picChest07.Location = new Point(107, 158);
            picChest07.Name = "picChest07";
            picChest07.Size = new Size(100, 91);
            picChest07.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest07.TabIndex = 11;
            picChest07.TabStop = false;
            // 
            // picChest06
            // 
            picChest06.Location = new Point(1, 158);
            picChest06.Name = "picChest06";
            picChest06.Size = new Size(100, 91);
            picChest06.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest06.TabIndex = 10;
            picChest06.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(459, 5);
            label8.Name = "label8";
            label8.Size = new Size(32, 25);
            label8.TabIndex = 9;
            label8.Text = "05";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 5);
            label7.Name = "label7";
            label7.Size = new Size(32, 25);
            label7.TabIndex = 8;
            label7.Text = "04";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 5);
            label6.Name = "label6";
            label6.Size = new Size(32, 25);
            label6.TabIndex = 7;
            label6.Text = "03";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 5);
            label5.Name = "label5";
            label5.Size = new Size(32, 25);
            label5.TabIndex = 6;
            label5.Text = "02";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 5);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 5;
            label3.Text = "01";
            // 
            // picChest05
            // 
            picChest05.Location = new Point(425, 33);
            picChest05.Name = "picChest05";
            picChest05.Size = new Size(100, 91);
            picChest05.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest05.TabIndex = 4;
            picChest05.TabStop = false;
            // 
            // picChest04
            // 
            picChest04.Location = new Point(319, 33);
            picChest04.Name = "picChest04";
            picChest04.Size = new Size(100, 91);
            picChest04.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest04.TabIndex = 3;
            picChest04.TabStop = false;
            // 
            // picChest03
            // 
            picChest03.Location = new Point(213, 33);
            picChest03.Name = "picChest03";
            picChest03.Size = new Size(100, 91);
            picChest03.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest03.TabIndex = 2;
            picChest03.TabStop = false;
            // 
            // picChest02
            // 
            picChest02.Location = new Point(107, 33);
            picChest02.Name = "picChest02";
            picChest02.Size = new Size(100, 91);
            picChest02.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest02.TabIndex = 1;
            picChest02.TabStop = false;
            // 
            // picChest01
            // 
            picChest01.Location = new Point(1, 33);
            picChest01.Name = "picChest01";
            picChest01.Size = new Size(100, 91);
            picChest01.SizeMode = PictureBoxSizeMode.StretchImage;
            picChest01.TabIndex = 0;
            picChest01.TabStop = false;
            // 
            // tabGuessSequence
            // 
            tabGuessSequence.Controls.Add(lstOpenedTreasureChests);
            tabGuessSequence.Controls.Add(label14);
            tabGuessSequence.Location = new Point(4, 24);
            tabGuessSequence.Name = "tabGuessSequence";
            tabGuessSequence.Size = new Size(545, 415);
            tabGuessSequence.TabIndex = 1;
            tabGuessSequence.Text = "Guess Sequence";
            tabGuessSequence.UseVisualStyleBackColor = true;
            // 
            // lstOpenedTreasureChests
            // 
            lstOpenedTreasureChests.FormattingEnabled = true;
            lstOpenedTreasureChests.ItemHeight = 25;
            lstOpenedTreasureChests.Location = new Point(28, 49);
            lstOpenedTreasureChests.Name = "lstOpenedTreasureChests";
            lstOpenedTreasureChests.Size = new Size(324, 329);
            lstOpenedTreasureChests.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 13);
            label14.Name = "label14";
            label14.Size = new Size(242, 25);
            label14.TabIndex = 0;
            label14.Text = "Sequence of opened chests";
            // 
            // btnOpenChest
            // 
            btnOpenChest.Enabled = false;
            btnOpenChest.Location = new Point(629, 421);
            btnOpenChest.Name = "btnOpenChest";
            btnOpenChest.Size = new Size(125, 40);
            btnOpenChest.TabIndex = 7;
            btnOpenChest.Text = "&Open Chest";
            btnOpenChest.UseVisualStyleBackColor = true;
            btnOpenChest.Click += btnOpenChest_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(578, 356);
            label15.Name = "label15";
            label15.Size = new Size(139, 25);
            label15.TabIndex = 5;
            label15.Text = "&Chest number?";
            // 
            // txtGuess
            // 
            txtGuess.Enabled = false;
            txtGuess.Location = new Point(723, 353);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(65, 32);
            txtGuess.TabIndex = 6;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = SystemColors.MenuBar;
            lblMessage.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.Location = new Point(7, 161);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(781, 42);
            lblMessage.TabIndex = 3;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMoneyBag
            // 
            picMoneyBag.Image = (Image)resources.GetObject("picMoneyBag.Image");
            picMoneyBag.Location = new Point(896, 227);
            picMoneyBag.Name = "picMoneyBag";
            picMoneyBag.Size = new Size(100, 91);
            picMoneyBag.SizeMode = PictureBoxSizeMode.StretchImage;
            picMoneyBag.TabIndex = 29;
            picMoneyBag.TabStop = false;
            picMoneyBag.Visible = false;
            // 
            // picNothing
            // 
            picNothing.Image = (Image)resources.GetObject("picNothing.Image");
            picNothing.Location = new Point(896, 371);
            picNothing.Name = "picNothing";
            picNothing.Size = new Size(100, 91);
            picNothing.SizeMode = PictureBoxSizeMode.StretchImage;
            picNothing.TabIndex = 30;
            picNothing.TabStop = false;
            picNothing.Visible = false;
            // 
            // mnuTreasure
            // 
            mnuTreasure.Items.AddRange(new ToolStripItem[] { mnuStart, mnuExit });
            mnuTreasure.Location = new Point(0, 0);
            mnuTreasure.Name = "mnuTreasure";
            mnuTreasure.Size = new Size(837, 24);
            mnuTreasure.TabIndex = 0;
            mnuTreasure.Text = "menuStrip1";
            mnuTreasure.ItemClicked += mnuTreasure_ItemClicked;
            // 
            // mnuStart
            // 
            mnuStart.Name = "mnuStart";
            mnuStart.Size = new Size(43, 20);
            mnuStart.Text = "Start";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(38, 20);
            mnuExit.Text = "Exit";
            // 
            // frmTreasureChest
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 665);
            ControlBox = false;
            Controls.Add(picNothing);
            Controls.Add(picMoneyBag);
            Controls.Add(lblMessage);
            Controls.Add(btnOpenChest);
            Controls.Add(label15);
            Controls.Add(txtGuess);
            Controls.Add(tabTreasure);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(mnuTreasure);
            Font = new Font("Segoe UI", 14F);
            MainMenuStrip = mnuTreasure;
            Name = "frmTreasureChest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Treasure Game";
            Load += frmTreasureChest_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabTreasure.ResumeLayout(false);
            tabTreasureChests.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChest15).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest14).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest13).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest12).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest11).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest10).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest09).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest08).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest07).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest06).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest05).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest04).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest03).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest02).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChest01).EndInit();
            tabGuessSequence.ResumeLayout(false);
            tabGuessSequence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMoneyBag).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNothing).EndInit();
            mnuTreasure.ResumeLayout(false);
            mnuTreasure.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayerAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabTreasure;
        private System.Windows.Forms.TabPage tabTreasureChests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox picChest10;
        private System.Windows.Forms.PictureBox picChest09;
        private System.Windows.Forms.PictureBox picChest08;
        private System.Windows.Forms.PictureBox picChest07;
        private System.Windows.Forms.PictureBox picChest06;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picChest05;
        private System.Windows.Forms.PictureBox picChest04;
        private System.Windows.Forms.PictureBox picChest03;
        private System.Windows.Forms.PictureBox picChest02;
        private System.Windows.Forms.PictureBox picChest01;
        private System.Windows.Forms.Button btnOpenChest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblGuessNumber;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picMoneyBag;
        private System.Windows.Forms.PictureBox picNothing;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox picChest15;
        private System.Windows.Forms.PictureBox picChest14;
        private System.Windows.Forms.PictureBox picChest13;
        private System.Windows.Forms.PictureBox picChest12;
        private System.Windows.Forms.PictureBox picChest11;
        private System.Windows.Forms.MenuStrip mnuTreasure;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private TabPage tabGuessSequence;
        private ListBox lstOpenedTreasureChests;
        private Label label14;
    }
}
