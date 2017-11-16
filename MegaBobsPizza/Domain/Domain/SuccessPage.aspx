<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuccessPage.aspx.cs" Inherits="MegaBobsPizza.Web.SuccessPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="successLabel" runat="server" ForeColor="#003399" Text="Thank you for your order!"></asp:Label>
            </h1>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="orderMgmtButton" runat="server" OnClick="orderMgmtButton_Click" Text="Go to Order Management" />
            </p>
        </div>
    </form>
</body>
</html>
