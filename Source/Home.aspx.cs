using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Source
{
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ROFH7UU1\SQLEXPRESS;Initial Catalog=Financepeer;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = "Hello, " + Session["Email"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (FileUpload1.HasFile)
            {
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Data/") + FileUpload1.FileName);
                string FilePath = Server.MapPath("~/Data/")+ FileUpload1.FileName;
                FileInfo fi = new FileInfo(FilePath);

                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Data]
   SET [Resume] = '"+fi.Name+ "',[FileSize] = '" + fi.Length + "',[FileType] = '" + fi.Extension + "' WHERE [Email]='" + Session["Email"]+"'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }

            Response.Write("<script>alert('Your Resume Uploaded Sucessfully');</script>");

            Server.Transfer("WebForm1.aspx");
        }
    }
}