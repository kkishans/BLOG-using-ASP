using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace myblog
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Users\\kishan\\Documents\\Visual Studio 2010\\Projects\\BLOG-using-ASP\\myblog\\App_Data\\blog.mdf';Integrated Security=True;User Instance=True");
       
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adb = new SqlDataAdapter("select * from posts", con);
            DataSet ds = new DataSet();
            adb.Fill(ds);

            TableRow trow;
            TableCell tcell;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                trow = new TableRow();
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    tcell = new TableCell();
                    tcell.Controls.Add(new LiteralControl(dr[dc.ColumnName].ToString()));
                    trow.Cells.Add(tcell);
                }
                Table1.Rows.Add(trow);
            }

            
        }
    }
}