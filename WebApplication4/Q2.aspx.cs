using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class Q2 : System.Web.UI.Page
    {
        string sc = @"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(sc);
            cn.Open();

            SqlCommand c = new SqlCommand("select * from Conducteur where noPermis=@n", cn);
            c.Parameters.AddWithValue("@n", TextBox1.Text);
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                Label1.Visible = true;
                dr = null;
                c = null;
                cn.Close();
                cn = null;
            }

            else
            {
                dr.Close();
                dr = null;
                c.CommandText = "insert into conducteur values(@nop,@nom,@prenom,@email,@passwrd)";
                c.Parameters.AddWithValue("@nop", TextBox1.Text);
                c.Parameters.AddWithValue("@nom", TextBox2.Text);
                c.Parameters.AddWithValue("@prenom", TextBox3.Text);
                c.Parameters.AddWithValue("@email", TextBox4.Text);
                c.Parameters.AddWithValue("@passwrd", TextBox5.Text);
                c.ExecuteNonQuery();

                Response.Redirect("Q3_login.aspx");

                c = null;
                cn.Close();
                cn = null;
            }
        }
    }
}