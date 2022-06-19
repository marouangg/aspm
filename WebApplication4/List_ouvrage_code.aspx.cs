using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace WebApplication4
{
    public partial class List_ouvrage_code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getAllOuvrage();
            }


        }

        void getAllOuvrage(string f="")
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456");
            cn.Open();SqlCommand c;
            if (f == "")
            {
                c = new SqlCommand("select * from Marque ", cn);
            }
            else
                c = new SqlCommand("select * from Marque where libelle like '%" + f + "%'", cn);
            
            SqlDataReader dr = c.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            GridView1.DataSource = t;
            GridView1.DataBind();
            //string t = "<Table><tr><th>Voiture Marque</th><th>Libelle</th></tr>";

            //while (dr.Read())
            //{
            //    t += "<tr><td>" + dr[0].ToString() + "</td><td><a href='fiche_ouvrage.aspx?code=" + dr[0].ToString() + "'>" + dr[1].ToString() + "</a></td></tr>";
            //}

            //t += "</Table>";
            //mydiv.InnerHtml = t;
            //Select1.DataSource = t;
            //Select1.DataTextField = "nomouvr";
            //Select1.DataValueField = "numouvr";
            //Select1.DataBind();
            dr.Close();
            dr = null;
            c = null;
            cn.Close();
            cn = null;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int m = e.RowIndex;
            int id =Convert.ToInt32( GridView1.Rows[m].Cells[1].Text);
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456");
            cn.Open();
            SqlCommand c = new SqlCommand("Delete Marque where idMarq=@id ", cn);
            c.Parameters.AddWithValue("@id", id);

            c.ExecuteNonQuery();
            
            c = null;
            cn.Close();
            cn = null;
            getAllOuvrage();
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            //foreach(GridViewRow g in GridView1.Rows)
            //{
            //    if (Convert.ToInt32(g.Cells[1].Text) > 2)
            //    {
            //        g.Cells[2].BackColor = Color.Red;
            //    }
            //}
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            //int id =GridView1.Rows[]
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456");
            cn.Open();
            SqlCommand c = new SqlCommand("update Marque set libelle=@lib where idMarq=@id ", cn);
            c.Parameters.AddWithValue("@id", txt_idmarq.Text);
            c.Parameters.AddWithValue("@lib", txt_lib.Text);
            c.ExecuteNonQuery();
           
            c = null;
            cn.Close();
            cn = null;
            getAllOuvrage();

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int r = e.NewSelectedIndex;
            txt_idmarq.Text = GridView1.Rows[r].Cells[4].Text;
            txt_lib.Text = GridView1.Rows[r].Cells[5].Text;
        }

        protected void btn_fid_Click(object sender, EventArgs e)
        {
            getAllOuvrage(txt_find.Text);
        }
    }
}