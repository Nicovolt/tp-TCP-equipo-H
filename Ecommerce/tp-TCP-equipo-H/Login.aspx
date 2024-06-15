<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="tp_TCP_equipo_H.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
           .contenedor3, .contenedor4, .contenedor5 {
            width: 100%;
            display: flex;
            align-content: center;
            justify-content: center;
            margin-bottom: 40px; 
        }

        .contenedor3 > h1, .contenedor4 > h1, .contenedor5 > h1 {
            align-content: center;
        }

        .form-contenedor3, .form-contenedor4, .form-contenedor5 {
            width: 100%;
            max-width: 450px;
            background: linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%);
            border-radius: 15px;
            color: white;
            padding: 50px 60px 70px;
        }
        
        
        
        .contenedor, .contenedor2 {
            width: 100%;
            display: flex;
            align-content: center;
            justify-content: center;
            margin-bottom: 50px; 
        }

        .contenedor > h1, .contenedor2 > h1 {
            align-content: center;
        }

        .form-contenedor, .form-contenedor2 {
            width: 100%;
            max-width: 450px;
            background: linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%);
            border-radius: 15px;
            color: white;
            padding: 50px 60px 70px;
        }

        .mb-3 {
            margin-bottom: 1rem;
        }

        .form-label {
            margin-bottom: 0.5rem;
        }

        .form-control {
            width: 100%;
            padding: 0.5rem;
            font-size: 1rem;
            border: 1px solid #ced4da;
            border-radius: 0.25rem;
        }

        .btn {
            display: inline-block;
            font-weight: 400;
            color: #212529;
            text-align: center;
            vertical-align: middle;
            cursor: pointer;
            border: 1px solid transparent;
            padding: 0.375rem 0.75rem;
            font-size: 1rem;
            line-height: 1.5;
            border-radius: 0.25rem;
            transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
        }

        .btn-primary {
            color: #fff;
            background-color: #007bff;
            border-color: #007bff;
        }

        .btn-primary:hover {
            color: #fff;
            background-color: #0056b3;
            border-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <% if (Session["usuario"] != null) { %>
        
    
    
   
            <section class="contenedor3">
            <div class="form-contenedor3">
                <h1>Cambiar contraseña</h1>
                <div class="mb-3">
                    <label class="form-label">Nombre de usuario</label>
                    <asp:TextBox runat="server" ID="txtNomUsuarioContra" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Contraseña antigua</label>
                    <asp:TextBox runat="server" ID="txtContraceñaAntigua" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Contraseña nueva</label>
                    <asp:TextBox runat="server" ID="txtContraceñaNueva" CssClass="form-control" />
                </div>
                <asp:Button Text="Cambiar" runat="server" ID="btnCambiarContra" onclick="btnCambiarContra_Click" CssClass="btn btn-primary" />
            </div>
        </section>

        <section class="contenedor4">
            <div class="form-contenedor4">
                <h1>Cambiar nombre de usuario</h1>
                <div class="mb-3">
                    <label class="form-label">Nombre de usuario</label>
                    <asp:TextBox runat="server" ID="txtUserCambio" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Nombre de usuario nuevo</label>
                    <asp:TextBox runat="server" ID="txtUserNuevo" placeholder="" CssClass="form-control" />
                </div>
                <asp:Button Text="Cambiar" runat="server" ID="btnCambiarNombreUser" onclick="btnCambiarNombreUser_Click" CssClass="btn btn-primary" />
            </div>
        </section>

        <section class="contenedor5">
            <div class="form-contenedor5">
                <h1>Cambiar Gmail</h1>
                <div class="mb-3">
                    <label class="form-label">Usuario</label>
                    <asp:TextBox runat="server" ID="txtUserMail" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Gmail</label>
                    <asp:TextBox runat="server" ID="txtGmail" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Gmail nuevo</label>
                    <asp:TextBox runat="server" ID="txtGmailNuevo" placeholder="" CssClass="form-control" />
                </div>
                <asp:Button Text="Cambiar" runat="server" ID="btnCambiarGmail" onclick="btnCambiarGmail_Click" CssClass="btn btn-primary" />
            </div>
        </section>
        
    <% } else { %>
        <section class="contenedor">
            <div class="form-contenedor">
                <h1>Ingresar</h1>
                <div class="mb-3">
                    <label class="form-label">User</label>
                    <asp:TextBox runat="server" ID="txtUser" placeholder="User Name" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Password</label>
                    <asp:TextBox runat="server" ID="txtPassword" placeholder="Password" CssClass="form-control" />
                </div>
                <div>
                    <asp:Button Text="Ingresar" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" CssClass="btn btn-outline-light" />
                </div>
            </div>
        </section>

        <section class="contenedor2">
            <div class="form-contenedor2">
                <div class="mb-3" cssclas="form-floating mb-3">
                    <h1>Registrar</h1>
                    <label class="form-label">Nombre</label>
                    <asp:TextBox runat="server" ID="txtNombre" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Apellido</label>
                    <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Mail</label>
                    <asp:TextBox runat="server" ID="txtMail" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Telefono</label>
                    <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Nombre de usuario</label>
                    <asp:TextBox runat="server" ID="txtNombreDeUsuario" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Contraseña</label>
                    <asp:TextBox runat="server" ID="txtContraceña" CssClass="form-control" />
                </div>
                <asp:Button Text="Registrar" runat="server" ID="btnRegistrar" onclick="btnRegistrar_Click" CssClass="btn btn-primary" />
            </div>
        </section>
    <% } %>
</asp:Content>
