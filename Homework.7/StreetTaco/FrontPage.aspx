<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrontPage.aspx.vb" Inherits="MyProject.FrontPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="269px" ImageUrl="https://www.tacobell.com/images/22101_crunchy_taco_supreme_269x269.jpg" Width="269px" />
        </div>
        <p style="margin-left: 75px">
            <asp:Button ID="Button1" runat="server" Height="50px" Text="Order Here" Width="125px" PostBackUrl="~/orderPage.aspx" />
        </p>
    </form>
</body>
</html>
