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
    public partial class Form1 : Form
    {


        public void cargar()
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            lista = articulo.listar();
            dgvArticulos.DataSource = lista;
        }

        private List<Articulo> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();

            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvCategorias.DataSource = categoria.listar();


            MarcaNegocio marca = new MarcaNegocio();
            dgvMarca.DataSource = marca.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo frm = new frmAltaArticulo();
            frm.ShowDialog();
            cargar();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            
            try
            {
               
                DialogResult resultado = MessageBox.Show("Desea eliminar el registro","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                if(resultado == DialogResult.Yes)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                    articuloNegocio.eliminar(articulo.IDArticulo);
                    cargar();
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Articulo articulo =(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo frm = new frmAltaArticulo(articulo);
            frm.ShowDialog();
            cargar();
        }
    }
}
