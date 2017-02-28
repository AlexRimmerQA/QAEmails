using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QAEmails
{
	public partial class NewPassword : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                if (TextBox1.Text=="")
                {
                    Label3.Text = "Please enter password";
                }

                else if (TextBox2.Text=="")
                {
                    Label3.Text = "Please enter re-enter password";
                }

                else if (TextBox1.Text!=TextBox2.Text)
                {
                    Label3.Text = "Please enter same password";
                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            

            
        }
    }
}