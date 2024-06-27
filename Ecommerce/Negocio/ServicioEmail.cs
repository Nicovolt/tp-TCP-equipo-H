using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class ServicioEmail
    {
        private SmtpClient server;
        private MailMessage mail;

        public ServicioEmail()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("90a1b3d2a55fe2", "8f9b2d2ad821fc");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "sandbox.smtp.mailtrap.io";
        }

        public void armarCorreo(string destino, string asunto, string cuerpo)
        {
            mail = new MailMessage();
            mail.From = new MailAddress("noresponder@tienda30.com");
            mail.To.Add(destino);
            mail.Subject = asunto;
            mail.Body = cuerpo;
        }

        public void enviarMail()
        {
            try
            {
                server.Send(mail);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
