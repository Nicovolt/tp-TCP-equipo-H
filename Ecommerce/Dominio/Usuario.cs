using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { set; get; }
        public string Pass { get; set; }
        public RolUsuario rolUsuario { get; set; }
    }
}
