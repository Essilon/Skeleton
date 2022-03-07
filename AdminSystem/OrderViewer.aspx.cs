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
        Response.Write(anOrder.OrderNo);
    }
}