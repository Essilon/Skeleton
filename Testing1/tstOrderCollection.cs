using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstancecOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Order_No = 1;
            TestItem.Order_Pass = true;
            TestItem.Est_Delivery_Date = DateTime.Now.Date;
            TestItem.Delivery_Address = "address";
            TestItem.Automated_Conf_Email = "confirmation email";
            TestItem.Payment_Details = 123412;

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.OrderList, TestList);
        }



        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Order_No = 1;
            TestOrder.Order_Pass = true;
            TestOrder.Est_Delivery_Date = DateTime.Now.Date;
            TestOrder.Delivery_Address = "address";
            TestOrder.Automated_Conf_Email = "confirmation email";
            TestOrder.Payment_Details = 123412;
            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Order_No = 1;
            TestItem.Order_Pass = true;
            TestItem.Est_Delivery_Date = DateTime.Now.Date;
            TestItem.Delivery_Address = "2 smith street";
            TestItem.Automated_Conf_Email = "order confirmed.";
            TestItem.Payment_Details = 121231231;

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.Order_No = 1;
            TestOrder.Order_Pass = true;
            TestOrder.Est_Delivery_Date = DateTime.Now.Date;
            TestOrder.Delivery_Address = "address";
            TestOrder.Automated_Conf_Email = "confirmation email";
            TestOrder.Payment_Details = 123412;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.Order_No = 1;
            TestOrder.Order_Pass = true;
            TestOrder.Est_Delivery_Date = DateTime.Now.Date;
            TestOrder.Delivery_Address = "address";
            TestOrder.Automated_Conf_Email = "confirmation email";
            TestOrder.Payment_Details = 123412;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            TestOrder.Order_No = 2;
            TestOrder.Order_Pass = false;
            TestOrder.Est_Delivery_Date = DateTime.Now.Date;
            TestOrder.Delivery_Address = "address2";
            TestOrder.Automated_Conf_Email = "confirmation email2";
            TestOrder.Payment_Details = 1234123;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.Order_No = 1;
            TestOrder.Order_Pass = true;
            TestOrder.Est_Delivery_Date = DateTime.Now.Date;
            TestOrder.Delivery_Address = "address";
            TestOrder.Automated_Conf_Email = "confirmation email";
            TestOrder.Payment_Details = 123412;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.Order_No = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDeliveryAddressOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByDeliveryAddress("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByDeliveryAddress("xxxxxxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByDeliveryAddress("yyyyyyyyyy");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].Order_No != 1)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].Order_No != 2)
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
