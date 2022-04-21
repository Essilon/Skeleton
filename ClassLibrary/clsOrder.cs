using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNo;

        public Int32 OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        private Boolean mOrderPass;
        public Boolean OrderPass
        {
            get
            {
                return mOrderPass;
            }
            set
            {
                mOrderPass = value;
            }
        }
        private DateTime mEstDeliveryDate;
        public DateTime EstDeliveryDate
        {
            get
            {
                return mEstDeliveryDate;
            }
            set
            {
                mEstDeliveryDate = value;
            }
        }
        private string mDeliveryAddress;
        public string DeliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }
        private string mAutomatedConfEmail;
        public string AutomatedConfEmail
        {
            get
            {
                return mAutomatedConfEmail;
            }
            set
            {
                mAutomatedConfEmail = value;
            }
        }
        private Int32 mPaymentDetails;
        public Int32 PaymentDetails
        {
            get
            {
                return mPaymentDetails;
            }
            set
            {
                mPaymentDetails = value;
            }
        }

        public bool Find(int orderNo)
        {
            mOrderNo = 21;
            mOrderPass = true;
            mEstDeliveryDate = Convert.ToDateTime("09/04/2000");
            mDeliveryAddress = "Test Address";
            mAutomatedConfEmail = "Automatic conf email";
            mPaymentDetails = 123456789;

            //always return true
            return true;
        }


    }
}