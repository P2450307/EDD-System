using System;

namespace EDDClasses
{
    public class clsStaff
    {
        private Int32 sStaffID; 
        public int StaffID 
        { 
            get
            {
                //this sends data out of the property
                return sStaffID;
            }

            set
            {
                //this allows data into the property
                sStaffID = value;
            }
        }

        private string fName;
        public string FullName 
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        private DateTime DOB;
        public DateTime DateOfBirth 
        {
            get
            {
                return DOB;
            }
            
            set
            {
                DOB = value;
            }
        }
        
        private Boolean LoggedIO;
        public bool LoggedInOut 
        { 
            get 
            {
                return LoggedIO;
            }

            set
            {
                LoggedIO = value;
            }
        }

       private string address;
        public string Address 
        { 
            get
            {
                return address;
            } 
            set
            {
                address = value;
            }
        }

        private string contactNo;
        public string ContactNo 
        { 
            get
            {
                return contactNo;
            }
            set
            {
                contactNo = value;
            }
        }

        public bool Find(int StaffID)
        {
            sStaffID = 321;
            fName = "Joe Bloggs";
            DOB = Convert.ToDateTime("10/01/2020");
            LoggedIO = true;
            address = "1b Gateway Walk, Leicester, LE3 0VF";
            contactNo = "+44 07836543291";
            return true;
        }
    }

    
}