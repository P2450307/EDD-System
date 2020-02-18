using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Staff : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e) 
    {
        //create new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //capture StaffID
        Staff.StaffID = txtStaffID.Text;
        //store staff in session object
        Session["Staff"] = Staff;
        //redirect to viewer page
        Response.Redirect("StaffViewer.aspx");

    }
}