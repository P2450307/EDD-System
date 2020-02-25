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
        public bool LoggedInOut { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        public bool Find(int StaffID)
        {
            sStaffID = 321;
            fName = "Joe Bloggs";
            DOB = Convert.ToDateTime("10/01/2020");
            return true;
        }
    }

    
}