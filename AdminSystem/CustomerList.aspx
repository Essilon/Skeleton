<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="191px" Width="303px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        </div>
    </form>
</body>
</html>
