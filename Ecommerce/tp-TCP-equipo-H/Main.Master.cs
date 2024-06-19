using Dominio;
using Negocio;
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
                List<Dominio.Articulo> carritoActual = (List<Dominio.Articulo>)Session["CarritoCompras"];
                int cantArticulos = carritoActual != null ? carritoActual.Count : 0;
                Dominio.Usuario usuario = (Dominio.Usuario)Session["usuario"];
                if (usuario != null && usuario.RolUsuario == Dominio.RolUsuario.admin)
                {
                    adminMenu.Visible = true;
                }
                else
                {
                    adminMenu.Visible = false;
                }
                ActualizarContadorCarrito(cantArticulos);

            }
        }
        public void ActualizarContadorCarrito(int contador)
        {
            Label1.Text = contador.ToString();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Articulo> articulos;
            string busqueda = searchTextBox.Text;

           
        }
       



    }
}