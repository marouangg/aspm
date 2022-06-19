using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["conexion"];
            if (c != null)
            {
                TextBox1.Text = c["login"];
                TextBox2.Text = c["password"];

                bool f = cnx(TextBox1.Text, TextBox2.Text);
                if (f)
                {
                    Session["pas"] = "ok";
                    Response.Redirect("Default.aspx");
                }
            }
        }
      
        bool cnx(string login,string pasw)
        {
            bool f = false;
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=librairie;User ID=sa; Password=123456");
            cn.Open();
            SqlCommand c = new SqlCommand("select * from [user] where email = @em", cn);
            c.Parameters.AddWithValue("@em", login);
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                if (dr[1].ToString().Equals(pasw))
                {
                    f = true;
                }
            }

            dr.Close();dr = null;
            
            c = null;
            cn.Close();cn = null;
            

            return f;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool f = cnx(TextBox1.Text, TextBox2.Text);

            if (f)
            {
                Session["pas"] = "ok";
                if (CheckBox1.Checked)
                {
                    HttpCookie c = new HttpCookie("conexion");
                    c["login"] = TextBox1.Text;
                    c["password"] = TextBox2.Text;
                    c.Expires = DateTime.Today.AddDays(3);
                    Response.Cookies.Add(c);
                }

                Response.Redirect("Default.aspx");
            }

            else
                lbl_error.Visible = true;
           
        }
    }
}