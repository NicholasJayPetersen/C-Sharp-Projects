using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Treasure_Chest
{
   public static class Validator
    {
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            // Check if value is empty
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }
        public static string  IsInteger(string value, string name)
        {
            string msg = "";

            //Check if value is an integer, code discard value for output
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }

        public static string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }

    }
}
