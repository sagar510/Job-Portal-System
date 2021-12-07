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
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ROFH7UU1\SQLEXPRESS;Initial Catalog=Financepeer;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Data]
           ([Resume]
           ,[Email]
           ,[Password]
           ,[FileSize]
           ,[FileType])
     VALUES
           ('','"+TextBox1.Text+"','"+TextBox2.Text+"','','')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            

            Response.Write("<script>alert('Sign Up Sucessfully');</script>");

            Server.Transfer("Webform1.aspx");

            //Response.Redirect("WebForm4.aspx");
           
        }

        /*protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(args.Value.Length<8)
            {
                i++;
                args.IsValid = false;
            }
            else
            {
                i = 0;
                args.IsValid = true;
            }

        }*/

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}