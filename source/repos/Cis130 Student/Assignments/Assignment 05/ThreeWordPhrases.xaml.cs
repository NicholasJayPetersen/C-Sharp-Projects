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
using System.Threading;

namespace Assignment05
{
    /// <summary>
    /// Interaction logic for wndPhrases.xaml
    /// </summary>
    public partial class wndPhrases : Window
    {   
        Random rand = new Random();
        int CurrentPlayerNumber;     // 1 for player one, 2 for player two
        int MoneyValue;             // Gets value of Spin results
        int Player1Total;           // Accumlates MoneyValue if player 1 guesses letter correctly
        int Player2Total;           // Accumulates MoneyValue if player 2 guesses letter correctly
        string SentenceWithAnswer="";  //Contains phrase that is to be guessed
        string SentenceToGuess="";     //Contains phrase where each letter in phrase is displayed with a "-"
        const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";  // used in ComboBox control to select a letter


        // phrases with will be loaded in the Phrase List of strings
        List<string> Phrases = new List<string>() ;

        public wndPhrases()
        {
            InitializeComponent();


            //Load Letters in combo box
            LoadLettersForInput();

            //Load Phases in collection
            LoadPhrases();

            //Clear RichTextBox control
            rtbLettersGuessed.Document.Blocks.Clear();

        }

        private void btnSpin_Click(object sender, RoutedEventArgs e)
        {
            // Create instance of WPF window that determines point value of turn
            SpinResults wndSpin = new SpinResults();
            wndSpin.RandomGenerator = rand;
            wndSpin.ShowDialog();  // display window to User

            // Get value from WPF SpinResults window and display in lblResults
            MoneyValue = wndSpin.SpinValue;
            lblResults.Content = MoneyValue.ToString() + " dollars";

            // 0 dollars returned indicates a player loses their turn
            // so switch to the other player
            if (MoneyValue == 0)
            {
                //Next Player's Turn
                if (CurrentPlayerNumber == 1)
                {
                    // Switch to player 2
                    NextPlayersTurn(2);
                }
                else 
                {   // Current player is 2, so switch to 1
                    NextPlayersTurn(1);
                }
            }
            else
            {   // means a point value was returned so player
                // must be able to guess a letter and not Spin again
                btnSpin.IsEnabled = false;
                btnGuessLetter.IsEnabled = true;
                cboLetter.IsEnabled = true;
            }
        }
        private void NextPlayersTurn(int PlayerNumber)
        {
            if (PlayerNumber == 1) //Means it is player 1 turn
            {
                CurrentPlayerNumber = 1;
                lblPlayer1.FontWeight = FontWeights.Bold;
                lblPlayer2.FontWeight = FontWeights.Normal;
            }
            else       //Means it is player 2 turn
            {
                CurrentPlayerNumber = 2;
                lblPlayer1.FontWeight = FontWeights.Normal;
                lblPlayer2.FontWeight = FontWeights.Bold;
            }

            // When players are switched the Spin button must be enabled while
            // the Guess Letter button and cboLetter ComboBox is disabled
            btnSpin.IsEnabled = true;
            btnGuessLetter.IsEnabled = false;
            cboLetter.IsEnabled = false;
        }
        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult Response;
            // Prompt to see who goes first
            Response = MessageBox.Show("If player 1 goes first click yes, otherwise no if player 2 goes first.","Whose Turn?",MessageBoxButton.YesNo,MessageBoxImage.Question);
            switch (Response)
            {
                case MessageBoxResult.Yes:
                    
                    NextPlayersTurn(1);
                    break; 
                case MessageBoxResult.No:
                    NextPlayersTurn(2);
                    break;
            }

            // Set up a new game...
            lblPhrase.Content = GetAPhrase();    // Get a Phrase randomly
            btnSpin.IsEnabled = true;            // Enable Spin button
            lblResults.Content = "";             // Clear lblResults from previous game
            txtPlayer1.Text = "";                // Set player totals to empty string
            txtPlayer2.Text = "";
            Player1Total = 0;                    // Player Point Totals initialized to 0
            Player2Total = 0;
            btnGuessLetter.IsEnabled = false;    // Disable Guess Letter and New Game buttons
            btnNewGame.IsEnabled = false;
            
            //Clear contents of Rich TextBox Control
            rtbLettersGuessed.Document.Blocks.Clear();

        }

        private void LoadLettersForInput()
        {
            // Load cboLetter ComboBox control with letters of alphabet. Use the constant
            // variable LETTERS
            cboLetter.Items.Clear();
            foreach(char letter in LETTERS)
            {
                cboLetter.Items.Add(letter);
            }
            
        }
        private string GetAPhrase()
        {
            Random R = new Random();
            int RanNumber;
            string BuildPhraseWithDashes="";

            // if all phrases have been used the application must exit
            if (Phrases.Count ==0 )
            {
                MessageBox.Show("Sorry, all phrases have been used! Application will shut down :(", "Shut Down");
                this.Close();
            }


            // Phrases are deleted after a game is over,
            // so the random generator must be from 0
            // to the number of phrases that are left
            RanNumber = R.Next(0, Phrases.Count);

            // Get Phrase that is to be guessed!!!
            SentenceWithAnswer = Phrases[RanNumber].ToUpper();  // Make sure all letters in Phrase
                                                                // are upper case

            Phrases.RemoveAt(RanNumber);  // When a phrase is selected, remove it from
                                          //  the collection so it is not used again

            // Replace each letter in Phrase with a dash, a
            // space character will not be replaced with a dash
            foreach(char ch in SentenceWithAnswer)
            {
                if (char.IsWhiteSpace(ch) == true)
                {
                    BuildPhraseWithDashes += " ";
                }
                else if (char.IsLetter(ch) == true)
                {
                    BuildPhraseWithDashes += "-";
                }

            }

            // Set field variable that will hold the 
            // phrase that is to be guessed containing dashes 
            // for each letter in the phrase
            SentenceToGuess = BuildPhraseWithDashes;

            return BuildPhraseWithDashes;
        }

