<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ModificarMarca.aspx.cs" Inherits="tp_TCP_equipo_H.ModificarMarca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="titulo-catalogo">Lista de Marcas</h1>

    <table class="table table-bordered border-primary">
        <thead>
            <tr>
                <th>ID</th>
                <th>Nombre</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeaterMarca" runat="server" OnItemCommand="repeaterArticulos_ItemCommand">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("idMarca") %></td>
                        <td><%# Eval("nombreMarca") %></td>
                        <td>
                            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CommandArgument='<%# Eval("idMarca") %>' CommandName="idModificar" CssClass="btn btn-primary" /></td>
                        <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# Eval("idMarca") %>' CommandName="idEliminar" CssClass="btn btn-danger" /></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
