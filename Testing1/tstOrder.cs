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
            AnOrder.Order_No = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.Order_No, TestData);

        }

        [TestMethod]
        public void OrderPassPropertyOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign to the property
            AnOrder.Order_Pass = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_Pass, TestData);
        }

        [TestMethod]

        public void EstDeliveryDatePropertyOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign
            DateTime TestData = DateTime.Now.Date;
            //asign to the property
            AnOrder.Est_Delivery_Date = TestData;
            //test to see that the two vals are same
            Assert.AreEqual(AnOrder.Est_Delivery_Date, TestData);

        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();

            string TestData = "LE1 4AB Leicester";

            AnOrder.Delivery_Address = TestData;

            Assert.AreEqual(AnOrder.Delivery_Address, TestData);
        }

        [TestMethod]
        public void AutomatedConfEmailPropertyOK()
        { 

            clsOrder AnOrder = new clsOrder();
            string TestData = "Order has been confirmed";
            AnOrder.Automated_Conf_Email = TestData;
            Assert.AreEqual(AnOrder.Automated_Conf_Email, TestData);

        }

        [TestMethod]
        public void PaymentDetailsPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1231231;
            AnOrder.Payment_Details = TestData;
            Assert.AreEqual(AnOrder.Payment_Details, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //boolean variablei to store the results of the validation
            Boolean Found = false;
            //create some test data to usess
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
            if (AnOrder.Order_No != 21)
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
            if(AnOrder.Order_Pass != true)
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
            if (AnOrder.Est_Delivery_Date != Convert.ToDateTime("09/04/2000"))
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
            if (AnOrder.Delivery_Address != "Test Address")
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
            if (AnOrder.Automated_Conf_Email != "Automatic conf email")
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
            if (AnOrder.Payment_Details != 123456789)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


    }

  
}