        private void btnGuessLetter_Click(object sender, RoutedEventArgs e)
        {
            char GuessedLetter;

            // make sure a letter is selected from ComboBox control, if not
            // display an error message using MessageBox class and get out
            // of method
            
            if (cboLetter.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a letter");
                return;
            }


            // add letter to Rich Textbox control making sure a tab character is added after the letter
            GuessedLetter = cboLetter.Text[0];
            rtbLettersGuessed.AppendText(GuessedLetter + "\t");

            // Remove letter from combo box since it has been selected

            cboLetter.Items.Remove(GuessedLetter);

            // See if a letter is guessed correctly. Any space characters in phrases will
            // be ignored. Anywhere a letter is found the dash character will be replaced
            // with the letter.
            char[] arrPhraseCharacters = SentenceToGuess.ToCharArray();

            int Position = 0;
            int NumberCorrect = 0;
            foreach (char Letter in SentenceWithAnswer)
            {
                if (Letter == GuessedLetter)
                {
                    arrPhraseCharacters[Position] = Letter;
                    NumberCorrect++;
                }
                Position += 1;
            }

            SentenceToGuess = new string(arrPhraseCharacters);
            lblPhrase.Content = SentenceToGuess;



            // if it a good guess accumulate dollars for
            // the correct player and display phrase in lblPhrase control
            // since a character was found.
            switch (CurrentPlayerNumber)
            {
                case 1:
                    Player1Total += MoneyValue * NumberCorrect;
                    txtPlayer1.Text = Player1Total.ToString();
                    break;
                case 2:
                    Player2Total += MoneyValue * NumberCorrect;
                    txtPlayer2.Text = Player2Total.ToString();

                    break;
            }

            // if is is a bad guess, no dollars are accumulated , switch to
            // another player
            if (NumberCorrect == 0)
            {
                MessageBox.Show($"The letter {GuessedLetter} is not in the phrase.");
                if (CurrentPlayerNumber == 1) { NextPlayersTurn(2); }
                else { NextPlayersTurn(1); }
            }

            // Check to see if any dashes exist "-", if none exist
            // then game is over, call GameIsOver() method
            int NumberOfDashes = 0;
            foreach (char Letter in SentenceToGuess)
            {
                if (Letter == '-')
                {
                    NumberOfDashes += 1;
                }
            }

            if (NumberOfDashes == 0)
            {
                GameIsOver();
                return;
            }

            // whether a character was found or not, set it up
            // for another spin, meaning the Spin button must be enabled 
            // while the Guess Letter button and the ComboBox control with
            // letters must be disabled. This code is already done...

            btnSpin.IsEnabled = true;
            btnGuessLetter.IsEnabled = false;
            cboLetter.IsEnabled = false;






        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            // Close the game
            this.Close();
        }

        private void LoadPhrases()
        {
            // All Phrases will be added to the Phrase collection
            Phrases.Clear();
            Phrases.Add("I love you");
            Phrases.Add("Never give up");
            Phrases.Add("Happy birthday dear");
            Phrases.Add("Stay the course");
            Phrases.Add("Time is money");
            Phrases.Add("Life goes on");
            Phrases.Add("Keep it simple");
            Phrases.Add("Dream big dreams");
            Phrases.Add("Love conquers all");
            Phrases.Add("Take it easy");
            Phrases.Add("Learn from mistakes");
            Phrases.Add("You got this");
            Phrases.Add("Live and learn");
            Phrases.Add("Forgive and forget");
            Phrases.Add("Seize the day");
            Phrases.Add("One day at a time");
            Phrases.Add("Less is more");
            Phrases.Add("Break a leg");
            Phrases.Add("One for all");
            Phrases.Add("Ready set go");
            Phrases.Add("Haste makes waste");
            Phrases.Add("Piece of cake");
            Phrases.Add("Happily ever after");
            Phrases.Add("In the moment");
            Phrases.Add("Rise and shine");
            Phrases.Add("Take a break");
            Phrases.Add("Laugh out loud");
            Phrases.Add("Love conquers all");
            Phrases.Add("Let it go");
            Phrases.Add("Give it up");
            Phrases.Add("Bold as brass");
            Phrases.Add("Come what may");
            Phrases.Add("Live and learn");
            Phrases.Add("Bite the bullet");
            Phrases.Add("Trust the process");
        }
        private void GameIsOver()
        {
            // Display the winner with the total amount that
            // the player won using the MessageBox class

            if (CurrentPlayerNumber == 1)
            {
                MessageBox.Show($"Player 1 is the winner with ${Player1Total}");
            }

            else {
                MessageBox.Show($"Player 2 is the winner with ${Player2Total}");
            }


            // Reset controls for new game, New game button enabled, Spin button, Guess button and
            // cboLetter ComboBox control disabled. Reload Letters for ComboBox
            // control. This code has been completed...

            btnNewGame.IsEnabled = true;
            btnSpin.IsEnabled = false;
            btnGuessLetter.IsEnabled = false;
            LoadLettersForInput();
            lblPhrase.Content = "You have " + Phrases.Count.ToString() + " more phrases to guess.";
            cboLetter.IsEnabled = false;

        }
    }
        
    }

