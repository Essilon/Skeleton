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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //store the address in this session object
        Session["AnCustomer"] = AnCustomer;

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

        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}