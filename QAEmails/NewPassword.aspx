<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPassword.aspx.cs" Inherits="QAEmails.NewPassword" %>

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
            <th colspan="2"> <h2>Change password</h2></th>
            <br />
          </tr>

          <tr>
            <td><asp:Label ID="Label1" runat="server" Text="New password: "></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        <br />
        </tr>

        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Re-enter password: "></asp:Label></td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        <br />
        </tr>

                
        <br />
          <tr>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
              </td>
            <td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
        </tr>


    </table>
    </div>
    </form>
</body>
</html>
