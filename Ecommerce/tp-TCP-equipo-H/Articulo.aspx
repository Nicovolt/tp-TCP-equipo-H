<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="tp_TCP_equipo_H.Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .lblArticulo {
            font-size: 40px;
        }
    </style>
    <asp:Label ID="lblArticulo" CssClass="lblArticulo" Text="" runat="server" />
    <asp:Repeater runat="server" ID="repeaterArticulos">
        <ItemTemplate>
             <div class="row row-cols-1 row-cols-md-3 g-4">
                <div class="col">
                    <div class="card h-100">
                        <img src="<%# ((List<Dominio.Imagen>)Eval("listaImagenes"))[0].UrlImagen %>" class="card-img-top" alt="Imagen del artículo">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("NombreArticulo") %></h5>
                            <p class="card-text">Descripcio: <%# Eval("Descripcion") %></p>
                            <p class="card-text">Precio: <%# Eval("Precio") %></p>
                            <asp:Button ID="btnVerDetalle" runat="server" Text="Ver detalle" class="btn btn-primary" />
                            <asp:Button ID="btnCarrito" runat="server" Text="Agregar al carrito" CssClass="btn btn-success" />

                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
