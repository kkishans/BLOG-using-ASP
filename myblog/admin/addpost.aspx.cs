using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace myblog.admin
{
    public partial class addpost : System.Web.UI.Page
    {
        string author;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }
            else author = Session["user"].ToString();   
        
        }

        protected void btnaddpost_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "insert into posts values(@title,@content,@author)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@content", txtContent.Text);
                cmd.Parameters.AddWithValue("@author", author);

                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "Post added.";
                Response.Redirect("dashboard.aspx");
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                
            }
        }
    }
}