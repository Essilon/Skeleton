using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];

        //display the CustomerID of the Customer
        Response.Write("Customer ID = " + AnCustomer.CustomerID + "<br />");

        //display the Full Name of the Customer
        Response.Write("Customer Full Name = " + AnCustomer.Full_Name + "<br />");

        //display the Date of Birth of the Customer
        Response.Write("Customer Date of Birth = " + AnCustomer.DateOfBirth + "<br />");

        //display the Gender of the Customer
        Response.Write("Customer Gender = " + AnCustomer.Gender + "<br />");

        //display the Email of the Customer
        Response.Write("Customer Email = " + AnCustomer.Email + "<br />");

        //display the house number for this entry
        Response.Write("Customer Address = " + AnCustomer.Address + "<br />");
    }


}