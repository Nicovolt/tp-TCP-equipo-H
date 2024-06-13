<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ModificarArticulo.aspx.cs" Inherits="tp_TCP_equipo_H.ModificarArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="titulo-catalogo">Lista de Articulos</h1>

    <table class="table table-bordered border-primary">
        <thead>
            <tr>
                <th>ID</th>
                <th>Nombre</th>
                <th>Descripción</th>
                <th>Categoría</th>
                <th>Marca</th>
                <th>Precio</th>
                <th>Stock</th>
                <th>Talla</th>
                <th>Estado</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeaterArticulo" runat="server" OnItemCommand="repeaterArticulos_ItemCommand">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("idArticulo") %></td>
                        <td><%# Eval("nombreArticulo") %></td>
                        <td><%# Eval("descripcion") %></td>
                        <td><%# Eval("categoria") %></td>
                        <td><%# Eval("marca") %></td>
                        <td><%# Eval("precio") %></td>
                        <td><%# Eval("stock") %></td>
                        <td><%# Eval("Talle") %></td>
                        <td><%# Eval("Estado") %></td>
                        <td>
                            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CommandArgument='<%# Eval("idArticulo") %>' CommandName="idModificar" CssClass="btn btn-primary" /></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
