using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        public object DataTime { get; private set; }

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
    }
}
