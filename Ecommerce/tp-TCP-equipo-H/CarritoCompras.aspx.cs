﻿using Dominio;
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
            if (Session["CarritoCompras"] == null)
            {
                List<Dominio.Articulo> Newcarrito = new List<Dominio.Articulo>();
                Session.Add("CarritoCompras", Newcarrito);
            }

            if (!IsPostBack)
            {
                CargarCarrito();
                if (Session["TotalCarrito"] != null)
                {
                    lblPrecioTotal.Text = Session["TotalCarrito"].ToString();
                }
                else
                {
                    actualizarTotalCarrito();
                }
            }

            int id = ObtenerIdArticulo();

            if (id > 0)
            {
                Dominio.Articulo articulo = articuloNegocio.buscarPorID(id);

                if (articulo != null)
                {
                    List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
                    carrito.Add(articulo);
                    Session["CarritoCompras"] = carrito;

                    CargarCarrito();
                    actualizarTotalCarrito();
                    ActualizarContadorCarrito(carrito.Count);
                }
            }
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

        private void CargarCarrito()
        {
            List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
            repeaterCarrito.DataSource = carrito;
            repeaterCarrito.DataBind();
        }

        private void actualizarTotalCarrito()
        {
            List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];
            decimal totalCarrito = 0;

            foreach (Dominio.Articulo item in carrito)
            {
                totalCarrito += item.Cantidad * item.precio;
            }
            Session["TotalaCarrito"] = totalCarrito.ToString("0.00");

            lblPrecioTotal.Text = totalCarrito.ToString("0.00");
        }

        protected void btnAumentarCantidad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];

            Dominio.Articulo articulo = carrito.FirstOrDefault(a => a.idArticulo == id);
            if (articulo != null)
            {
                articulo.Cantidad += 1;
            }

            CargarCarrito();
            actualizarTotalCarrito();
        }

        protected void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            List<Dominio.Articulo> carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];

            Dominio.Articulo articulo = carrito.FirstOrDefault(a => a.idArticulo == id);
            if (articulo != null && articulo.Cantidad > 1)
            {
                articulo.Cantidad -= 1;
            }

            CargarCarrito();
            actualizarTotalCarrito();
        }
        private int ObtenerIdArticulo()
        {
            int id;
            if (Request.QueryString["id"] != null && int.TryParse(Request.QueryString["id"], out id))
            {
                return id;
            }

            return -1;
        }

        private void ActualizarContadorCarrito(int cantArticulos)
        {
            Main masterPage = (Main)this.Master;
            masterPage.ActualizarContadorCarrito(cantArticulos);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            Dominio.Articulo articulo = new Dominio.Articulo();
            articulo = articuloNegocio.buscarPorID(id);
            List<Dominio.Articulo> carrito = new List<Dominio.Articulo>();
            carrito = (List<Dominio.Articulo>)Session["CarritoCompras"];

            EliminarArticulo(articulo);
            CargarCarrito();
            actualizarTotalCarrito();
            ActualizarContadorCarrito(carrito.Count);

        }
    }
}
