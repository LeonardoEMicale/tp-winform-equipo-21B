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
        public List<Imagen> buscarImagenes(int articuloID)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Imagen> listaImg = new List<Imagen>();

            try
            {
                datos.setearConsulta("select Id, IdArticulo, ImagenUrl from IMAGENES where idArticulo = " + articuloID);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.IdImagen = (int)datos.Lector["Id"];
                    img.IdArticulo = (int)datos.Lector["IdArticulo"];
                    img.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    listaImg.Add(img);
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
        public void agregarImagen(Imagen nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into IMAGENES(IdArticulo, ImagenUrl)values(@IdArticulo, @ImagenUrl);");
                datos.setearParametros("@IdArticulo", nueva.IdArticulo);
                datos.setearParametros("@ImagenUrl", nueva.UrlImagen);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarImagen(int IdImagen, string Url)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update IMAGENES Set ImagenUrl = @ImagenURL Where Id = @Id");
                datos.setearParametros("@Id", IdImagen);
                datos.setearParametros("@ImagenURL", Url);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
