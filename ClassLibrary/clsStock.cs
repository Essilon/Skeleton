using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data memeber for the SofaNumber property
        private Int32 mSofaNumber;
        public int SofaNumber
        {
            get
            {
                return mSofaNumber;
            }
            set
            {
                mSofaNumber = value;
            }
        }

        private Int32 mSofaDescription;
        public int SofaDescription
        {
            get
            {
                return mSofaDescription;
            }
            set
            {
                mSofaDescription = value;
            }
        }

        private String mSofaColour;
        public string SofaColour
        {
            get
            {
                return mSofaColour;
            }
            set
            {
                mSofaColour = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = (DateTime)value;
            }
        }

        private decimal mPrice;
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }

        }

        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public bool Find(int SofaNumber)
        {

            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the prameter for the SofaNumber to search for
            DB.AddParameter("@SofaNumber", SofaNumber);
            //execute the store procedure
            DB.Execute("sproc_tblAddress_FilterByAddressNo");
            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                mSofaNumber = Convert.ToInt32(DB.DataTable.Rows[0]["Sofa Number"]);
                mSofaDescription = Convert.ToInt32(DB.DataTable.Rows[0]["Sofa Description"]);
                mSofaColour = Convert.ToString(DB.DataTable.Rows[0]["Sofa Colour"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["Date Time"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
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