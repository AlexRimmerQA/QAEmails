using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace QAEmails
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mohammad\Desktop\database\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            SqlCommand cmd3 = new SqlCommand();

            string a1, n1;

            cmd.Connection = con;
            cmd2.Connection = con;
            cmd3.Connection = con;
            con.Open();

            string QAid = (Request["qid"]);

            cmd.CommandText = "select [From], Subject from Emails where EmailId='" + QAid + "'";


            SqlDataReader R1 = cmd.ExecuteReader();

            while (R1.Read())
            {
                n1 = R1["From"].ToString();
                a1 = R1["Subject"].ToString();

                TextBox1.Text = n1;
                TextBox2.Text = a1;

            }
            R1.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mohammad\Desktop\database\EmailDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con2;
            con2.Open();

            string QAid = (Request["qid"]);
            int qaid = Convert.ToInt32(QAid);

            // cmd2.CommandText = "delete from Emails where EmailId='" + qaid + "'";
            cmd2.CommandText = "update Emails set Deleted='Y' where EmailId='"+QAid+"'";
            cmd2.ExecuteNonQuery();
            Response.Redirect("Inbox.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inbox.aspx");
        }
    }
}