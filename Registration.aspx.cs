using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Registration : System.Web.UI.Page
{
    Db_operations db = new Db_operations();
    SqlCommand cmd = new SqlCommand();
    SendMail sm = new SendMail();
    static  string pass;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.SetActiveView(View1);
            cmd.CommandText = "select max (ID) from Reg_tb";
            TextBox1.Text = db.max_id(cmd).ToString();


            for (int i = 1; i <= 31; i++)
            {
                DropDownList1.Items.Add(i.ToString());

            }
            DropDownList1.Items.Insert(0, "DD");
            DropDownList2.Items.Insert(0, "MM");
            for (int i = 1950; i <= 2019; i++)
            {
                DropDownList3.Items.Add(i.ToString());

            }
            DropDownList3.Items.Insert(0, "YYYY");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Random ran = new Random();
         pass = ran.Next(0000, 9999).ToString();
        sm.sendmail(TextBox5.Text,pass,"Verification Code");
        MultiView1.SetActiveView(View2);
           
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //cmd.CommandText = "select OTP from reg_tb";
        //DataTable dt = new DataTable();
        //string otp=dt.Rows[0][0].ToString();
         if(TextBox9.Text==pass)     
         {
            string dob = DropDownList1.Text + "/" + DropDownList2.Text + "/" + DropDownList3.Text;
            string name = TextBox2.Text + "-" + TextBox3.Text;
            cmd.CommandText = "insert into Reg_tb values('" + TextBox1.Text + "','" + name + "','" + TextBox8.Text + "','" + RadioButtonList1.Text + "','" + dob + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','pending','" + pass + "')";
            db.execute(cmd);
            cmd.CommandText = "insert into Login_tb values('" + TextBox1.Text + "','"+TextBox5.Text+"','"+TextBox6.Text+"','user')";
            Response.Write("<script>alert('Registration Success')</script>");

        }
        else
        {
            Response.Write("<script>alert('Registration failed')</script>");
        }

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox8.Text = "";
        RadioButtonList1.ClearSelection();
        DropDownList1.ClearSelection();
        DropDownList2.ClearSelection();
        DropDownList3.ClearSelection();
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
    }
}