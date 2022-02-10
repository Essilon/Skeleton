using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to ceate
            clsCustomer AnCustomer = new clsCustomer();
            //test top see that it exsits
            Assert.IsNotNull(AnCustomer);
        }
    }
}
