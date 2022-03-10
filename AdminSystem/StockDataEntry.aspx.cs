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
        clsStock AnStock = new clsStock();
        //store the address in this session object
        Session["AnStock"] = AnStock;

        //cpature the Sofa Number
        AnStock.SofaNumber = Convert.ToInt32(txtSofaNumber.Text);

        //capture the Sofa's description
        AnStock.SofaDescription = Convert.ToInt32(txtSofaDescription.Text);

        //capture the Sofa Colour
        AnStock.SofaColour = txtSofaColour.Text;

        //capture the Date Added 
        AnStock.DateAdded = txtDateAdded.Text;

        //capture the Sofa Price
        AnStock.Price = Convert.ToDecimal(txtPrice.Text);

        //capture the Sofa's Availablity
        AnStock.Available = Convert.ToBoolean(txtAvailable.Text);
        //navigate to the viewer page 
        Response.Redirect("StockDataEntry.aspx");
    }
}