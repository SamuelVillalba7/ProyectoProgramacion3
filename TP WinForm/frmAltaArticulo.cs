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

            
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();            
            
            try
            {
                bool flag = false;
                if (articulo == null)
                {   
                    articulo= new Articulo();
                    flag = true;
                }
                articulo.Codigo= txtCodigo.Text;
                articulo.Nombre= txtNombre.Text;
                articulo.Descripcion= txtDescripcion.Text;
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                articulo.Precio= decimal.Parse(txtPrecio.Text);

                if (flag==true)
                {
                    articuloNegocio.agregar(articulo);
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
