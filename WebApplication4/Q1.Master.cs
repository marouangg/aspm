using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Q1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_name"] != null) { Label1.Text = Session["user_name"].ToString(); }
            if (Session["pas"] == "ok") { Response.Redirect("Q4.aspx");}
        }
    }
}