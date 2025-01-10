using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Test_Score_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<int> colTestScores = new List<int>();

        //***************************************** Control Events
        //*******************************************************
        private void BtnEnterScore_Click(object sender, RoutedEventArgs e)
        {
            //Validate the data
            if (IsValidData() == false) return;

            //convert input of test score to integer
            int intTestScore = int.Parse(txtScore.Text);

            //?? add test score to list box control and collection
            lstScores.Items.Add(intTestScore);
            colTestScores.Add(intTestScore);

            // if there are 2 test scores enable the Results tab
            if (colTestScores.Count == 2)
                tabResults.IsEnabled = true;

        }
        private void TabScoreList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
                //Determine which tab item was selected       
                int tabItem = ((sender as TabControl)).SelectedIndex;
                switch (tabItem)
                {
                    case 0:    //Scores tab is clicked so set focus to Score TextBox control
                        tabScores.Focus();
                        txtScore.Focus();
                        break;
                    case 1:    //Results tab is clicked Display Test Results

                        // Call method to display Test Results
                        DisplayTestResults();
                        break;
                }
            
        }

        private void BtnRemoveScore_Click(object sender, RoutedEventArgs e)
        {
            //Make sure a test score is selected in the ListBox control
            if (lstScores.SelectedIndex != -1)
            {
                int i = lstScores.SelectedIndex;

                //remove test score from list box control
                lstScores.Items.RemoveAt(i);

                //remove test score from collection
                colTestScores.RemoveAt(i);

                //if only 1 test score then make sure tabResults is not enabled 
                if (colTestScores.Count < 2)
                    tabResults.IsEnabled = false;
            }
            else
                MessageBox.Show("A test score has not been selected!", "Attention");
        }

        //***************************** Validation Methods
        //************************************************
        public bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

          
            // Validate the Test Score text box - integer within 0 to 100
            errorMessage += IsInt32(txtScore.Text, "Test score");
            errorMessage += IsWithinRange(txtScore.Text, "Test score", 0, 100);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;


        }
        public string IsPresent(string value, string name)
        {
            string msg = "";
            // Check if value is empty
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }

        public string IsDecimal(string value, string name)
        {
            string msg = "";
            //Check if value is a decimal, code discard value for output
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n";
            }
            return msg;
        }

        public string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }

        public string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }

        //***************************************Methods to Process Test Scores
        //********************************************************************
        private void DisplayTestResults()
        {
            lblAverageScore.Content = Average(colTestScores).ToString("N1");
            lblCountAboveAverage.Content = AboveAverage(colTestScores).ToString();
            lblCountBelowAverage.Content = BelowAverage(colTestScores).ToString();
            lblHighestScore.Content = HighestTestScore(colTestScores).ToString();
            lblLowestScore.Content = LowestTestScore(colTestScores).ToString();


        }

        private double Average(List<int> scoresList)
        {
            int intTotal = 0;      // Accumulator
            double dblAverage;     // To hold the average

            // Calculate the total of the scores.
            foreach (int score in scoresList)
            {
                intTotal += score;
            }

            // Calculate the average of the scores.
            dblAverage = (double) intTotal/ scoresList.Count;

            // Return the average.
            return dblAverage;
        }

        // The AboveAverage method returns the number of
        // above average scores in scoresList.
        private int AboveAverage(List<int> scoresList)
        {
            int intNumAbove = 0;       // Counter

            // Get the average score.
            double dblAvg = Average(scoresList);

            // Count the number of above average scores.
            foreach (int score in scoresList)
            {
                if (score > dblAvg) intNumAbove++;
            }

            // Return the number of above average scores.
            return intNumAbove;
        }

        // The BelowAverage method returns the number of
        // below average scores in scoresList.
        private int BelowAverage(List<int> scoresList)
        {
            int intNumBelow = 0;       // Counter

            // Get the average score.
            double dblAvg = Average(scoresList);

            //Code loop structure to Count the number of tests below average score.
            foreach (int score in scoresList)
            {
                if (score < dblAvg) intNumBelow++;
            }

            // Return the number of below average scores.
            return intNumBelow;
        }

        private int HighestTestScore(List<int> scoresList)
        {
            int intHighScore;
            //????set HighScore to first test in list
            intHighScore = scoresList[0];

            //Code For Loop to determine Highest Score
            for (int i=1;i < scoresList.Count;i++)
            {
                if (scoresList[i] > intHighScore)
                    intHighScore = scoresList[i];
            }

            return intHighScore;
        }

        private int LowestTestScore(List<int> scoresList)
        {
            int intLowScore;
            intLowScore = scoresList[0];

            for (int i = 1; i < scoresList.Count; i++)
            {
                if (scoresList[i] < intLowScore)
                {
                    intLowScore = scoresList[i];
                }
            }


            return intLowScore;
        }


    }
}
