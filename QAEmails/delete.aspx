<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="QAEmails.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 65px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="height: 133px; width: 304px">

          <tr>
            <th colspan="2"> <h2>Delete email</h2></th>
            <br />
          </tr>

          <tr>
            <td class="auto-style1">From:</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        <br />
        </tr>

        <tr>
            <td class="auto-style1">subject:</td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        <br />
        </tr>


      
  
        <br />
          <tr>
            <td class="auto-style1"><asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" style="height: 26px" /></td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" />
              </td>
        </tr>


    </table>
    



    </div>
    </form>
</body>
</html>
