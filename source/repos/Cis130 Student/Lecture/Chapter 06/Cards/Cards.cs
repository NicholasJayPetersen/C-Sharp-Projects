using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class frmCards : Form
    {
        public frmCards()
        {
            InitializeComponent();
        }

        // The ShowCard method accepts a string that names
        // the selected card, and displays that card.

        // The ShowAceSpades method makes the Ace of Spades
        // visible and the other cards invisible.
        private void ShowAceSpades()
        {
            picAceSpades.Visible = true;
            picTenHearts.Visible = false;
            picKingClubs.Visible = false;
        }

        // The ShowTenHearts method makes the Ten of Hearts
        // visible and the other cards invisible.
        private void ShowTenHearts()
        {
            picTenHearts.Visible = true;
            picAceSpades.Visible = false;
            picKingClubs.Visible = false;
        }

        // The ShowKingClubs method makes the King of Clubs
        // visible and the other cards invisible.
        private void ShowKingClubs()
        {
            picKingClubs.Visible = true;
            picAceSpades.Visible = false;
            picTenHearts.Visible = false;
        }

        private void btnShowCard_Click(object sender, EventArgs e)
        {
            // If a card is selected in the ListBox, display it.
            if (lstCardList.SelectedIndex != -1)
            {
                //Call ShowCard method passing in the SelectedItem

            }
            else
            {
                MessageBox.Show("Please select a card from " +
                                "the list box.");
            }
        }

        private void frmCards_Load(object sender, EventArgs e)
        {
            lstCardList.Items.Add("Ace of Spades");
            lstCardList.Items.Add("10 of Hearts");
            lstCardList.Items.Add("King of Clubs");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }
    }
}
