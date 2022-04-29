using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Order_No;

    protected void Page_Load(object sender, EventArgs e)
    {
        Order_No = Convert.ToInt32(Session["Order_No"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ThisOrder.Find(Order_No);
        Order.Delete();
        Response.Redirect("OrderList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ThisOrder.Find(Order_No);
        Response.Redirect("OrderList.aspx");
    }
}