using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace QAEmails
{
	public partial class Login : System.Web.UI.Page
	{

        protected void Page_Rendering(object sender, EventArgs e)
        {
            //Response.Write("12345555555555555555555555555");
        }
        protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				PageBody.Attributes.Add("bgcolor", Request.Cookies["UserSettings"]["Colour"]);
			}
			catch (Exception ex)
			{

			}
			//          if (Request.Cookies["Email"] == null)
			//          {
			//              Response.Write("no cokkies");
			//              TextBox1.Text = "";
			//          }
			//          else
			//              Response.Write("->" + Request.Cookies["Email"].Value);

			//          if (!IsPostBack)
			//          {
			//              if (Request.Cookies["Email"] != null)
			//                  TextBox1.Text = Request.Cookies["Email"].Value;
			//              else
			//                  TextBox1.Text = "";
			//              if (Request.Cookies["Password"] != null)
			//                  TextBox2.Text = "";
			//          }
		}

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           //if (CheckBox1.Checked)
           // {
           //     Response.Cookies["Email"].Value = TextBox1.Text.ToString();
           //     Response.Cookies["Password"].Value = TextBox2.Text.ToString();
           // }
           // else
           // {
           //     Response.Cookies["Email"].Expires = DateTime.Now.AddDays(-1);
           //     Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
           // }
            //Response.Write("Login.aspx");
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Source\\Repos\\QAEmails\\QAEmails\\App_Data\\EmailDatabase.mdf';Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con2;
            con2.Open();

            cmd.CommandText = "SELECT * FROM Users WHERE EmailAddress='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'";

            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                Session["email"] = r["EmailAddress"].ToString();
                Session["pass"] = r["Password"].ToString();
				Session["Valid"] = "True";

                Response.Redirect("Inbox.aspx");
            }
            else
            {
                Label3.Text = "User details not found. Check your username and password";
            }
            r.Close();

            SqlDataAdapter sdata = new SqlDataAdapter(cmd);     //Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database. 
            DataSet ldata = new DataSet();                      //Represents an in-memory cache of data

            sdata.Fill(ldata);                                  //add rows in dataset

            if (ldata.Tables[0].Rows.Count > 0)
            {
                if (CheckBox1.Checked == true)
                {
                    Response.Cookies["email"].Value = TextBox1.Text;
                    Response.Cookies["pass"].Value = TextBox2.Text;
                    Response.Cookies["email"].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies["pass"].Expires = DateTime.Now.AddDays(15);
                }
                else
                {
                    Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["pass"].Expires = DateTime.Now.AddDays(-1);
                }
            }
                Response.Redirect("Inbox.aspx");
            
        }
    }
}