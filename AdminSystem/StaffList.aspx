<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="340px" Width="437px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
            <asp:Button ID="Edit" runat="server" OnClick="Button1_Click" Text="Edit" />
            <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="EnterFullName" runat="server" Text="Enter Empoyee Full Name         "></asp:Label>
            <asp:TextBox ID="AnwserBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
