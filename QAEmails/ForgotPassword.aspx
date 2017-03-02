<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="QAEmails.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id ="PageBody" runat ="server">
    <form id="form1" runat="server">
    <div>
   
      <table style="height: 133px; width: 304px">

          <tr>
            <th colspan="2"> <h2>Forgot password</h2></th>
            <br />
          </tr>

          <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Email: "></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        <br />
        </tr>

        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Security Question: "></asp:Label></td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        <br />
        </tr>


        <tr>
        <td><asp:Label ID="Label3" runat="server" Text="Security Answer: "></asp:Label></td>
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        <br />
        </tr>

        <br />
          <tr>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
              </td>
            <td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
        </tr>


    </table>
    </div>
    </form>
</body>
</html>
