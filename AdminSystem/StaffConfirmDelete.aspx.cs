﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    protected void Yes_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffNo);
        StaffBook.Delete();
        Response.Redirect("StaffList.aspx");

    }
}