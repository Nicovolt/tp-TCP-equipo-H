﻿using System;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nombreArticulo = Request.QueryString["nombre"];
                if (!string.IsNullOrEmpty(nombreArticulo))
                {
                    lblArticulo.Text = nombreArticulo;
                    
                    ListArtculos = articulonegocio.buscarPorCategoria(nombreArticulo);
                    repeaterArticulos.DataSource = ListArtculos;
                    repeaterArticulos.DataBind();
                }
                else
                {
                    lblArticulo.Text = "Artículo no encontrado.";
                }
            }

        }
    }
}