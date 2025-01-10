using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CIS_Textbooks
{
    public static class UserValidation
    {
        // IsPresent will determine if an input contains any string data
        public static string IsPresent(string value, string field)
        {
            string strMsg = "";
            if (value == "")
            {
                strMsg = field + " is a required field.\n";
            }
            return strMsg;
        }
        public static string IsInt32(string value, string name)
        {
            string msg = "";

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

        // IsValidISBN makes sure it is in the format of 999-9-999999-99-9
        public static string IsValidISBN(string value)
        {
            string strMsg = "";

            Match IDFormat = Regex.Match(value, @"[0-9][0-9][0-9]-[0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9]");
            if (IDFormat.Success == false)
            {
                strMsg += "ISBN must be in the format of 999-9-999999-99-9";
            }
            return strMsg;
        }
        
       
        // The phone number must be in the format of 999-999-9999
        public static string IsValidPhoneNumber(string value)
        {
            string strMsg = "";

            //Phone number must be in the following format 999-999-9999
            Match IDFormat = Regex.Match(value, @"[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]");
            if (IDFormat.Success == false)
            {
                strMsg = "The phone number must be in the following format: 999-999-9999.\n";
            }
            return strMsg;
        }

    }
}
