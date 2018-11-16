using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Hotelreg_adm : System.Web.UI.Page
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
            TextBox8.Text = db.max_id(cmd).ToString();

        }
        
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        path = "~/images/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath(path));
        Image1.ImageUrl = path;
    
    }
   

    protected void Button3_Click1(object sender, EventArgs e)
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
        cmd.CommandText = "insert into Hotel_tb values(" + TextBox8.Text + ",'" + DropDownList1.SelectedValue + "','" + TextBox13.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + type + "','" + TextBox12.Text + "','" + path + "','" + path1 + "','admin','Pending')";
        db.execute(cmd);
        Response.Write("<script>alert('Submitted')</script>");

        cmd.CommandText = "select max (ID) from Hotel_tb";
        TextBox8.Text = db.max_id(cmd).ToString();

        DropDownList1.ClearSelection();
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";

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
        path1 = "~/images/" + FileUpload2.FileName;
        FileUpload2.SaveAs(Server.MapPath(path1));
        Image2.ImageUrl = path1;
    }
}