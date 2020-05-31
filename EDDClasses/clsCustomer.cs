using EDDClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDClasses
{
    public class ClsCustomer
    {
        private DateTime mdateOfBirth;
        private string muserName;
        private string memailAddress;
        private bool mhasPlaceOrder;
        private int mcustomerId;

        public int CustomerId
        {
            get
            {
                return mcustomerId;
            }
            set
            {
                mcustomerId = value;
            }
        }
        public string emailAddress
        {
            get
            {
                return memailAddress;
            }
            set
            {
                memailAddress = value;
            }
        }
        public string userName
        {
            get
            {
                return muserName;
            }
            set
            {
                muserName = value;
            }
        }
        public DateTime dateOfBirth
{
            get
            {
                return mdateOfBirth;
            }
            set
            {
                mdateOfBirth = value;
            }
        }
        public bool hasPlaceOrder
        {
            get
            {
                return mhasPlaceOrder;
            }
            set
            {
                mhasPlaceOrder = value;
            }
        }
        public bool Find(int CustomerId)
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblStock_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mcustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mdateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                muserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                memailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mhasPlaceOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["HasPlaceOrder"]);
                return true;
            }

            else
            {
                return false;
            }
        }
        public string Valid(string userName, string emailAddress, string dateOfBirth)
        {
            String Error = "";
            DateTime DateTemp;

            if (userName.Length == 0)
            {
                Error = Error + "The Product Details may not be blank: ";
            }
            if (userName.Length > 20)
            {
                Error = Error + "The Product Details must be less than 20 characters : ";
            }
            try
            {

                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date connot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }
            if (emailAddress.Length == 0)
            {
                Error = Error + "The Product Details may not be blank: ";
            }
            if (emailAddress.Length > 40)
            {
                Error = Error + "The Product Details must be less than 40 characters : ";
            }

            return Error;
        }
    }
}
