 <%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Compra.aspx.cs" Inherits="tp_TCP_equipo_H.Compra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    
   



    <section class="contenedor">
    <div class="form-contenedor">
        <h1>Entrega</h1>
       
        <div class="mb-3" cssclas="form-floating mb-3">
            <label class="form-label">pais</label>
             <asp:DropDownList runat="server" ID="ddlPais">
             <asp:ListItem Text="Argenitna" />
             <asp:ListItem Text="Chile" />
                 <asp:ListItem Text="Peru" />
                 <asp:ListItem Text="Uruguay" />
                 <asp:ListItem Text="Paraguay" />
                 <asp:ListItem Text="Mexico" />
                 <asp:ListItem Text="Paraguay" />
                 <asp:ListItem Text="Peru" />
                 <asp:ListItem Text="Venezuela" />
                 <asp:ListItem Text="Colombia" />
                 <asp:ListItem Text="Volivia" />
                 </asp:DropDownList>
        </div>
        <div class="mb-3" cssclas="form-floating mb-3">
            <label class="form-label">Codigo postal</label>
            <asp:TextBox runat="server" ID="txtCodigoPostal" CssClass="form-control" />
        </div>
       
    </div>
</section>

      
        <section class="contenedor2">
    <div class="form-contenedor2">
        <h1>Datos de facturacion</h1>
       
        <div class="mb-3" cssclas="form-floating mb-3">
            <label class="form-label">pais</label>
             <asp:DropDownList runat="server" ID="DropDownList1">
             <asp:ListItem Text="Argenitna" />
             <asp:ListItem Text="Chile" />
                 <asp:ListItem Text="Peru" />
                 <asp:ListItem Text="Uruguay" />
                 <asp:ListItem Text="Paraguay" />
                 <asp:ListItem Text="Mexico" />
                 <asp:ListItem Text="Paraguay" />
                 <asp:ListItem Text="Peru" />
                 <asp:ListItem Text="Venezuela" />
                 <asp:ListItem Text="Colombia" />
                 <asp:ListItem Text="Volivia" />
                 </asp:DropDownList>
        </div>

        <h2>Persona que pagara el envio</h2>

        <div class="mb-3" cssclas="form-floating mb-3">
            <label class="form-label">Nombre</label>
            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
        </div>
        <div class="mb-3" cssclas="form-floating mb-3">
           <label class="form-label">Apellido</label>
           <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
           </div>
            <div class="mb-3" cssclas="form-floating mb-3">
            <label class="form-label">Telefono</label>
           <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" />
           </div>
        




    </div>
</section>

            <section class="contenedor2">
    <div class="form-contenedor2">
        <h1>Metodo depagos</h1>
       
        <div class="mb-3" cssclas="form-floating mb-3">
            <asp:CheckBox Text="Transferencia" runat="server" />
             <asp:CheckBox Text="Mercado pago" runat="server" />
        </div>
        <asp:Button Text="Continuar" runat="server" ID="btnContinuar" onclick="btnEntregaContinuar_Click" CssClass="btn btn-primary" />
      
    </div>
</section>
    
    
    
    
    
    
    
    
    
    






















</asp:Content>
