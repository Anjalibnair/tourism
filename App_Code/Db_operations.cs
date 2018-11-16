using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for Db_operations
/// </summary>
public class Db_operations
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\lenovo\Desktop\tourism22\App_Data\Tourism.mdf;Integrated Security=True;User Instance=True");
    public void execute(SqlCommand cmd)
    {
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            e.ToString();
        }
        con.Close();
    }
    public DataTable getdata(SqlCommand cmd)
    {
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }
    public int max_id(SqlCommand cmd)
    {
        cmd.Connection = con;
        int i;
        try
        {
            con.Open();
            i = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
        }
        catch
        {
            i = 1;
        }
        con.Close();
        return i;
    }


    public Db_operations()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}