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

        //create a new intance 
        clsOrder AnOrder = new clsOrder();
        //store the order in session obj
        Session["AnOrder"] = AnOrder;

        //capture the customers OrderNo

        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);

        //navigation
        Response.Redirect("OrderViewer.aspx");

    }
}