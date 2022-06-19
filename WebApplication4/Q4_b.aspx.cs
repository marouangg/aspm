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
    public partial class Q4_b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getAllLocation();
            }
        }
        void getAllLocation()
        {
            int idloc = Convert.ToInt32(Request.QueryString["idloc"].ToString());
            string sc = @"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456";
            SqlConnection cn = new SqlConnection(sc);
            cn.Open();
            SqlCommand c = new SqlCommand("select * from Location  where idLoc=@id ", cn);
            c.Parameters.AddWithValue("@id",idloc);
            SqlDataReader dr = c.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            DetailsView1.DataSource = t;
            DetailsView1.DataBind();
        }
    }
}