using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class food : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();
    static string path;
    String type = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cmd.CommandText = "select max (ID) from food_tb";
            TextBox1.Text = db.max_id(cmd).ToString();

            cmd.CommandText = "select id,name from place_tb";
            DropDownList3.DataSource = db.getdata(cmd);
            DropDownList3.DataTextField = "name";
            DropDownList3.DataValueField = "id";
            DropDownList3.DataBind();
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
        type = type.TrimStart(',');
        cmd.CommandText = "insert into food_tb values('" + TextBox1.Text + "','" + type + "','" + TextBox5.Text + "','" + path + "','" + DropDownList3.SelectedValue + "')";
            db.execute(cmd);
            Response.Write("<script>alert('Submitted')</script>");
            cmd.CommandText = "select max (ID) from food_tb";
            TextBox1.Text = db.max_id(cmd).ToString();
            TextBox5.Text = "";
            DropDownList3.ClearSelection(); 
            Image1.ImageUrl = null;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
           
         
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        path = "~/images/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath(path));
        Image1.ImageUrl = path;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}