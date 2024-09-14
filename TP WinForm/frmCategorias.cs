using negocio;
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

namespace TP_WinForm
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
            
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvCategorias.DataSource = categoria.listar();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregarCategoria_Click_1(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
            cargarCategorias();
        }

        

        private void cargarCategorias()
        ///seguire usando mi "cargarCategorias" aun cuando la "practica comun es la linea 25"
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                dgvCategorias.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                frmAltaCategoria modificar = new frmAltaCategoria(categoriaSeleccionada);
                modificar.ShowDialog();
                cargarCategorias();
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar esta categoría?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    categoriaNegocio.eliminar(categoriaSeleccionada.IDCategoria);
                    cargarCategorias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría a eliminar");
            }
        }
    }
}
