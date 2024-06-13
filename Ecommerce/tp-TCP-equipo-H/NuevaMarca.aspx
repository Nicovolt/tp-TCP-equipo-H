<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="NuevaMarca.aspx.cs" Inherits="tp_TCP_equipo_H.NuevaMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .contenedor {
            width: 100%;
            display: flex;
            align-content: center;
            justify-content: center;
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
                <%if (Request.QueryString["id"] != null)
                    {%>
                <h1>Modificar Marca</h1>
                <% }
                else
                {%>
                <h1>Nueva Marca</h1>
                <% }%>
                <div class="mb-3">
                    <label for="formGroupExampleInput" class="form-label">Nombre Marca</label>
                    <asp:TextBox type="text" cssclass="form-control" id="textMarca" placeholder="Nombre de Marca" runat="server"/>
                </div>
                <div>
                    <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-light" OnClick="Unnamed_Click"/>
                </div>

            </div>
        </section>
    </div>
</asp:Content>
