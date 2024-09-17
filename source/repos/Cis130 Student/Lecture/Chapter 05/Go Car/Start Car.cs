using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Go_Car
{
    public partial class frmCar : Form
    {
        public frmCar()
        {
            InitializeComponent();
        }

        private void tmrCarSpeed_Tick(object sender, EventArgs e)
        {
            //UnComment lines 23 to 28
            //int iCount;
            //for (iCount = ?; iCount <= ?; iCount++)
            //{
            //    picCar.Location = new Point(?, ?);
            //    this.Refresh();
            //}

            //the car will never stop, add a line of code to stop the car after it
            //crosses the finish line
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start the timer control

        }
    }
}
