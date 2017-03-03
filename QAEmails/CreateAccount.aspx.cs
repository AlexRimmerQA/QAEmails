using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace QAEmails
{
	public partial class CreateAccount : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try { PageBody.Attributes.Add("bgcolor", Request.Cookies["UserSettings"]["Colour"]); }
			catch (Exception ex) { }
		}

		protected void CreateButton_Click(object sender, EventArgs e)
		{
			//If textboxes are filled
			if (EmailTextbox.Text != "" && PasswordTextbox.Text != "" && RePassTextbox.Text != "" && NameTextbox.Text != "" && AddressTextbox.Text != "" && QuestionTextbox.Text != "" && AnswerTextbox.Text != "")
			{
				if (PasswordTextbox.Text == RePassTextbox.Text)
				{
					SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Source\\Repos\\QAEmails\\QAEmails\\App_Data\\EmailDatabase.mdf';Integrated Security=True");
					SqlCommand cmd = new SqlCommand();
					try
					{
						conn.Open();
						cmd.Connection = conn;
					}
					catch(Exception ex)
					{
						Response.Write("<script>alert('There was a problem connecting to the emails, Please try again.');</script>");
					}

					cmd.CommandText = "INSERT INTO Users VALUES(";
					cmd.CommandText += "'" + EmailTextbox.Text + "',";
					cmd.CommandText += "'" + PasswordTextbox.Text + "',";
					cmd.CommandText += "'" + NameTextbox.Text + "',";
					cmd.CommandText += "'" + AddressTextbox.Text + "',";
					cmd.CommandText += "'" + QuestionTextbox.Text + "',";
					cmd.CommandText += "'" + AnswerTextbox.Text + "')";


					try
					{
						cmd.ExecuteNonQuery();
						Response.Redirect("Login.aspx");
					}
					catch (Exception ex)
					{
						Response.Write("<script>alert('Email Address already exists, please use another.');</script>");
					}
				}
				else
				{
					Response.Write("<script>alert('Both passwords entered must match');</script>");
				}
			}
			else
			{
				Response.Write("<script>alert('All fields must be filled in');</script>");
			}
		}
	}
}