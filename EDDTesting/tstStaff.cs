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

        [TestMethod]
        public void fNameMinLessOne()
        {
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String error = "";
            //create test data to pass to method
            string FullName = ""; //should trigger the error
            //invoke method
            error = Staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            //test to see result is correct
            Assert.AreNotEqual(error, "");
               
        }

        [TestMethod]
        public void fNameMin()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string FullName = "a";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void fNameMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string FullName = "ab";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void fNameMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string FullName = "0154g3h2kl0154g3h2kl0154g3h2kl0154g3h2kl0154g3h2k";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void fNameMax()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string FullName = "0154g3h2kl0154g3h2kl0154g3h2kl0154g3h2kl0154g3h2ke";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void fNameMid()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string FullName = "1eyrg65erste5823tdow2pdma";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void fNameMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string FullName = "0154g3h2kl0154g3h2kl0154g3h2kl0154g3h2kl0154g3h2ke1";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void fNameExtremeMax()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string FullName = "";
            FullName = FullName.PadRight(100, 'a');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            DateTime tstDate;
            tstDate = DateTime.Now.Date;
            tstDate = tstDate.AddYears(-100);
            DateOfBirth = tstDate.ToString();
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            DateTime tstDate;
            tstDate = DateTime.Now.Date;
            tstDate = tstDate.AddYears(-100);
            string DateOfBirth = tstDate.ToString();
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            DateTime tstDate;
            tstDate = DateTime.Now.Date;
            tstDate = tstDate.AddYears(-99);
            string DateOfBirth = tstDate.ToString();
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            DateTime tstDate;
            tstDate = DateTime.Now.Date;
            tstDate = tstDate.AddYears(-98);
            string DateOfBirth = tstDate.ToString();
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            DateTime tstDate;
            tstDate = DateTime.Now.Date;
            tstDate = tstDate.AddDays(50);
            string DateOfBirth = tstDate.ToString();
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DOBInvalidData()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            //set dob value to non date value
            string DateOfBirth = "this is not a date";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string Address = "";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string Address = "a";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string Address = "aa";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string Address = "";
            Address = Address.PadRight(51, 'a');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNoMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string ContactNo = "";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ContactNoMin()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string ContactNo = "1";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNoMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string ContactNo = "12";
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNoMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(10, '1');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNoMax()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(20, '1');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNoMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(21, '1');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNoMid()
        {
            clsStaff staff = new clsStaff();
            String error = "";
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(10, '1');
            error = staff.Valid(FullName, DateOfBirth, Address, ContactNo);
            Assert.AreEqual(error, "");
        }










        
    }
}
