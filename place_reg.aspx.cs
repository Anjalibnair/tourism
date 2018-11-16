using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class place_reg : System.Web.UI.Page
{
    Db_operations db=new Db_operations();
    SqlCommand cmd=new SqlCommand();
    static string path;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cmd.CommandText = "select max (ID) from place_tb";
            TextBox8.Text = db.max_id(cmd).ToString();
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        cmd.CommandText = "insert into place_tb values('" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + path + "','" + TextBox7.Text + "','" + DropDownList1.Text + "')";
        db.execute(cmd);
        Response.Write("<script>alert('successfully registered')</script>");
        TextBox9.Text = "";
        TextBox10.Text = "";
        DropDownList1.ClearSelection();
        TextBox7.Text = "";
        Image1.ImageUrl = null;
        cmd.CommandText = "select max (ID) from place_tb";
        TextBox8.Text = db.max_id(cmd).ToString();
    }
protected void  Button1_Click(object sender, EventArgs e)
{
    path="~/images/"+FileUpload1.FileName;
    FileUpload1.SaveAs(Server.MapPath(path));
    Image1.ImageUrl=path;
}
}