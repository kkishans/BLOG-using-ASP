using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myblog
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                btnlogin.Visible = false;
                btnDashbord.Text = "Hello,  " + Session["user"];
                btnDashbord.Visible = true;
            }
            else
            {
                btnDashbord.Visible = false;
                btnlogin.Visible = true;
            }
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnDashbord_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin/dashboard.aspx");
        }
    }
}