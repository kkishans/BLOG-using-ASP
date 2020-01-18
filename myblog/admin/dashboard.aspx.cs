using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace myblog.admin
{
    public partial class dashboard : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Label1.Text = Session["user"].ToString();
            }
            else { Response.Redirect("../login.aspx"); }


            con.Open();
            SqlDataAdapter adb = new SqlDataAdapter("select * from posts where author = '"+Session["user"]+"'", con);
            DataSet ds = new DataSet();
            adb.Fill(ds);

            TableRow trow;
            TableCell tcell;
            Button btn;
      
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int post_id = 0;
                trow = new TableRow();
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                   
                    tcell = new TableCell();
                    //trow.CssClass = "post-body";
                    if (dc.ColumnName.ToString().Equals("postid"))
                    {
                       post_id = Convert.ToInt32(dr[dc.ColumnName].ToString());
                    }
                    else if (dc.ColumnName.ToString().Equals("title"))
                    {
                       // tcell.CssClass = "post-head";
                    }
                    else
                    {
                        continue;
                    }
                    tcell.Controls.Add(new LiteralControl(dr[dc.ColumnName].ToString()));
                    trow.Cells.Add(tcell);
                }
                btn = new Button();
                btn.Text = "Update";
                tcell = new TableCell();
                btn.CssClass = "btn_update";
                btn.PostBackUrl = "updatepost.aspx?pid="+ post_id;
                tcell.Controls.Add(btn);
                trow.Cells.Add(tcell);
                btn = new Button();
                btn.Text = "Delete";
                tcell = new TableCell();
                btn.CssClass = "btn_update";
                btn.PostBackUrl = "deletepost.aspx?pid=" + post_id;
                tcell.Controls.Add(btn);
                trow.Cells.Add(tcell);
                Table1.Rows.Add(trow);

            }

        }
    }
}