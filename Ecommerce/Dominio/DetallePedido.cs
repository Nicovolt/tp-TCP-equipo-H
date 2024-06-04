using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class DetallePedido
    {
        public int idPedido { get; set; }

        public string nombreUsuario { get; set; }

        public string nombreMarca { get; set; }

        public string nombreArticulo { get; set; }

        public int cantidad { get; set; }

        public string talle { get; set; }

        public decimal importe { get; set; }

        public int estado { get; set; }
    }
}
