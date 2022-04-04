using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        //create an instance of the Customer
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(CustomerID);
        //display the data for thjis record
        txtCustomerID.Text = Customer.ThisCustomer.CustomerID.ToString();
        txtFull_Name.Text = Customer.ThisCustomer.Full_Name;
        txtDate_of_Birth.Text = Customer.ThisCustomer.DateOfBirth.ToString();
        MaleRadioButton1.Checked = Customer.ThisCustomer.Gender;
        FemaleRadioButton2.Checked = Customer.ThisCustomer.Gender;
        txtEmail.Text = Customer.ThisCustomer.Email;
        txtAddress.Text = Customer.ThisCustomer.Address;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //capture the customer's Full Name
        string Full_Name = txtFull_Name.Text;

        //capture the Customer's Date of Birth
        string DateOfBirth = txtDate_of_Birth.Text;

        //capture the Customer's Email
        string Email = txtEmail.Text;

        //capture the Customer's Address
        string Address = txtAddress.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnCustomer.Valid(Full_Name, DateOfBirth, Email, Address);
        if (Error == "")
        {
            //capture the customer's ID
            AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //capture the customer's Full Name
            AnCustomer.Full_Name = txtFull_Name.Text;
            //capture the Customer's Date of Birth
            AnCustomer.DateOfBirth = Convert.ToDateTime(txtDate_of_Birth.Text);
            //capture the Customer's Gender
            AnCustomer.Gender = Convert.ToBoolean(MaleRadioButton1.Checked);
            //capture the Customer's Email
            AnCustomer.Email = txtEmail.Text;
            //capture the Customer's Address
            AnCustomer.Address = txtAddress.Text;
            //create an instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //if not then it must be updated
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance for the Customer class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the Record in the database
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = Convert.ToString(AnCustomer.CustomerID);
            txtFull_Name.Text = AnCustomer.Full_Name;
            txtDate_of_Birth.Text = Convert.ToString(AnCustomer.DateOfBirth);
            txtEmail.Text = AnCustomer.Email;
            txtAddress.Text = AnCustomer.Address;

        }
    }
}