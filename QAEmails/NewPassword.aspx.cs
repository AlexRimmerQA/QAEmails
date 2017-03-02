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
        string ea;
        protected void Page_Load(object sender, EventArgs e)
		{
            ea = Session["EA"].ToString();
            Label4.Text = ea;
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

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Source\Repos\QAEmails\QAEmails\App_Data\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "update Users set Password='"+TextBox2.Text+"' where EmailAddress='"+ea+"'";
                    Response.Write(cmd.CommandText);



                    cmd.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                }

            

        }
    }
}