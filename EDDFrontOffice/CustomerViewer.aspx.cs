using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EDDClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsCustomer customer = new ClsCustomer();
        customer = (ClsCustomer)Session["Customer"];
        Response.Write(customer.CustomerId);
    }
}