using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class frmCarRace : Form
    {
        public frmCarRace()
        {
            InitializeComponent();
        }
        //Declare class-level variables (fields)
        PictureBox[] picCars = new PictureBox[11];
        Random Rnd = new Random();

        

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start the timer control
            lblCountDown.Visible = true;

            for (int i = 8; i >= 0; i -= 1)
            {
                lblCountDown.Text = i.ToString();
                this.Refresh();
                System.Threading.Thread.Sleep(1000);

            }

            btnStart.Enabled = false;
            tmrCarSpeed.Enabled = true;

        }

        private void frmCar_Load(object sender, EventArgs e)
        {
            picCars[1] = picCar1;
            picCars[2] = picCar2;
            picCars[3] = picCar3;
            picCars[4] = picCar4;
            picCars[5] = picCar5;
            picCars[6] = picCar6;
            picCars[7] = picCar7;
            picCars[8] = picCar8;
            picCars[9] = picCar9;
            picCars[10] = picCar10;

        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnNewRace.Enabled = false;
            int intYValue;

            for (int i = 1; i <= 10; i += 1)
            {
                intYValue = picCars[i].Location.Y;
                picCars[i].Location = new Point(1, intYValue);
            }
        }

        private void tmrCarSpeed_Tick(object sender, EventArgs e)
        {
            int intCarNumber = 0, intCurrentXPosition, intCurrentYPosition;
            bool blnWinner = false;


            while (blnWinner == false)
            {
                intCarNumber = Rnd.Next(1, 11);
                intCurrentXPosition = picCars[intCarNumber].Location.X;
                intCurrentYPosition = picCars[intCarNumber].Location.Y;
                intCurrentXPosition += 4;
                picCars[intCarNumber].Location = new Point(intCurrentXPosition, intCurrentYPosition);
                this.Refresh();
                if (intCurrentXPosition >= 905)
                {
                    blnWinner = true;

                }
            }

            //the car will never stop, add a line of code to stop the car after it
            //crosses the finish line
            tmrCarSpeed.Enabled = false;
            MessageBox.Show("Car number " + intCarNumber + " has won!!!!");
            btnNewRace.Enabled = true;

        }
    }
}
