using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Add_trans : System.Web.UI.Page
{ Db_operations db=new Db_operations();
  SqlCommand cmd=new SqlCommand();
    String type="";
    protected void Page_Load(object sender, EventArgs e)
    {
         if (!IsPostBack)
        {
            cmd.CommandText = "select max (ID) from add_trans";
            TextBox2.Text = db.max_id(cmd).ToString();
         }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         if (CheckBox1.Checked == true)
        {
            type = type + "," + CheckBox1.Text;
        }
        if(CheckBox2.Checked == true)
        {
            type = type + "," + CheckBox2.Text;
        }
         if(CheckBox3.Checked == true)
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
        cmd.CommandText="insert into Add_trans values ('"+TextBox2.Text+"','"+TextBox4.Text+"','"+TextBox8.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"','"+TextBox7.Text+"','"+type+"')";
         db.execute(cmd);
         Response.Write("<script>alert('sucessfully added')</script>");
         cmd.CommandText = "select max (ID) from Add_trans";
         TextBox2.Text = db.max_id(cmd).ToString();
         
         TextBox4.Text = "";
         TextBox8.Text = "";
         TextBox5.Text = "";
         TextBox6.Text = "";
         TextBox7.Text = "";
         CheckBox1.Checked = false;
         CheckBox2.Checked = false;
         CheckBox3.Checked = false;
         CheckBox4.Checked = false;
         CheckBox5.Checked = false;
         
        
    }
}