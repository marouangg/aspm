using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class TestSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("my_cookies");
            c["name"] = TextBox1.Text;
            c.Expires = DateTime.Today.AddDays(7);
            Response.Cookies.Add(c);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["my_cookies"];
            if (c != null)
            {
                if (c["name"] != null)
                {
                    Label1.Text = c["name"];
                }
                else
                {
                    Label1.Text = "name makinx";
                }
            }
            else
                Label1.Text = "cookies makinx";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["my_cookies"];
            c.Expires = DateTime.Today.AddDays(-1);
            Response.Cookies.Add(c);
        }
    }
}