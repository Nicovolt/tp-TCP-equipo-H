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
            
                CargarCategorias();
                CargarMarcas();
            }
        }
        private void CargarCategorias()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            ddlCategoria.DataSource = categoriaNegocio.listarCategorias();
            ddlCategoria.DataTextField = "nombreCategoria";
            ddlCategoria.DataValueField = "idCategoria";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("Seleccione la Categoria", ""));
        }

        private void CargarMarcas()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            ddlMarca.DataSource = marcaNegocio.listarMarcas();
            ddlMarca.DataTextField = "nombreMarca";
            ddlMarca.DataValueField = "idMarca";
            ddlMarca.DataBind();
            ddlMarca.Items.Insert(0, new ListItem("Seleccione la Marca", ""));
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpNombreArticulo.Text) ||
                string.IsNullOrWhiteSpace(inpDescripcion.Text) ||
                string.IsNullOrWhiteSpace(ddlCategoria.SelectedValue) ||
                string.IsNullOrWhiteSpace(ddlMarca.SelectedValue) ||
                string.IsNullOrWhiteSpace(inpPrecio.Text) ||
                string.IsNullOrWhiteSpace(inpStock.Text) ||
                string.IsNullOrWhiteSpace(ddlEstado.SelectedValue) ||
                string.IsNullOrWhiteSpace(ddlTalla.SelectedValue) ||
                string.IsNullOrWhiteSpace(inpImagen.Text))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                return;
            }

            // Crear nuevo artículo
            Dominio.Articulo nuevoArticulo = new Dominio.Articulo();
            {
                nuevoArticulo.nombreArticulo = inpNombreArticulo.Text;
                nuevoArticulo.descripcion = inpDescripcion.Text;
                nuevoArticulo.categoria = new Categoria { idCategoria = int.Parse(ddlCategoria.SelectedValue) };
                nuevoArticulo.marca = new Marca { idMarca = int.Parse(ddlMarca.SelectedValue) };
                nuevoArticulo.precio = decimal.Parse(inpPrecio.Text);
                nuevoArticulo.stock = int.Parse(inpStock.Text);
                nuevoArticulo.Estado = ddlEstado.SelectedValue == "1";
                nuevoArticulo.talle = char.Parse(ddlTalla.SelectedValue);
                nuevoArticulo.listaImagenes = new List<Imagen>
                {
                    new Imagen { UrlImagen = inpImagen.Text }
                };
            };

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                int idArticulo = articuloNegocio.agregar(nuevoArticulo);
                if (idArticulo > 0)
                {
                    inpNombreArticulo.Text = "";
                    inpDescripcion.Text = "";
                    ddlCategoria.SelectedValue = "";
                    ddlMarca.SelectedValue = "";
                    inpPrecio.Text = "";
                    inpStock.Text = "";
                    ddlEstado.SelectedValue = "";
                    ddlTalla.SelectedValue = "";
                    inpImagen.Text = "";
                }
                else
                {
                    lblError.Text = "Ocurrió un error al guardar el artículo.";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }
    }
}