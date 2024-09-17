	     // ? declare intCreditHours as an integer data type
            int intCourseLabFees;
            decimal decCreditHourRate;
            decimal decTotalTuition;
            const int INFRASTRUCTURE_FEE = 60;
            const int REGISTRATION_FEE = 50;
            // const int SERVICE_FEE_PER_CREDIT = ?;
            const int TECH_FEE_PER_CREDIT = 4;
            // ? define a constant STUDENT_ACTIVITY_FEE_PER_CREDIT to 2            

            string strMessage = "";

            //Get numeric data from textbox controls
            intCreditHours = int.Parse(txtCreditHours.Text);
            decCreditHourRate = decimal.Parse(txtCreditHourRate.Text);
            // ? Set intCourseLabFees to txtCourseLabFees using the Parse method


            //Calculate Total Tuition
            decTotalTuition = INFRASTRUCTURE_FEE + REGISTRATION_FEE +
                (? * decCreditHourRate) +
                (intCreditHours * SERVICE_FEE_PER_CREDIT) +
                (intCreditHours * ? ) +
                (intCreditHours * ? ) +
                intCourseLabFees;

            //Display message to student
            strMessage = ? "'s total tuition is " + decTotalTuition.ToString("C2") + "."
                + "Thank you for choosing HFC - Future Driven!";

            