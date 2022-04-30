﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    private object txtFilter;

    protected void Page_Load(object sender, EventArgs e)
    {

        //if this is the first time the page is displayed 
        if(IsPostBack == false)
        {
            //update the list box 
            DisplayStocks();
        }


    }

    private void DisplayStocks()
    {
        //craete an instance of the Customer collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to list of customers in the collection
        lstStocksList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStocksList.DataValueField = "Stocks";
        //set the data field to display
        lstStocksList.DataTextField = "Stocks";
        //bind the data to the list
        lstStocksList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["SofaNumber"] = -1;
        //redirect to the data entry page 
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the porimary key value of the record to be edited 
        Int32 SofaNumber;
        //if a record has been selected from the list 
        if(lstStocksList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            SofaNumber = Convert.ToInt32(lstStocksList.SelectedValue);
            //stoer the data iun the session object 
            Session["SofaNumber"] = SofaNumber;
            //rediret to the edit page 
            Response.Redirect("StockDataEntry.Aspx");
        }
        else
        {
            lblError.Text = "please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited 
        Int32 SofaNumber;
        //if a record has been selected from the list 
        if(lstStocksList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            SofaNumber = Convert.ToInt32(lstStocksList.SelectedValue);
            //store the data in the session object 
            Session["SofaNumber"] = SofaNumber;
            //rediret to the delete page 
            Response.Redirect("StockConfirmDelete.aspxx");
        }
        else
        {
            lblError.Text = "Please select a record to delete  from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByAvailable(txtFilter.Text);
        lstStocksList.DataSource = Stock.StockList;
        lstStocksList.DataValueField = "SofaNUmber";
        lstStocksList.DataTextField = "Available";
        lstStocksList.DataBind();
    }



    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByAvailable("");
        txtFilter.Text = "";
        lstStocksList.DataSource = Stock.StockList;
        lstStocksList.DataValueField = "SofaNumber";
        lstStocksList.DataTextField = "Available";
        lstStocksList.DataBind();
    }
}