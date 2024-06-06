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
        public RolUsuario RolUsuario { get; set; }
    
        
        
        public Usuario(string user, string pass, bool admin)
        {
            User = user;
            Pass = pass;
            RolUsuario = admin ? RolUsuario.admin : RolUsuario.normal;  
        }
    }

}
