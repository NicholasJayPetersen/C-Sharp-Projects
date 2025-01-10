using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TurnLightOn()
        {
            // Display the "light on" image.
            picLightOn.Visible = true;

            // Hide the "light off" image.
            picLightOff.Visible = false;

            // Display the light's state.
            lblStateLabel.Text = "ON";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the application
            this.Close();
        }

        private void btnSwitchLight_Click(object sender, EventArgs e)
        {
            // Reverse the state of the light.

            if (picLightOn.Visible == true)  //light is currently on
            {
                //call the correct method to turn the light off

            }
            else
            {
                //call the correct method to turn the light on

            }
        }
    }
}
