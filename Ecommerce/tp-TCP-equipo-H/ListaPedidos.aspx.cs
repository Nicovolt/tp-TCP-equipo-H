using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_TCP_equipo_H
{
    public partial class ListaPedidos : System.Web.UI.Page
    {
        public List<Dominio.Pedido> ListPedido = new List<Dominio.Pedido>();
        private PedidoNegocio pedidonegocio = new PedidoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListPedido = pedidonegocio.listar();
                repeaterPedidos.DataSource = ListPedido;
                repeaterPedidos.DataBind();
            }

        }

        protected void repeaterPedidos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "VerDetalleArticulo")
            {
                string pedidoID = e.CommandArgument.ToString();
                Response.Redirect($"DetallePedido.aspx?id={pedidoID}");
            }
        }
        protected void repeaterPedidos_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var pedido = (Dominio.Pedido)e.Item.DataItem;
                var ddlEstado = (DropDownList)e.Item.FindControl("ddlEstado");

                if (ddlEstado != null && pedido != null)
                {
                    ddlEstado.SelectedValue = pedido.estado.ToString();
                }
            }
        }
        protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            RepeaterItem item = (RepeaterItem)ddl.NamingContainer;

            Label lblIDPedido = (Label)item.FindControl("lblIDPedido");
            int idPedido = int.Parse(((Label)item.FindControl("lblIDPedido")).Text);
            int nuevoEstado = int.Parse(ddl.SelectedValue);

            Dominio.Pedido pedido = pedidonegocio.listarPorID(idPedido);
            if (nuevoEstado > pedido.estado)
            {      
                ddl.SelectedValue = nuevoEstado.ToString();
                pedidonegocio.actualizarEstadoPedido(idPedido, nuevoEstado);
                ListPedido.Find(p => p.idPedido == idPedido).estado = nuevoEstado;
                return;
            }
            else
            {
                Label lblError = (Label)item.FindControl("lblError");
                lblError.Text = "No se puede volver a un estado anterior.";
                lblError.Visible = true;
            }

           
               
            
        }
    }
}