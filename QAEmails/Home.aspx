<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QAEmails.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id ="PageBody" runat ="server">
    <form id="form1" runat="server">
    <div>
    
    	<asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
		<br />
		<br />
		<asp:Button ID="CreateAccButton" runat="server" OnClick="CreateAccButton_Click" Text="Create Account" />
		<br />
		<br />
		<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
			<asp:ListItem Value="rgb(255, 180, 180)">Red</asp:ListItem>
			<asp:ListItem Value="rgb(180, 255, 180)">Green</asp:ListItem>
			<asp:ListItem Value="rgb(180, 180, 255)">Blue</asp:ListItem>
			<asp:ListItem Value="rgb(255, 255, 180)">Yellow</asp:ListItem>
		</asp:RadioButtonList>
    
    </div>
    </form>
</body>
</html>
