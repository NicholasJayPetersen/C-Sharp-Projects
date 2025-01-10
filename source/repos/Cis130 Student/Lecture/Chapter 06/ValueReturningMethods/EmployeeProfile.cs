using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueReturningMethods
{
    public partial class frmEmployeeProfile : Form
    {
        public frmEmployeeProfile()
        {
            InitializeComponent();
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {



            //Display information in Results form
            frmProfileResults frmResults = new frmProfileResults();

            ////Set up employee name
            //frmResults.lblEmployee.Text = txtEmployeename.Text;

            ////Set up employee gender
            //if (rdoMale.Checked == true)
            //    frmResults.lblGender.Text = "This employee is a male.";
            //else
            //    frmResults.lblGender.Text = "This employee is a female.";

            ////Set up how many years at company
            //frmResults.lblYearsAtCompany.Text = "This employee has worked " + ? + " year(s).";

            //frmResults.lblDepartments.Text = ?;

            frmResults.ShowDialog();

        }
    }
}
