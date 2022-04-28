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



    }


}
