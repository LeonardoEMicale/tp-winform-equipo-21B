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
        public List<string> buscarImagenes(int articuloID)
        {
            AccesoDatos datos = new AccesoDatos();
            List<string> listaImg = new List<string>();

            try
            {
                datos.setearConsulta("select ImagenUrl from IMAGENES where idArticulo = " + articuloID);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    listaImg.Add((string)datos.Lector["ImagenUrl"]);
                }

                return listaImg;

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
