using System;
using System.Collections.Generic;

namespace EDDClasses
{
    public class clsStaffCollection
    {
      

        //private data member for list and count
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member for thisStaff
        clsStaff mThisStaff = new clsStaff();
        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
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
        public clsStaff thisStaff { 
            get
            {
                return mThisStaff;
            } 
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to database based on values of mThisStaff
           
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored proc
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@LoggedInOut", mThisStaff.LoggedInOut);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@ContactNo", mThisStaff.ContactNo);
            //execite query returning PK
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored proc
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //updates a new record to database based on values of mThisStaff
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored proc
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@LoggedInOut", mThisStaff.LoggedInOut);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@ContactNo", mThisStaff.ContactNo);
            //execute query returning PK
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByFullName(string FullName)
        {
            //filters records based on full name
            clsDataConnection DB = new clsDataConnection();
            //send full name to database
            DB.AddParameter("@FullName", FullName);
            DB.Execute("sproc_tblStaff_ReportByFullName");
            PopulateArray(DB);
        }

        void PopulateArray (clsDataConnection DB)
        {
            //var for index
            Int32 Index = 0;
            //var to ctore record count
            Int32 recordCount;
            recordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
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
    }
}