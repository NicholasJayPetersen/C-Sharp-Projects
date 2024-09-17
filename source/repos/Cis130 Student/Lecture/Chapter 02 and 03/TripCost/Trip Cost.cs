using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripCost
{
    public partial class frmTripCost : Form
    {
        public frmTripCost()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables for numeric input from TextBox controls
            int intTankCapacity;
            decimal decGallonsLeft;
            decimal decMilesDriven;
            decimal decCostofGas;

            //declare variables used in calculations
            decimal decGallonsUsedOnTrip, decMPG, decTripCost, decMiles;

            //Get input and assign data to numeric variables
            intTankCapacity = int.Parse(txtCarTankCapacity.Text);
            decGallonsLeft = decimal.Parse(txtGallonsLeft.Text);
            decMilesDriven = decimal.Parse(txtMilesDriven.Text);
            decCostofGas = decimal.Parse(txtGasCostPerGallon);

            //Determine how many gallons were used on the trip
            decGallonsUsedOnTrip = decGallonsLeft - intTankCapacity;

            //Compute the Miles Per Gallon
            decMPG = intTankCapacity / decGallonsUsedOnTrip;

            //Compute the trip cost
            decTripCost = decGallonsLeft * decCostofGas;

            //Output results to user
            lblMilesPerGallon.Text = decMPG;
        }
    }
}
