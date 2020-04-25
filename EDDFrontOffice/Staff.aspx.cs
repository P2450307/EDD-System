using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EDDClasses;


public partial class Staff : System.Web.UI.Page
{
    Int32 SID;

    protected void Page_Load(object sender, EventArgs e)
    {

        SID = Convert.ToInt32(Session["StaffID"]);
        if(IsPostBack == false)
        {
            //if this is not new
            if (SID != -1)
            {
                //display current record for data
                DisplayStaff();
            }
        }
        
        //clsStaff Staff = new clsStaff();
        //get data from session object
        //Staff = (clsStaff)Session["Staff"];
        //display staff ID for this entry
        //Response.Write(Staff.StaffID);
    }

    void DisplayStaff()
    {
        clsStaffCollection staff = new clsStaffCollection();
        staff.thisStaff.Find(SID);
        //display data
        txtStaffID.Text = staff.thisStaff.StaffID.ToString();
        txtFullName.Text = staff.thisStaff.FullName;
        txtDateOfBirth.Text = staff.thisStaff.DateOfBirth.ToString();
        txtAddress.Text = staff.thisStaff.Address;
        txtContactNo.Text = staff.thisStaff.ContactNo;
    }

    

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStaff Staff = new clsStaff();

        string StaffID = txtStaffID.Text;
        string FullName = txtFullName.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Address = txtAddress.Text;
        string ContactNo = txtContactNo.Text;
        string error = "";
        error = Staff.Valid(FullName, DateOfBirth, Address, ContactNo);
        if(error == "")
        {
            //capture all information below
            Staff.StaffID = Convert.ToInt32(StaffID);
            Staff.FullName = FullName;
            Staff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            Staff.Address = Address;
            Staff.ContactNo = ContactNo;
            Staff.LoggedInOut = LoggedInOut.Checked;
            //create instance of collection class
            clsStaffCollection staffList = new clsStaffCollection();

            if (SID == -1)
            {
                //set thisStaff property
                staffList.thisStaff = Staff;
                //add the new record
                staffList.Add();
            }
            else
            {
                staffList.thisStaff.Find(SID);
                //set this staff property
                staffList.thisStaff = Staff;
                staffList.Update();
            }

            //redirect back to list page
            Response.Redirect("StaffList.aspx");
            
            //store address in session object
            //Session["Staff"] = Staff;
            //redirect to viewer page
            //Response.Write("StaffViewer.aspx");
        }

        else
        {
            lblError.Text = error;
        }      

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff Staff = new clsStaff();

        //variable to store primary key
        Int32 StaffID;

        //variable to store result of find operation
        Boolean found = false;

        //get primary key entered by user
        StaffID = Convert.ToInt32(txtStaffID.Text);

        //find the record
        found = Staff.Find(StaffID);

        //if found
        if(found == true)
        {
            //display values in the form
            txtFullName.Text = Staff.FullName;
            txtDateOfBirth.Text = Staff.DateOfBirth.ToString();
            txtAddress.Text = Staff.Address;
            txtContactNo.Text = Staff.ContactNo;
            
        }
       
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
}