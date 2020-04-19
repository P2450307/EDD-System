using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            //update list box
            DisplayStaffAddress();

        }
    }

    void DisplayStaffAddress()
    {
        EDDClasses.clsStaffCollection staff = new EDDClasses.clsStaffCollection();
        //set data source to list of staff in the collection
        lstStaffList.DataSource = staff.staffList;
        //set name of primary key
        lstStaffList.DataValueField = "Address";
        //set data field to display
        lstStaffList.DataTextField = "Address";
        //bind data to list
        lstStaffList.DataBind();
    }
}