using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using Negocio;

namespace tp_TCP_equipo_H
{
    public partial class EnvioGmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGmailAyuda_Click(object sender, EventArgs e)
        {
            EmailService EmailService = new EmailService();


            EmailService.armarCorreo(txtGmail.Text, txtAsuntiGmail.Text, txtCuerpo.Text);
            try
            {
                EmailService.enviarEmail();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}