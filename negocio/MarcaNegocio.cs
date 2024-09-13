﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
namespace negocio
{
    public class MarcaNegocio
    {
        public void eliminar(int id)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("delete from MARCAS where id=@IDMarca");
                datos.setearParametro("@IDMarca", id);
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
        public void agregar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into MARCAS VALUES (@Id,@Descripcion)");
                datos.setearParametro("@Id", marca.IDMarca);
                datos.setearParametro("@Descripcion", marca.Nombre);
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
                datos.setearConsulta("UPDATE MARCAS set IDMarca=@IdMarca, Nombre=@Nombre where Id=@IDMarca");
                datos.setearParametro("@IdMarca", marca.IDMarca);
                datos.setearParametro("@Nombre", marca.Nombre); 
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
