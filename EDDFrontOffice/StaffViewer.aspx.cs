using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EDDClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff Staff = new clsStaff();
        //get data from session object
        Staff = (EDDClasses.clsStaff)Session["Staff"];
        //display the staff ID for this entry
        Response.Write(Staff.StaffID);
    }
}