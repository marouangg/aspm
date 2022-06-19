using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class fiche_ouvrage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456");
            cn.Open();
            SqlCommand c = new SqlCommand("select * from Marque where idMarq=@code", cn);
            c.Parameters.AddWithValue("@code", Request.QueryString["code"]);
            SqlDataReader dr = c.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            DetailsView1.DataSource = t;
            DetailsView1.DataBind();

            dr.Close();
            dr = null;
            c = null;
            cn.Close();
            cn = null;
        }
    }
}