﻿<%@ Page Title="" Language="C#" MasterPageFile="~/InboxMaster.Master" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="QAEmails.Inbox" %>
<%@import namespace="System.Data.SqlClient"%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
		<br /><a href="sent.aspx">Sent</a> <br /> <a href="mdelete.aspx">Mail deleted</a><br /> <br />
        <table border="1" id="infotable" style="width:100%;">
            <tr>
                
                <td id="col1">From</td>
                <td id="col2">Subject</td>
                <td id="col3">Date</td>
                <td id="col4">operation</td>
            </tr>
            
        
     <%

         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mohammad\Desktop\database\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
         SqlCommand cmd=new SqlCommand();
         SqlCommand cmd2 = new SqlCommand();

         string fr, su, dt, n;

         cmd.Connection = con;
         cmd2.Connection = con;
         con.Open();

         n = Session["ne"].ToString();


         cmd.CommandText = "select EmailId,[From],Subject,Date from Emails where [To]='"+n+"' and Deleted='N'";
         SqlDataReader R2 = cmd.ExecuteReader();


             while (R2.Read())
             {
                string id=R2["EmailId"].ToString();
                 fr= R2["From"].ToString();
                 su = R2["Subject"].ToString();
                 dt = R2["Date"].ToString();

                 Response.Write("<tr>");
                 Response.Write("<td>"+fr+"</td>");
                 Response.Write("<td> <a href='#'>" + su + "</a></td>");
                 Response.Write("<td>"+dt+"</td>");

                
                Response.Write("<td><a href='delete.aspx?qid="+id+"'>delete</a></td>");

                Response.Write("</tr>");

             }
             R2.Close();


        %>
      </table>
        
        <br />
        <br />
	</div>
</asp:Content>
