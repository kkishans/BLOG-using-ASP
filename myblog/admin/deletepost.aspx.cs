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
    public partial class deletepost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            SqlCommand cmd;
            string postid;
            postid = Request.QueryString["pid"];
            if (Session["user"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "delete from posts where postid = " + postid;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("dashboard.aspx");
            }
            catch (Exception ex)
            {

                Label1.Text = ex.Message;
            }
        }
    }
}