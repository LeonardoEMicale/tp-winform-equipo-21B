using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ConexionBD;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion AS DescripcionA, M.Descripcion AS DescripcionM, C.Descripcion AS DescripcionC, Precio from Articulos A, Marcas M, Categorias C where A.IdMarca = M.Id and IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.IdArticulo = (int)datos.Lector["Id"];
                    art.Codigo = (string)datos.Lector["Codigo"];
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["DescripcionA"];
                    art.Marca = new Marca();
                    art.Marca.Descripcion = (string)datos.Lector["DescripcionM"];
                    art.Categoria = new Categoria();
                    art.Categoria.Descripcion = (String)datos.Lector["DescripcionC"];
                    art.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(art);
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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Articulos(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)VALUES(" + nuevo.Codigo + ", '" + nuevo.Nombre + " ', '" + nuevo.Descripcion + "', @IdMarca, @IdCategoria, '" + nuevo.Precio + " ')");
                datos.setearParametros("@IdMarca", nuevo.Marca.IdMarca);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.IdCategoria);
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
