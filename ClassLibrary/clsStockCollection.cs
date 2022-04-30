using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data 
                mStockList = value;
            }
        }
        
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //weshall worry about this later 
            }
        }


        public clsStock ThisStock
        {
            get
            {
                //return the private data 
                return mThisStock;
            }
            set
            {
                //set the private data 
                mThisStock = value;
            }
        }


        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@SofaNumber", mThisStock.SofaNumber);
            DB.AddParameter("SofaDescription", mThisStock.SofaDescription);
            DB.AddParameter("SofaColour", mThisStock.SofaColour);
            DB.AddParameter("DateAdded", mThisStock.DateAdded);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("Available", mThisStock.Available);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@SofaNumber", mThisStock.SofaNumber);
            DB.AddParameter("SofaDescription", mThisStock.SofaDescription);
            DB.AddParameter("SofaColour", mThisStock.SofaColour);
            DB.AddParameter("DateAdded", mThisStock.DateAdded);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("Available", mThisStock.Available);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SofaNumber", mThisStock.SofaNumber);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByAvailable(string Available)
        {
            //filters the record based on a full or partial available
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Available", Available);
            DB.Execute("sproc_tblStock_FilterByAvaialble");
        }

    }
}