using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class feedback_pub : System.Web.UI.Page
{
    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
        cmd.CommandText = "SELECT Feedback_tb.ID, Feedback_tb.USER_ID, Reg_tb.NAME, Feedback_tb.FEEDBACK, Feedback_tb.SUGGESTION  FROM Feedback_tb INNER JOIN Reg_tb ON Feedback_tb.USER_ID = Reg_tb.ID";
        DataGrid1.DataSource = db.getdata(cmd);
        DataGrid1.DataBind();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        MultiView1.SetActiveView(View2);
        TextBox3.Text = e.Item.Cells[1].Text;
        TextBox1.Text = e.Item.Cells[2].Text;
        TextBox2.Text = e.Item.Cells[3].Text;
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}