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

        private string fullName;
        public string FullName { 
           
            get{
                return FullName;
            }
            
            set {
                FullName = value;
            }
        
        }
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
            fullName = "Joe Bloggs";

            return true;
        }

      
    }

    
}