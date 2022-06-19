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
    public partial class Q4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getAllLocation();
            }
        }

        void getAllLocation(string d1="",string d2="")
        {
            string sc = @"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456";
            SqlConnection cn = new SqlConnection(sc);SqlCommand c;
            cn.Open();
            if(d1=="" && d2 == "")
            {
                c= new SqlCommand("select * from Location  order by dateLocation DESC ", cn);
            }
            else
            {
                c = new SqlCommand("select * from Location  order by dateLocation DESC ", cn);

            }
            SqlDataReader dr = c.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            GridView1.DataSource = t;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}