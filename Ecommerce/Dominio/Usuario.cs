using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

     public enum RolUsuario
    {
        normal = 1,
        admin = 2,
    }
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string User { set; get; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }

        public RolUsuario RolUsuario { get; set; }
    
        
        
        public Usuario(string user, string pass, bool admin)
        {
            User = user;
            Pass = pass;
            RolUsuario = admin ? RolUsuario.admin : RolUsuario.normal;  
        }

        public Usuario(string user, string pass, bool admin, string nombre, string apellido, string mail, string telefono)
        {
            User = user;
            Pass = pass;
            RolUsuario = admin ? RolUsuario.admin : RolUsuario.normal;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Telefono = telefono;
        }
    }

}
