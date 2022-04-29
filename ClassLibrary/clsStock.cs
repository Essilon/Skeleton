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

        public object Count { get; set; }
        public bool Active { get; set; }

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

        public string Valid(string SofaNumber, string SofaDescription, string SofaColour, string DateAdded, string Price, string Available)
        {
            //create a string variable to store the error
            String Error = "";
            
            //create a tempory variable to store date values 
            DateTime DateTemp;
            //if the sofanumber is blank
            if (SofaNumber.Length == 0) ;
            {
                //record the error 
                Error = Error + "The sofa number may be blank";
            }
            //if the sofa Number is greater than 6 character 
            if(SofaNumber.Length > 6)
            {
                //record the error 
                Error = Error + "The sofa number must be less then 6 character";

            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
               DateTemp = Convert.ToDateTime(DateAdded);
               if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
               if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //is the post code blank
            if (SofaDescription.Length == 0)
            {
                //record the error
                Error = Error + "The SofaDescription may not be blank : ";
            }
            //if the post code is too long
            if (SofaDescription.Length > 9)
            {
                //record the error
                Error = Error + "The SofaDescription must be less than 9 characters : ";
            }
            //is the street blank
            if (SofaColour.Length == 0)
            {
                //record the error
                Error = Error + "The SofaColour may not be blank : ";
            }
            //if the street is too long
            if (SofaColour.Length > 50)
            {
                //record the error
                Error = Error + "The SofaColour must be less than 50 characters : ";
            }
            //is the town blank
            if (Price.Length == 0)
            {
                //record the error
                Error = Error + "The Price may not be blank : ";
            }
            //if the town is too long
            if (Price.Length > 50)
            {
                //record the error
                Error = Error + "The Price must be less than 50 characters : ";
            }

            //is the town blank
            if (Available.Length == 0)
            {
                //record the error
                Error = Error + "The Available may not be blank : ";
            }
            //if the town is too long
            if (Available.Length > 50)
            {
                //record the error
                Error = Error + "The Available must be less than 50 characters : ";
            }

            //return any error messages
            return Error;
        }

        public void Find(string sofaNumber)
        {
            throw new NotImplementedException();
        }
    }
}