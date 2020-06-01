using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EDDClasses;

public partial class CustomerFinder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        ClsCustomer customer = new ClsCustomer();
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
            customer.dateOfBirth = Convert.ToDateTime(txtdateOfBirth.Text);
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
        return;
    }
    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsCustomer customer = new ClsCustomer();
        int CustomerId;
        bool Found = false;
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Found = customer.Find(CustomerId);


        if (Found == true)
        {
            txtuserName.Text = customer.userName;
            txtemailAddress.Text = customer.emailAddress;
            txtdateOfBirth.Text = customer.dateOfBirth.ToString();
            txthasPlaceOrder.Text = customer.hasPlaceOrder.ToString();
        }
        else
        {
            txtuserName.Text = "";
            txtemailAddress.Text = "";
            txtdateOfBirth.Text = "";
            txthasPlaceOrder.Text = "";
            lblError.Text = "Provided CustomerID does not exist. Please enter a valid CustomerID!";
        }
    }
}