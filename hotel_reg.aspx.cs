using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hotel_reg : System.Web.UI.Page
{

    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();
    static string path;
    static string path1;
    string type = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            cmd.CommandText = "select ID,LOCATION from Place_tb";
            DropDownList1.DataSource = db.getdata(cmd);
            DropDownList1.DataTextField = "LOCATION";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select--");
            cmd.CommandText = "select max (ID) from Hotel_tb";
            TextBox1.Text = db.max_id(cmd).ToString();
                
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

 if (CheckBox1.Checked == true)
        {
            type = type + "," + CheckBox1.Text;
        }
        if (CheckBox2.Checked == true)
        {
            type = type + "," + CheckBox2.Text;
        }
        if (CheckBox3.Checked == true)
        {
            type = type + "," + CheckBox3.Text;
        }
        if (CheckBox4.Checked == true)
        {
            type = type + "," + CheckBox4.Text;
        }
        if (CheckBox5.Checked == true)
        {
            type = type + "," + CheckBox5.Text;
        }
        type = type.TrimStart(',');
        cmd.CommandText = "select max (ID) from Hotel_tb";
        TextBox1.Text = db.max_id(cmd).ToString();
        cmd.CommandText = "insert into Hotel_tb values('" + TextBox1.Text + "','" + DropDownList1.SelectedValue + "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + type + "','" + TextBox4.Text + "','" + path1 + "','" + path + "','user','pending')";
        db.execute(cmd);
        Response.Write("<script>alert('Submitted')</script>");

       

        DropDownList1.ClearSelection();
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
        CheckBox3.Checked = false;
        CheckBox4.Checked = false;
        CheckBox5.Checked = false;
        Image1.ImageUrl = null;
        Image2.ImageUrl = null;
        
    
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        path1 = "~/images/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath(path1));
        Image1.ImageUrl = path1;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        path = "~/images/" + FileUpload2.FileName;
        FileUpload2.SaveAs(Server.MapPath(path));
        Image2.ImageUrl = path;
    }
       
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}