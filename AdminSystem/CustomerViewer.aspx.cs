using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingCustomer;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        Customer = (clsCustomer)Session["Customer"];
        Response.Write("Customer ID: " + Customer.CustomerId + ", ");
        Response.Write("Customer Name: " + Customer.Name + ", ");
        Response.Write("Customer Email: " +Customer.EmailAddress + ", ");
        Response.Write("Customer Address: " + Customer.Address + ", ");
        Response.Write("Customer Password: " + Customer.Password + ", ");
        Response.Write("Customer Loyalty Points: " + Customer.LoyaltyPoints + ", ");
        Response.Write("Customer Created At: " + Customer.CreatedAt + ", ");
        Response.Write("Customer Email Confirmed: " + Customer.isEmailConfirmed + ".");

    }
}