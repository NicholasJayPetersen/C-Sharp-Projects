using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class frmTestScores : Form
    {
        int[] intScores = { 75, 82, 96, 71, 98, 67, 84, 73, 91, 95, 82, 71, 82 };  // Array of test Scores


        public frmTestScores()
        {
            InitializeComponent();
        }
        // ************************************************
        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.
        // ************************************************

        //private double Average(int[] iArray)
        //{
        //    int intTotal = 0;   // Accumulator, initialized to 0
        //    double dblAverage;  // To hold the average

        ////  Step through the array, adding each element to
        ////  the accumulator.
        //    for (int index = 0; index < iArray.Length; index++)
        //    {
        //        ?  // accumulate using the total variable
        //    }

        ////    Calculate the average.
        //   dblAverage = (double) intTotal / ? ;

        ////    Return the average.
        //    return dblAverage;
        //}

        // ************************************************
        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        // ************************************************

        //private int Highest(int[] iArray)
        //{
        //// Declare a variable to hold the highest value, and
        //// initialize it with the first value in the array.
        //int intHighest = iArray[0];

        //// Step through the rest of the array, beginning at
        //// element 1. When a value greater than highest is found,
        //// assign that value to highest.
        //for (int index = 1; index < iArray.Length; index++)
        //{
        //    if (iArray[?] > ?)
        //    {
        //        intHighest = ?;
        //    }
        //}

        //// Return the highest value.
        //return intHighest;
        //}

        // ************************************************
        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        // ************************************************

        //private int Lowest(int[] iArray)
        //{
        //    // Declare a variable to hold the lowest value, and
        //    // initialize it with the first value in the array.
        //    int intLowest = ?;

        //    // Step through the rest of the array, beginning at
        //    // element 1. When a value less than lowest is found,
        //    // assign that value to lowest.
        //    for (int index = ?; index < ? ; index++)
        //    {
        //        if (iArray[index] ? intLowest)
        //        {
        //            ? = iArray[index];
        //        }
        //    }

        //    // Return the lowest value.
        //    return intLowest;
        //}


        // ************************************************
        // The Search method accepts an int array argument 
        // and an integer test score. It returns a count
        // of how many times a score was found. 
        // ************************************************
        //private int Search(int[] iArray,int intSearchScore)
        //{
        //    // Declare a variable to count how many times a score
        //    // was found within an array
        //    int intCount=0;

        //    // Step through the array to and count how many
        //    // times a score was found
        //    foreach (int intScore in iArray)
        //    {
        //        if (? == ?)
        //        {
        //            intCount = intCount + 1;
        //        }
        //    }

        //    // Return the counter
        //    return intCount;
        //}

        private void btnGetScores_Click(object sender, EventArgs e)
        {

            // Local variables

            int intHighestScore;              // To hold the highest score
            int intLowestScore;               // To hold the lowest score
            double dblAverageScore;           // To hold the average score


            // Display the test Scores.
            foreach (int value in intScores)
            {
                lstTestScores.Items.Add(value);
            }

            // Get the highest, lowest, and average Scores.
            //intHighestScore = ?;
            //intLowestScore = ?;
            //dblAverageScore = ?;


            // Display the values.
            //lblHighScore.Text = intHighestScore.ToString();
            //lblLowScore.Text = intLowestScore.ToString();
            //lblAverageScore.Text = dblAverageScore.ToString("n1");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void btnSearchScore_Click(object sender, EventArgs e)
        {
            int intScore;
            if (int.TryParse(txtSearchScore.Text, out intScore) == true)
            {
                //call the search method, display results using MessageBox class
            }
            else
            {
                MessageBox.Show("Please enter a valid test score.", "User Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchScore.Focus();

            }
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            //sort the array in ascending order


            // Display the test Scores in ascending order, but first clear
            // the list box control...
            lstTestScores.Items.Clear();

            foreach (int value in intScores)
            {
                lstTestScores.Items.Add(value);
            }
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            //sort the array in descending order

            

        }


    }
}
