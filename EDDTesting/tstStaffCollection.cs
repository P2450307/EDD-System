﻿using System;
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
            clsStaffCollection staffCollection = new clsStaffCollection();
            //data needs to be a list of objects
            List<clsStaff> tstList = new List<clsStaff>();
            //add item to list and create that item
            clsStaff testData = new clsStaff();
            //set properties

        }
    }
}
