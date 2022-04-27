using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection allStock = new clsStockCollection();
            //test to see thatr it exists 
            Assert.IsNotNull(allStock);
        }


        [TestMethod]
        public void StockListOK()
        {
            //create an instacne of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of object 
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list 
            //create the itemto the list 
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.SofaNumber = 1;
            TestStock.SofaDescription = 1;
            TestStock.SofaColour = "";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Available = true;
            //add the item tot he test list
            TestList.Add(TestStock);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.StockList, TestList);

        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.SofaNumber = 1;
            TestStock.SofaDescription = 1;
            TestStock.SofaColour = "";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Available = true;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.SofaNumber = 1;
            TestStock.SofaDescription = 1;
            TestStock.SofaColour = "";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Available = true;
            //add the item to the test list
            TestList.Add(TestStock);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two are the same
            Assert.AreEqual(AllStock.Count, TestStock.Count);
        }

    }
}
