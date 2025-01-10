            if (txtEmployeename.Text== "")
            {
                //Employee name is required
                MessageBox.Show("The employee name is required.", "Entry Error",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmployeename.Focus();
                return false;
            }

            if (rdoFemale.Checked==false && rdoMale.Checked==false)
            {
                //Gender is required
                MessageBox.Show("The gender is required.", "Entry Error",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpGender.Focus();
                return false;
            }

            if (dtpHireDate.Checked==false)
            {
                //Date of Hire is required
                MessageBox.Show("Please enter the date of hire.", "Entry Error",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpHireDate.Focus();
                return false;
            }

            if (chkFinance.Checked==false &&
                chkGeneralManagement.Checked==false &&
                chkHumanResources.Checked==false &&
                chkMarketing.Checked==false &&
                chkOperations.Checked==false &&
                chkPurchasing.Checked==false &&
                chkSales.Checked==false)
            {
                //One department must be selected
                MessageBox.Show("At least one department must be selected.", "Entry Error",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpDepartments.Focus();
                return false;
            }

            //If there are no validation errors then return true

            