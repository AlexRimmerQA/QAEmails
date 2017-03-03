<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="QAEmails.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body id ="PageBody" runat ="server">
	<form id="form1" runat="server">
		<span style="font-size: 18px">Email Address</span><br />
		<asp:TextBox ID="EmailTextbox" Style="font-size: 18px" runat="server"></asp:TextBox>
		<br /><br />
		<span style="font-size: 18px">Password</span><br />
		<asp:TextBox ID="PasswordTextbox" Style="font-size: 18px" runat="server" TextMode="Password"></asp:TextBox>
		<br /><br />
		<span style="font-size: 18px">Re-enter Password</span><br />
		<asp:TextBox ID="RePassTextbox" Style="font-size: 18px" runat="server" TextMode="Password"></asp:TextBox>
		<br /><br />
		<span style="font-size: 18px">Name</span><br />
		<asp:TextBox ID="NameTextbox" Style="font-size: 18px" runat="server"></asp:TextBox>
		<br /><br />
		<span style="font-size: 18px">Address</span><br />
		<asp:TextBox ID="AddressTextbox" Style="font-size: 18px" runat="server"></asp:TextBox>
		<br /><br />
		<span style="font-size: 18px">Security Question</span><br />
		<asp:TextBox ID="QuestionTextbox" Style="font-size: 18px" runat="server"></asp:TextBox>
		<br /><br />
		<span style="font-size: 18px">Security Answer</span><br />
		<asp:TextBox ID="AnswerTextbox" Style="font-size: 18px" runat="server"></asp:TextBox>
		<br /><br />
		<asp:Button ID="CreateButton" Style="font-size: 18px" runat="server" OnClick="CreateButton_Click" Text="Create" />
	</form>
</body>
</html>
