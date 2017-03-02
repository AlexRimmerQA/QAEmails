<%@ Page Title="" Language="C#" MasterPageFile="~/InboxMaster.Master" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="QAEmails.Inbox" %>
<%@import namespace="System.Data.SqlClient"%>
<%@import namespace="System.Data"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
		<%
           //Session["email"]="b";
            //string userid,username;
            //SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Source\Repos\QAEmails\QAEmails\App_Data\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con2;
            //con2.Open();


            //userid = Session["email"].ToString();
            //cmd.CommandText = "SELECT Name FROM Users WHERE EmailAddress='"+userid+"'";

            //SqlDataReader r = cmd.ExecuteReader();

            //while (r.Read())
            //{
            //    Session["name"] = r["Name"].ToString();
            //}
            //r.Close();

            //username = Session["name"].ToString();


            //string queryString ="SELECT [From],Subject,Date,Seen FROM Emails where [To]='"+username+"'";
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // DataSet uea = new DataSet();
            //adapter.Fill(uea, "Customers");





             %>
	    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="From" HeaderText="From" SortExpression="From" />
                <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [From], [Subject], [Date] FROM [Emails] WHERE ([To] = @To)">
            <SelectParameters>
                <asp:SessionParameter Name="To" SessionField="email" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
	</div>
</asp:Content>
