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
            mSofaNumber = 1;
            mSofaDescription = 1;
            mSofaColour = "RED";
            mDateAdded = Convert.ToDateTime("24/04/2022");
            mPrice = 1;
            mAvailable = true;
            return true;
        }
    }
}