using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class view_hotelreg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    Db_operations db = new Db_operations();
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Hotel_tb";
        DataGrid1.DataSource = db.getdata(cmd);
        DataGrid1.DataBind();
    }
    protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        MultiView1.SetActiveView(View2);
        TextBox8.Text = e.Item.Cells[0].Text;
        TextBox15.Text = e.Item.Cells[1].Text;
        TextBox13.Text = e.Item.Cells[2].Text;
        Image1.ImageUrl = e.Item.Cells[8].Text;
        TextBox9.Text = e.Item.Cells[3].Text;
        TextBox10.Text = e.Item.Cells[4].Text;
        TextBox14.Text = e.Item.Cells[6].Text;
        TextBox11.Text = e.Item.Cells[5].Text;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from Hotel_tb where id=" + TextBox8.Text + "";
        db.execute(cmd);
        Response.Write("<script>alert('Blocked')</script>");
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        Response.Write("<script>alert('Accepted')</script>");
    }
}