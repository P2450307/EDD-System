
using EDDClasses;
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

        public bool Find(Int32 StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the staffID to search for
            DB.AddParameter("@StaffID", StaffID);

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");

            //if one record is found
            if(DB.Count == 1) 
            {
            sStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
            fName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
            DOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
            LoggedIO = Convert.ToBoolean(DB.DataTable.Rows[0]["LoggedInOut"]);
            address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
            contactNo = Convert.ToString(DB.DataTable.Rows[0]["ContactNo"]);

                return true;

            }

            //if no record was found
            else 
            {
                return false;
            }        
        }

        public string Valid(string fullName, string dateOfBirth, string address, string contactNo)
        {
            //create string variable to store error
            String error = "";

            //create temporary date variable to store values
            DateTime DateTemp;

            if(fullName.Length == 0)
            {
                //record the error
                error = error + "full name may not be left blank";
            }

            if(fullName.Length > 50)
            {
                error = error + "full name must be less than 50";
            }

            DateTemp = Convert.ToDateTime(dateOfBirth);
            if(DateTemp < DateTime.Now.Date)
            {
                error = error + "this date is too old";
            }
            //return any error messages
            return error;
        }


    }

    
}