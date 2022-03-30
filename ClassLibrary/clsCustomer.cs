using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data memeber for the Customer ID property
        private Int32 mCustomerID;
        //public property for Customer ID
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data memeber for the Customer ID property
        private string mFull_Name;
        //full name public Property
        public string Full_Name
        {
            get
            {
                //this line of code sends data out of the property
                return mFull_Name;
            }
            set
            {
                //this line of code allows data into the property
                mFull_Name = value;
            }
        }

        //private data memeber for the Customer ID property
        private DateTime mDateOfBirth;
        //date of birth public property
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfBirth = value;
            }
        }

        //private data memeber for the Customer ID property
        private Boolean mGender;
        //gender public property
        public Boolean Gender
        {
            get
            {
                //this line of code sends data out of the property
                return mGender;
            }
            set
            {
                //this line of code allows data into the property
                mGender = value;
            }
        }

        //private data memeber for the Customer ID property
        private string mEmail;
        //email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        //private data memeber for the Customer ID property
        private string mAddress;
        //address public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFull_Name = Convert.ToString(DB.DataTable.Rows[0]["Full_Name"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["Date_of_Birth"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                //return that everything worked OK
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
        public string Valid(string full_Name, string dateOfBirth, string email, string address)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store tdata values
            DateTime DateTemp;

            //if the full_Name is blank
            if (full_Name.Length == 0)
            {
                //record the error
                Error = Error + "The Full Name field cannot be left blank! ";
            }

            //if the full_Name entered is greater than 50 characters
            if (full_Name.Length > 50)
            {
                //record the error
                Error = Error + "The Full Name field cannot be more than 50 characters! ";
            }

            //if the full_Name is entered too long
            if (full_Name.Length > 1000)
            {
                //record the error
                Error = Error + "The Full Name field cannot be more than 50 characters! ";
            }

            try
            {
                //copy the dateofBirth value to DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                //check to see if the date of birth is less than or equal to 100
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The date of birth that was entered is invalid! ";
                }

                //check to  see if the date is greater than the date value
                if (DateTemp > DateTime.Now.Date.AddDays(+1))
                {
                    //record the error
                    Error = Error + "The date you entered is in the future! ";
                }
            }

            catch
                {
                //record the error
                Error = Error + "This is not a valid date! ";
                }


            //if the email field is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email field cannot be left blank! ";
            }

            //if the email entered is greater than 50 characters
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "You cannot enter more than 50 characters! ";
            }

            //if the full_Name is too long
            if (email.Length > 1000)
            {
                //record the error
                Error = Error + "The enter more than 50 characters! ";
            }


            //if the address is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The Address field cannot be left blank! ";
            }

            //if the address is greater than 50 characters
            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The Address field cannot be more than 50 characters! ";
            }

            //if the address is too long
            if (address.Length > 1000)
            {
                //record the error
                Error = Error + "The Address field cannot be more than 50 characters! ";
            }

            //return any error messages
            return Error;
        }
    }
}