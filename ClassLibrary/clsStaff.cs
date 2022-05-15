using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public string Employee_No;

        private bool mMale;
        public bool Male
        {
            get
            {
                return mMale;
            }
            set
            {
                mMale = value;
            }
        }

       
       

        private Int32 mStaffNo; 
        public Int32 StaffNo
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value; 
            }
        }

        private Int32 mStaffAge;
        public Int32 StaffAge
        {
            get
            {
                return mStaffAge;
            }
            set
            {
                mStaffAge = value;
            }
        }

        private Int32 mStaffTarget;
        public int StaffTarget
        {
            get
            {
                return mStaffTarget;
            }
            set
            {
                mStaffTarget = value;
            }
        }

        private string mStaffFullName; 
        public string StaffFullName
        {
            get
            {
                return mStaffFullName;
            }
            set
            {
                mStaffFullName = value;
            }
        }

        private DateTime mStaffDateOfBirth;
        public DateTime StaffDateOfBirth
        {
            get
            {
                return mStaffDateOfBirth;
            }
            set
            {
              mStaffDateOfBirth = value;
            }
        }

        public bool Find(int StaffNo)
        {
            mStaffNo = 21;
            mStaffAge = 21;
            mStaffTarget = 21;
            mStaffFullName = "Ken Dow";
            mStaffDateOfBirth = Convert.ToDateTime("16/9/2015");
            mMale = true; 
          return true;
            
        }
        public string Valid(string StaffAge, string StaffDateOfBirth, string StaffFullName, string StaffTarget)
        {
            String Error = "";
            int Age;
            DateTime DateTemp;
            int target;

            if (StaffFullName.Length == 0)
            {
                Error = Error + "The Staff full name may not be blank : ";
            }

            if (StaffFullName.Length > 50)
            {
                Error = Error + "The Staff Full Name should be less than 50 characters :  ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(StaffDateOfBirth);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not valid";
            }
            try
            {
                Age = Convert.ToInt32(StaffAge);

                if (Age < 0)
                {
                    Error = Error + "This Age is not possible";
                }

                if (Age > 100)
                {
                    Error = Error + "This age is too old for work";
                }
            }
            catch { Error = Error + "Error"; }

            try
            {
                target = Convert.ToInt32(StaffTarget);

                if (target < 0)
                {
                    Error = Error + "This number is not possible";
                }

                if (target > 50)
                {
                    Error = Error + "This number is to big to be the target";
                }
            }
            catch { Error = Error + "Error"; }


            return Error;
        
        }
    }
}