<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QAEmails.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table style="height: 133px; width: 304px">

          <tr>
            <th colspan="2"> <h2>Login</h2></th>
            <br />
          </tr>

          <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Email: "></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        <br />
        </tr>

        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label></td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        <br />
        </tr>


        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember me" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" />
            </td>
            
        <br />
        </tr>

        <tr>
            <td colspan="2"><a href="ForgotPassword.aspx">Forgot password</a></td>
            
        <br />
        </tr>
                
        <br />
          <tr>
            <td></td>
            <td><asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td>
        </tr>


    </table>
    
    </div>
    </form>
</body>
</html>
