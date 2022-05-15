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

        string Employee_No = txtEmployeeNo.Text;
        string StaffTarget = txtEmployeeTarget.Text;
        string StaffFullName = txtEmployeeFullName.Text;
        string StaffDateOfBirth = txtDateOfBirth.Text;
        AnStaff.Male = chkGender.Checked;
        string StaffAge = txtEmployeeAge.Text;

        string Error = "";
        Error = AnStaff.Valid(StaffAge,StaffDateOfBirth,StaffFullName,StaffTarget);
        if (Error == "")
        {
            AnStaff.StaffNo = Convert.ToInt32(Employee_No);
            AnStaff.StaffAge = Convert.ToInt32(StaffAge);
            AnStaff.StaffTarget = Convert.ToInt32(StaffTarget);
            AnStaff.StaffFullName = StaffFullName;
            AnStaff.StaffDateOfBirth = Convert.ToDateTime(StaffDateOfBirth);
           
            Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffViewer.aspx");

        }
        else
        {
            lblError.Text = Error; 
        }
      
        
        

    }
}