            DateTime dtmNow = DateTime.Now;
            int intYearsWorked = dtmNow.Year - dtmHireDate.Year;

            if (dtmNow.Month < dtmHireDate.Month || (dtmNow.Month == dtmHireDate.Month && dtmNow.Day < dtmHireDate.Day))
                intYearsWorked--;
                                   
            //return years worked