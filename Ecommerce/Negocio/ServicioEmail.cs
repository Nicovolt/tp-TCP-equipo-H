using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioEmail
    {
        private SmtpClient server;
        private MailMessage mail;

        public ServicioEmail()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("5.3.pereznicolas@gmail.com", "xcib wejn uzkh efxh");
            server.EnableSsl = true;
            server.Port = 587; 
            server.Host = "smtp.gmail.com";
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
                // Agregar un mensaje más descriptivo al error
                throw new Exception("Error al enviar el correo: " + ex.Message, ex);
            }
        }
    }
}
