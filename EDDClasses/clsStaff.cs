using System;

namespace EDDClasses
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool LoggedInOut { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
    }
}