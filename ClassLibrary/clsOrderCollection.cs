using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            PopulateArray(DB);
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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Order_No", mThisOrder.Order_No);
            DB.AddParameter("@Order_Pass", mThisOrder.Order_Pass);
            DB.AddParameter("@Est_Delivery_Address", mThisOrder.Est_Delivery_Date);
            DB.AddParameter("@Delivery_Address", mThisOrder.Delivery_Address);
            DB.AddParameter("@Automated_Conf_Email", mThisOrder.Automated_Conf_Email);
            DB.AddParameter("@Payment_Details", mThisOrder.Payment_Details);

            return DB.Execute("sproc_tblorders_Insert");
        }
        
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Order_No", mThisOrder.Order_No);
            DB.AddParameter("@Order_Pass", mThisOrder.Order_Pass);
            DB.AddParameter("@Est_Delivery_Address", mThisOrder.Est_Delivery_Date);
            DB.AddParameter("@Delivery_Address", mThisOrder.Delivery_Address);
            DB.AddParameter("@Automated_Conf_Email", mThisOrder.Automated_Conf_Email);
            DB.AddParameter("@Payment_Details", mThisOrder.Payment_Details);
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Order_No", mThisOrder.Order_No);
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void ReportByDeliveryAddress(string Delivery_Address)
        {
            //filters the records based on a full or partial post code
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Delivery_Address", Delivery_Address);
            DB.Execute("sproc_tblOrders_FilterByDeliveryAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
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

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
    }
}