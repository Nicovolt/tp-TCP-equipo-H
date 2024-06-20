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
    public partial class Articulo : System.Web.UI.Page
    {
        public List<Dominio.Articulo> ListArtculos = new List<Dominio.Articulo>();
        private ArticuloNegocio articulonegocio = new ArticuloNegocio();

        public List<Dominio.Marca> ListMarca = new List<Dominio.Marca>();
        private MarcaNegocio marcanegocio = new MarcaNegocio();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nombreArticulo = Request.QueryString["nombre"];
                if (!string.IsNullOrEmpty(nombreArticulo))
                {
                    lblArticulo.Text = nombreArticulo;

                    // Obtener la lista de artículos según la categoría
                    ListArtculos = articulonegocio.buscarPorCategoria(nombreArticulo);
                    repeaterArticulos.DataSource = ListArtculos;
                    repeaterArticulos.DataBind();

                    // Cargar las marcas disponibles en el DropDownList
                    List<Marca> listaMarcas = marcanegocio.listarMarcas();
                    ddlMarca.DataSource = listaMarcas;
                    ddlMarca.DataTextField = "nombreMarca";
                    ddlMarca.DataValueField = "idMarca";
                    ddlMarca.DataBind();

                    // Agregar opción de Todas las Marcas
                    ddlMarca.Items.Insert(0, new ListItem("Todas las Marcas", "0"));
                }
                else
                {
                    lblArticulo.Text = "Artículo no encontrado.";
                }
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {


            int idMarca = Convert.ToInt32(ddlMarca.SelectedValue);


            ListArtculos = articulonegocio.BuscarPorMarca(idMarca);
            repeaterArticulos.DataSource = ListArtculos;
            repeaterArticulos.DataBind();
        }
        protected void repeaterArticulos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "VerDetalle")
            {
                string articuloID = e.CommandArgument.ToString();
                Response.Redirect($"DetalleArticulo.aspx?id={articuloID}");
            }
            if (e.CommandName == "AgregarAlCarrito")
            {
                string idArticulo = e.CommandArgument.ToString();
                AgregarAlCarrito(idArticulo);
            }
        }
        private void AgregarAlCarrito(string idArticulo)
        {
            if (Session["CarritoCompras"] == null)
            {
                Session["CarritoCompras"] = new List<Dominio.Articulo>();
            }

            int id = Convert.ToInt32(idArticulo);
            Dominio.Articulo articulo = articulonegocio.buscarPorID(id);
            articulo.Cantidad = 1;

            if (articulo != null)
            {
                List<Dominio.Articulo> carrito = Session["CarritoCompras"] as List<Dominio.Articulo>;
                
                carrito.Add(articulo);
                Session["CarritoCompras"] = carrito;

                List<Dominio.Articulo> carritoActual = (List<Dominio.Articulo>)Session["CarritoCompras"];
                int cantArticulos = carritoActual.Count;

                Main masterPage = (Main)this.Master;
                masterPage.ActualizarContadorCarrito(cantArticulos);

                // Redirigir a la página del carrito de compras o mostrar un mensaje de éxito
                //Response.Redirect("CarritoCompras.aspx");
            }
        }

        protected void ddlTalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}