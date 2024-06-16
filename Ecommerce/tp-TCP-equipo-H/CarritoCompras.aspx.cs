using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using System.Collections.Generic;
using Dominio;

namespace tp_TCP_equipo_H
{
    public partial class CarritoCompras : System.Web.UI.Page
    {
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CarritoCompras"] == null)
            {
                List<Dominio.Articulo> Newcarrito = new List<Dominio.Articulo>();
                Session.Add("CarritoCompras", Newcarrito);
            }

            if (!IsPostBack)
            {
                CargarCarrito();
            }

            int id = ObtenerIdArticulo(); // Método para obtener el ID del artículo (de la URL o de otra fuente)

            if (id > 0)
            {
                Dominio.Articulo articulo = articuloNegocio.buscarPorID(id);

                if (articulo != null)
                {
                    List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
                    carrito.Add(articulo);
                    Session["CarritoCompras"] = carrito;

                    CargarCarrito();
                    ActualizarPrecioTotal(carrito);
                    ActualizarContadorCarrito(carrito.Count);
                }
            }
        }

        private void CargarCarrito()
        {
            List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
            repeaterCarrito.DataSource = carrito;
            repeaterCarrito.DataBind();
        }

        private void ActualizarPrecioTotal(List<Dominio.Articulo> carrito)
        {
            decimal total = 0;

            foreach (RepeaterItem item in repeaterCarrito.Items)
            {
                var lblCantidad = (Label)item.FindControl("lblCantidad");
                var lblPrecio = (Label)item.FindControl("lblPrecio");

                if (lblCantidad != null && lblPrecio != null)
                {
                    int cantidad = int.Parse(lblCantidad.Text);
                    decimal precio = decimal.Parse(lblPrecio.Text);
                    total += precio * cantidad;
                }
            }

            lblPrecioTotal.Text = total.ToString("C");
        }

        protected void btnAumentarCantidad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            ModificarCantidad(id, 1);
        }

        protected void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            ModificarCantidad(id, -1);
        }

        private void ModificarCantidad(int idArticulo, int cantidadModificar)
        {
            List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
            Dominio.Articulo articulo = carrito.Find(a => a.idArticulo == idArticulo);

            if (articulo != null)
            {
                articulo.Cantidad += cantidadModificar;

                if (articulo.Cantidad < 1)
                {
                    carrito.Remove(articulo);
                }

                Session["CarritoCompras"] = carrito;
                CargarCarrito();
                ActualizarPrecioTotal(carrito);
            }
        }

        private int ObtenerIdArticulo()
        {
            int id;
            if (Request.QueryString["id"] != null && int.TryParse(Request.QueryString["id"], out id))
            {
                return id;
            }

            return -1; // Valor inválido si no se encuentra ID
        }

        private void ActualizarContadorCarrito(int cantArticulos)
        {
            Main masterPage = (Main)this.Master;
            masterPage.ActualizarContadorCarrito(cantArticulos);
        }
    }
}
