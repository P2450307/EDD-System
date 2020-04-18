using System;
using EDDClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EDDTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOk()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOk()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            //data needs to be a list of objects
            List<clsStaff> tstList = new List<clsStaff>();
            //add item to list and create that item
            clsStaff testData = new clsStaff();
            //set properties
            testData.StaffID = 1;
            testData.FullName = "Joe Bloggs";
            testData.DateOfBirth = DateTime.Now.Date;
            testData.LoggedInOut = true;
            testData.Address = "1 Regent Avenue, LE2 1U3, Leicester";
            testData.ContactNo = "07882365012";
            //add item to test list
            tstList.Add(testData);
            //assign data to property
            allStaff.staffList = tstList;
            //test to see 2 values are the same
            Assert.AreEqual(allStaff.staffList, tstList);
        }

            [TestMethod]
            public void CountPropertyOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            //create test data to assign to property
            Int32 someCount = 0;
            //assign data to property
            allStaff.Count = someCount;
            //test to see values are equal
            Assert.AreEqual(allStaff.Count, someCount);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff tstStaff = new clsStaff();
            //set properties for test object
            tstStaff.StaffID = 1;
            tstStaff.FullName = "Joe Bloggs";
            tstStaff.DateOfBirth = DateTime.Now.Date;
            tstStaff.LoggedInOut = true;
            tstStaff.Address = "1 Regent Road, Leicester, LE2 8QU";
            tstStaff.ContactNo = "07812634829";
            allStaff.thisStaff = tstStaff;
            Assert.AreEqual(allStaff.thisStaff, tstStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            //data needs to be a list of objects
            List<clsStaff> tstList = new List<clsStaff>();
            //add item to list and create that item
            clsStaff testData = new clsStaff();
            //set properties
            testData.StaffID = 1;
            testData.FullName = "Joe Bloggs";
            testData.DateOfBirth = DateTime.Now.Date;
            testData.LoggedInOut = true;
            testData.Address = "1 Regent Avenue, LE2 1U3, Leicester";
            testData.ContactNo = "07882365012";
            //add item to test list
            tstList.Add(testData);
            //assign data to property
            allStaff.staffList = tstList;
            //test to see 2 values are the same
            Assert.AreEqual(allStaff.Count, tstList.Count);
        }
            
            

        }
    }

