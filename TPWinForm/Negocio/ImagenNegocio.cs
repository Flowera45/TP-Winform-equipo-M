using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    internal class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            // ↓ Lista que va a devolver la función
            List<Imagen> lista = new List<Imagen>();

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
                comando.CommandText = "Select IdArticulo, ImagenUrl from IMAGENES";

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.IdArticulo = (int)lector["IdArticulo"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];

                    lista.Add(aux);
                }



                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
