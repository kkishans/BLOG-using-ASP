using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace myblog.admin
{
    public partial class updatepost : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        SqlCommand cmd;
        string title,content,postid;

        protected void Page_Load(object sender, EventArgs e)
        {
            postid = Request.QueryString["pid"];

            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }
            //else author = Session["user"].ToString();   

            if (!IsPostBack)
			{
                try
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "select * from posts where postid = " + postid;
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtTitle.Text = dr[1].ToString();
                        txtContent.Text = dr[2].ToString();
                        title = txtTitle.Text;
                        content = txtContent.Text;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                    Label1.Text = ex.Message;
                }
            }
        }
 
        protected void txtTitle_TextChanged(object sender, EventArgs e)
        { 
            title = txtTitle.Text;
        }

        protected void txtContent_TextChanged(object sender, EventArgs e)
        {
            content = txtContent.Text;
        }

        protected void btnupdatepost_Click(object sender, EventArgs e)
       {
            title = txtTitle.Text;
            content = txtContent.Text;
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "update posts set title = @title , content = @content where postid = " + postid;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@content", content);
                //cmd.Parameters.AddWithValue("@author", author);

                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = title + " " + content;
                Response.Redirect("dashboard.aspx");
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;

            }
        }
    }
}