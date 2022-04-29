using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Order_No;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new intance 
        clsOrder AnOrder = new clsOrder();
        //store the order in session obj
      

        
        String Order_Pass = txtOrderPass.Text;
        String Est_Delivery_Date = txtEstDeliveryDate.Text;
        String Delivery_Address = txtDeliveryAdres.Text;
        String Automated_Conf_Email = txtAutoEmComf.Text;
        String Payment_Details = txtPayDetail.Text;

        string Error = "";
        Error = AnOrder.Valid(Est_Delivery_Date,
            Delivery_Address, Automated_Conf_Email, Payment_Details);
        if (Error == "")
        {
            //capture the customers OrderNo

            AnOrder.Order_No = Convert.ToInt32(txtOrderNo.Text);
            AnOrder.Order_Pass = Convert.ToBoolean(txtOrderPass.Text);
            AnOrder.Est_Delivery_Date = Convert.ToDateTime(txtEstDeliveryDate.Text);
            AnOrder.Delivery_Address = txtDeliveryAdres.Text;
            AnOrder.Automated_Conf_Email = txtAutoEmComf.Text;
            AnOrder.Payment_Details = Convert.ToInt32(txtPayDetail.Text);
             

            clsOrderCollection OrderList = new clsOrderCollection();
           
            if (Order_No == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(Order_No);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }
}