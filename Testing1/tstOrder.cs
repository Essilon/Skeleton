using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass to method

        string Est_Delivery_Date = DateTime.Now.Date.ToString();
        string Delivery_Address = "Address";
        string Automated_Conf_Email = "AutomaticConfEmail";
        string Payment_Details = "12312312";

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

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-101);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EstDeliveryDateLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-18).AddDays(-1);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-18);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-18).AddDays(+1);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100).AddDays(-1);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100).AddDays(+1);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(50);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(101);
            string Est_Delivery_Date = TestDate.ToString();
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstDeliveryDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //convert the date variable to a string variable
            string DateOfBirth = "This is not a valid date!";
            //invoke the method
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Delivery_Address = "";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Delivery_Address = "f";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Delivery_Address = "ff";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Delivery_Address = "ffffffffffffffffffff";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Delivery_Address = "fffffffffffffffffff";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Delivery_Address = Delivery_Address.PadRight(21, 'f');
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Delivery_Address = Delivery_Address.PadRight(1000, 'f');
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Delivery_Address = "ffffffffff";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AutomatedConfEmailMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Automated_Conf_Email = "";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AutomatedConfEmailMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Automated_Conf_Email = "f";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AutomatedConfEmailMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Automated_Conf_Email = "ff";
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AutomatedConfEmailMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Automated_Conf_Email = Automated_Conf_Email.PadRight(100);
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AutomatedConfEmailMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Automated_Conf_Email = Automated_Conf_Email.PadRight(99);
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AutomatedConfEmailMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Automated_Conf_Email = Automated_Conf_Email.PadRight(100, 'f');
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AutomatedConfEmailExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Automated_Conf_Email = Automated_Conf_Email.PadRight(1000, 'f');
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AutomatedConfEmailMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Automated_Conf_Email = Automated_Conf_Email.PadRight(50);
            Error = AnOrder.Valid(Est_Delivery_Date, Delivery_Address, Automated_Conf_Email, Payment_Details);
            Assert.AreNotEqual(Error, "");
        }


    }


}
