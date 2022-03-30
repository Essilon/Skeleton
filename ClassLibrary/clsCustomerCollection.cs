using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data memeber thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the p;rivate data
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //ibject for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                //copy the data from the database to the private data members
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.Full_Name = Convert.ToString(DB.DataTable.Rows[Index]["Full_Name"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date_of_Birth"]);
                AnCustomer.Gender = Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@Full_Name", mThisCustomer.Full_Name);
            DB.AddParameter("Date_of_Birth", mThisCustomer.DateOfBirth);
            DB.AddParameter("Gender", mThisCustomer.Gender);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("Address", mThisCustomer.Address);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
}