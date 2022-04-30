using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    public int SofaNumber { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object 
        SofaNumber = Convert.ToInt32(Session["SofaNumber"]);
    }

    public partial class Delete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 SofaNumber;

        //event handler for the load event 
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the SofaNumber
        clsStockCollection Stock = new clsStockCollection();
        //find the record to delete 
        Stock.ThisStock.Find(SofaNumber);
        //delete the record 
        Stock.Delete();
        //redirect back to the main page 
        Response.Redirect("StockList.aspx");
    }
}