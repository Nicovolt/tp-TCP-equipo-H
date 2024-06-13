using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_TCP_equipo_H
{
    public partial class ModificarCategoria : System.Web.UI.Page
    {
        public List<Dominio.Categoria> ListCategoria = new List<Dominio.Categoria>();
        private CategoriaNegocio articulonegocio = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ListCategoria = articulonegocio.listarCategorias();
                repeaterCategoria.DataSource = ListCategoria;
                repeaterCategoria.DataBind();

            }
        }
        protected void repeaterArticulos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "idModificar")
            {
                string articuloID = e.CommandArgument.ToString();
                Response.Redirect($"NuevaCategoria.aspx?id={articuloID}");
            }
        }
    }
}