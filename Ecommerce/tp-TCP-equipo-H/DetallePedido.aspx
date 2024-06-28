<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="DetallePedido.aspx.cs" Inherits="tp_TCP_equipo_H.DetallePedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
        .container {
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            min-height: 80%;
            /*background: linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%);*/
            color: #fff; 
            padding: 20px;
        }

        .table-container {
            background: linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%); 
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
        }

        .titulo-catalogo {
            text-align: center;
            margin-bottom: 20px;
            color: white
        }

        .table {
            width: auto;
            margin: auto;
            background: linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%);
            color: #fff; 
        }

        .table th, .table td {
            text-align: center;
            vertical-align: middle;
            background-color: #000;
            color: #fff; 
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    

    <div class="table-container">
        <h1 class="titulo-catalogo">Articulos</h1>
        <table class="table table-bordered border-primary">
            <thead>
                <tr>
                    <th>ID Detalle</th>
                    <th>ID Pedido</th>
                    <th>Nombre Articulo</th>
                    <th>Descripción</th>
                    <th>Categoría</th>
                    <th>Marca</th>
                    <th>Importe</th>
                    <th>Cantidad</th>
                    <th>Talla</th>
                    <th>Estado</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="repeaterDetallesPedido" runat="server" >
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("idDetallePedido") %></td>
                            <td><%# Eval("idPedido") %></td>
                            <td><%# Eval("nombreArticulo") %></td>
                            <td><%# Eval("descripcion") %></td>
                            <td><%# Eval("nombreCategoria") %></td>
                            <td><%# Eval("nombreMarca") %></td>
                            <td><%# Eval("importe") %></td>
                            <td><%# Eval("cantidad") %></td>
                            <td><%# Eval("talle") %></td>
                            <td><%# Eval("Estado")%></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</div>
</asp:Content>
