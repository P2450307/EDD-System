using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EDDClasses;

namespace EDDTesting
{
    [TestClass]
    public class tstCustomer
    {
        string userName = "renebaebae";
        string emailAddress = "irene@gmail.com";
        string dateOfBirth = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            ClsCustomer customer = new ClsCustomer();
            Assert.IsNotNull(customer);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Int32 TestData = 1;
            AnCustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void userNameOK()
        {
            ClsCustomer AnUserName = new ClsCustomer();
            String TestData = "50";
            AnUserName.userName = TestData;
            Assert.AreEqual(AnUserName.userName, TestData);
        }
        [TestMethod]
        public void emailAddressOK()
        {
            ClsCustomer AnEmailAddress = new ClsCustomer();
            String TestData = "50";
            AnEmailAddress.emailAddress = TestData;
            Assert.AreEqual(AnEmailAddress.emailAddress, TestData);
        }
        [TestMethod]
        public void DOBOK()
        {
            ClsCustomer DOB = new ClsCustomer();
            DateTime TestData = DateTime.Now.Date;
            DOB.dateOfBirth = TestData;
            Assert.AreEqual(DOB.dateOfBirth, TestData);
        }
        [TestMethod]
        public void PlaceOrderOK()
        {
            ClsCustomer AnPlaceOrder = new ClsCustomer();
            Boolean TestData = true;
            AnPlaceOrder.hasPlaceOrder = TestData;
            Assert.AreEqual(AnPlaceOrder.hasPlaceOrder, TestData);
        }
    }
}
