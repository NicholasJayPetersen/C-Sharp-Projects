            string msg = "";
            //Check if value is a decimal, code discard value for output
            if (!Decimal.TryParse(? , out ?))
            {
                msg += name + " must be a valid decimal value.\n";
            }
            return msg;