using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
namespace negocio
{
    public class ArticuloNegocio
    {

        public void eliminar(int id)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("delete from ARTICULOS where id=@id");
                datos.setearParametro("@id", id);
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

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.IDMarca);
                datos.setearParametro("IdCategoria",articulo.Categoria.IDCategoria);
                datos.setearParametro("@Precio", articulo.Precio);
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

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select a.Id,a.Codigo,a.Nombre,a.Descripcion, m.Descripcion as marcaDescripcion,c.Descripcion as categoriaDescripcion,a.Precio from ARTICULOS as a left join MARCAS AS m on a.IdMarca =m.Id left JOIN CATEGORIAS as c on a.IdCategoria = c.Id");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.IDArticulo = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["marcaDescripcion"] is DBNull))
                    {
                        articulo.Marca= new Marca();
                        articulo.Marca.Nombre = (string)datos.Lector["marcaDescripcion"];
                    }

                    if (!(datos.Lector["categoriaDescripcion"] is DBNull))
                    {   
                        articulo.Categoria= new Categoria();
                        articulo.Categoria.Nombre = (string)datos.Lector["categoriaDescripcion"];
                    }
                        
                 
                    
                    articulo.Precio = Convert.ToDecimal(datos.Lector["Precio"]);


                    lista.Add(articulo);

               
                }
                return lista;


            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}
