<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="orderPage.aspx.vb" Inherits="MyProject.orderPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Order Information:</h3>
            <asp:Label ID="firstNameLabel" runat="server" Text="First Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameTextBox" ErrorMessage="First name is required">*</asp:RequiredFieldValidator>
<br /><br />
            <asp:Label ID="lastNameLabel" runat="server" Text="Last Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastNameTextBox" ErrorMessage="Last name required">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="addressLabel" runat="server" Text="Address (include zip code):"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="addressTextBox" ErrorMessage="Ensure that your address contains your zip code." ValidationExpression="\d{5}(-\d{4})?">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="phoneNumberLabel" runat="server" Text="Phone Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="phoneNumberTextBox" runat="server"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="phoneNumberTextBox" ErrorMessage="Phone number is required" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <h3>Customize your taco:</h3> </div>
        <p>
            <asp:Label ID="enterMeatLabel" runat="server" Text="Choose taco meat:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="meatsDropDownList" runat="server" Height="16px" Width="222px" AutoPostBack="True">
                <asp:ListItem Value="8.99">Chipotle Chicken     $8.99</asp:ListItem>
                <asp:ListItem Value="9.99">Pastor Pork     $9.99</asp:ListItem>
                <asp:ListItem Value="12.99">Blackened Fish     $12.99</asp:ListItem>
                <asp:ListItem Value="13.99">Carne Asada     $13.99</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="meatsDropDownList" ErrorMessage="Meat selection required">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="chooseToppingsLabel" runat="server" Text="Choose taco toppings (additional $0.99 each):"></asp:Label>
        </p>
        <asp:CheckBox ID="cheeseCheckBox" runat="server" Text="Cheese" AutoPostBack="True" />
        <br />
        <asp:CheckBox ID="lettuceCheckBox" runat="server" Text="Lettuce" AutoPostBack="True" />
        <br />
        <asp:CheckBox ID="tomatoesCheckBox" runat="server" Text="Tomatoes" AutoPostBack="True" />
        <br />
        <asp:CheckBox ID="sourCreamCheckBox" runat="server" Text="Sour Cream" AutoPostBack="True" />
        <br />
        <asp:CheckBox ID="secretSauceCheckBox" runat="server" Text="Secret Sauce" AutoPostBack="True" />
        <br />
        <asp:Button ID="orderButton" runat="server" Text="Submit Order" />
        <br />
        <br />
        <asp:Label ID="finalCostLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
