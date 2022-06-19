using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label2.Text = Request.QueryString["code"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["name"] = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Application["name"] != null)
            {
                Label1.Text = Application["name"].ToString();
            }
            else
                Label1.Text = "viiide";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write("hello to evry one");
        }
    }
}