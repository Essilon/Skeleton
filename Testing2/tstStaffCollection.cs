using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]

    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            Assert.IsNotNull(AllStaff);
        }

        public void StaffListOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffNo = 1;
            TestItem.StaffTarget = 1;
            TestItem.StaffFullName = "Ken Dow";
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffAge = 22;
            TestItem.Male = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ThisStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffNo = 1;
            TestStaff.StaffTarget = 1;
            TestStaff.StaffFullName = "Ken Dow";
            TestStaff.StaffDateOfBirth = DateTime.Now.Date;
            TestStaff.StaffAge = 22;
            TestStaff.Male = true;


            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffNo = 1;
            TestItem.StaffTarget = 1;
            TestItem.StaffFullName = "Ken Dow";
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffAge = 22;
            TestItem.Male = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffNo = 1;
            TestItem.StaffAge = 22;
            TestItem.StaffTarget = 1;
            TestItem.StaffFullName = "Ken Dow";
            TestItem.Male = true;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffNo = 1;
            TestItem.StaffAge = 22;
            TestItem.StaffTarget = 1;
            TestItem.StaffFullName = "Ken Dow";
            TestItem.Male = true;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;

            TestItem.StaffNo = 3;
            TestItem.StaffAge = 24;
            TestItem.StaffTarget = 12;
            TestItem.StaffFullName = "ben now";
            TestItem.Male = false;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffNo = 19;
            TestItem.StaffAge = 22;
            TestItem.StaffTarget = 1;
            TestItem.StaffFullName = "Ken Dow";
            TestItem.Male = true;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();

            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportByStaffFullNameMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffFullName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }


        [TestMethod]
            
            public void ReportByStaffFullNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffFullName("xxx xxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffFullNameTestDataFound()
        {
            clsStaffCollection FilteredStaffFullName = new clsStaffCollection();
            Boolean Ok = true;

            FilteredStaffFullName.ReportByStaffFullName("Random Name");
            if (FilteredStaffFullName.Count == 2)
            {
                if (FilteredStaffFullName.StaffList[0].StaffNo != 1)
                {
                    Ok = false;
                }
                if (FilteredStaffFullName.StaffList[1].StaffNo != 2)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;

            }
            Assert.IsFalse(Ok);
        }
    }
}

