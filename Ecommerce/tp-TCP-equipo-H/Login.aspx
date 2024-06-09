<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="tp_TCP_equipo_H.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="col-md-6">

    <div class="mb-3"> 
        <h1> ingresar </h1>
        <label class="form-label"> User </label>
        <asp:TextBox runat="server" id="txtUser" placeholder="user name" CssClass ="form-control"/>
    </div>
    <div class="mb-3">
        <label class="form-label"> Password </label>
         <asp:TextBox runat="server" id="txtPassword" placeholder="*****" CssClass ="form-control"/>
    </div>
    <asp:Button Text="Ingresar" runat="server" id="btnIngresar" OnClick="btnIngresar_Click" />
</div>

 <div class="col-md-8">

    <div class="col-md-6">

    <div class="mb-3"> 
        <h1>registrar</h1> 
        <label class="form-label"> Nombre </label>
        <asp:TextBox runat="server" id="txtNombre" placeholder="" CssClass ="form-control"/>
    </div>
    <div class="mb-3">
        <label class="form-label"> Apellido </label>
         <asp:TextBox runat="server" id="txtApellido"  CssClass ="form-control"/>
    </div>
    <div class="mb-3">
       <label class="form-label"> Mail </label>
       <asp:TextBox runat="server" id="txtMail"  CssClass ="form-control"/>
 </div>
         <div class="mb-3">
     <label class="form-label"> Telefono </label>
      <asp:TextBox runat="server" id="txtTelefono"  CssClass ="form-control"/>
 </div>
         <div class="mb-3">
     <label class="form-label"> Nombre de usuario </label>
      <asp:TextBox runat="server" id="txtNombreDeUsuario"  CssClass ="form-control"/>
 </div>
                <div class="mb-3">
    <label class="form-label"> Contraceña </label>
     <asp:TextBox runat="server" id="txtContraceña"  CssClass ="form-control"/>
</div>
    <asp:Button Text="Registrar" runat="server" id="btnRegistrar" onclick="btnRegistrar_Click" />
</div>

     </div>
</asp:Content>