using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_TCP_equipo_H
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dominio.Usuario usuario = (Dominio.Usuario)Session["usuario"];
                if (usuario != null && usuario.RolUsuario == Dominio.RolUsuario.admin)
                {
                    adminMenu.Visible = true;
                }
                else
                {
                    adminMenu.Visible = false;
                }
            }
        }
    }
}