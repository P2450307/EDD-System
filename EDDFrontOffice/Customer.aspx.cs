using System;
using EDDClasses;

public partial class Customer: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();
        string userName = txtuserName.Text;
        string emailAddress = txtemailAddress.Text;
        string dateOfbirth = txtdateOfBirth.Text;
        string hasPlaceOrder = txthasPlaceOrder.Text;
        string Error = "";
        Error = customer.Valid(userName, emailAddress, dateOfbirth);
        if (Error == "")
        {
            customer.userName = userName;
            customer.emailAddress = emailAddress;
            customer.dateOfbirth = Convert.ToDateTime(txtdateOfBirth.Text);
            customer.hasPlaceOrder = Convert.ToBoolean(txthasPlaceOrder.Text);
            Session["Customer"] = customer;
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
}