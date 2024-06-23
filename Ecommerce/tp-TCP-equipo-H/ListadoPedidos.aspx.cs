﻿using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_TCP_equipo_H
{
    public partial class ListadoPedidos : System.Web.UI.Page
    {
        public List<Dominio.Pedido> ListPedido = new List<Dominio.Pedido>();
        private PedidoNegocio pedidonegocio = new PedidoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListPedido = pedidonegocio.listar();
            repeaterPedidos.DataSource = ListPedido;
            repeaterPedidos.DataBind();
        }

        protected void repeaterPedidos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}