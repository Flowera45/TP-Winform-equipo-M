using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Imagen
    {
        public int IdImagen { get; set; }
        public string UrlImagen { get; set; }

        public override string ToString()
        {
            return UrlImagen;
        }
    }
}
