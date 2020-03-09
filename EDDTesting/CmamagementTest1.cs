using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EDDClasses;


namespace EDDTesting
{
    [TestClass]
    public class CmamagementTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsCustomer Customer = new clsCustomer();
            //test to see it exists
            Assert.IsNotNull(Customer);

        }
    }
}
