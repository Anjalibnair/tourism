using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class transportation : System.Web.UI.Page
{
    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            cmd.CommandText = "select LOCATION from Place_tb";
            DropDownList1.DataSource = db.getdata(cmd);
            DropDownList1.DataTextField = "LOCATION";
            DropDownList1.DataValueField = "LOCATION";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select--");
            cmd.CommandText = "select LOCATION from Add_trans";
            DropDownList3.DataSource = db.getdata(cmd);
            DropDownList3.DataTextField = "LOCATION";
            DropDownList3.DataValueField = "LOCATION";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, "--select--");

            cmd.CommandText = "select max (ID) from transport_tb";
           TextBox1.Text = db.max_id(cmd).ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd.CommandText = "insert into transport_tb values(" + TextBox1.Text + ",'" + DropDownList3.Text + "','" + DropDownList2.Text + "','" + DropDownList4.Text + "','" + TextBox4.Text + "','" + DropDownList1.Text + "','" + TextBox14.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
        db.execute(cmd);
        Response.Write("<script>alert('successfully submitted')</script>");
       
        cmd.CommandText = "select max (ID) from transport_tb";
        TextBox1.Text = db.max_id(cmd).ToString();

        TextBox4.Text = "";
        TextBox14.Text = "";
        TextBox12.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox13.Text = "";
        DropDownList1.ClearSelection();
        DropDownList2.ClearSelection();
        DropDownList3.ClearSelection();
        DropDownList4.ClearSelection();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd.CommandText = "select NAME from add_trans  where LOCATION='" + DropDownList3.SelectedItem.Text + "'";
        DropDownList2.DataSource = db.getdata(cmd);
        DropDownList2.DataTextField = "NAME";
        DropDownList2.DataValueField = "NAME";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "--select--");
      
        
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}