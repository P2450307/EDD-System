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
        [TestMethod]
        public void FindMethodOK()
        {
            ClsCustomer Customer = new ClsCustomer();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = Customer.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            ClsCustomer CustomerID = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = CustomerID.Find(CustomerId);
            if (CustomerID.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            ClsCustomer CustomerID = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = CustomerID.Find(CustomerId);
            if (CustomerID.dateOfBirth != Convert.ToDateTime("29/03/1991"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserNameFound()
        {
            ClsCustomer CustomerID = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = CustomerID.Find(CustomerId);
            if (CustomerID.userName != "renebaebae")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            ClsCustomer CustomerID = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = CustomerID.Find(CustomerId);
            if (CustomerID.emailAddress != "irene@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHasPlaceOrderFound()
        {
            ClsCustomer CustomerID = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = CustomerID.Find(CustomerId);
            if (CustomerID.hasPlaceOrder!= true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void userNameMinLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string userName = "";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void userNameMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string userName = "a";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void userNameMinPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string userName = "aa";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void userNameMaxLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string userName = "";
            userName = userName.PadRight(19, 'a');
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void userNameMax()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string userName = "";
            userName = userName.PadRight(20, 'a');
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void userNameMid()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string userName = "";
            userName = userName.PadRight(10, 'a');
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void dateOfBirthExtremeMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string dateOfBirth = TestDate.ToString();
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void dateOfBirthMinLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string dateOfBirth = TestDate.ToString();
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void dateOfBirthMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string dateOfBirth = TestDate.ToString();
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void dateOfBirthMinPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string dateOfBirth = TestDate.ToString();
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void dateOfBirthExtremeMax()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string dateOfBirth = TestDate.ToString();
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void dateOfBirthInvalidData()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string dateOfBirth = "This is not a date!";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void emailAddressMinLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string emailAddress = "";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void emailAddressMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string emailAddress = "a";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailAddressMinPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string emailAddress = "aa";
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void emailAddressMaxLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string emailAddress = "";
            emailAddress = emailAddress.PadRight(49, 'a');
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailAddressMax()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string emailAddress = "";
            emailAddress = emailAddress.PadRight(50, 'a');
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void emailAddressMid()
        {
            ClsCustomer customer = new ClsCustomer();
            String Error = "";
            string emailAddress = "";
            emailAddress = emailAddress.PadRight(25, 'a');
            Error = customer.Valid(userName, emailAddress, dateOfBirth);
            Assert.AreEqual(Error, "");
        }

    }
}

