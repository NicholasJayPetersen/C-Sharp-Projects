using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Airlines
{
    public static class Validator
        // All methods needed to validate any input will be coded in this
        // static class
    {
        public static string IsValidFlightDate(DateTime ?FlightDate)
        {
            string msg = "";
            // Make sure FlightDate is not within 6 months of today
            DateTime currentDate = DateTime.Today;
            if(FlightDate < currentDate.AddMonths(6)){
                msg += ((DateTime)FlightDate).ToString("d") + " Must be 6 months from today.\n";
            }

            return msg;
        }
        public static string IsValidFlightTime(string Hour, string Minute, string AMPM)
        {
            string msg = "";
            // Make sure Hour is an integer and within 1 to 12 range
            msg += IsInt32(Hour, "Hour");
            msg += IsWithinRange(Hour, "Hour", 1, 12);

            // Make sure minute is an integer and within range of 0 to 59
            msg += IsInt32(Minute, "Minute");
            msg += IsWithinRange(Minute, "Minute", 0, 59);

            // Make sure AMPM is present by calling IsPresent method
            msg += IsPresent(AMPM, "AM/PM");


            return msg;
        }
        public static string IsValidFlightGate(string GateLetter, string GateNo)
        {
            string msg = "";
            
            // Make sure GateLetter is valid
            if (GateLetter.ToUpper() != "A" && GateLetter.ToUpper() != "B" && GateLetter.ToUpper() != "C") {
                msg += "Gate Letter must be either A, B, or C.\n";
                return msg;
            }

            // Make sure Gate number is valid based upon gate letter selected
            switch (GateLetter)
            {
                case "A":
                    if (!(int.TryParse(GateNo, out int numA) && numA >= 1 && numA <= 78))
                        msg += "Gate Number must be a valid integer between 1 and 78\n";
                    break;
                case "B":
                    if (!(int.TryParse(GateNo, out int numB) && numB >= 1 && numB <= 21))
                        msg += "Gate Number must be a valid integer between 1 and 21\n";
                    break;
                case "C":
                    if (!(int.TryParse(GateNo, out int numC) && numC >= 1 && numC <= 43))
                        msg += "Gate Number must be a valid integer between 1 and 43\n";
                    break;
            }

            return msg;
        }
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value=="")
            {
                msg += name + " is required, it cannot be blank.\n";
            }
            return msg;
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

    }
}
