using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
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

        public clsStock ThisStock { get; set; }

        List<clsStock> mStockList = new List<clsStock>();

    }
}