using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_TCP_equipo_H
{
    public partial class ModificarArticulo : System.Web.UI.Page
    {
        public List<Dominio.Articulo> ListArtculos = new List<Dominio.Articulo>();
        private ArticuloNegocio articulonegocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
      
                    ListArtculos = articulonegocio.listar();
                    repeaterArticulo.DataSource = ListArtculos;
                    repeaterArticulo.DataBind();
              
            }

        }
        protected void repeaterArticulos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "idModificar")
            {
                string articuloID = e.CommandArgument.ToString();
                Response.Redirect($"NuevoArticulo.aspx?id={articuloID}");
            }
        }
    }
}