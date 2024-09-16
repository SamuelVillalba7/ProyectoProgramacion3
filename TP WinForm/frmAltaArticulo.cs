using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForm
{
    public partial class frmAltaArticulo : Form
    {

        private Articulo articulo=null; 
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo( Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {   
                cboxMarca.DataSource= marcaNegocio.listar();
                cboxMarca.ValueMember = "IDMarca";
                cboxMarca.DisplayMember = "Nombre";

                cboxCategoria.DataSource = categoriaNegocio.listar();
                cboxCategoria.ValueMember = "IDCategoria";
                cboxCategoria.DisplayMember = "Nombre";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboxMarca.SelectedValue = articulo.Marca.IDMarca;
                    cboxCategoria.SelectedValue = articulo.Categoria.IDCategoria;
                    txtPrecio.Text = articulo.Precio.ToString();
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //no vacios
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Precio debe ser un numero");
                return;
            }
            int idActual = articulo != null ? articulo.IDArticulo : 0;

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            if (articuloNegocio.existeArticulo(txtNombre.Text, idActual))
            {
                if (idActual == 0)
                {
                    MessageBox.Show("Ya existe ese Articulo");

                    return;
                }
            }
            try
            {
                bool flag = false;
                if (articulo == null)
                {
                    articulo = new Articulo();
                    flag = true;
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (flag == true)
                {
                    articuloNegocio.agregar(articulo);
                    agregarImagenURL(articulo.IDArticulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                else
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }

                Close();
                
            }
            catch (Exception ex)
            {

                  MessageBox.Show(ex.ToString()) ;
            }
        }

        //txtImagen
        private void agregarImagenURL(int idArticulo)
        {
            if (!string.IsNullOrWhiteSpace(txtImagen.Text))
            {
                Imagen nuevaImagen= new Imagen();
                nuevaImagen.IDArticulo= idArticulo;
                nuevaImagen.ImagenUrl= txtImagen.Text;

                // Insertar la imagen en la base de datos
                AccesoDatos datos= new AccesoDatos();

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


        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
