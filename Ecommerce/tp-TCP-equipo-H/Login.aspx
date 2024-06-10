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
         <asp:TextBox runat="server" id="txtPassword" placeholder="***" CssClass ="form-control"/>
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




    
 <div class="col-md-9">

    <div class="col-md-3">


         <div class="mb-3"> 
        <h1>cambiar contraceña</h1> 
    
     <label class="form-label">  Nombre de usuario </label>
     <asp:TextBox runat="server" id="txtNomUsuarioContra" placeholder="" CssClass ="form-control"/>
 </div>

    <div class="mb-3"> 
        <label class="form-label"> contraseña antigua </label>
        <asp:TextBox runat="server" id="txtContraceñaAntigua" placeholder="" CssClass ="form-control"/>
    </div>
    <div class="mb-3">
        <label class="form-label"> contraceña nueva </label>
         <asp:TextBox runat="server" id="txtContraceñaNueva"  CssClass ="form-control"/>
    </div>
   <asp:Button Text="Cambiar" runat="server" id="btnCambiarContra" onclick="btnCambiarContra_Click" />
</div>

     </div>









    <div>
        <div>
             <div class="col-md-9">

    <div class="col-md-3">


         <div class="mb-3"> 
        <h1>cambiar nombre de usuario</h1> 
    
     <label class="form-label">  Nombre de usuario </label>
     <asp:TextBox runat="server" id="txtUserCambio" placeholder="" CssClass ="form-control"/>
 </div>

    <div class="mb-3"> 
        <label class="form-label"> Nombre de usuario nuevo </label>
        <asp:TextBox runat="server" id="txtUserNuevo" placeholder="" CssClass ="form-control"/>
    </div>
   
   <asp:Button Text="Cambiar" runat="server" id="btnCambiarNombreUser" onclick="btnCambiarNombreUser_Click" />
</div>

     </div>
        </div>
    </div>








        <div>
        <div>
             <div class="col-md-9">

    <div class="col-md-3">


        <div class="mb-3"> 
        <h1>cambiar Gmail</h1> 
    <label class="form-label"> Usuario </label>
    <asp:TextBox runat="server" id="txtUserMail" placeholder="" CssClass ="form-control"/>
</div>

         <div class="mb-3"> 
    
     <label class="form-label">  Gmail </label>
     <asp:TextBox runat="server" id="txtGmail" placeholder="" CssClass ="form-control"/>
 </div>

    <div class="mb-3"> 
        <label class="form-label"> Gmail nuevo </label>
        <asp:TextBox runat="server" id="txtGmailNuevo" placeholder="" CssClass ="form-control"/>
    </div>
   
   <asp:Button Text="Cambiar" runat="server" id="btnCambiarGmail" onclick="btnCambiarGmail_Click" />
</div>

     </div>
        </div>
    </div>



</asp:Content>