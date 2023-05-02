using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

class Dal
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-PNVONP0\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
    public int InsertPartyAddress(String name, string address)
    {
        con.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("insert into manjusha(stud_name,stud_addr)values('" + name + "','" + address + "')", con);
            cmd.ExecuteNonQuery();
            return 1;
        }
        catch
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }
}