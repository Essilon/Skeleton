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
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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

        public void Update()
        {
            //UpdateMethodOK and exsisting record based on the values of thisCustomer
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedurte
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("Full_Name", mThisCustomer.Full_Name);
            DB.AddParameter("Date_of_Birth", mThisCustomer.DateOfBirth);
            DB.AddParameter("Gender", mThisCustomer.Gender);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("Address", mThisCustomer.Address);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByAddress(string Address)
        {
            //filters the record based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@Address", Address);
            //execute the sotred [rpcedure
            DB.Execute("sproc_tblCustomer_FilterByAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to soter the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
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
    }
}