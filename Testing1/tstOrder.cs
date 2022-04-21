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
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1231231;
            AnOrder.PaymentDetails = TestData;
            Assert.AreEqual(AnOrder.PaymentDetails, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //boolean variablei to store the results of the validation
            Boolean Found = false;
            //create some test data to use
            Int32 OrderNo = 21;
            //invoke method
            Found = AnOrder.Find(OrderNo);
            //test to see if true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderNo = 21;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != 21)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestOrderPassFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderNo = 21;
            Found = AnOrder.Find(OrderNo);
            if(AnOrder.OrderPass != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestEstDeliveryDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderNo = 21;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.EstDeliveryDate != Convert.ToDateTime("09/04/2000"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderNo = 21;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.DeliveryAddress != "Test Address")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void TestAutomatedComfEmail()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderNo = 21;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.AutomatedConfEmail != "Automatic conf email")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        
        public void TestPaymentDetails()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderNo = 21;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.PaymentDetails != 123456789)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


    }

  
}
