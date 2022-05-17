using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
     
        public List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff(); 
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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);

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
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@EmployeeAge ", mThisStaff.StaffAge );
            DB.AddParameter("@EmployeeTarget", mThisStaff.StaffTarget);
            DB.AddParameter("@EmployeeFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@Gender ", mThisStaff.Male );
            DB.AddParameter("@DateOfBirth", mThisStaff.StaffDateOfBirth);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Employee_No", mThisStaff.StaffNo);
            DB.AddParameter("@EmployeeAge ", mThisStaff.StaffAge);
            DB.AddParameter("@EmployeeTarget", mThisStaff.StaffTarget);
            DB.AddParameter("@EmployeeFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@Gender ", mThisStaff.Male);
            DB.AddParameter("@DateOfBirth", mThisStaff.StaffDateOfBirth);

             DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Employee_No", mThisStaff.StaffNo);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffFullName(string StaffFullName)
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeFullName", StaffFullName);

            DB.Execute("sproc_tblStaff_FilterByStaffFullName");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {

            Int32 Index = 0;
            Int32 RecordCount = 0;


            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["Employee_No"]);
                AnStaff.StaffAge = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeAge "]);
                AnStaff.StaffTarget = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeTarget"]);
                AnStaff.StaffFullName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeFullName"]);
                AnStaff.Male = Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender "]);
                AnStaff.StaffDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);

                mStaffList.Add(AnStaff);
                Index++;
            }

        }


    }
}