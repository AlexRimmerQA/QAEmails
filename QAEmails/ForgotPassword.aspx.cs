using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace QAEmails
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        string na, qu, an;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Source\Repos\QAEmails\QAEmails\App_Data\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "SELECT * FROM Users WHERE EmailAddress='" + TextBox1.Text + "' AND Question='" + TextBox2.Text + "' AND Answer='" + TextBox3.Text + "'";
            Response.Write(cmd.CommandText);


            SqlDataReader R = cmd.ExecuteReader();
            while (R.Read())
            {

                 na = R["EmailAddress"].ToString();
                 qu = R["Question"].ToString();
                 an = R["Answer"].ToString();
            }

            R.Close();


            if (TextBox1.Text==na & TextBox2.Text==qu & TextBox3.Text==an)
            {
                Session["EA"] = na;
                Response.Redirect("NewPassword.aspx");
            }

            else
            {
                Label4.Text = "Enter the correct details";
            }

           
        }
    }
}