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
     body {
            padding-top: 20px;
            background-color: #f8f9fa;
            font-family: 'Roboto', sans-serif; /* Aplicar la fuente Roboto */

        }
        .card-img-top {
            filter: grayscale(25%) brightness(70%);
            transition: transform 0.5s ease;
        }
        .card-img-top:hover {
            transform: scale(1.1);
        }
        .card {
            overflow: hidden;
            border-radius: 15px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            transition: box-shadow 0.3s ease;
        }
        .card:hover {
            box-shadow: 0 8px 16px rgba(0,0,0,0.2);
        }
           .lblNombre {
            text-align: center;
            display: block;
            padding: 10px 0;
            animation: changeColor 1s infinite alternate; /* Animación de cambio de color */
          
            font-weight: 700; /* Peso de la fuente */
        }
        @keyframes changeColor {
            0% {
                color: #fff; /* Color inicial */
            }
           
            100% {
                color: black; /* Color final, igual al inicial */
            }
        }
  
</style>
    <div class="row row-cols-1 row-cols-md-3 g-4">

        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Remeras"><img src="Imagenes/remeras.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblRemeras" CssClass="lblNombre" Text="REMERAS" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Pantalones"><img src="Imagenes/Pantalones.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblPantalones" CssClass="lblNombre" Text="PANTALONES" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Sweater"><img src="Imagenes/sweater.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label id="lblSweater" CssClass="lblNombre" Text="SWEATER" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Buzos"><img src="Imagenes/buzos.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblBuzos" CssClass="lblNombre" Text="BUZOS" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Camperas"><img src="Imagenes/camperas.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblCamperas" CssClass="lblNombre" Text="CAMPERAS" runat="server" /></a>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <a href="Articulo.aspx?nombre=Gafas"><img src="Imagenes/Gafas.jpg" class="card-img-top" alt="Imagen del artículo" />
                <asp:Label ID="lblGafas" CssClass="lblNombre" Text="GAFAS" runat="server" /></a>
            </div>
        </div>        
    </div>
</asp:Content>

