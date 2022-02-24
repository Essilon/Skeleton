using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderNo { get; set; }
        public bool OrderPass { get; set; }
        public DateTime EstDeliveryDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string AutomatedConfEmail { get; set; }
        public int PaymentDetails { get; set; }
    }
}