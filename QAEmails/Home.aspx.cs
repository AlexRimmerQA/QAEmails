using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QAEmails
{
	public partial class Home : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				PageBody.Attributes.Add("bgcolor", Request.Cookies["UserSettings"]["Colour"]);
			}
			catch(Exception ex)
			{

			}
		}

		protected void LoginButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("Login.aspx");
		}

		protected void CreateAccButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("CreateAccount.aspx");
		}

		protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			PageBody.Attributes.Add("bgcolor", RadioButtonList1.SelectedValue);
			Response.Cookies["UserSettings"]["Colour"] = RadioButtonList1.SelectedValue;
			Response.Cookies["UserSettings"].Expires = DateTime.Now.AddDays(1d);
		}
	}
}