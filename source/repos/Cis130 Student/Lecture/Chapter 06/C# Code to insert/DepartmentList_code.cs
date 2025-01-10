            string strList="";

            for (int iloop=?;iloop<=?; iloop++)
            {
                switch (iloop)
                {
                    case 1:
                        if (chkGeneralManagement.Checked == true)
                        strList += "General Management" + Environment.NewLine;
                        break;
                    case 2:
                        if (chkMarketing.Checked == true)
                        strList += "Marketing" + Environment.NewLine;
                        break;
                    case 3:
                        if (chkOperations.Checked == true)
                            strList += "Operations" + Environment.NewLine;
                        break;
                    case 4:
                        if (chkFinance.Checked == true)
                            strList += "Finance" + Environment.NewLine;
                        break;
                    case 5:
                        if (chkSales.Checked == true)
                            strList += "Sales" + Environment.NewLine;
                        break;
                    case 6:
                        if (chkHumanResources.Checked == true)
                            strList += "Human Resources" + Environment.NewLine;
                        break;
                    
                }  //end of switch

                
            } //end of for loop

           