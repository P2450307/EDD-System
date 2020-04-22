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
            testData.StaffID = 6;
            testData.FullName = "Joe Bloggs";
            testData.DateOfBirth = DateTime.Now.Date;
            testData.LoggedInOut = true;
            testData.Address = "6 Overton Road, Leicester, LE5 2WH";
            testData.ContactNo = "4407";
            //add item to test list
            tstList.Add(testData);
            //assign data to property
            allStaff.staffList = tstList;
            //test to see 2 values are the same
            Assert.AreEqual(allStaff.staffList, tstList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff tstStaff = new clsStaff();
            //set properties for test object
            tstStaff.StaffID = 6;
            tstStaff.FullName = "Joe Bloggs";
            tstStaff.DateOfBirth = DateTime.Now.Date;
            tstStaff.LoggedInOut = true;
            tstStaff.Address = "6 Overton Road, Leicester, LE5 2WH";
            tstStaff.ContactNo = "4407";
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
            testData.StaffID = 6;
            testData.FullName = "Joe Bloggs";
            testData.DateOfBirth = DateTime.Now.Date;
            testData.LoggedInOut = true;
            testData.Address = "6 Overton Road, Leicester, LE5 2WH";
            testData.ContactNo = "4407";
            //add item to test list
            tstList.Add(testData);
            //assign data to property
            allStaff.staffList = tstList;
            //test to see 2 values are the same
            Assert.AreEqual(allStaff.Count, tstList.Count);
        }

       
            
            

        }
    }

