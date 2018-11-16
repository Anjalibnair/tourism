using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hotel : System.Web.UI.Page
{
    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cmd.CommandText = "select ID,LOCATION from Place_tb";
            DropDownList10.DataSource = db.getdata(cmd);
            DropDownList10.DataTextField = "LOCATION";
            DropDownList10.DataValueField = "LOCATION";
            DropDownList10.DataBind();
            DropDownList10.Items.Insert(0, "--select--");
            cmd.CommandText = "select max (ID) from Hotel_tb";
            TextBox1.Text = db.max_id(cmd).ToString();
            for (int i = 1; i <= 31; i++)
            {
                DropDownList1.Items.Add(i.ToString());

            }
            DropDownList1.Items.Insert(0, "DD");
            DropDownList2.Items.Insert(0, "MM");
            for (int i =2018; i <= 2100; i++)
            {
                DropDownList3.Items.Add(i.ToString());

            }
            DropDownList3.Items.Insert(0, "YYYY");
        }
         for (int i = 1; i <= 31; i++)
            {
                DropDownList4.Items.Add(i.ToString());

            }
            DropDownList4.Items.Insert(0, "DD");
            DropDownList5.Items.Insert(0, "MM");
            for (int i =2018; i <= 2100; i++)
            {
                DropDownList6.Items.Add(i.ToString());

            }
            DropDownList6.Items.Insert(0, "YYYY");
         for (int i =1; i <=10 ; i++)
            {
                DropDownList8.Items.Add(i.ToString());

            }
            DropDownList8.Items.Insert(0, "");
        
     for (int i =1; i <= 7; i++)
            {
                DropDownList9.Items.Add(i.ToString());

            }
            DropDownList9.Items.Insert(0, "");
        }
        

    protected void  Button1_Click(object sender, EventArgs e)
{
    string dt1 = DropDownList1 + "/" + DropDownList2 + "/" + DropDownList3;
    string dt2 = DropDownList4 + "/" + DropDownList5 + "/" + DropDownList6;
    cmd.CommandText = "insert into Hotel_tb values(" + TextBox1.Text + ",'" + Session["id"] + "','" + DropDownList10.Text + "','" + DropDownList11.Text + "',,'" + dt1 + "','" + dt2 + "','" + DropDownList7.Text + "','" + DropDownList8.Text + "','" + DropDownList9 + "','" + TextBox4.Text + "')";
    db.execute(cmd);
    Response.Write("<script>alert('Submitted')</script>");
    cmd.CommandText = "select max (ID) from Hotel_tb";
    TextBox1.Text = db.max_id(cmd).ToString();

    TextBox4.Text = "";
    DropDownList1.ClearSelection();
    DropDownList2.ClearSelection();
    DropDownList3.ClearSelection();
    DropDownList4.ClearSelection();
    DropDownList5.ClearSelection();
    DropDownList6.ClearSelection();
    DropDownList7.ClearSelection();
    DropDownList8.ClearSelection();
    DropDownList9.ClearSelection();
}
    protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd.CommandText = "select ID,HOTEL_NAME from Hotel_tb where location='" + DropDownList10.SelectedItem.Text + "'";
        DropDownList11.DataSource = db.getdata(cmd);
        DropDownList11.DataTextField = "LOCATION";
        DropDownList11.DataValueField = "id";
        DropDownList11.DataBind();
        DropDownList11.Items.Insert(0, "--select--");

    }


   
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

  