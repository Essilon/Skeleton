using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
     
        public List<clsStaff> mStaffList = new List<clsStaff>();
       /* public clsStaffCollection()
        {
            clsStaff TestItem = new clsStaff();
            TestItem.StaffNo = 1;
            TestItem.StaffTarget = 1;
            TestItem.StaffFullName = "Ken Dow";
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffAge = 22;
            TestItem.Male = true;

            mStaffList.Add(TestItem);

            TestItem = new clsStaff();
            TestItem.StaffNo = 2;
            TestItem.StaffTarget = 2;
            TestItem.StaffFullName = "ben Low";
            TestItem.StaffDateOfBirth= DateTime.Now.Date;
            TestItem.StaffAge = 24;
            TestItem.Male = true;

            mStaffList.Add(TestItem);
        }*/
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.Male = Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender"]);
                AnStaff.StaffAge = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeAge"]);
                AnStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["Employyee_No"]);
                AnStaff.StaffDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnStaff.StaffTarget = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeTarget"]);
                AnStaff.StaffFullName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeFullName"]);

                mStaffList.Add(AnStaff);
                Index++; 
            }

        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }

            set
            {
                mStaffList = value; 
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {
                
            }
        }
        public clsStaff ThisStaff { get; set; }
    }
}