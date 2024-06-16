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
    public partial class CarritoCompras : System.Web.UI.Page
    {
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (Session["CarritoCompras"] == null)
                {
                    List<Dominio.Articulo> Newcarrito = new List<Dominio.Articulo>();
                    Session.Add("CarritoCompras", Newcarrito);
                }
            }

            if (Request.QueryString["id"] == null)
            {
                List<Dominio.Articulo> carrito;
                carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
                cargarCarrito(carrito);
                List<Dominio.Articulo> carritoActual = (List<Dominio.Articulo>)Session["CarritoCompras"];
                int cantArticulos = carritoActual.Count;


            }
            else
            {

                int id = int.Parse(Request.QueryString["id"]);


                Dominio.Articulo articulo = new Dominio.Articulo();
                articulo = articuloNegocio.buscarPorID(id);
                List<Dominio.Articulo> carrito = new List<Dominio.Articulo>();
                carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
                carrito.Add(articulo);

                repeaterCarrito.DataSource = carrito;

                repeaterCarrito.DataBind();

                List<Dominio.Articulo> carritoActual = (List<Dominio.Articulo>)Session["CarritoCompras"];
                int cantArticulos = carritoActual.Count;


                Main masterPage = (Main)this.Master;
                masterPage.ActualizarContadorCarrito(cantArticulos);
            }

        }

        private void ActualizarPrecioTotal(List<Dominio.Articulo> carritoAct)
        {
            decimal total = 0;

            foreach (RepeaterItem item in repeaterCarrito.Items)
            {
                System.Web.UI.WebControls.Label lblCantidad = (System.Web.UI.WebControls.Label)item.FindControl("lblCantidad");
                System.Web.UI.WebControls.Label lblPrecio = (System.Web.UI.WebControls.Label)item.FindControl("lblPrecio");

                if (lblCantidad != null && lblPrecio != null)
                {
                    int cantidad = int.Parse(lblCantidad.Text);
                    decimal precio = decimal.Parse(lblPrecio.Text);

                    total += precio * cantidad;
                }
            }

            lblPrecioTotal.Text = total.ToString("C");
        }



        private void cargarCarrito(List<Dominio.Articulo> carrito)
        {
            repeaterCarrito.DataSource = carrito;
            repeaterCarrito.DataBind();

        }

        private void EliminarArticulo(Dominio.Articulo articulo)
        {
            List<Dominio.Articulo> carrito = new List<Dominio.Articulo>();
            carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];

            for (int i = 0; i < carrito.Count; i++)
            {
                if (carrito[i].idArticulo == articulo.idArticulo)
                {
                    carrito.RemoveAt(i);
                    return;
                }
            }
        }

        protected void btnAumentarCantidad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            ModificarCantidad(id, 1); // Aumentar cantidad en 1
        }

        protected void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            ModificarCantidad(id, -1); // Disminuir cantidad en 1
        }
        private void ModificarCantidad(int idArticulo, int cantidadModificar)
        {
            List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];

            // Buscar el artículo en el carrito
            Dominio.Articulo articulo = carrito.Find(a => a.idArticulo == idArticulo);
            if (articulo != null)
            {
                // Aumentar o disminuir la cantidad según el parámetro proporcionado
                articulo.Cantidad += cantidadModificar;

                // Asegurarse de que la cantidad no sea menor que 0
                if (articulo.Cantidad < 0)
                {
                    articulo.Cantidad = 0;
                }

                // Actualizar el repeater y el precio total
                cargarCarrito(carrito);
                ActualizarPrecioTotal(carrito);
            }
        }
    }
}