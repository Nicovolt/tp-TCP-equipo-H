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
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string articuloID = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(articuloID))
                {
                    CargarDetalleArticulo(articuloID);
                }
            }
        }
        private void CargarDetalleArticulo(string articuloID)
        {
            ArticuloNegocio articuloService = new ArticuloNegocio();
            Dominio.Articulo articulo = articuloService.buscarPorID(int.Parse(articuloID));
            lblNombreArticulo.Text = articulo.nombreArticulo;
            lblDescripcionArticulo.Text = articulo.marca.nombreMarca;
            lblCategoriaArticulo.Text = articulo.categoria.nombreCategoria;
            lblMarcaArticulo.Text = articulo.marca.nombreMarca;
            lblPrecioArticulo.Text = articulo.precio.ToString();
            repeaterImagenes.DataSource = articulo.listaImagenes;
            repeaterImagenes.DataBind();
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {

        }
    }
}