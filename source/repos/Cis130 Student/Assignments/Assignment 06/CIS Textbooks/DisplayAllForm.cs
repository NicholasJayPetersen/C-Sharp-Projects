using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIS_Textbooks
{
    public partial class DisplayAllForm : Form
    {
        //declare field for collection of textbook objects
        List<Textbook> _Textbooks = new List<Textbook>();
        public DisplayAllForm()
        {
            InitializeComponent();
            // Call method to get all textbooks from a disk file
            GetAllTextbooks();

            
        }
        private void GetAllTextbooks()
        {
            try
            {
                StreamReader TextbookFile = new(new FileStream(AppGlobals.DiskFileName, FileMode.Open, FileAccess.Read));
                if(TextbookFile == null)
                {
                    throw new IOException("File is empty!");
                }
                if (File.Exists(AppGlobals.DiskFileName) == false)
                {
                    throw new IOException("Textbooks.txt does not exist!");
                }

                //check if not end of file
                int i = 0;
                while (TextbookFile.Peek() != -1)
                {
                    string BookFromFile = TextbookFile.ReadLine() ?? "";
                    string[] Properties = BookFromFile.Split("|");

                    if (Properties.Length == 5)
                    {
                        //set field textbook properties
                        _Textbooks.Add(new Textbook());
                        _Textbooks[i].CourseNumber = Convert.ToInt32(Properties[0]);
                        _Textbooks[i].ISBN = Properties[1];
                        _Textbooks[i].Title = Properties[2];
                        _Textbooks[i].Author = Properties[3];
                        _Textbooks[i].Publisher = Properties[4];


                        //add course number to course listbox
                        lstCISCourse.Items.Add(_Textbooks[i].CourseNumber);
                    }
                    else
                    {
                        throw new IOException("Unexpected text format in Textbooks.txt\n");
                    }
                    //incremement for next textbook
                    i++;
                }

                //close the file and set the selected course to first in the list
                TextbookFile.Close();
                lstCISCourse.SelectedIndex = 0;
            }
            catch(IOException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Uknown Error");
            }
        }

        private void lstCISCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A course has been selected.
            int intIndex;
            Textbook TextbookInfo;

            //populates textbook data for the selected course
            intIndex = lstCISCourse.SelectedIndex;
            TextbookInfo = _Textbooks[intIndex];
            lblTextInformation.Text = TextbookInfo.GetTextbookInfo();
        }
    }
}
