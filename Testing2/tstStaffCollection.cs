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
        public void TestMethod1() 
        {
        }

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

            TestList.Add(TestStaff);
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
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

  

       


        
    }

}
