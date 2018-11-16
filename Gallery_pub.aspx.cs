using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Gallery_pub : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    Db_operations db = new Db_operations();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.SetActiveView(View1);
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Food")
        {
            MultiView1.SetActiveView(View2);
            cmd.CommandText = "select *from food_tb";
            DataGrid1.DataSource = db.getdata(cmd);
            DataGrid1.DataBind();
        }
        else if (DropDownList1.SelectedItem.Text == "Hotel")
        {
            MultiView1.SetActiveView(View3);
            cmd.CommandText = "select *from Hotel_tb";
            DataGrid2.DataSource = db.getdata(cmd);
            DataGrid2.DataBind();
        }
        else if (DropDownList1.SelectedItem.Text == "Place")
        {
            MultiView1.SetActiveView(View4);
            cmd.CommandText = "select *from Place_tb";
            DataGrid3.DataSource = db.getdata(cmd);
            DataGrid3.DataBind();
        }
        else if (DropDownList1.SelectedItem.Text == "Others")
        {
            MultiView1.SetActiveView(View5);
            cmd.CommandText = "select *from Image_tb";
            DataGrid4.DataSource = db.getdata(cmd);
            DataGrid4.DataBind();
        }
    }
    protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {
       

    }
}