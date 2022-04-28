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
        //create a new instance of cls
        clsOrder anOrder = new clsOrder();
        //get the data from the session obj
        anOrder = (clsOrder)Session["AnOrder"]; 

        //display the house number for this entry
        Response.Write("Order Number" + anOrder.Order_No + "<br / >");
        Response.Write("Order Pass: " + anOrder.Order_Pass + "<br / >");
        Response.Write("Estimated Delivery Date: " + anOrder.Est_Delivery_Date + "<br / >");
        Response.Write("Delivery Address: " + anOrder.Delivery_Address + "<br / >");
        Response.Write("Automatic Email: " + anOrder.Automated_Conf_Email + "<br / >");
        Response.Write("Payment details: " + anOrder.Payment_Details + "<br / >");

    }
}