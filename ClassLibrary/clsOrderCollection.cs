using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Order_No = Convert.ToInt32(DB.DataTable.Rows[Index]["Order_No"]);
                AnOrder.Order_Pass = Convert.ToBoolean(DB.DataTable.Rows[Index]["Order_Pass"]);
                AnOrder.Est_Delivery_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Est_Delivery_Date"]);
                AnOrder.Delivery_Address = Convert.ToString(DB.DataTable.Rows[Index]["Delivery_Address"]);
                AnOrder.Automated_Conf_Email = Convert.ToString(DB.DataTable.Rows[Index]["Automated_Conf_Email"]);
                AnOrder.Payment_Details = Convert.ToInt32(DB.DataTable.Rows[Index]["Payment_Details"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }

        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder { get; set; }
    }
}