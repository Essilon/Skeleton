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
        Response.Write("Order Number" + anOrder.OrderNo + "<br / >");
        Response.Write("Order Pass: " + anOrder.OrderPass + "<br / >");
        Response.Write("Estimated Delivery Date: " + anOrder.EstDeliveryDate + "<br / >");
        Response.Write("Delivery Address: " + anOrder.DeliveryAddress + "<br / >");
        Response.Write("Automatic Email: " + anOrder.AutomatedConfEmail + "<br / >");
        Response.Write("Payment details: " + anOrder.PaymentDetails + "<br / >");

    }
}