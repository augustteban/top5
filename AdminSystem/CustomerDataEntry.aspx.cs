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

        string Name = txtName.Text;
        string EmailAddress = txtEmailAddress.Text;
        string Address = txtAddress.Text;
        string Password = txtPassword.Text;
        string LoyaltyPoints = txtLoyaltyPoints.Text;
        string CreatedAt = txtCreatedAt.Text;
        string isEmailConfirmed = chkIsEmailConfirmed.Checked ? "true" : "false";

        string Error = Customer.Valid(Name, EmailAddress, Address, Password, isEmailConfirmed, LoyaltyPoints, CreatedAt);

        if (Error == "")
        {
            Customer.CustomerId = Int32.Parse(txtCustomerId.Text);
            Customer.Name = Name;
            Customer.EmailAddress = EmailAddress;
            Customer.Address = Address;
            Customer.Password = Password;
            Customer.LoyaltyPoints = Double.Parse(LoyaltyPoints);
            Customer.CreatedAt = DateTime.Parse(CreatedAt);
            Customer.isEmailConfirmed = chkIsEmailConfirmed.Checked;

            Session["Customer"] = Customer;

            //navigate to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
       
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