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
        public int agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Articulos(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)VALUES(@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio); SELECT scope_identity();");
                datos.setearParametros("@Codigo", nuevo.Codigo);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@IdMarca", nuevo.Marca.IdMarca);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.IdCategoria);
                datos.setearParametros("@Precio", nuevo.Precio);

                // Ejecutamos en lectura para que nos devuela la ID
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                    return int.Parse(datos.Lector[0].ToString());
                else
                    return -1;

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
