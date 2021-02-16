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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        Int32 CustomerId;
        bool isNumeric = int.TryParse(txtCustomerId.Text, out CustomerId);

        if (!isNumeric)
        {
            lblError.Text = "Provided ID is not a number.";
        }
        else
        {
            Boolean Found = false;
            Found = Customer.Find(CustomerId);

            if (Found == true)
            {
                txtName.Text = Customer.Name;
                txtEmailAddress.Text = Customer.EmailAddress;
                txtAddress.Text = Customer.Address;
                txtPassword.Text = Customer.Password;
                txtLoyaltyPoints.Text = Customer.LoyaltyPoints.ToString();
                txtCreatedAt.Text = Customer.CreatedAt.ToString();
                chkIsEmailConfirmed.Checked = Customer.isEmailConfirmed;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "The customer with this ID has not been found.";
            }
        }
    }
}