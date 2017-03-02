using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace QAEmails
{
	public partial class Read : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				try
				{
					string colour = Request.Cookies["UserSettings"]["Colour"];
					int red = Int32.Parse(colour.Substring(4, 3));
					int green = Int32.Parse(colour.Substring(9, 3));
					int blue = Int32.Parse(colour.Substring(14, 3));

					emailContent.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
				}
				catch (Exception ex)
				{

				}
			}
			catch(Exception ex)
			{

			}
			try
			{
				//string emailID = Session["EmailID"].ToString();
				string emailID = Request["ID"].ToString(); // change this to the above line when implemented with the inbox. inbox should create a session id to pass the email id

				SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Source\\Repos\\QAEmails\\QAEmails\\App_Data\\EmailDatabase.mdf';Integrated Security=True");
				SqlCommand cmd = new SqlCommand();
				conn.Open();
				cmd.Connection = conn;
				cmd.CommandText = "SELECT * FROM Emails WHERE EmailId = '" + emailID + "'";
				SqlDataReader r = cmd.ExecuteReader();

				if (r.Read())
				{
					fromLabel.Text = r["From"].ToString();
					toLabel.Text = r["To"].ToString();
					dateLabel.Text = r["Date"].ToString();
					subjectLabel.Text = r["Subject"].ToString();
					emailContent.Text = r["Text"].ToString();
				}
				else
				{
					Response.Write("There was a problem with retrieving the email.");
					Response.Redirect("Inbox.aspx");
				}
			}
			catch(Exception ex)
			{
				Response.Write("There was a problem with retrieving the email.");
				Response.Redirect("Inbox.aspx");
			}
		}

		protected void DeleteLink_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Source\\Repos\\QAEmails\\QAEmails\\App_Data\\EmailDatabase.mdf';Integrated Security=True");
			SqlCommand cmd = new SqlCommand();
			conn.Open();
			cmd.Connection = conn;
			cmd.CommandText = "UPDATE Emails SET Deleted = 'Y' WHERE EmailId = '" + Request["ID"].ToString() + "'";
			cmd.ExecuteNonQuery();
		}

		protected void ReplyLink_Click(object sender, EventArgs e)
		{
			Response.Redirect("Compose.aspx?To=" + fromLabel.Text);
		}
	}
}