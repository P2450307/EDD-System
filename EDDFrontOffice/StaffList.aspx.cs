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
        lstStaffList.DataValueField = "StaffID";
        //set data field to display
        lstStaffList.DataTextField = "Address";
        //bind data to list
        lstStaffList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into session object to indicate it is a new record
        Session["StaffID"] = -1;
        //redirect to data entry page
        Response.Redirect("Staff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store primary key
        Int32 sID;
        //if record has been selected from list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get PK of record to be deleted
            sID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in session object
            Session["StaffID"] = sID;
            //redirect to delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete";
        }


    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store primary key
        Int32 sID;
        //if record has been selected from list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get PK of record to be deleted
            sID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in session object
            Session["StaffID"] = sID;
            //redirect to delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete";
        }

    }
}