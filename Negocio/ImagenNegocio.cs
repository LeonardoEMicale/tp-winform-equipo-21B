using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ConexionBD;

namespace Negocio
{
    public class ImagenNegocio
    {
        public string buscarImagen(int articuloID)
        {
            AccesoDatos datos = new AccesoDatos();
            string urlImagen = "";

            try
            {
                datos.setearConsulta("select ImagenUrl from IMAGENES where idArticulo = " + articuloID);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    urlImagen = (string)datos.Lector["ImagenUrl"];
                }

                return urlImagen;

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
