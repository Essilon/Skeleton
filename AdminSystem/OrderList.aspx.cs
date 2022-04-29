using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "Order_No";
        lstOrderList.DataTextField = "Delivery_Address";
        lstOrderList.DataBind();

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Order_No"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 Order_No;

        if (lstOrderList.SelectedIndex != -1)
        {
            Order_No = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["Order_No"] = Order_No;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Pleasse select a record to delte from the lsit";
        }
    }
}