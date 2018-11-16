using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class view_reg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    Db_operations db = new Db_operations();
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from reg_tb where STATUS='pending'";
        DataGrid1.DataSource = db.getdata(cmd);
        DataGrid1.DataBind();

      
    }
    protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        string dob = e.Item.Cells[4].Text;
        string []a = dob.Split('/');

        MultiView1.SetActiveView(View2);
        TextBox1.Text = e.Item.Cells[0].Text;
        TextBox2.Text = e.Item.Cells[1].Text;
        TextBox8.Text = e.Item.Cells[2].Text;
        RadioButtonList1.Text = e.Item.Cells[3].Text;
        TextBox4.Text = e.Item.Cells[5].Text;
        TextBox5.Text = e.Item.Cells[6].Text;
        TextBox9.Text = e.Item.Cells[4].Text;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
       cmd.CommandText = "update reg_tb set STATUS='accept' where ID=" + TextBox1.Text + "";
       db.execute(cmd);
       Response.Write("<script>alert('accepted')</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       SqlCommand cmd = new SqlCommand();
       cmd.CommandText = "update reg_tb  set STATUS='block' where ID=" + TextBox1.Text + "";
        db.execute(cmd);
        Response.Write("<script>alert('blocked')</script>");
    }
}