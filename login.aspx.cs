using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd.CommandText = "select * from login_tb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            string type = dt.Rows[0][3].ToString();
            Session["id"] = dt.Rows[0][0].ToString();
            if (type == "admin")
            {
                Response.Redirect("~/admin_home.aspx");
            }
            else
            {
                Response.Redirect("~/user_home.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('invalid username or password')</script>");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {

    }
}