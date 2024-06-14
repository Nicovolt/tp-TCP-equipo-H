<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ModificarMarca.aspx.cs" Inherits="tp_TCP_equipo_H.ModificarMarca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    .container {
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
        min-height: auto;
        /*background-color: #2c2c2c; */
        color: black; 
        padding: 20px;
    }

    .table-container {
        background:linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%); 
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
    }

    .titulo-catalogo {
        text-align: center;
        margin-bottom: 20px;
        color: white;
    }

    .table {
        width: 90%; 
        margin: auto;
         background-color: #000; 
        color: #fff; 
    }

    .table th, .table td {
        text-align: center;
        vertical-align: middle;
        background-color: #000; 
        color: #fff; 
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">      
           <div class="table-container">
               <h1 class="titulo-catalogo">Lista de Marcas</h1>
            <table class="table table-bordered border-primary">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nombre</th>
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
                                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CommandArgument='<%# Eval("idMarca") %>' CommandName="idModificar" CssClass="btn btn-primary" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
