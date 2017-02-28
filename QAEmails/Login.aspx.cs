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
		protected void Page_Load(object sender, EventArgs e)
		{

            if (!IsPostBack)
            {


                HttpCookie udata2 = Request.Cookies["userdata"];
                if (udata2 != null )
                {
                    TextBox1.Text = udata2["Email"];
                    TextBox2.Text = udata2["Password"];
                    CheckBox1.Checked = true;
                }

                else 
                {
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    CheckBox1.Checked = false;
                }

               
            }
		}

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            HttpCookie udata = new HttpCookie("userdata");
            udata["Email"] = TextBox1.Text;
            udata["Password"] = TextBox2.Text;
            udata.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(udata);            
            
        }
    }
}