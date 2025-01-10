
            catch (?)            //reference the FormatException class
            {
                MessageBox.Show("Invalid numeric format. Please check all entries.", "Entry Error");
            }
            catch (?)         //reference the OverflowException
            {
                MessageBox.Show("Overflow error. Please enter smaller values.","Entry Error");
            }
            catch (?)          //declare variable ex as Exception class
            {
                MessageBox.Show("Error message: " + ex.Message, ex.GetType().ToString());
            }