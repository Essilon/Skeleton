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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestStock = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStock.SofaNumber = 1;
            TestStock.SofaDescription = 1;
            TestStock.SofaColour = "";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Available = true;
            //set ThisCustomer to the test data
            AllStock.ThisStock = TestStock;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestStock.SofaNumber = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void UpdateMehtodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestStock = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStock.SofaNumber = 1;
            TestStock.SofaDescription = 1;
            TestStock.SofaColour = "";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Available = true;
            //set this stock to the test data 
            AllStock.ThisStock = TestStock;
            //add the record 
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data 
            TestStock.SofaNumber = PrimaryKey;
            //Modify the test data 
            TestStock.SofaNumber = 2;
            TestStock.SofaDescription = 2;
            TestStock.SofaColour = "";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Available = false;
            //set the record based on the new test data 
            AllStock.ThisStock = TestStock;
            //update the record 
            AllStock.Update();
            //find the record 
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see thisStock matches the test data 
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestStock = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStock.SofaNumber = 1;
            TestStock.SofaDescription = 1;
            TestStock.SofaColour = "";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Available = true;
            //set this stock to the test data 
            AllStock.ThisStock = TestStock;
            //add the record 
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data 
            TestStock.SofaNumber = PrimaryKey;
            //find the record 
            AllStock.Delete();
            //now find the record 
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByAvailableMethoidOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredAvailable = new clsStockCollection();
            FilteredAvailable.ReportByAvailable("");
            Assert.AreEqual(AllStock.Count, FilteredAvailable.Count);
        }


        [TestMethod]
        public void ReportByAvailableNoneFound()
        {
            clsStockCollection FilteredAvailable = new clsStockCollection();
            FilteredAvailable.ReportByAvailable("hhhhhhh");
            Assert.AreEqual(0, FilteredAvailable.Count);
        }


        public void ReportByAvailableTestDataFound()
        {
            clsStockCollection FilteredAvailable = new clsStockCollection();
            Boolean OK = true;
            FilteredAvailable.ReportByAvailable("yyyyyyyyyyy");
            if(FilteredAvailable.Count == 2)
            {
                if(FilteredAvailable.StockList[0].SofaNumber != 36)
                {
                    OK = false;
                }
                if (FilteredAvailable.StockList[1].SofaNumber != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


    }
}
