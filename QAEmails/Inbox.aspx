<%@ Page Title="" Language="C#" MasterPageFile="~/InboxMaster.Master" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="QAEmails.Inbox" %>
<%@import namespace="System.Data.SqlClient"%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
		<br /><a href="sent1.aspx">Sent</a> <br /> <a href="mdelete1.aspx">Mail deleted</a><br /> <br /><br />
        <h1>Inbox</h1><br />
        <table border="1" id="infotable" style="width:100%;">
            <tr>
                
                <td id="col1">From</td>
                <td id="col2">Subject</td>
                <td id="col3">Date</td>
                <td id="col4">operation</td>
            </tr>
            
        
     <%

         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Source\Repos\QAEmails\QAEmails\App_Data\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
         SqlCommand cmd=new SqlCommand();
         SqlCommand cmd2 = new SqlCommand();

         string fr, su, dt, n,sen;

         cmd.Connection = con;
         cmd2.Connection = con;
         con.Open();

         n = Session["email"].ToString();


         cmd.CommandText = "select * from Emails where [To]='"+n+"' and Deleted='N'";
         SqlDataReader R2 = cmd.ExecuteReader();


         while (R2.Read())
         {
             string id=R2["EmailId"].ToString();
             fr= R2["From"].ToString();
             su = R2["Subject"].ToString();
             dt = R2["Date"].ToString();
             sen = R2["Seen"].ToString();

             if(sen=="Y")
             {
                 Response.Write("<tr>");
                 Response.Write("<td> <a href='read.aspx?ID="+id+"'>" + fr + "</a></td>");
                 Response.Write("<td> <a href='read.aspx?ID="+id+"'>" + su + "</a></td>");
                 Response.Write("<td>"+dt+"</td>");
             }
             else
             {
                 Response.Write("<tr>");
                 Response.Write("<td> <a href='read.aspx?ID="+id+"'>" + fr + "</a></td>");
                 Response.Write("<td> <a href='read.aspx?ID="+id+"'>" + su + "</a></td>");
                 Response.Write("<td><b>"+dt+"</b></td>");
             }



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
