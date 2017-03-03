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

				string ccEmails = CCTextbox.Text;

				//remove any spaces from the cc
				string noSpaces = "";
				for(int i = 0; i < ccEmails.Length; i++) { if (ccEmails[i] != ' ') noSpaces += ccEmails[i]; }

				//convert to a string array by splitting it with ,
				string[] splitEmails = noSpaces.Split(',');

				//get a complete list by adding in the to address
				string[] allEmails = new string[splitEmails.Length + 1];
				allEmails[0] = ToTextbox.Text;
				for(int i = 0; i < splitEmails.Length; i++)
				{
					allEmails[i + 1] = splitEmails[i];
				}


				try
				{
					//open the connection to the database
					conn.Open();
					cmd.Connection = conn;
					
					//Test the email address is in the database to send to
					cmd.CommandText = "SELECT EmailAddress FROM Users WHERE lower(EmailAddress) = '" + allEmails[0].ToLower() + "' ";
					for (int i = 1; i < allEmails.Length; i++)
					{
						cmd.CommandText += "OR lower(EmailAddress) = '" + allEmails[i].ToLower() + "' ";
					}
					SqlDataReader r = cmd.ExecuteReader();

					//Create an array with all the emails found in the database
					List<string> readEmails = new List<string>();
					while (r.Read())
					{
						readEmails.Add(r["EmailAddress"].ToString());
					}
					string[] readArray = readEmails.ToArray();

					r.Close();

					//for each found in the database
					for(int i = 0; i < readArray.Length; i++)
					{
						//if the email is both here and in the database, send the email
						if(allEmails.Contains(readArray[i]))
						{
							DateTime localDate = DateTime.Now;
							string date = localDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

							try
							{
								cmd.CommandText = "INSERT INTO Emails VALUES('" + allEmails[i] + "','";
								cmd.CommandText += Session["email"] + "','" + SubjectTextbox.Text + "','" + EmailTextbox.Text + "','" + localDate.ToString("yyyy-MM-dd HH:mm:ss.fff") + "','N','N')";
								cmd.ExecuteNonQuery();
							}
							catch (Exception sEx)
							{
								string temp = sEx.ToString();
							}
						}
					}
					Response.Redirect("Inbox.aspx");
				}
				catch (Exception ex)
				{
					Response.Write("<script>alert('There was a problem connecting to the email server')</script>");
				}
			}
			else
			{
				Response.Write("<script>alert('Please enter an email address to send to')</script>");
			}
		}
	}
}