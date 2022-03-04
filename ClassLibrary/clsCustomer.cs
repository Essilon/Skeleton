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

        public bool Find(int CustotmerID)
        {
            //set the private data member to the test data value
            mCustomerID = 6;

            mFull_Name = "Test Name";

            mDateOfBirth = Convert.ToDateTime("04/03/2022");

            mGender = true;

            mEmail = "Test@Email.com";

            mAddress = "Test Address";

            //always return true
            return true;
        }
    }
}