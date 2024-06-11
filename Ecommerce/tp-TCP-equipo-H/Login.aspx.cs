﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace tp_TCP_equipo_H
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                usuario = new Usuario(txtUser.Text,txtPassword.Text, false);    
                if (negocio.login(usuario))
                {
                    Session.Add("usuario", usuario);
                    Response.Redirect("Default.aspx", false);
                }
                else
                {
                    Session.Add("error", "user o pass incorrectos");
                    Response.Redirect("Error.aspx");

                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario usuario;
            try
            {

                usuario = new Usuario(txtNombreDeUsuario.Text, txtContraceña.Text, false, txtNombre.Text, txtApellido.Text, txtMail.Text, txtTelefono.Text);
                negocio.Registrarse(usuario);
                if (!negocio.Registrarse(usuario))
                {
                   
                    Response.Redirect("Default.aspx", false);
                }
                else
                {
                    Session.Add("error", "no se pudo registrar correctamente");
                    Response.Redirect("Error.aspx", false);

                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }



        protected void btnCambiarContra_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                usuario = new Usuario(txtNomUsuarioContra.Text, txtContraceñaAntigua.Text, txtContraceñaNueva.Text);
                negocio.resetContraseña(usuario);


            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnCambiarNombreUser_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                usuario = new Usuario(txtUserCambio.Text, txtUserNuevo.Text);
                negocio.resetUsuario(usuario);


            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnCambiarGmail_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {                        
                usuario = new Usuario(txtUserMail.Text, txtGmail.Text, txtGmailNuevo.Text, 1);
                negocio.resetGmail(usuario);


            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

    }
}
