using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFC_Tuition_Calculator
{
    public partial class frmTuitionCalculator : Form
    {
        public frmTuitionCalculator()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear input and output controls
            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCreditHours.Text = "";
            txtCreditHourRate.Text = "";
            txtCourseLabFees.Text = "";


            //Set Focus to first control
            txtStudentID.Focus();


        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {





        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }
    }
}
