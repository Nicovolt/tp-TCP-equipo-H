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
    .card p{
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
                <img src="Imagenes/remeras.jpg" class="card-img-top" alt="Imagen del artículo" />
                <p>Remeras</p>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <img src="Imagenes/Pantalones.jpg" class="card-img-top" alt="Imagen del artículo" />
                <p>Pantalones</p>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <img src="Imagenes/sweater.jpg" class="card-img-top" alt="Imagen del artículo" />
                <p>Sweater</p>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <img src="Imagenes/buzos.jpg" class="card-img-top" alt="Imagen del artículo" />
                <p>Buzos</p>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <img src="Imagenes/camperas.jpg" class="card-img-top" alt="Imagen del artículo" />
                <p>Camperas</p>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <img src="Imagenes/Gafas.jpg" class="card-img-top" alt="Imagen del artículo" />
                <p>Gafas</p>
            </div>
        </div>
        
       
        
    </div>
</asp:Content>

