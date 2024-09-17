using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        //Declare class level variables for accumulator and counter
        double dblScoreTotal;
        int intScoreCount;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get score from input, convert to integer
            int.TryParse(txtScore.Text, out int intScore);

            //accumulate score, count it and calculate average
            dblScoreTotal += intScore;
            intScoreCount++;
            double dblAverage = Math.Round((dblScoreTotal / intScoreCount), 1);

            //display values in output labels
            lblScoreTotal.Text = dblScoreTotal.ToString();
            lblScoreCount.Text = intScoreCount.ToString();
            lblAverage.Text = dblAverage.ToString();

            //set focus to first input
            txtScore.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear counter and accumulator
            dblScoreTotal = 0;
            intScoreCount = 0;

            //clear input and all output labels
            txtScore.Clear();
            lblScoreTotal.Text = "";
            lblScoreCount.Text = "";
            lblAverage.Text = "";



            //set focus to the first input
            txtScore.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            lblScoreTotal.Text = "";
            lblScoreCount.Text = "";
            lblAverage.Text = "";
        }
    }
}
