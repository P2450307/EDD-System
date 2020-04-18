using System.Collections.Generic;

namespace EDDClasses
{
    public class clsStaffCollection
    {
        //private data member for list and count
        List<clsStaff> mStaffList = new List<clsStaff>();
        public clsStaffCollection()
        {
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