using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 EmployeeNo;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new insance of clsStaff
        clsStaff AnStaff = new clsStaff();

      
        string StaffTarget = txtEmployeeTarget.Text;
        string StaffFullName = txtEmployeeFullName.Text;
        string StaffDateOfBirth = txtDateOfBirth.Text;
        string StaffAge = txtEmployeeAge.Text;

        string Error = "";
        Error = AnStaff.Valid(StaffAge,StaffDateOfBirth,StaffFullName,StaffTarget);
        if (Error == "")
        {
            
            AnStaff.StaffNo = EmployeeNo;
            AnStaff.StaffAge = Convert.ToInt32(StaffAge);
            AnStaff.StaffTarget = Convert.ToInt32(StaffTarget);
            AnStaff.StaffFullName = StaffFullName;
            AnStaff.StaffDateOfBirth = Convert.ToDateTime(StaffDateOfBirth);
            AnStaff.Male = chkGender.Checked;

            clsStaffCollection StaffList = new clsStaffCollection();
            if (EmployeeNo == -1)
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(EmployeeNo);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
               
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error; 
        }
      
        
        

    }
}