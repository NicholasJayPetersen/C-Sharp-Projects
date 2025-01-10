namespace CIS_Textbooks
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            tolMain = new ToolStrip();
            tolBTNAddBook = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tolBTNSaveBooks = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tolBTNDisplayAll = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tolBTNExit = new ToolStripButton();
            tolMain.SuspendLayout();
            SuspendLayout();
            // 
            // tolMain
            // 
            tolMain.Items.AddRange(new ToolStripItem[] { tolBTNAddBook, toolStripSeparator1, tolBTNSaveBooks, toolStripSeparator3, tolBTNDisplayAll, toolStripSeparator2, tolBTNExit });
            tolMain.Location = new Point(0, 0);
            tolMain.Name = "tolMain";
            tolMain.Padding = new Padding(0, 0, 2, 0);
            tolMain.Size = new Size(1804, 25);
            tolMain.TabIndex = 0;
            tolMain.Text = "toolStrip1";
            // 
            // tolBTNAddBook
            // 
            tolBTNAddBook.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolBTNAddBook.Image = (Image)resources.GetObject("tolBTNAddBook.Image");
            tolBTNAddBook.ImageTransparentColor = Color.Magenta;
            tolBTNAddBook.Name = "tolBTNAddBook";
            tolBTNAddBook.Size = new Size(65, 22);
            tolBTNAddBook.Text = "New Book";
            tolBTNAddBook.Click += tolBTNAddBook_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tolBTNSaveBooks
            // 
            tolBTNSaveBooks.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolBTNSaveBooks.Image = (Image)resources.GetObject("tolBTNSaveBooks.Image");
            tolBTNSaveBooks.ImageTransparentColor = Color.Magenta;
            tolBTNSaveBooks.Name = "tolBTNSaveBooks";
            tolBTNSaveBooks.Size = new Size(70, 22);
            tolBTNSaveBooks.Text = "Save Books";
            tolBTNSaveBooks.Click += tolBTNSaveBooks_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // tolBTNDisplayAll
            // 
            tolBTNDisplayAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolBTNDisplayAll.Image = (Image)resources.GetObject("tolBTNDisplayAll.Image");
            tolBTNDisplayAll.ImageTransparentColor = Color.Magenta;
            tolBTNDisplayAll.Name = "tolBTNDisplayAll";
            tolBTNDisplayAll.Size = new Size(75, 22);
            tolBTNDisplayAll.Text = "Display All...";
            tolBTNDisplayAll.Click += tolBTNDisplayAll_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tolBTNExit
            // 
            tolBTNExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolBTNExit.Image = (Image)resources.GetObject("tolBTNExit.Image");
            tolBTNExit.ImageTransparentColor = Color.Magenta;
            tolBTNExit.Name = "tolBTNExit";
            tolBTNExit.Size = new Size(30, 22);
            tolBTNExit.Text = "Exit";
            tolBTNExit.Click += tolBTNExit_Click;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1804, 1061);
            Controls.Add(tolMain);
            Font = new Font("Segoe UI", 15F);
            IsMdiContainer = true;
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmMainForm";
            Text = "CIS Textbooks";
            WindowState = FormWindowState.Maximized;
            tolMain.ResumeLayout(false);
            tolMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tolMain;
        private ToolStripButton tolBTNAddBook;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tolBTNDisplayAll;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tolBTNExit;
        private ToolStripButton tolBTNSaveBooks;
        private ToolStripSeparator toolStripSeparator3;
    }
}
