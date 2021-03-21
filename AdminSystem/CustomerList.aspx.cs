using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingCustomer;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
        void DisplayCustomers()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();
            lstCustomers.DataSource = Customers.CustomerList;
            lstCustomers.DataValueField = "CustomerId";
            lstCustomers.DataTextField = "Name";
            lstCustomers.DataBind();

        
        }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        Int32 CustomerId;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName(txtFilter.Text);
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerId";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName("");
        txtFilter.Text = "";
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerId";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();
    }
}