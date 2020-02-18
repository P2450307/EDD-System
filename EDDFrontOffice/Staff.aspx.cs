using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EDDClasess;
using EDDClasses;

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
        clsStaff AStaff = new clsStaff();

        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffIDViewer.aspx");

    }
}