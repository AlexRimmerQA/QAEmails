using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Source\Repos\QAEmails\QAEmails\App_Data\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "SELECT * FROM Users WHERE EmailAddress='" + TextBox1.Text + "' AND Question='" + TextBox2.Text + "'";
            Response.Write(cmd.CommandText);

        }
    }
}