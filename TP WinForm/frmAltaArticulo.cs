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
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {   
                cboxMarca.DataSource= marcaNegocio.listar();
                cboxCategoria.DataSource = categoriaNegocio.listar();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();            
            
            try
            {
                articulo.Codigo= txtCodigo.Text;
                articulo.Nombre= txtNombre.Text;
                articulo.Descripcion= txtDescripcion.Text;
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                articulo.Precio= decimal.Parse(txtPrecio.Text);

                articuloNegocio.agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                  MessageBox.Show(ex.ToString()) ;
            }
        }
    }
}
