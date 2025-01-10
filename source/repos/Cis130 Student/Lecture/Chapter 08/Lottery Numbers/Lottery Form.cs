using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class frmLottery : Form
    {
        public frmLottery()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Create an integer array, intLotteryNumbers, to hold the random numbers.


            // Create a Random object.
            Random rand = new Random();

            // Iteration Example #1 - for ( )
            // Fill the array with random numbers, in the range
            // of 0 through 99 using the for loop structure


            // Display the array elements in the Label controls.
            //lblFirst.Text = intLotteryNumbers[0].ToString();
            //lblSecond.Text = intLotteryNumbers[1].ToString();
            //lblThird.Text = intLotteryNumbers[2].ToString();
            //lblFourth.Text = intLotteryNumbers[3].ToString();
            //lblFifth.Text = intLotteryNumbers[4].ToString();

            // Iteration Example #2 - foreach (  )
            // Display the random numbers generated using the ListBox control




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
