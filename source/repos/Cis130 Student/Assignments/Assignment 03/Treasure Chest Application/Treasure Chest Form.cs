using System.Runtime.InteropServices;

namespace Assignment_03_Treasure_Chest
{
    public partial class frmTreasureChest : Form
    {
        public frmTreasureChest()
        {
            InitializeComponent();
        }

        //initialize field variables
        Random _number = new Random();
        int _intCurrentGuess;
        int _intNumGuesses;
        int _intWinningChest;
        decimal _decChestValue;
        PictureBox[] arrPicChests = new PictureBox[16];
        private void mnuTreasure_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {   // When user clicks button on menu strip then this
            // event will fire. 

            if (e.ClickedItem != null)     // making sure a button was clicked on ToolStrip
            {
                if (e.ClickedItem.Name == "mnuStart")
                {
                    // call the Start Game method
                    Start_Game();
                }

                else if (e.ClickedItem.Name == "mnuExit")
                {
                    // Exit the Application
                    Application.Exit();
                }
            }

        }
        private void Start_Game()
        { // This void method was added to handle click event of Start button

            if (!IsValidStart(txtPlayerName.Text, txtPlayerAge.Text, cboNumber.Text))
            {
                return;
            }

            //Clear outputs
            lblMessage.Text = "";
            _intNumGuesses = 0;
            _intCurrentGuess = 0;
            lblGuessNumber.Text = "";

            //clear guess sequence from last game
            lstOpenedTreasureChests.Items.Clear();

            //clear picture boxes
            ClearPicBoxes();

            //setup the chessts
            GenerateGameElements();
        }

        private void frmTreasureChest_Load(object sender, EventArgs e)
        {
            for (_intNumGuesses = 1; _intNumGuesses <= 10; _intNumGuesses++)
            {
                cboNumber.Items.Add(_intNumGuesses.ToString());
            }
            cboNumber.SelectedIndex = -1;
        }

        private bool IsValidStart(string Name, string Age, string NumGuesses)
        {
            string strErrorMessage = "";
            strErrorMessage += Validator.IsPresent(Name, "Player Name");
            strErrorMessage += Validator.IsPresent(Age, "Player Age");
            strErrorMessage += Validator.IsPresent(NumGuesses, "Number of guesses");

            strErrorMessage += Validator.IsInteger(Age, "Player Age");
            strErrorMessage += Validator.IsInteger(NumGuesses, "Number of guesses");

            strErrorMessage += Validator.IsWithinRange(Age, "Player Age", 5, 7);
            strErrorMessage += Validator.IsWithinRange(NumGuesses, "Number of guesses", 1, 10);

            if (strErrorMessage == "")
            {
                return true;
            }

            MessageBox.Show(strErrorMessage, "Error");
            return false;
        }

        private void ClearPicBoxes()
        {
            //assign picture boxes as array elements
            arrPicChests[1] = picChest01;
            arrPicChests[2] = picChest02;
            arrPicChests[3] = picChest03;
            arrPicChests[4] = picChest04;
            arrPicChests[5] = picChest05;
            arrPicChests[6] = picChest06;
            arrPicChests[7] = picChest07;
            arrPicChests[8] = picChest08;
            arrPicChests[9] = picChest09;
            arrPicChests[10] = picChest10;
            arrPicChests[11] = picChest11;
            arrPicChests[12] = picChest12;
            arrPicChests[13] = picChest13;
            arrPicChests[14] = picChest14;
            arrPicChests[15] = picChest15;


            //clear each picturebox image
            for (int i = 1; i < arrPicChests.Length; i++)
            {
                 arrPicChests[i].Image = null;
            }
        }

        private void GenerateGameElements()
        {
            //generate winning chest, value and other key elements
            _intNumGuesses = int.Parse(cboNumber.Text);
            _decChestValue = _number.Next(1, 1000);
            _intWinningChest = _number.Next(1, 15);
            lblMessage.Text = "$$$ The money bag value is " + _decChestValue.ToString("c") + " $$$";
            mnuStart.Enabled = false;
            btnOpenChest.Enabled = true;
            txtGuess.Enabled = true;
        }

        private void btnOpenChest_Click(object sender, EventArgs e)
        {
            int.TryParse(txtGuess.Text, out int guess);

            //input validatioin for guess. Must be a valid chest or exit
            if( guess < 1 || guess > 15)
            {
                return;
            }

            //if fucntion returns true, exit and dont run incorrect function
            if (Guessed_Correctly(guess))
            {
                return;
            }
            else
            {
                Guessed_Incorrectly(guess);
            }
        }

        private bool Guessed_Correctly(int guess)
        {
            //validate guess and if not correct exit with false
            if (guess != _intWinningChest)
            {
                return false;
            }

            _intCurrentGuess++;
            lblGuessNumber.Text = _intCurrentGuess.ToString();
            lstOpenedTreasureChests.Items.Add(guess);
            arrPicChests[guess].Image = picMoneyBag.Image;
            lblMessage.Text = "Winner! You found the treasure chest and got " + _decChestValue.ToString("c");
            btnOpenChest.Enabled = false;
            mnuStart.Enabled = true;
            return true;

        }

        private void Guessed_Incorrectly(int guess)
        {
            //when incorrect set pic to nothing and increment guess number
            arrPicChests[guess].Image = picNothing.Image;
            _intCurrentGuess++;
            lblGuessNumber.Text = _intCurrentGuess.ToString();

            //add guess to list of opened chests
            lstOpenedTreasureChests.Items.Add(guess);

            //when the guesses are maxed out end the game
            if (_intCurrentGuess >= _intNumGuesses)
            {
                lblMessage.Text = "Sorry, you lose! The winning chest was " + _intWinningChest + " with " + _decChestValue.ToString("c") + " inside.";
                mnuStart.Enabled = true;
                btnOpenChest.Enabled = false;
                txtGuess.Enabled = false;
            }
        }
    }

}
