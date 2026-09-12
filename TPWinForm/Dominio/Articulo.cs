using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }

        /*
        // Asociaciones con otras clases del dominio
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        // Lista dinámica para soportar múltiples imágenes sin límite
        public List<Imagen> Imagenes { get; set; }

        // Constructor para inicializar la lista y evitar errores de referencia nula
        public Articulo()
        {
            Imagenes = new List<Imagen>();
        }
        */
    }
}

