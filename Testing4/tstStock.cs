using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {

        //good test data 
        //create some test data to pass to the method 
        string SofaNumber = "";
        string SofaDescription = "";
        string SofaColour = "";
        string DateAdded = DateTime.Now.Date.ToString();
        string Price = "";
        string Available = "";


        [TestMethod]
        public void InstanceOK()
        {
            //create and instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //test to see that it exists 
            Assert.IsNotNull(AnStock);

        }

        [TestMethod]
        public void SofaNumberPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data 
            int TestData = 1;
            //assign the data to the property 
            AnStock.SofaNumber = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnStock.SofaNumber, TestData);
        }

        [TestMethod]
        public void SofaDescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data
            int TestData = 1;
            //assign the data to the property 
            AnStock.SofaDescription = TestData;
            //test to se if the two values are the same
            Assert.AreEqual(AnStock.SofaDescription, TestData);
        }

        [TestMethod]
        public void SofaColourPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some data test
            string TestData = "";
            //assign the data to the property
            AnStock.SofaColour = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnStock.SofaColour, TestData);
        }

        [TestMethod]
        public void DataAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance for the class we want to create 
            clsStock AnStock = new clsStock();
            //create test data 
            decimal TestData = 1;
            //assign the data to the property 
            AnStock.Price = TestData;
            //test to see of the values are the same 
            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance for the class we wnt to create 
            clsStock AnStock = new clsStock();
            //create test data 
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Available = TestData;
            //test to see if the values are the same 
            Assert.AreEqual(AnStock.Available, TestData);
         }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some testr data to use with the method
            Int32 SofaNumber = 1;
            //invoke the method 
            Found = AnStock.Find(SofaNumber);
            //test to see if the result is true;
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSofaNumber()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean varailbe to store the result of the search
            Boolean Found = false;
            //boolean varaible ro record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use witht he method 
            Int32 SofaNumber = 1;
            //invoke the method 
            Found = AnStock.Find(SofaNumber);
            //check the sofanumber 
            if(AnStock.SofaNumber != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSofaDescription()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean varailbe to store the result of the search
            Boolean Found = false;
            //boolean varaible ro record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use witht he method 
            Int32 SofaNumber = 1;
            //invoke the method 
            Found = AnStock.Find(SofaNumber);
            //check the sofanumber 
            if (AnStock.SofaNumber != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSofaColour()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean varailbe to store the result of the search
            Boolean Found = false;
            //boolean varaible ro record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use witht he method 
            Int32 SofaNumber = 1;
            //invoke the method 
            Found = AnStock.Find(SofaNumber);
            //check the sofanumber 
            if (AnStock.SofaNumber != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAdded()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean varailbe to store the result of the search
            Boolean Found = false;
            //boolean varaible ro record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use witht he method 
            Int32 SofaNumber = 1;
            //invoke the method 
            Found = AnStock.Find(SofaNumber);
            //check the sofanumber 
            if (AnStock.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPrice()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean varailbe to store the result of the search
            Boolean Found = false;
            //boolean varaible ro record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use witht he method 
            Int32 SofaNumber = 1;
            //invoke the method 
            Found = AnStock.Find(SofaNumber);
            //check the sofanumber 
            if (AnStock.SofaNumber != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailable()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean varailbe to store the result of the search
            Boolean Found = false;
            //boolean varaible ro record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use witht he method 
            Int32 SofaNumber = 1;
            //invoke the method 
            Found = AnStock.Find(SofaNumber);
            //check the sofanumber 
            if (AnStock.SofaNumber != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaNumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string varaible to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SofaNumber = "";
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaNumberMin()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string varaible to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SofaNumber = "";
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaNumberMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string varaible to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SofaNumber = "";
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaNumberMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string varaible to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SofaNumber = "";
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaNumberMax()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string varaible to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SofaNumber = "";
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaNumberMid()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string varaible to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SofaNumber = "";
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaNumberExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string varaible to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SofaNumber = "";
            SofaNumber = SofaNumber.PadRight(500, 'a'); //this should fail
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the classwe want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //chnage the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date varaible to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the classwe want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //chnage the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date varaible to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the classwe want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data date 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //convert the date varaible to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAddress.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAddress.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method 
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SofaDescritionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescritionMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescritionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescritionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescritionMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescritionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescritionMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "a";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "aa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "a";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "aa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock(); ;
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailableMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AvailableMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "a";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailableMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "aa";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailableMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailableMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock(); ;
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailableMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AvailableMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method
            Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
