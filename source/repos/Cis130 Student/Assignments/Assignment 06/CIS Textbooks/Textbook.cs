using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Textbooks
{
    public class Textbook
    {
        public Textbook(Textbook Textbook) 
        {
            this.CourseNumber = 0;
            this.ISBN = Textbook.ISBN;
            this.Title = Textbook.Title;
            this.Author = Textbook.Author;
            this.Publisher = Textbook.Publisher;
        }
        public Textbook() 
        {
            this.CourseNumber= 0;
            this.ISBN = string.Empty;
            this.Title = string.Empty;
            this.Author = string.Empty;
            this.Publisher = string.Empty;
        }

        public int CourseNumber { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; } 
        public string Author {  get; set; }
        public string Publisher {  get; set; }

        public string GetTextbookInfo()
        {
            return $"ISBN: {ISBN}\n" +
                   $"Title: {Title}\n" +
                   $"Author/Publisher: {Author}/{Publisher}"; 
        }
    }
}
