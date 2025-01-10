using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Textbooks
{
    public static class AppGlobals
    {
        // Declare a List of Textbook objects
        public static List<Textbook> Textbooks = new List<Textbook>();
        public static string DiskFileName = "TextbookData.txt";
    }
}
