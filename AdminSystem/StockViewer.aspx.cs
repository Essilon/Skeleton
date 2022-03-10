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
        //create a new instance of the clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
        //display the Sofa number for this entry 
        Response.Write(AnStock.SofaNumber);

        //display the sofa Description for this entry 
        Response.Write(AnStock.SofaDescription);

        //display the sofa Colour for this entry 
        Response.Write(AnStock.SofaColour);

        //display the Date Added for this entry 
        Response.Write(AnStock.DateAdded);

        //dsiplay the Price for this entry
        Response.Write(AnStock.Price);

        //display the available for this entry 
        Response.Write(AnStock.Available);

    }
}