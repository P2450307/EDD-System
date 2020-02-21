using System;

namespace EDDClasses
{
    public class clsStaff
    {
        private Int32 sStaffID;
        public int StaffID { 
            get
            {
                return sStaffID;
            }
            
            set
            {
                sStaffID = value;
            }
        }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool LoggedInOut { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        public bool Find(string FullName)
        {
            return true;
        }

        public bool Find(int StaffID)
        {
            sStaffID = 12345;

            return true;
        }
    }

    
}