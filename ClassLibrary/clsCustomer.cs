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
    }
}