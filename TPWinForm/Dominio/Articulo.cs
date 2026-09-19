using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
    } 
}

        
        /* Lista dinámica para soportar múltiples imágenes sin límite
       // public List<Imagen> Imagenes { get; set; }

        // Constructor para inicializar la lista y evitar errores de referencia nula
       // public Articulo()
        {
            Imagenes = new List<Imagen>();
        }
        */


