using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetallePedido
    {
        public int idDetallePedido { get; set; }

        public int idPedido { get; set; }
        public string nombreArticulo { get; set; }

        public string descripcion { get; set; }

        public string nombreCategoria { get; set; }

        public string nombreMarca { get; set; }
        public decimal importe { get; set; }

        public int cantidad { get; set; }

        public string talle { get; set; }

        public int estado { get; set; }
    }
}
