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
			//check cookies, get page colour, set page colour
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
			string colour = RadioButtonList1.SelectedValue;
			switch(colour)
			{
				case "Red":
					//do something
					break;
				case "Green":
					//do something
					break;
				case "Blue":
					//do something
					break;
				case "Yellow":
					//do something
					break;
			}
		}
	}
}