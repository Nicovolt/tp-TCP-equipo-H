<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CarritoCompras.aspx.cs" Inherits="tp_TCP_equipo_H.CarritoCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .titulo-catalogo {
            text-align: center;
            font-size: 2rem;
            color: #000000;
            margin-top: 15px;
            margin-bottom: 15px;
            text-shadow: 2px 2px 2px rgba(0, 0, 0, 0.2);
        }
    </style>



    <h1 class="titulo-catalogo">Carrito de compras</h1>

    <table class="table table-bordered">
        <thead>
            <tr>
                <th class="d-none">Id</th>
                <th>Nombre</th>
                <th>Descripción</th>
                <th>Marca</th>
                <th>Categoría</th>
                <th>Precio</th>
                <th>Talla</th>                
                <th>Cantidad</th>
                <th>Eliminar</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeaterCarrito" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="d-none" name="id"><%# Eval("idArticulo") %></td>                       
                        <td><%# Eval("NombreArticulo") %></td>
                        <td><%# Eval("Descripcion") %></td>
                        <td><%# Eval("Marca") %></td>
                        <td><%# Eval("Categoria") %></td>
                        <td><%# Eval("Precio") %></td>
                        <td><%# Eval("Talle") %></td>
                        <!--<td></td>-->
                        <td>
                            <asp:Button ID="btnDisminuirCantidad" runat="server" Text="-" OnClick="btnDisminuirCantidad_Click" CommandArgument='<%# Eval("idArticulo") %>' CommandName="disminuirCantidad" />
                            <asp:Label ID="lblCantidad" runat="server" Text='<%# Eval("Cantidad") %>'></asp:Label>
                            <asp:Button ID="btnAumentarCantidad" runat="server" Text="+" OnClick="btnAumentarCantidad_Click" CommandArgument='<%# Eval("idArticulo") %>' CommandName="aumentarCantidad" />
                        </td>
                        <td>
                            <asp:Button ID="btnEliminar" runat="server" Text="X" OnClick="btnEliminar_Click" CommandArgument='<%# Eval("idArticulo") %>' CommandName="idArticulo" /></td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
        <tfoot>
            <tr>
                <td>Total</td>
                <td>
                    <asp:Label ID="lblPrecioTotal" runat="server" Text="0"></asp:Label></td>
                <td>
                    <!-- comento este boton ya que da error en la pagina de carrito -->

            </tr>
        </tfoot>
    </table>
</asp:Content>
