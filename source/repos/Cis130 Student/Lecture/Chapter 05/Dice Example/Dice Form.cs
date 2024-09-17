using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Example
{
    public partial class frmDice : Form
    {
        public frmDice()
        {
            InitializeComponent();
        }

        // Declare a field variable and name it
        // objRand and create an object instance of the Random class
        Random objRand = new Random();
        
        //declare two integer variables to represent the value
        //of one die rolled
        int n1, n2;

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // set n1 to a random number between 1 and 6

            // set n2 to a random number between 1 and 6


            //finish the case labels for the first die
            switch (n1)
            {
                case 1:
                    picFirstDie.Image = picOne.Image; break;
                case 2:
                    picFirstDie.Image = picTwo.Image; break;
                case 3:
                    picFirstDie.Image = picThree.Image; break;
                case 4:
                    picFirstDie.Image = picFour.Image; break;
                case 5:
                    picFirstDie.Image = picFive.Image; break;

            }
            //finish code the switch statement for the second die
        }
    }
}
