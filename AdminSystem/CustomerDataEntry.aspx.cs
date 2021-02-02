using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingCustomer;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        Customer.CustomerId = Int32.Parse(txtCustomerId.Text);
        Customer.Name = txtName.Text;
        Customer.EmailAddress = txtEmailAddress.Text;
        Customer.Address = txtAddress.Text;
        Customer.Password = txtPassword.Text;
        Customer.LoyaltyPoints = Double.Parse(txtLoyaltyPoints.Text);
        Customer.CreatedAt = DateTime.Parse(txtCreatedAt.Text);
        Customer.isEmailConfirmed = chkIsEmailConfirmed.Checked;

        Session["Customer"] = Customer;

        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}