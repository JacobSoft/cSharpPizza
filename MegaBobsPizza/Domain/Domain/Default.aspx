<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaBobsPizza.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">

            <div class="page-header">
                <h1>Papa Bob's Pizza</h1>
                <p class ="lead">Pizza to code by</p>
            </div>

            <div class="row">
                <div class="col-lg-12 col-md-8 col-sm-6 col-xs-4">
                    <div class ="form-group">
                        <label><b>Size: </b></label>
                        <asp:DropDownList ID ="SizeList" runat="server" CssClass="form-control" AutoPostBack ="true" OnSelectedIndexChanged="displayCost">
                        <asp:ListItem Text="Small (12 inch - $12)" Value="0" />
                        <asp:ListItem Text="Medium (14 inch - $14)" Value="1" />
                        <asp:ListItem Text="Large (16 inch - $16)" Value="2" />
                         </asp:DropDownList>
                    </div>
                    <div class ="form-group">
                        <label><b>Crust: </b></label>
                        <asp:DropDownList ID ="CrustList" runat="server" CssClass="form-control" AutoPostBack ="true" OnSelectedIndexChanged="displayCost">
                        <asp:ListItem Text="Regular" Value="0" />
                        <asp:ListItem Text="Thin" Value="1" />
                        <asp:ListItem Text="Thick (+$2)" Value="2" />
                         </asp:DropDownList>
                    </div>
                    <div class ="checkbox"><label><asp:Checkbox ID ="sausageCheckbox" runat="server" AutoPostBack ="true" OnCheckedChanged="displayCost"></asp:Checkbox> Sausage</label></div>
                    <div class ="checkbox"><label><asp:Checkbox ID ="pepperoniCheckbox" runat="server" AutoPostBack ="true" OnCheckedChanged="displayCost"></asp:Checkbox> Pepperoni</label></div>
                    <div class ="checkbox"><label><asp:Checkbox ID ="onionsCheckbox" runat="server" AutoPostBack ="true" OnCheckedChanged="displayCost"></asp:Checkbox> Onions</label></div>
                    <div class ="checkbox"><label><asp:Checkbox ID ="greenPeppersCheckbox" runat="server" AutoPostBack ="true" OnCheckedChanged="displayCost"></asp:Checkbox> Green Peppers</label></div>
                    <h3>Deliver To:</h3>
                <div class ="form-group">
                    <label>Name: </label>
                    <asp:TextBox ID ="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class ="form-group">
                    <label>Address: </label>
                    <asp:TextBox ID ="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class ="form-group">
                    <label>Zip: </label>
                    <asp:TextBox ID ="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class ="form-group">
                    <label>Phone: </label>
                    <asp:TextBox ID ="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                    <h3>Payment: </h3>
                 <div class ="radio"><label><asp:RadioButton ID ="cashRadioButton" runat="server" GroupName ="pmtGroup"></asp:RadioButton> Cash</label></div>
                 <div class ="radio"><label><asp:RadioButton ID ="creditRadioButton" runat="server" GroupName ="pmtGroup"></asp:RadioButton> Credit</label></div>

                     <asp:Button ID="orderButton" runat="server" Text="Order!" OnClick="orderButton_Click" CssClass="btn btn-md btn-warning" />
                  <h3>Total Cost:
                        <asp:Label ID="resultLabel" runat="server">$12.00</asp:Label>
                    </h3>
                    <p>
                        <asp:Label ID="errorLabel" runat="server" CssClass="alert-danger"></asp:Label>
                    </p>
                    <p>
                        &nbsp;</p>

                </div>

            </div>


        </div>
                <script src="Scripts/jquery-3.1.1.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
