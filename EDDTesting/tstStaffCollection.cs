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

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff tstItem = new clsStaff();
            //var to store PK
            Int32 PKey = 0;
            //set properties
            tstItem.StaffID = 1;
            tstItem.FullName = "test name";
            tstItem.DateOfBirth = DateTime.Now.Date;
            tstItem.LoggedInOut = true;
            tstItem.Address = "some address";
            tstItem.ContactNo = "4407";
            //set thisStaff to test data
            allStaff.thisStaff = tstItem;
            //add record
            PKey = allStaff.Add();
            //set the primary key of tst data
            tstItem.StaffID = PKey;
            //find record
            allStaff.thisStaff.Find(PKey);
            //test to see both values are the same
            Assert.AreEqual(allStaff.thisStaff, tstItem);
    }
            
            [TestMethod]
            public void DeleteMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff tstItem = new clsStaff();
            Int32 PKey = 0;
            tstItem.StaffID = 3;
            tstItem.FullName = "anonymous";
            tstItem.DateOfBirth = DateTime.Now.Date;
            tstItem.LoggedInOut = true;
            tstItem.Address = "some address";
            tstItem.ContactNo = "4407";
            allStaff.thisStaff = tstItem;
            PKey = allStaff.Add();
            tstItem.StaffID = PKey;
            allStaff.thisStaff.Find(PKey);
            //delete record
            allStaff.Delete();
            Boolean Found = allStaff.thisStaff.Find(PKey);
            //test to see record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff tstItem = new clsStaff();
            //var to store PK
            Int32 PKey = 0;
            //set properties
            tstItem.StaffID = 1;
            tstItem.FullName = "test name";
            tstItem.DateOfBirth = DateTime.Now.Date;
            tstItem.LoggedInOut = true;
            tstItem.Address = "some address";
            tstItem.ContactNo = "4407";
            //set thisStaff to test data
            allStaff.thisStaff = tstItem;
            //add record
            PKey = allStaff.Add();
            //set the primary key of tst data
            tstItem.StaffID = PKey;
            //modify properties
            tstItem.StaffID = 2;
            tstItem.FullName = "test name2";
            tstItem.DateOfBirth = DateTime.Now.Date;
            tstItem.LoggedInOut = true;
            tstItem.Address = "some other address";
            tstItem.ContactNo = "1407";
            //set record based on new test data
            allStaff.thisStaff = tstItem;
            //update
            allStaff.Update();
            //find record
            allStaff.thisStaff.Find(PKey);
            //test to see both values are the same
            Assert.AreEqual(allStaff.thisStaff, tstItem);
        }

        [TestMethod]
        public void ReportByFullName()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            //instance of filtered data
            clsStaffCollection filteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            filteredStaff.ReportByFullName("");
            Assert.AreEqual(allStaff.Count, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            clsStaffCollection filteredStaff = new clsStaffCollection();
            //apply ful name that doesnt exist
            filteredStaff.ReportByFullName("00xx 00xx");
            //test to see there are no records
            Assert.AreEqual(0, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestFound()
        {
            clsStaffCollection filteredNames = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply name that doesnt exist
            filteredNames.ReportByFullName("some name");
            //check that correct number of records are found
            if (filteredNames.Count == 2)
            {
                if(filteredNames.staffList[0].StaffID != 29)
                {
                    OK = false;
                }
                if(filteredNames.staffList[1].StaffID != 32)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
           
        }
        
            
            

        }
    }

