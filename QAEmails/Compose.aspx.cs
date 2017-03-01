using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace QAEmails
{
	public partial class Compose : System.Web.UI.Page
	{
		//TO DO:
		//Check session is valid/user logged in
		//When send button pressed, create email in database

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack) { 

				try
				{
					string toValue = Request["To"];
					string ccValue = Request["CC"];
					ToTextbox.Text = toValue;
					CCTextbox.Text = ccValue;
				}
				catch (Exception ex)
				{

				}
			}
		}

		protected void SendButton_Click(object sender, EventArgs e)
		{
			if (ToTextbox.Text != "")
			{
				//INSERT INTO Emails VALUES('Shafeeq@gmail.com', 'Alex@gmail.com', 'Hello', 'I am writing to inform you that this was made via query', '2017-03-01 11:44:37.230', 'N', 'N')
				SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Source\\Repos\\QAEmails\\QAEmails\\App_Data\\EmailDatabase.mdf';Integrated Security=True");
				SqlCommand cmd = new SqlCommand();
				try
				{
					conn.Open();
					cmd.Connection = conn;
					cmd.CommandText = "SELECT EmailAddress FROM Users WHERE lower(EmailAddress) = '" + ToTextbox.Text.ToLower() + "'";
					SqlDataReader r = cmd.ExecuteReader();

					if(r.Read()) // If true, the email address exists and should therefore allow sending.
					{
						r.Close();
						DateTime localDate = DateTime.Now;
						string date = localDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
						cmd.CommandText = "INSERT INTO Emails VALUES('" + ToTextbox.Text + "','" + CCTextbox.Text + "','" + SubjectTextbox.Text + "','" + EmailTextbox.Text + "','" + localDate.ToString("yyyy-MM-dd HH:mm:ss.fff") + "','N','N')";
						cmd.ExecuteNonQuery();
						Response.Redirect("Inbox.aspx");
					}
					else // The email address does not exist, report error.
					{
						Response.Write("<script>alert('The email you are sending to does not exist')</script>");
					}
				}
				catch (Exception ex)
				{
					
				}
			}
			else
			{
				Response.Write("<script>alert('Please enter an email address to send to')</script>");
			}
		}
	}
}