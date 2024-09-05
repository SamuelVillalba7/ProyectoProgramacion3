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


        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id,Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio from ARTICULOS");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.IDArticulo = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.IDMarca = (int)datos.Lector["IdMarca"];
                    articulo.IDCategoria = (int)datos.Lector["IdCategoria"];
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
