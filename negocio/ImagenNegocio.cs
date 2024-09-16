using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listarPorId(int id)
        {

            List<Imagen> lista = new List<Imagen>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select i.Id,i.IdArticulo,i.ImagenUrl from IMAGENES as i inner join ARTICULOS as a on i.IdArticulo=a.Id where a.id =@idArticulo");
                accesoDatos.setearParametro("@IdArticulo", id);
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.IDImagen = (int)accesoDatos.Lector["Id"];
                    imagen.IDArticulo = (int)accesoDatos.Lector["IdArticulo"];
                    imagen.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];

                    lista.Add(imagen);
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


        public void agregarImagenURL(int idArticulo, string url)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                Imagen nuevaImagen = new Imagen();
                nuevaImagen.IDArticulo = idArticulo;
                nuevaImagen.ImagenUrl = url;

                // Insertar la imagen en la base de datos
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                    datos.setearParametro("@IdArticulo", nuevaImagen.IDArticulo);
                    datos.setearParametro("@ImagenUrl", nuevaImagen.ImagenUrl);
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }
        }


    }
}
