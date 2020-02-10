using System;
using EDDClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EDDTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsStaff Staff = new clsStaff();
            //test to see it exists
            Assert.IsNotNull(Staff);

        }
    }
}
