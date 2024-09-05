using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> listar()
        {

            List<Categoria> lista = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("SELECT Id,Descripcion from CATEGORIAS");
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.IDCategoria = (int)accesoDatos.Lector["Id"];
                    categoria.Nombre = (string)accesoDatos.Lector["Descripcion"];

                    lista.Add(categoria);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}