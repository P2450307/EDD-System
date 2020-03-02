using System;
using EDDClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace EDDTesting
{
    [TestClass]
    public class TstStaff
    {

        //good test data
        string FullName = "Joe Bloggs";
        string DateOfBirth = DateTime.Now.Date.ToString();
        string Address = "1 regent road, Leicester, LE2 1UG ";
        string ContactNo = "44078";


        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsStaff Staff = new clsStaff();
            //test to see it exists
            Assert.IsNotNull(Staff);

        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();

            //create test data to assign to property
            Int32 TestData = 12345;

            //assign data to the property
            Staff.StaffID = TestData;

            //test to see if both alues are equal
            Assert.AreEqual(Staff.StaffID, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsStaff Staff = new clsStaff();

            string TestData = "Joe Bloggs";

            Staff.FullName = TestData;

            Assert.AreEqual(Staff.FullName, TestData);
            
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsStaff Staff = new clsStaff();

            DateTime TestData = DateTime.Now.Date;

            Staff.DateOfBirth = TestData;

            Assert.AreEqual(Staff.DateOfBirth, TestData);
        }

        [TestMethod]
        public void LoggedInOutPropertyOK()
        {
            clsStaff Staff = new clsStaff();

            Boolean TestData = true;

            Staff.LoggedInOut = TestData;

            Assert.AreEqual(Staff.LoggedInOut, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsStaff Staff = new clsStaff();

            string TestData = "6 Overton Road, Leicester, LE5 2WH";

            Staff.Address = TestData;

            Assert.AreEqual(Staff.Address, TestData);
        }

        [TestMethod]
        public void ContactNoPropertyOK()
        {
            clsStaff Staff = new clsStaff();

            string TestData = "4407";

            Staff.ContactNo = TestData;

            Assert.AreEqual(Staff.ContactNo, TestData);
        }

      
        [TestMethod]
        public void FindMethodOk()
        {
            clsStaff Staff = new clsStaff();

            Boolean found = false;

            Int32 StaffID = 6;

            found = Staff.Find(StaffID);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffIDFoundOK()
        {
            clsStaff Staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 StaffID = 6;

            found = Staff.Find(StaffID);

            if(Staff.StaffID != 6)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestFullNameFoundOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffID = 6;
            found = Staff.Find(StaffID);
            if(Staff.FullName != "Joe Bloggs")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFoundOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffID = 6;
            found = Staff.Find(StaffID);
            if (Staff.DateOfBirth != Convert.ToDateTime("31/07/1996"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLoggedIOFoundOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffID = 6;
            found = Staff.Find(StaffID);
            if(Staff.LoggedInOut != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFoundOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffID = 6;
            found = Staff.Find(StaffID);
            if(Staff.Address != "6 Overton Road, Leicester, LE5 2WH")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNoFoundOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffID = 6;
            found = Staff.Find(StaffID);
            if(Staff.ContactNo != "4407") {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff Staff = new clsStaff();
            //string variable to store error message
            string Error = "";
            //invoke the method
            Error = Staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }



        
    }
}
