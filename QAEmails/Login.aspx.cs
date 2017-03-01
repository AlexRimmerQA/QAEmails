using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QAEmails
{
	public partial class Login : System.Web.UI.Page
	{

        protected void Page_Rendering(object sender, EventArgs e)
        {
            Response.Write("12345555555555555555555555555");
        }
        protected void Page_Load(object sender, EventArgs e)
		{
            if (Request.Cookies["Email"] == null)
            {
                Response.Write("no cokkies");
                TextBox1.Text = "";
            }
            else
                Response.Write("->" + Request.Cookies["Email"].Value);

            if (!IsPostBack)
            {
                if (Request.Cookies["Email"] != null)
                    TextBox1.Text = Request.Cookies["Email"].Value;
                else
                    TextBox1.Text = "";
                if (Request.Cookies["Password"] != null)
                    TextBox2.Text = "";
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (CheckBox1.Checked)
            {
                Response.Cookies["Email"].Value = TextBox1.Text.ToString();
                Response.Cookies["Password"].Value = TextBox2.Text.ToString();
            }
            else
            {
                Response.Cookies["Email"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Write("Login.aspx");
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inbox.aspx");
        }
    }
}