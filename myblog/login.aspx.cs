﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace myblog
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\upeksha\Documents\GitHub\BLOG-using-ASP\myblog\App_Data\blog.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["user"] != null)
            {
                Response.Redirect("/admin/dashboard.aspx");
            }
        }

        protected void btnUsersubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "select * from users where username = '" + txtUname.Text +"' and password ='"+txtpass.Text+"'" ;
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                   
                    Label1.Text = txtUname.Text.ToString();
                    Session["user"] = txtUname.Text;
                    Response.Redirect("~/admin/dashboard.aspx");
                }
                else
                {
                    Label1.Text = "incorect useername or password.";
                }
           
                con.Close();

            }
            catch (Exception ex)
            {

                Label1.Text = ex.Message;
            }
        }

        protected void btnAdminsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "select * from users where username = '" + txtUname.Text + "' and password ='" + txtpass.Text + "'";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Session["user"] = txtUname.Text;
                    Response.Redirect("~/admin/dashboard.aspx");
                }
                else
                {
                    Label1.Text = "incorect useername or password.";
                }

                con.Close();
            }
            catch (Exception ex)
            {

                Label1.Text = ex.Message;
            }
        }
    }
}