using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        public object DataTime { get; private set; }
        public bool OK { get; private set; }

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

    }
}
