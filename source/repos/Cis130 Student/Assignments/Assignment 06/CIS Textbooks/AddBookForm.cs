using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_Textbooks
{
    public partial class AddBookForm : Form
    {
        int _CourseNumber = 0;
        string _Title = "";
        string _Author = "";
        string _Publisher = "";
        string _ISBN = "";
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate user data
            string errors = "";

            errors += UserValidation.IsInt32(txtCourseNumber.Text, "Course Number");
            errors += UserValidation.IsWithinRange(txtCourseNumber.Text, "Course Number", 100, 299);
            errors += UserValidation.IsPresent(txtCourseNumber.Text, "Course Number");
            errors += UserValidation.IsPresent(txtTitle.Text, "Title");
            errors += UserValidation.IsPresent(txtAuthor.Text, "Author");
            errors += UserValidation.IsPresent(txtPublisher.Text, "Publisher");
            errors += UserValidation.IsPresent(txtISBN.Text, "ISBN");
            errors += UserValidation.IsValidISBN(txtISBN.Text);

            if(errors != "")
            {
                MessageBox.Show(errors);
                return;
            }


            //pull input data from form
            _CourseNumber = int.Parse(txtCourseNumber.Text);
            _Title = txtTitle.Text;
            _Author = txtAuthor.Text;
            _Publisher = txtPublisher.Text;
            _ISBN = txtISBN.Text;

            //Add to global list
            Textbook _Textbook = new Textbook();
            _Textbook.CourseNumber = _CourseNumber;
            _Textbook.Title = _Title;
            _Textbook.Author = _Author;
            _Textbook.Publisher = _Publisher;
            _Textbook.ISBN = _ISBN;

            AppGlobals.Textbooks.Add(_Textbook);

            MessageBox.Show("Textbook Added successfully.");
            this.Close();

        }
    }
}
