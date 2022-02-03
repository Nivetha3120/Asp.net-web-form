<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Footwear.aspx.cs" Inherits="Footwear.Footwear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Footware</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">     
        
        <div>
            <nav>
                <h47>Category</h47>
            <asp:DropDownList ID="Category" runat="server">
                <asp:ListItem>Kids</asp:ListItem>
                <asp:ListItem>Women</asp:ListItem>
                <asp:ListItem>Men</asp:ListItem>
            </asp:DropDownList>
                <asp:Button runat="server" ID="Viewbtn" Text="View" OnClick="Viewbtn_Click" />
                </nav>
                </div>
        <br /><br /><br />
        <div>
            <asp:GridView ID="GView" runat="server"></asp:GridView>
        </div>

         <div id="div1" runat="server">
            <asp:TextBox ID="txtProductCode" runat="server" PlaceHolder="Enter a ProductId" ></asp:TextBox>
            <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" />
        </div>
        <div>
            <asp:Button ID="StatusButton" runat="server" Text="Status Details" OnClick="StatusButton_Click" />
        </div>
    </form>
</body>
</html>
