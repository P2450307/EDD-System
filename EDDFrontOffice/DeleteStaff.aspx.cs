using EDDClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the staff id to be deleted from session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
        
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection staff = new clsStaffCollection();
        staff.thisStaff.Find(StaffID);
        staff.Delete();
        //redirect to main page
        Response.Redirect("StaffList.aspx");


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}