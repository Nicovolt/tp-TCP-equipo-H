<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="NuevoArticulo.aspx.cs" Inherits="tp_TCP_equipo_H.NuevoArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .contenedor {
            width: 100%;
            display: flex;
            align-items: center;
            justify-content: center;
            position: relative;
        }

            .contenedor > hi {
                align-content: center;
            }

        .form-contenedor {
            width: 100%;
            max-width: 450px;
            background: linear-gradient(to top, #30cfd0 0%, #330867 100%);
            border-radius: 15px;
            color: white;
            padding: 50px 60px 70px;
        }
    </style>
    <div>

        <section class="contenedor">
            <div class="form-contenedor">
                <h1>Nuevo articulo</h1>
                <div class="mb-3">
                    <label for="formGroupExampleInput" class="form-label">Nombre Articulo</label>
                    <input type="text" class="form-control" id="inpNombreArticulo" placeholder="Nombre del articulo">
                </div>
                <div class="mb-3">
                    <label for="formGroupExampleInput2" class="form-label">Descripcion</label>
                    <input type="text" class="form-control" id="inpDescripcion" placeholder="Descripcion del articulo">
                </div>
                <label for="formGroupExampleInput2" class="form-label">Categoria</label>
                <select class="form-select" aria-label="Default select example">
                    <option selected>Seleccione la Categoria</option>
                    <option value="1">One</option>
                    <option value="2">Two</option>
                    <option value="3">Three</option>
                </select>
                <label for="formGroupExampleInput2" class="form-label">Marcar</label>
                <select class="form-select" aria-label="Default select example">
                    <option selected>Seleccione la Marca</option>
                    <option value="1">One</option>
                    <option value="2">Two</option>
                    <option value="3">Three</option>
                </select>
                <div class="mb-3">
                    <label for="formGroupExampleInput2" class="form-label">Precio</label>
                    <input type="text" class="form-control" id="inpPrecio" placeholder="Precio del articulo">
                </div>
                <div class="mb-3">
                    <label for="formGroupExampleInput" class="form-label">Stock</label>
                    <input type="text" class="form-control" id="inpStock" placeholder="Cantidad de articulos">
                </div>
                <label for="formGroupExampleInput2" class="form-label">Estado</label>
                <select class="form-select" aria-label="Default select example">
                    <option selected>Seleccione El estado</option>
                    <option value="1">En stock</option>
                    <option value="2">Sin stock</option>
                </select>
                <label for="formGroupExampleInput2" class="form-label">Talla</label>
                <select class="form-select" aria-label="Default select example">
                    <option selected>Seleccione la Talla</option>
                    <option value="1">S</option>
                    <option value="2">M</option>
                    <option value="3">L</option>
                </select>
                <div class="mb-3">
                    <label for="formGroupExampleInput" class="form-label">Imagen</label>
                    <input type="text" class="form-control" id="inpImagen" placeholder="Url de la imagen">
                </div>
                <div>
                    <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-light" />
                </div>
            </div>
        </section>

    </div>
</asp:Content>
