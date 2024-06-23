using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int idPedido { get; set; }

        public decimal importe { get; set; }

        public int idUsuario { get; set; }

        public int estado { get; set; }

        public int cantidad { get; set; }
    }
}
