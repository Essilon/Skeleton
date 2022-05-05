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
        //create a new insance of clsStaff
        clsStaff AnStaff = new clsStaff();

        AnStaff.Employee_No = txtEmployeeNo.Text;

          AnStaff.StaffTarget = Convert.ToInt32(txtEmployeeTarget.Text);


        //capture the staff no
        AnStaff.StaffFullName = txtEmployeeFullName.Text; 
       


        AnStaff.StaffDateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
         
        
        AnStaff.Male = chkGender.Checked;
        


        AnStaff.StaffAge = Convert.ToInt32 (txtEmployeeAge.Text);


      
        
        Session["AnStaff"] = AnStaff;

        //navigates to viewer page
        Response.Redirect("StaffViewer.aspx");

    }
}