<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActiveOrdersScreen.aspx.cs" Inherits="MegaBobsPizza.Web.ActiveOrdersScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns ="True" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:ButtonField Text="Finished" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
