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
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion AS DescripcionA, M.Descripcion AS DescripcionM, C.Descripcion AS DescripcionC, Precio, A.IdMarca, A.IdCategoria from Articulos A, Marcas M, Categorias C where A.IdMarca = M.Id and IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.IdArticulo = (int)datos.Lector["Id"];
                    art.Codigo = (string)datos.Lector["Codigo"];
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["DescripcionA"];
                    art.Marca = new Marca();
                    art.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    art.Marca.Descripcion = (string)datos.Lector["DescripcionM"];
                    art.Categoria = new Categoria();
                    art.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
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
        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE Articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio Where Id = @IdArticulo");
                datos.setearParametros("@IdArticulo", modificar.IdArticulo);
                datos.setearParametros("@Codigo", modificar.Codigo);
                datos.setearParametros("@Nombre", modificar.Nombre);
                datos.setearParametros("@Descripcion", modificar.Descripcion);
                datos.setearParametros("@IdMarca", modificar.Marca.IdMarca);
                datos.setearParametros("@IdCategoria", modificar.Categoria.IdCategoria);
                datos.setearParametros("@Precio", modificar.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void eliminar(int articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From articulos where id = @Id");
                datos.setearParametros("@Id", articulo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
