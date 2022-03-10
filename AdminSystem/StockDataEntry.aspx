<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSofaNo" runat="server" Text="Sofa Number "></asp:Label>
        <asp:TextBox ID="txtSofaNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSofaDescription" runat="server" Text="Sofa DES" width="86px"></asp:Label>
        <asp:TextBox ID="txtSofaDescription" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSofaColour" runat="server" Text="Sofa Colour" width="86px"></asp:Label>
        <asp:TextBox ID="txtSofaColour" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="86px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="86px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAvailable" runat="server" Text="Available" width="86px"></asp:Label>
        <asp:TextBox ID="txtAvailable" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
