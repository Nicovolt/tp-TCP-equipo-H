<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="tp_TCP_equipo_H.Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    
    .card img{
        height: 250px;
        width: 300px;
        margin: 0 auto;            
    }
    .card-title, h1{
        text-align:center;
    }

    .container {
        display: flex;
        justify-content: center;
        align-items: center;
    }
    .titulo-catalogo {
        text-align: center;
        font-size: 2rem; 
        color: #0000; 
        margin-bottom: 30px; 
        text-shadow: 2px 2px 2px rgba(0, 0, 0, 0.2);
    }   
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .lblArticulo {
            font-size: 40px;
        }
    </style>
    <asp:Label ID="lblArticulo" CssClass="lblArticulo" Text="" runat="server" />
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="repeaterArticulos" OnItemCommand="repeaterArticulos_ItemCommand">
            <ItemTemplate>

                <div class="col">
                    <div class="card">
                        <img src="<%# ((List<Dominio.Imagen>)Eval("listaImagenes"))[0].UrlImagen %>" class="card-img-top" alt="Imagen del artículo">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("NombreArticulo") %></h5>
                            <p class="card-text">Descripcio: <%# Eval("Descripcion") %></p>
                            <p class="card-text">Precio: <%# Eval("Precio") %></p>
                            <asp:Button ID="Button1" runat="server" CommandName="VerDetalle" CommandArgument='<%# Eval("idArticulo") %>' Text="Ver detalle" CssClass="btn btn-primary" />
                            <asp:Button ID="Button2" runat="server" CommandName="AgregarAlCarrito" CommandArgument='<%# Eval("idArticulo") %>' Text="Agregar al carrito" CssClass="btn btn-success" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
