<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    This is the order entry page 
        <p>
            <asp:Label ID="lblOrderNo" runat="server" Text="Order Number: " width="153px"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderPass" runat="server" Text="Order Pass:" width="153px"></asp:Label>
            <asp:TextBox ID="txtOrderPass" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblEstDeliveryDate" runat="server" Text="Estimated Delivery Date: "></asp:Label>
        <asp:TextBox ID="txtEstDeliveryDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDeliveryAddress" runat="server" Text="Delivery Address: " width="153px"></asp:Label>
            <asp:TextBox ID="txtDeliveryAdres" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblAutomatedConfEmail" runat="server" Text="Automated Confirmation Email: " width="153px"></asp:Label>
        <asp:TextBox ID="txtAutoEmComf" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPaymentDetails" runat="server" Text="Payment Details: " width="153px"></asp:Label>
            <asp:TextBox ID="txtPayDetail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
