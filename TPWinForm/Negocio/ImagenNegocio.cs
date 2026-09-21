using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select IdArticulo, ImagenUrl From IMAGENES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Imagen nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into IMAGENES (IdArticulo, ImagenUrl) values (@IdArticulo, @ImagenUrl)");

                datos.setearParametro("@IdArticulo", nueva.IdArticulo);
                datos.setearParametro("@ImagenUrl", nueva.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int idarticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("Delete from IMAGENES Where idarticulo = @idarticulo");
                datos.setearParametro("@idarticulo", idarticulo);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;

            }

            finally
            {

                datos.cerrarConexion();
            }
        }
    }
}
