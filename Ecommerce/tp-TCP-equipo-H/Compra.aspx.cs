﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_TCP_equipo_H
{
    public partial class Compra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntregaContinuar_Click(object sender, EventArgs e)
        {
           Negocio.ServicioEmail servicioEmail = new Negocio.ServicioEmail();

           string nombre = txtNombre.Text;
           string apellido = txtApellido.Text;
           string mailUsuario = txtMail.Text;
           string telefono = txtTelefono.Text;

           servicioEmail.ConfirmarCompra(mailUsuario,nombre,apellido,telefono);

        }
    }

    
}