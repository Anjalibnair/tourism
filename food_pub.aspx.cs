using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class food_pub : System.Web.UI.Page
{
    Db_operations db = new Db_operations();
    SqlCommand cmd=new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        cmd.CommandText = "select * from food_tb where type='"+DropDownList1.SelectedItem.Text+"'";

        DropDownList2.DataSource = db.getdata(cmd);
        DropDownList2.DataTextField = "name";
        DropDownList2.DataValueField = "id";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "--select--");

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd.CommandText = "select * from food_tb where name='" + DropDownList2.SelectedItem + "'";
        DataTable dt = db.getdata(cmd);
        TextBox1.Text = dt.Rows[0][3].ToString();
        
        Image1.ImageUrl = dt.Rows[0][4].ToString();
        

    }
}