<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tp_TCP_equipo_H.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    
    .col{
        margin: 50px; 
        height: 550px;
        width: 400px;
    }

    .card img{
        height: 550px;
        width: 400px;
        margin: 0 auto;            
    }
    .lblNombre{
        color:white;
        font-size:50px;
        position:absolute;
        top:50%;
        left:50%;
        text-shadow:0 0 6px 0 rgb(0, 0, 0);
        transform: translate(-50%, -50%);
    }

    .card:hover{
        transform: scale(1.1);

    }
  
</style>
    <div class="row row-cols-1 row-cols-md-3 g-4">

        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Remeras"><img src="Imagenes/remeras.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblRemeras" CssClass="lblNombre" Text="Remeras" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Pantalones"><img src="Imagenes/Pantalones.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblPantalones" CssClass="lblNombre" Text="Pantalones" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Sweater"><img src="Imagenes/sweater.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label id="lblSweater" CssClass="lblNombre" Text="Sweater" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Buzos"><img src="Imagenes/buzos.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblBuzos" CssClass="lblNombre" Text="Buzos" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Camperas"><img src="Imagenes/camperas.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblCamperas" CssClass="lblNombre" Text="Camperas" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Gafas"><img src="Imagenes/Gafas.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblGafas" CssClass="lblNombre" Text="Gafas" runat="server" /></a>
            </div>
        </div>        
    </div>
</asp:Content>

