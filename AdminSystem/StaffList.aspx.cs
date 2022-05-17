using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    Int32 Employee_No;
    protected void Page_Load(object sender, EventArgs e)
    {
        Employee_No = Convert.ToInt32(Session["Employee_No"]);
        if (IsPostBack == false)
        {
            if (Employee_No != -1)
            {
                DisplayStaff();
            }
        }
       
    }
    /*void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(Employee_No);
        txtEmployee_No.Text = StaffBook.ThisStaff.StaffNo.ToString();
        txtEmployeeAge.Text = StaffBook.ThisStaff.StaffAge.ToString();
        txtEmployeeFullName = StaffBook.ThisStaff.StaffFullName;
        txtDateOfBirth = StaffBook.ThisStaff.StaffDateOfBirth.DateAdded.ToString();
        chkGender.Text = StaffBook.ThisStaff.StaffNo.ToString();
        txtEmployeeTarget.Text = StaffBook.ThisStaff.StaffTarget.ToString();
    }*/

    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        lstStaffList.DataSource = StaffBook.StaffList;
        lstStaffList.DataValueField = "Employee_No";
        lstStaffList.DataTextField = "EmployeeTarget";
        lstStaffList.DataBind();
    }

    protected void Add_Click(object sender, EventArgs e)
    {
        Session["Employee_No"] = Employee_No;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void Edit_Click (object sender, EventArgs e)
    {
        Int32 StaffNo; 
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["Employee_No"] = StaffNo;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        Int32 StaffNo;

        if (lstStaffList.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["Employee_No"] = StaffNo;
            Response.Redirect("StaffConfirmDelete.aspx.cs");
        }
        else
        {
            lblError.Text = " Please select a record to delete from this list";
        }
    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByStaffFullName(AnwserBox.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "Employee_No";
        lstStaffList.DataTextField = "EmployeeFullName";
        lstStaffList.DataBind();

    }




    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByStaffFullName("");
        AnwserBox.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "Employee_No";
        lstStaffList.DataTextField = "EmployeeFullName";
        lstStaffList.DataBind();
    }
}