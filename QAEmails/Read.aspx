<%@ Page Title="" Language="C#" MasterPageFile="~/InboxMaster.Master" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="QAEmails.Read" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<p>
		<asp:LinkButton ID="ReplyLink" runat="server" style="left:90%" OnClick="ReplyLink_Click" Font-Size="18px">Reply</asp:LinkButton>
		<asp:LinkButton ID="DeleteLink" runat="server" OnClick="DeleteLink_Click" style="left:95%" Font-Size="18px">Delete</asp:LinkButton>
	</p>
	<p>
		<span style="font-size:18px">From: </span><asp:Label ID="fromLabel" runat="server" Text="TempFrom" Font-Size="18px"></asp:Label><br />
		<span style="font-size:18px">To: </span><asp:Label ID="toLabel" runat="server" Text="TempTo" Font-Size="18px"></asp:Label><br />
		<asp:Label ID="dateLabel" runat="server" Text="TempDateTime" Font-Size="18px"></asp:Label>
	</p>
	<p>
		<asp:Label ID="subjectLabel" runat="server" Text="" Font-Size="22px" Font-Bold="True"></asp:Label>
	</p>
	<p>
		<asp:TextBox ID="emailContent" runat="server" BorderStyle="None" Enabled="False" Height="400px" TextMode="MultiLine" Width="100%"></asp:TextBox>
	</p>

</asp:Content>
