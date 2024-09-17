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
            lblMessage.Text = "";

            //Set Focus to first control
            txtStudentID.Focus();


        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            int intCreditHours;
            int intCourseLabFees;
            decimal decCreditHourRate;
            decimal decTotalTuition;
            const int INFRASTRUCTURE_FEE = 60;
            const int REGISTRATION_FEE = 50;
            const int SERVICE_FEE_PER_CREDIT = 18;
            const int TECH_FEE_PER_CREDIT = 4;
            const int STUDENT_ACTIVITY_FEE_PER_CREDIT = 2;

            string strMessage = "";

            //Get numeric data from textbox controls
            intCreditHours = int.Parse(txtCreditHours.Text);
            decCreditHourRate = decimal.Parse(txtCreditHourRate.Text);
            intCourseLabFees = int.Parse(txtCourseLabFees.Text);


            //Calculate Total Tuition
            decTotalTuition = INFRASTRUCTURE_FEE + REGISTRATION_FEE +
                (intCreditHours * decCreditHourRate) +
                (intCreditHours * SERVICE_FEE_PER_CREDIT) +
                (intCreditHours * TECH_FEE_PER_CREDIT ) +
                (intCreditHours * STUDENT_ACTIVITY_FEE_PER_CREDIT ) +
                intCourseLabFees;

            //Display message to student
            strMessage = txtFirstName.Text + " " + txtLastName.Text +
                "'s total tuition is " + 
                decTotalTuition.ToString("C2") + "." + Environment.NewLine
                + "Thank you for choosing HFC - Future Driven!";

            lblMessage.Text = strMessage;
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }

        private void frmTuitionCalculator_Load(object sender, EventArgs e)
        {
	    string strTuition;

            strTuition = "Registration Fee - $50" + Environment.NewLine
                + "Infrastructure Fee - $60" + Environment.NewLine
                + "Tuition Per Credit Hour" + Environment.NewLine
                + "    Dearborn District - $111.00" + Environment.NewLine
                + "    Out of District - $194.00" + Environment.NewLine
                + "    Out of State - $281.00" + Environment.NewLine
                + "    International Students - $281.00" + Environment.NewLine
                + "Service Fee Per Credit Hour -   $18" + Environment.NewLine
                + "Tech. Investment Fee Per Credit Hour - $4" + Environment.NewLine
                + "Student Activity Fee Per Credit Hour - $2";
            
            //display tuition information to student
            txtTuitionInformation.Text = strTuition;
        }
    }
}
