using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFC_Calculator
{
    public partial class frmTuitionCalculator : Form
    {
        public frmTuitionCalculator()
        {
            InitializeComponent();
        }
        //Define class-level variables (fields)
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear input and output controls
            //textbox controls
            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCreditHours.Text = "";
            txtCourseLabFees.Text = "";
            //radio button and check box controls

            //list box control

            lblMessage.Text = "";

            //Set Focus to first control
            txtStudentID.Focus();


        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            decimal decCreditHourRate;              //based upon Residency
            decimal decTotalTuition;                //total tuition and fees owed by student
            int intCreditHours;
            int intCourseLabFees;
            const int INFRASTRUCTURE_FEE = 60;
            const int REGISTRATION_FEE = 50;
            const int SERVICE_FEE_PER_CREDIT = 18;
            const int TECH_FEE_PER_CREDIT = 4;
            const int STUDENT_ACTIVITY_FEE_PER_CREDIT = 2;
            string strMessage = "", strLastLine = "";

            //Get input for numeric variables
            int.TryParse(txtCreditHours.Text, out intCreditHours);
            int.TryParse(txtCourseLabFees.Text, out intCourseLabFees);


            //? Finish code for determining Credit Hour Rate based upon student residency
            if (rdoDearbornDistrict.Checked == true)
            {
                decCreditHourRate = 111.00m;
            }
            else if (rdoOutOfDistrict.Checked == true)
            {
                decCreditHourRate = 194.00m;
            }




            //Calculation for student Total Tuition
            decTotalTuition = INFRASTRUCTURE_FEE + REGISTRATION_FEE +
                (intCreditHours * decCreditHourRate) +
                (intCreditHours * SERVICE_FEE_PER_CREDIT) +
                (intCreditHours * TECH_FEE_PER_CREDIT) +
                (intCreditHours * STUDENT_ACTIVITY_FEE_PER_CREDIT) +
                intCourseLabFees;


            //Uncomment the following if statement
            //if (chkNewStudent.?)
            //{
            //    strLastLine = "Welcome to Henry Ford College!";
            //}
            //else
            //    strLastLine = "Thank you for returning to HFC!";

            //Display message to student, remember to add the strLastLine
            //Uncomment the following line of code
            //strMessage = txtFirstName.Text + " " + txtLastName.Text + "'s total tuition is " + decTotalTuition.ToString("C2") + "." + Environment.NewLine
            //    + ?;

            lblMessage.Text = strMessage;

            //? Display the staff name within the label lblStaffName


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }

        private void frmTuition_Load(object sender, EventArgs e)
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
                + "Tech. Investment Fee Per Credit Hour - $4 " + Environment.NewLine
                + "Student Activtiy Fee Per Credit Hour - $2";

            txtTuitionInformation.Text = strTuition;

            //Call InputBox method here to prompt for Staff Name


            //? If staff name is empty then use "Student" for staff name 

        }

    }
}
