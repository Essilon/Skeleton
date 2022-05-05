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
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();


        //get the data from the session object 
        AnStaff = (clsStaff)Session["AnStaff"];

        //display the Staff Number for this entry 
        Response.Write(AnStaff.Employee_No + "\n");

        Response.Write(AnStaff.StaffAge + "\n");

        Response.Write(AnStaff.StaffTarget + "\n");


        Response.Write(AnStaff.StaffFullName + "\n");
 
        Response.Write(AnStaff.Male + "\n");

        Response.Write(AnStaff.StaffDateOfBirth + "\n");

       
        

        

        
    }
}