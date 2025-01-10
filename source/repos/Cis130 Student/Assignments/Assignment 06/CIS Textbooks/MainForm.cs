namespace CIS_Textbooks
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();

            // Display All Form will appear first
            DisplayForm("DisplayAll");

        }

        private void tolBTNAddBook_Click(object sender, EventArgs e)
        {
            DisplayForm("NewBook");

        }

        private void tolBTNDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayForm("DisplayAll");

        }
        private void DisplayForm(string Name)
        {
            switch (Name.ToUpper())
            {
                case "DISPLAYALL":
                    DisplayAllForm frmDisplayAll = new DisplayAllForm();

                    frmDisplayAll.ShowDialog();
                    break;
                case "NEWBOOK":
                    AddBookForm frmAddBook = new AddBookForm();
                    frmAddBook.MdiParent = this;
                    frmAddBook.Show();
                    break;

            }
        }

        private void tolBTNSaveBooks_Click(object sender, EventArgs e)
        {
            try
            {
                //Create stream writer to handle file update
                StreamWriter NewBooks = File.AppendText(AppGlobals.DiskFileName);
                string line;

                //add each new book to the file
                foreach (Textbook Book in AppGlobals.Textbooks)
                {
                    line = $"\n{Book.CourseNumber}|{Book.ISBN}|{Book.Title}|{Book.Author}|{Book.Publisher}";
                    NewBooks.Write(line);
                }

                //clkose the file and clear the list
                NewBooks.Close();
                AppGlobals.Textbooks.Clear();
                MessageBox.Show("Books saved successfully");
            }
            catch (IOException IOerror)
            {
                MessageBox.Show(IOerror.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tolBTNExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
