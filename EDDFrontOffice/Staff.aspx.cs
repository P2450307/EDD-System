using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EDDClasses;


public partial class Staff : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
       // clsStaff Staff = new clsStaff();

        //get data from session object
       // Staff = (clsStaff)Session["Staff"];

        //display staff ID for this entry
       // Response.Write(Staff.FullName);
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStaff Staff = new clsStaff();

        //capture all information below
        Staff.StaffID = Convert.ToInt32(txtStaffID.Text);
        Staff.FullName = txtFullName.Text;
        Staff.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        Staff.LoggedInOut = Convert.ToBoolean(RadioButton1);
        Staff.Address = txtAddress.Text;
        Staff.ContactNo = txtContactNo.Text;
        
        Session["Staff"] = Staff;
        Response.Redirect("StaffViewer.aspx");

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
}