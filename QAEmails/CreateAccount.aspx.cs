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
			try { form1.Attributes.Add("bgcolor", Request.Cookies["UserSettings"]["Colour"]); }
			catch (Exception ex) { }
		}

		protected void CreateButton_Click(object sender, EventArgs e)
		{

		}
	}
}