using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace tp_TCP_equipo_H
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* if (Session["usuario"] == null)
            {
                Session.Add("error", "debes loguearte para ingresar");
                Response.Redirect("Error.aspx",false);
            }
           */
        }
    }
}