<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 85px">
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID  " width="108px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />

        <asp:Label ID="lblFull_Name" runat="server" Text="Full Name " height="22px" width="108px"></asp:Label>
        <asp:TextBox ID="txtFull_Name" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblDate_of_Birth" runat="server" Text="Date of Birth " height="22px" width="108px"></asp:Label>
        <asp:TextBox ID="txtDate_of_Birth" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblEmail" runat="server" Text="Email " height="22px" width="108px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblAddress" runat="server" Text="Address " height="22px" width="108px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
        
        
        <fieldset style="width:130px">
            <legend><b>Gender</b></legend>
            <asp:RadioButton ID="MaleRadioButton1" Text="Male" runat="server" GroupName="Gender" />
            <asp:RadioButton ID="FemaleRadioButton2" Text="Female" runat="server" GroupName="Gender" />
            </fieldset>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />

        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />

        </div>
    </form>
</body>
</html>