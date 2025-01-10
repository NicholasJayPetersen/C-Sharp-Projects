using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment05
{
    /// <summary>
    /// Interaction logic for SpinResults.xaml
    /// </summary>

    public partial class SpinResults : Window
    {
        public int SpinValue;
        public Random RandomGenerator = new Random();
        private Label[] _lblWindowLabels;
        

        public SpinResults()
        {
            InitializeComponent();

            SetUpArrayLabels();

            DisplaySpinValue();
        }
        private void SetUpArrayLabels()
        {
            _lblWindowLabels = new Label[] {lbl0,lbl100,lbl200,lbl300,lbl400,lbl500};
        }
        private void DisplaySpinValue()
        {
            int iIndex;

            iIndex = RandomGenerator.Next(0, 6);

            _lblWindowLabels[iIndex].Background = Brushes.Yellow;
            SpinValue = iIndex * 100;
        }

        

        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        
    }
}
