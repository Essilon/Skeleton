using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrder_No;

        public Int32 Order_No
        {
            get
            {
                return mOrder_No;
            }
            set
            {
                mOrder_No = value;
            }
        }
        private Boolean mOrder_Pass;
        public Boolean Order_Pass
        {
            get
            {
                return mOrder_Pass;
            }
            set
            {
                mOrder_Pass = value;
            }
        }
        private DateTime mEst_Delivery_Date;
        public DateTime Est_Delivery_Date
        {
            get
            {
                return mEst_Delivery_Date;
            }
            set
            {
                mEst_Delivery_Date = value;
            }
        }
        private string mDelivery_Address;
        public string Delivery_Address
        {
            get
            {
                return mDelivery_Address;
            }
            set
            {
                mDelivery_Address = value;
            }
        }
        private string mAutomated_Conf_Email;
        public string Automated_Conf_Email
        {
            get
            {
                return mAutomated_Conf_Email;
            }
            set
            {
                mAutomated_Conf_Email = value;
            }
        }
        private Int32 mPayment_Details;
        public Int32 Payment_Details
        {
            get
            {
                return mPayment_Details;
            }
            set
            {
                mPayment_Details = value;
            }
        }

        public bool Find(int OrderNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNo");
            //if one record is found ss
            if (DB.Count == 1) 
            { 
                mOrder_No = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrder_Pass = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderPass"]);
                mEst_Delivery_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["EstDeliveryDate"]);
                mDelivery_Address = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mAutomated_Conf_Email = Convert.ToString(DB.DataTable.Rows[0]["AutomatedConfEmail"]);
                mPayment_Details = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentDetails"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string est_Delivery_Date, string delivery_Address, string automated_Conf_Email, string payment_Details)
        {
            String Error = "";
            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(est_Delivery_Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }

            //DELIVERY ADDRESS IF STATEMENT
            if (delivery_Address.Length == 0)
            {
                Error = Error + " Delivery Address cannot be left blank! ";
            }

            if (delivery_Address.Length > 20)
            {
                Error = Error + "You cannot enter more then 20 characters! ";
            }

            //AUTOMATED CONF EMAIL IF STATEMENTS
            if (automated_Conf_Email.Length == 0)
            {
                Error = Error + "Automated Confirmation email cannot be left blank! ";
            }
            if (automated_Conf_Email.Length > 100)
            {
                Error = Error + "You cannot entere more then 100 characters! ";
            }
            return Error;
        }
    }
}