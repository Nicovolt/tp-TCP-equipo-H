using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Imagen
    {
        public int idImagen { get; set; }

        public int idArticulo { get; set; }

        public string UrlImagen { get; set; }

        public override string ToString()
        {
            return UrlImagen;
        }
        public bool IsFirst { get; set; }

        public bool Estado { get; set; }
    }
}
