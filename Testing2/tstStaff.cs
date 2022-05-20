using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        string StaffAge = "22";
        string StaffFullName = " Kenny Williamosn";
        string StaffTarget = "5";
        string StaffDateOfBirth = DateTime.Now.Date.ToString();

        [TestMethod]
        public void TestStaffNoFound()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = true;

            Int32 StaffNo = 1;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffNo != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Int32 StaffNo = 22;
            Found = AnStaff.Find(StaffNo);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void InstanceOk()
        {
            clsStaff AnStaff = new clsStaff();

            Assert.IsNotNull(AnStaff);

        }
        [TestMethod]
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
        [TestMethod]
        public void StaffDateOfBirthOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();

            //create some test data to assignm to th
            DateTime TestData = DateTime.Now.Date;

            AnStaff.StaffDateOfBirth = TestData;

            Assert.AreEqual(AnStaff.StaffDateOfBirth, TestData);
        }
        [TestMethod]
        public void StaffNo()
        {
            clsStaff AnStaff = new clsStaff();

            Int32 TestData = 1;

            AnStaff.StaffNo = TestData;

            Assert.AreEqual(AnStaff.StaffNo, TestData);

        }
        [TestMethod]
        public void StaffAgeOK()
        {
            clsStaff AnStaff = new clsStaff();

            Int32 TestData = 1;

            AnStaff.StaffAge = TestData;

            Assert.AreEqual(AnStaff.StaffAge, TestData);
        }
        [TestMethod]
        public void StaffTargetOK()
        {
            clsStaff AnStaff = new clsStaff();

            Int32 TestData = 25;

            AnStaff.StaffTarget = TestData;

            Assert.AreEqual(AnStaff.StaffTarget, TestData);
        }
        [TestMethod]
        public void StaffFullNameOK()
        {
            clsStaff AnStaff = new clsStaff();

            string TestData = "Kenny Williamosn";

            AnStaff.StaffFullName = TestData;

            Assert.AreEqual(AnStaff.StaffFullName, TestData);
        }
        [TestMethod]
        public void TestStaffDateOfBirth()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 1;
            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffDateOfBirth != Convert.ToDateTime("10/02/2000"))
            {
                OK = false;

            }

            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffAge()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = true;

            Int32 StaffNo = 1;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffAge != 22)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffTarget()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = true;

            Int32 StaffNo = 1;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffTarget != 5)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffFullName()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 1;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.StaffFullName != "Kenny Williamosn")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffGender()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean Ok = true;

            Int32 StaffNo = 1;

            Found = AnStaff.Find(StaffNo);

            if (AnStaff.Male != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        public void StaffFullNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "";
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();

            string Error = "";

            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffFullNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFullName = "a";
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffFullNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "aa";
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void StaffFullNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "aaaaa";
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffFullNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(50, 'a');
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffFullNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(25, 'a');
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffFullNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "";
            StaffFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(50000, 'a');
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String StaffDateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffDateOfBirthMinlessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            String StaffDateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffDateOfBirthMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String StaffDateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDateOfBirthPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String StaffDateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffDateOfBirthExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String StaffDateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffDateOfBirth = "This is not a date!";
            Error = AnStaff.Valid(StaffFullName, StaffAge, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAgeExtreme()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = 1000;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAgeExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = -100000000;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAgeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = 1;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = 2;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffAgeMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = 99;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = 100;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = 101;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int Age = 50;
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeInvaldData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Age = "This is not an age!";
            String StaffAge = Age.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffTargetMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int target = -1;
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffTargetMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int target = 0;
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffTargetMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int target = 1;
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffTargetMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int target = 49;
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffTargetMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int target = 50;
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffTargetMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int target = 51;
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffTargetMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int target = 25;
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffTargetInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string target = "The data is not a valid number";
            String StaffAge = target.ToString();
            Error = AnStaff.Valid(StaffAge, StaffFullName, StaffDateOfBirth, StaffTarget);
            Assert.AreNotEqual(Error, "");

        }
    }
}
