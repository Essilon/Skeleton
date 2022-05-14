using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]

        public void TestStaffNoFound()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = false;

            Int32 StaffNo = 21;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffNo != 21)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Int32 StaffNo = 21;
            Found = AnStaff.Find(StaffNo);
            Assert.IsTrue(Found);

        }

        public void InstanceOk()
        {
            clsStaff AnStaff = new clsStaff();

            Assert.IsNotNull(AnStaff);

        }

        public void StaffMaleYes()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();

            //create some test data to assignm to the property 
            Boolean TestData = true;

            //assign the data to the staff

            AnStaff.Male = TestData;
            //test to see that the two valuees are the same 
            Assert.AreEqual(AnStaff.Male, TestData); 


        }

        public void StaffDateOfBirth()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();

            //create some test data to assignm to the property 
            DateTime TestData = DateTime.Now.Date;

            AnStaff.StaffDateOfBirth = TestData;

            Assert.AreEqual(AnStaff.StaffDateOfBirth, TestData); 
        }

        public void StaffNo()
        {
           clsStaff AnStaff = new clsStaff();

            Int32 TestData = 1;

            AnStaff.StaffNo = TestData;

            Assert.AreEqual(AnStaff.StaffNo, TestData); 

        }
        public void StaffAge()
        {
            clsStaff AnStaff = new clsStaff();

            Int32 TestData = 1;

            AnStaff.StaffAge = TestData;

            Assert.AreEqual(AnStaff.StaffAge, TestData);
        }

        public void StaffTarget()
        {
            clsStaff AnStaff = new clsStaff();

            Int32 TestData = 25;

            AnStaff.StaffTarget = TestData;

            Assert.AreEqual(AnStaff.StaffTarget, TestData);
        }

        public void StaffFullName()
        {
            clsStaff AnStaff = new clsStaff();

            string TestData = "Joe Miller";

            AnStaff.StaffFullName = TestData;

            Assert.AreEqual(AnStaff.StaffFullName, TestData);
        }

        public void TestDateAddedFound()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 21;
            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffDateOfBirth != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;

            }

            Assert.IsTrue(OK); 

        }

        public void TestStaffAge() 
        { 
         clsStaff AnStaff = new clsStaff();

        Boolean Found = false;

        Boolean Ok = false;

        Int32 StaffNo = 21;

        Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffAge != 21)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        public void TestStaffTarget()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = false;

            Int32 StaffNo = 21;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffTarget != 21)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        public void TestStaffFullName()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = false;

            Int32 StaffNo = 21;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffFullName != "Josh Mosh ")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        public void TestStaffGender()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = false;

            Int32 StaffNo = 21;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.Male != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

    }
}
