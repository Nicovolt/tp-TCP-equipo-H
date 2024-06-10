using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace tp_TCP_equipo_H
{
    public partial class NuevoArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            MarcaNegocio marcanegocio = new MarcaNegocio();
            List<Dominio.Marca> marcas = marcanegocio.listarMarcas();

            repeaterMarca.DataSource = marcas;
            repeaterMarca.DataBind();
            }

            if (!IsPostBack)
            {
                CategoriaNegocio categorianegocio = new CategoriaNegocio();
                List<Dominio.Categoria> marcas = categorianegocio.listarCategorias();

                repeaterCategoria.DataSource = marcas;
                repeaterCategoria.DataBind();
            }
        }
    }
}