﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QAEmails
{
	public partial class InboxMaster : System.Web.UI.MasterPage
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
	}
}