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
                    <asp:TextBox runat="server" type="text" class="form-control" id="inpNombreArticulo" placeholder="Nombre del articulo"/>
                </div>
                <div class="mb-3">
                    <label for="formGroupExampleInput2" class="form-label">Descripcion</label>
                    <asp:TextBox runat="server" type="text" class="form-control" id="inpDescripcion" placeholder="Descripcion del articulo"/>
                </div>
                <div class="mb-3">
                    <label for="ddlCategoria" class="form-label">Categoria</label>
                    <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-select">
                        <asp:ListItem Text="Seleccione la Categoria" Value="" />
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="ddlMarca" class="form-label">Marca</label>
                    <asp:DropDownList runat="server" ID="ddlMarca" CssClass="form-select">
                        <asp:ListItem Text="Seleccione la Marca" Value="" />
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="formGroupExampleInput2" class="form-label">Precio</label>
                    <asp:TextBox runat="server" type="text" class="form-control" id="inpPrecio" placeholder="Precio del articulo"/>
                </div>
                <div class="mb-3">
                    <label for="formGroupExampleInput" class="form-label">Stock</label>
                    <asp:TextBox runat="server" type="text" class="form-control" id="inpStock" placeholder="Cantidad de articulos"/>
                </div>
                <div class="mb-3">
                    <label for="ddlEstado" class="form-label">Estado</label>
                    <asp:DropDownList runat="server" ID="ddlEstado" CssClass="form-select">
                        <asp:ListItem Text="Seleccione El estado" Value="" />
                        <asp:ListItem Text="En stock" Value="1" />
                        <asp:ListItem Text="Sin stock" Value="0" />
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="ddlTalla" class="form-label">Talla</label>
                    <asp:DropDownList runat="server" ID="ddlTalla" CssClass="form-select">
                        <asp:ListItem Text="Seleccione la Talla" Value="" />
                        <asp:ListItem Text="S" Value="S" />
                    <asp:ListItem Text="M" Value="M" />
                    <asp:ListItem Text="L" Value="L" />
                </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="formGroupExampleInput" class="form-label">Imagen</label>
                    <asp:TextBox runat="server" type="text" class="form-control" ID="inpImagen" placeholder="Url de la imagen" />
                </div>
                <div>
                    <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-light" OnClick="Unnamed_Click" />
                </div>
                <asp:Label runat="server" ID="lblError" CssClass="text-danger" />
            </div>
        </section>

    </div>
</asp:Content>
