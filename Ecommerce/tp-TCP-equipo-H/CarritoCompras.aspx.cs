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
        private void cargarCarrito(List<Dominio.Articulo> carrito)
        {
            repeaterCarrito.DataSource = carrito;
            repeaterCarrito.DataBind();

        }
    }
}