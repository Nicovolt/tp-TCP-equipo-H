<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="tp_TCP_equipo_H.Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style> 
        .lblArticulo{
            font-size: 40px;
        }
    </style>
    <asp:Label ID="lblArticulo" CssClass="lblArticulo" Text=""  runat="server" />
</asp:Content>
