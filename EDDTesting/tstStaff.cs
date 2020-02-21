using System;
using EDDClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EDDTesting
{
    [TestClass]
    public class TstStaff
    {
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

            string TestData = "John Smith";

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

            string TestData = "1 Regent Road, Leicester, LE4 1EJ";

            Staff.Address = TestData;

            Assert.AreEqual(Staff.Address, TestData);
        }

        [TestMethod]
        public void ContactNoPropertyOK()
        {
            clsStaff Staff = new clsStaff();

            string TestData = "+44 78235017391";

            Staff.ContactNo = TestData;

            Assert.AreEqual(Staff.ContactNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff Staff = new clsStaff();
            //boolean variable to store validation
            Boolean found = false;
            
            string FullName = "Joe Bloggs";

            found = Staff.Find(FullName);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffIDFoundOK()
        {
            clsStaff Staff = new clsStaff();

            Boolean found = false;

            Boolean Ok = true;

            Int32 StaffID = 12345;

            found = Staff.Find(StaffID);

            if(Staff.StaffID != 12345)
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }
        
    }
}
