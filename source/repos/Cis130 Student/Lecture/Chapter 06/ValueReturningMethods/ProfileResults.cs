using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValueReturningMethods
{
    public partial class frmProfileResults : Form
    {
        public frmProfileResults()
        {
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Close Form
            this.Close();
        }
    }
}
