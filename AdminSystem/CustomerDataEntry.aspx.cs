using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingCustomer;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false) {
            if (CustomerId != -1) {
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerId);

        txtName.Text = Customers.ThisCustomer.Name;
        txtEmailAddress.Text = Customers.ThisCustomer.EmailAddress;
        txtAddress.Text = Customers.ThisCustomer.Address;
        txtPassword.Text = Customers.ThisCustomer.Password;
        txtLoyaltyPoints.Text = Customers.ThisCustomer.LoyaltyPoints.ToString();
        txtCreatedAt.Text = Customers.ThisCustomer.CreatedAt.ToString();
        chkIsEmailConfirmed.Checked = Customers.ThisCustomer.isEmailConfirmed;
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
            Customer.CustomerId = CustomerId;
            Customer.Name = Name;
            Customer.EmailAddress = EmailAddress;
            Customer.Address = Address;
            Customer.Password = Password;
            Customer.LoyaltyPoints = Double.Parse(LoyaltyPoints);
            Customer.CreatedAt = DateTime.Parse(CreatedAt);
            Customer.isEmailConfirmed = chkIsEmailConfirmed.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = Customer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = Customer;
                CustomerList.Update();
            }

            //navigate to the viewer page
            Response.Redirect("CustomerList.aspx");
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