using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    //Clase de acceso a datos
    
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            // ↓ Lista que va a devolver la función
            List<Articulo> lista = new List<Articulo>();

            // ↓ Objeto para establecer conexiones a la DB
            SqlConnection conexion = new SqlConnection();
            // ↓ Objeto para realizar comandos en la DB
            SqlCommand comando = new SqlCommand();
            // ↓ Lector donde se albergan los datos de las consultas
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Codigo, Nombre, Descripcion, Precio from ARTICULOS";
                comando.Connection = conexion;
                // ↑ El comando de la linea 30 va ser ejecutado en la conexion establecida en la linea 28

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //aux.IdMarca = lector.GetInt32(4);
                    //aux.IdCategoria = lector.GetInt32(5);
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
                // ↑ Lista que va a devolver la función

            }
            catch (Exception)
            {

                throw;
            }
        } 
    }
}
