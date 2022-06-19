using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication4
{
    public partial class Q3_login : System.Web.UI.Page
    {
        bool f = false;
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie ck = Request.Cookies["myC"];
            if (ck != null)
            {
                TextBox1.Text = ck["email"];
                TextBox2.Text = ck["password"];
                if (f)
                {
                    Session["passport"] = "ok";
                    Response.Redirect("Q4.aspx");
                }
            }

        }
        string sc = @"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456";

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(sc);
            cn.Open();

            SqlCommand c = new SqlCommand("select * from Conducteur where emailConducteur=@n", cn);
            c.Parameters.AddWithValue("@n", TextBox1.Text);
            SqlDataReader dr = c.ExecuteReader();
           
            while (dr.Read())
            {
                if (dr[4].ToString() == TextBox2.Text)
                {
                    Session["user_name"] = dr[1].ToString() + " " + dr[2].ToString();
                    f = true;
                }
            }

            if (f)
            {
                Session["passport"] = "ok";
                if (CheckBox1.Checked)
                {
                    HttpCookie ck = new HttpCookie("myC");
                    ck["email"] = TextBox1.Text;
                    ck["password"] = TextBox2.Text;
                    ck.Expires = DateTime.Today.AddDays(4);
                    Response.Cookies.Add(ck);
                }
                Response.Redirect("Q4.aspx");
            }
            else
                Label1.Visible = true;
        }
    }
}