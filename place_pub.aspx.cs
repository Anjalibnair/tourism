using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class place_pub : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        cmd.CommandText = "select * from place_tb";
        DropDownList1.DataSource = db.getdata(cmd);
        DropDownList1.DataTextField = "name";
        DropDownList1.DataValueField = "id";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "--select--");

        
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
            }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd.CommandText="select * from place_tb where name='" + DropDownList1.SelectedItem + "'";
        DataTable dt = db.getdata(cmd);
        TextBox2.Text = dt.Rows[0][2].ToString();
        TextBox3.Text = dt.Rows[0][6].ToString();
        Image1.ImageUrl = dt.Rows[0][5].ToString();
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}