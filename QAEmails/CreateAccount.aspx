<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="QAEmails.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Email Address<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Re-enter Password<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Security Question<br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Security Answer<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />
    
    </div>
    </form>
</body>
</html>
