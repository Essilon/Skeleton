using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{



    Int32 SofaNumber;

    protected void Page_Load(object sender, EventArgs e)
    {

        //get the number of the address to be processed 
        SofaNumber = Convert.ToInt32(Session["SofaNumber"]);
        if(IsPostBack == false)
        {
            //if this is not  new record 
            if(SofaNumber != -1)
            {
                //display the current data for the record 
                DisplayStock();
            }
        }


    }

    private void DisplayStock()
    {
        //create an insatcne of the address book 
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update 
        StockBook.ThisStock.Find(SofaNumber);
        //display the data for this record 
        txtSofaNumber.Text = StockBook.ThisStock.SofaNumber.ToString();
        txtSofaDescription.Text = StockBook.ThisStock.SofaDescription.ToString();
        txtDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        txtSofaColour.Text = StockBook.ThisStock.SofaColour;
        txtPrice.Text = StockBook.ThisStock.Price.ToString();
        txtAvailable.Text = StockBook.ThisStock.Available.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsStock AnStock = new clsStock();

        //capture the sofa Number
        string SofaNumber = txtSofaNumber.Text;

        //capture the sofa description
        string SofaDescription = txtSofaDescription.Text;

        //capture the sofa colour
        string SofaColour = txtSofaColour.Text;

        //capture the date added
        string DateAdded = txtDateAdded.Text;

        //capture the price 
        string Price = txtPrice.Text;

        //capture the available 
        string Available = txtAvailable.Text;
        
        //variable to store any error messages 
        string Error = "";

        //validate the data 
        Error = AnStock.Valid(SofaNumber, SofaDescription, SofaColour, DateAdded, Price, Available);
        if(Error == "")
        {
            //cpature the Sofa Number
            AnStock.SofaNumber = Convert.ToInt32(txtSofaNumber.Text);
            //capture the Sofa's description
            AnStock.SofaDescription = Convert.ToInt32(txtSofaDescription.Text);
            //capture the Sofa Colour
            AnStock.SofaColour = Convert.ToString(txtSofaColour.Text);
            //capture the Date Added 
            AnStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //capture the Sofa Price
            AnStock.Price = Convert.ToDecimal(txtPrice.Text);
            //capture the Sofa's Availablity
            AnStock.Available = Convert.ToBoolean(txtAvailable.Text);
            //capture active 
            AnStock.Active = chkActive.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. SofaNumber = -1 then add the data 
            /*
             * if (SofaNumber == -1)
            {
                //set the ThisStock Property
                StockList.ThisStock = AnStock;
                //add the new record 
                StockList.Add();
            }*/
            //otherwise it must be an update 
            else
            {
                //find the record to update 
                StockList.ThisStock.Find(SofaNumber);
                //set the ThisStock property 
                StockList.ThisStock = AnStock;
                //update the record 
                StockList.Update();
            }
            //navigate to the viewer page 
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}