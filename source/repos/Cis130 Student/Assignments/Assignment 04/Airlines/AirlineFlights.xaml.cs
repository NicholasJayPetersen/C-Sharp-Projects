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
using System.Xml.Linq;



namespace Airlines
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetupFlightWindow();
        }

        List<String> lstDepartures = new List<string>();
        List<String> lstArrivals = new List<string>();
        string strAirline = "";
        private void SetupFlightWindow()
        {
            // setup ComboBox control for Flight Type
            cboFlightType.Items.Add("Arrival");
            cboFlightType.Items.Add("Departure");
            cboFlightType.SelectedIndex = 0;
            
            // setup ComboBox control with AM and PM needed for flight time
            cboAmPm.Items.Add("AM");
            cboAmPm.Items.Add("PM");

            // Set DatePicker control to the current date
            dtpFlightDate.SelectedDate = DateTime.Now;
            
        }

        private void cboFlightType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If Arrival is selected then the caption label should by "_Arriving from:"
            if(cboFlightType.SelectedIndex == 0)
            {
                lblLocationCaption.Content = "_Arriving from:";
            }
            // otherwise, "_Departing to:"
            if (cboFlightType.SelectedIndex == 1) 
            {
                lblLocationCaption.Content = "_Departing to:";
            }

        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if(!IsValidData())
            {
                return;
            }

            //get checked the airline radio box
            if (rdoAirFrance.IsChecked == true)
            {
                strAirline = (string)rdoAirFrance.Content;
            }
            if (rdoDelta.IsChecked == true) 
            {
                strAirline = (string)rdoDelta.Content;
            }


            //get flight data
            DateTime dteFlightDate = DateTime.Parse(dtpFlightDate.Text);
            string strFlightData = strAirline + " -- Date: " + dtpFlightDate.Text + " Time: " + txtHour.Text + ":" + txtMinute.Text + " " + cboAmPm.Text + "\n" +
                        "Gate: " + txtGateLetter.Text + "-" + txtGateNumber.Text + " Location: " + txtCityLocation.Text + "\n" +
                        "========================================Your flight is in " + (dteFlightDate - DateTime.Now).Days + " days========================================";

            //add flight data to the appropriate list
            if (cboFlightType.SelectedIndex == 0)
            {
                lstArrivals.Add("Arrival -- " + strFlightData);

            }

            if (cboFlightType.SelectedIndex == 1)
            {

                lstDepartures.Add("Departure -- " + strFlightData);
            }

            MessageBox.Show("Your " + strAirline + " " + cboFlightType.Text + " was added succesfully");
        }

        private bool IsValidData()
        {
            bool success = true;
            string ErrMessage="";
            DateTime.TryParse(dtpFlightDate.Text, out DateTime dteFlightDate);

            // Call Validation methods from Validator class to validate input
            ErrMessage += Validator.IsPresent(cboFlightType.Text, "Flight Type");
            ErrMessage += Validator.IsPresent(txtCityLocation.Text, "Location");
            ErrMessage += Validator.IsValidFlightDate(dteFlightDate);
            ErrMessage += Validator.IsValidFlightTime(txtHour.Text, txtMinute.Text, cboAmPm.Text);
            ErrMessage += Validator.IsValidFlightGate(txtGateLetter.Text, txtGateNumber.Text);

            // If any errors exist then display in User Messages form
            if (ErrMessage!="")
            {
                success = false;
                User_Messages wndUserMsgs = new User_Messages();
                // display error messages in TextBox control of user messages window
                wndUserMsgs.Content = ErrMessage;

                // Display error messages to user by calling ShowDialog method of user messages window
                wndUserMsgs.ShowDialog();
            }
            return success;




        }

        private void btnDisplayArrivals_Click(object sender, RoutedEventArgs e)
        {
            // Use your List<string> collection for arrivals to display information in the Flight Information window
            Flight_Information frmArrivals = new Flight_Information();
            frmArrivals.Title = "Flight Information";

            //removes System.Windows.Controls.Grid from content property before appending string
            frmArrivals.Content = "";

            //append each flight in the list to the content box
            foreach (string flight in lstArrivals)
            {
                frmArrivals.Content += flight + "\n";
            }




            // Display Flight information to user
            frmArrivals.ShowDialog();
        }

        private void btnDeparture_Click(object sender, RoutedEventArgs e)
        {
            // Use your List<string> collection for departures to display information in the Flight Information window
            Flight_Information frmDepartures = new Flight_Information();
            frmDepartures.Title = "Flight Information";

            //removes System.Windows.Controls.Grid from content property before appending string
            frmDepartures.Content = "";

            //append each flight in the list to the content box
            foreach( string flight in lstDepartures)
            {
                frmDepartures.Content += (string)flight + "\n";
            }



            // Display Flight information to user
            frmDepartures.ShowDialog();

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            cboFlightType.SelectedIndex = 0;
            rdoDelta.IsChecked = true;
            txtCityLocation.Text = "";
            dtpFlightDate.Text = DateTime.Now.ToString("d");
            txtHour.Text = "";
            txtMinute.Text = "";
            txtGateLetter.Text = "";
            txtGateNumber.Text = "";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
