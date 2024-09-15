using dominio;
using negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm
{
    public partial class frmMarcas : Form
    {
        private List<Articulo> lista;
        public frmMarcas()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            MarcaNegocio marca = new MarcaNegocio();
          
            dgvMarca.DataSource = marca.listar();




        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            dgvMarca.DataSource = marca.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            


               frmAltaMarcas alta = new frmAltaMarcas();
            alta.ShowDialog();
            cargar();

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMarca.CurrentRow != null)
            {
                Marca marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                frmAltaMarcas modificar = new frmAltaMarcas(marcaSeleccionada);
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una marca para modificar.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarca.CurrentRow != null)
            {
                Marca marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;

                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar esta marca?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    marcaNegocio.eliminar(marcaSeleccionada.IDMarca);
                    cargar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una marca a eliminar");
            }

        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
