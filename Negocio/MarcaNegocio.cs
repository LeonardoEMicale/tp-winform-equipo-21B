using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using Dominio;

namespace Negocio
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
                    mar.Descripcion = (string)datos.Lector["Descripcion"];

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
    
            public void agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Marcas(Descripcion)VALUES('" + nuevo.Descripcion + "')");
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

        public void modificar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Marcas set Descripcion = @descripcion where Id = @id");
                datos.setearParametros("@descripcion", marca.Descripcion);
                datos.setearParametros("@id", marca.IdMarca);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int idMarca)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete from Marcas Where Id = @id");
                datos.setearParametros("@id", idMarca);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool existeMarca(string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id From Marcas where UPPER(Descripcion) = UPPER(@descripcion)");
                datos.setearParametros("@descripcion", descripcion);
                datos.ejecutarLectura();

                return datos.Lector.Read();
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