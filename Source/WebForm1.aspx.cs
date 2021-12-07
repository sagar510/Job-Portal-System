using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Source
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm4.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            /*Session["Email"] = TextBox1.Text;
            Session["Password"] = TextBox3.Text;*/

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ROFH7UU1\SQLEXPRESS;Initial Catalog=Financepeer;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"SELECT [Resume]
      ,[Email]
      ,[Password]
      ,[FileSize]
      ,[FileType]
  FROM [dbo].[Data] WHERE [Email]='"+TextBox1.Text+"' and [Password]='"+TextBox3.Text+"'", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                Session["Email"] = TextBox1.Text;

                Response.Redirect("Home.aspx");
            }
            else
            {
                /*Response.Write("<script>alert('Invalid or Mismatch Credentials')</script>");
                Server.Transfer("WebForm1.aspx");*/
            }


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}