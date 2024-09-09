using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class MarcaNegocio
    {

        public List <Marca> listar()
        {
			AccesoDatos datos = new AccesoDatos();
			List <Marca> lista = new List <Marca>();
			try
			{
                datos.setearConsulta("SELECT Id,Descripcion from MARCAS");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.IDMarca = (int)datos.Lector["Id"];
                    marca.Nombre = (string)datos.Lector["Descripcion"];

                    lista.Add(marca);
                }

                return lista;


            }
			catch (Exception e)
			{

				throw e;
			}
        }



    }
}
