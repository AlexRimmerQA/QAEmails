<%@ Page Title="" Language="C#" MasterPageFile="~/InboxMaster.Master" AutoEventWireup="true" CodeBehind="Compose.aspx.cs" Inherits="QAEmails.Compose" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<p>
		<span style="font-size:18px">To: </span><asp:TextBox ID="ToTextbox" runat="server" Width="400px" Font-Size="18px"></asp:TextBox><br />
		<span style="font-size:18px">CC: </span><asp:TextBox ID="CCTextbox" runat="server" Width="400px" Font-Size="18px"></asp:TextBox><br />
		<span style="font-size:18px">Subject: </span><asp:TextBox ID="SubjectTextbox" runat="server" Width="400px" Font-Size="18px"></asp:TextBox><br />
	</p>
	<p>
		<asp:TextBox ID="EmailTextbox" runat="server" Font-Size="18px" style="width:98%;position:center" Height="300px" TextMode="MultiLine"></asp:TextBox><br />
		<asp:Button ID="SendButton" runat="server" Text="Send" OnClick="SendButton_Click" Font-Size="18px" />
	</p>
</asp:Content>
