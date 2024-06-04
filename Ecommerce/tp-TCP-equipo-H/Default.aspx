<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tp_TCP_equipo_H.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hola</h1>
    <div class="row row-cols-1 row-cols-md-3 g-4">
  
            <div class="col">
                <div class="card">
                  
                    <img  src="" class="card-img-top" alt="Imagen del artículo"  />
                    <div class="card-body">
                        <h5 class="card-title"></h5>
                        <p class="card-text">Descripcio: </p>
                        <p class="card-text">Precio: </p>
                        <a href= "DetallesArticulo.aspx?id= " class="btn btn-primary"> Ver detalle </a>
                        <a href="CarritoCompras.aspx?id" class="btn btn-success" onclick="redireccionarCarrito()">Agregar al carrito</a>
                     
                    </div>
                </div>
            </div>
</div>
</asp:Content>

