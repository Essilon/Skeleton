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
            mStaffFullName = "Josh Mosh";
            mStaffDateOfBirth = Convert.ToDateTime("16/9/2015");
            mMale = true; 
          return true;
            
        }

    }
}