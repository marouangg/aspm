using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;


namespace WebApplication4
{
    /// <summary>
    /// Description résumée de Q5
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Q5 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(int id)
        {
            string sc = @"Data Source=DESKTOP-IF3P216\SQLEXPRESS;initial Catalog=ex_eff2018;User ID=sa; Password=123456";

            SqlConnection cn = new SqlConnection(sc);
            cn.Open();
            SqlCommand c = new SqlCommand("select  montantTotal from Location where idLoc =@id", cn);
            c.Parameters.AddWithValue("@id", id);
            
            return c.ExecuteScalar().ToString();
            //ServiceReference1.Q5SoapClient s = new ServiceReference1.Q5SoapClient();

            //Label1.Text = s.HelloWorld().ToString();
        }
    }
}
