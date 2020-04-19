using System;
using System.Collections.Generic;

namespace EDDClasses
{
    public class clsStaffCollection
    {
       

        //private data member for list and count
        List<clsStaff> mStaffList = new List<clsStaff>();
        public clsStaffCollection()
        {
            //var for index
            Int32 Index = 0;
            //var to ctore record count
            Int32 recordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            recordCount = DB.Count;
            //while there are records to process
            while (Index < recordCount)
            {
                //create blank staff
                clsStaff aStaff = new clsStaff();
                //read in fields from records
                aStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                aStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                aStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                aStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                aStaff.ContactNo = Convert.ToString(DB.DataTable.Rows[Index]["ContactNo"]);
                aStaff.LoggedInOut = Convert.ToBoolean(DB.DataTable.Rows[Index]["LoggedInOut"]);
                //add data to private data member
                mStaffList.Add(aStaff);
                //point at next record
                Index++;
            }
        }

        //public property for the staff list
        public List<clsStaff> staffList { 
            get
            {
                return mStaffList;

            } 
            set
            {
                mStaffList = value;
            }
        }
       
       //public property for count;
        public int Count { 
            get
            {
                //return count of list
                return mStaffList.Count;

            } 
            set
            {

            }
        }
        public clsStaff thisStaff { get; set; }
    }
}