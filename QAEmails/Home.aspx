<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QAEmails.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
		<br />
		<br />
		<asp:Button ID="CreateAccButton" runat="server" OnClick="CreateAccButton_Click" Text="Create Account" />
		<br />
		<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
			<asp:ListItem>Red</asp:ListItem>
			<asp:ListItem>Green</asp:ListItem>
			<asp:ListItem>Blue</asp:ListItem>
			<asp:ListItem>Yellow</asp:ListItem>
		</asp:RadioButtonList>
    
    </div>
    </form>
</body>
</html>
