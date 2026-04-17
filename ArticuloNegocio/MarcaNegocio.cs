using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using Dominio;

namespace ArticuloNegocio
{
    public class MarcaNegocio
    {
        // Metodo
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From Marcas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca mar = new Marca();
                    mar.IdMarca = (int)datos.Lector["Id"];
                    mar.Descripcion = (string)datos.Lector["Desccripcion"];

                    lista.Add(mar);

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
    }
}
