using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //capture the Customer ID
        string CustomerID = txtCustomerID.Text;

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
            //cpature the customer'd ID
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
            //set the ThisCustomer property
            CustomerList.ThisCustomer = AnCustomer;
            //add the new record
            CustomerList.Add();
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