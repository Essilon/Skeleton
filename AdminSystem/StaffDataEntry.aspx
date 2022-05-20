<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Employee_No" runat="server" Height="19px" Text="Employee Number " width="146px"></asp:Label>
        <asp:TextBox ID="txtEmployeeNo" runat="server" style="margin-top: 0px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="EmployeeAge" runat="server" Text="Employee Age " width="146px"></asp:Label>
            <asp:TextBox ID="txtEmployeeAge" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="EmployeeTarget" runat="server" Text="Empolyee Target " width="146px"></asp:Label>
            <asp:TextBox ID="txtEmployeeTarget" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="EmpoyeeFullName" runat="server" Text="Employee  Full Name " width="146px"></asp:Label>
        <asp:TextBox ID="txtEmployeeFullName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Gender" runat="server" Text="Employee Gender" width="146px"></asp:Label>
            <asp:CheckBox ID="chkGender" runat="server" Text="Male " />
        </p>
        <asp:Label ID="DateOfBirth" runat="server" Text="Employee Date of Birth "></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
