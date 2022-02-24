using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 1;
            //assign thee data to property
            AnOrder.OrderNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);

        }

        [TestMethod]
        public void OrderPassPropertyOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign to the property
            AnOrder.OrderPass = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPass, TestData);
        }

        [TestMethod]

        public void EstDeliveryDatePropertyOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign
            DateTime TestData = DateTime.Now.Date;
            //asign to the property
            AnOrder.EstDeliveryDate = TestData;
            //test to see that the two vals are same
            Assert.AreEqual(AnOrder.EstDeliveryDate, TestData);

        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();

            string TestData = "LE1 4AB Leicester";

            AnOrder.DeliveryAddress = TestData;

            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void AutomatedConfEmailPropertyOK()
        { 

            clsOrder AnOrder = new clsOrder();
            string TestData = "Order has been confirmed";
            AnOrder.AutomatedConfEmail = TestData;
            Assert.AreEqual(AnOrder.AutomatedConfEmail, TestData);

        }

        [TestMethod]
        public void PaymentDetailsPropertyOK()
        {
            clsOrder AnOrder = new clseOrder();
            Int32 TestData = 1231231;
            AnOrder.PaymentDetails = TestData;
            Assert.AreEqual(AnOrder.PaymentDetails, TestData);
        }
    }

  
}
