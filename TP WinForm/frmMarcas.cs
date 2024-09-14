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
        public frmMarcas()
        {
            InitializeComponent();
        }
        private List<Marca> lista;
        public void cargar()
        {
            MarcaNegocio marca = new MarcaNegocio();
            lista = marca.listar();
            dgvMarca.DataSource = lista;
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            dgvMarca.DataSource = marca.listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


               AltaMarcas alta = new AltaMarcas();
            alta.ShowDialog();
                
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            AltaMarcas alta = new AltaMarcas();
            alta.ShowDialog();
            cargar();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca ();
            
            try
            {

                DialogResult resultado = MessageBox.Show("Desea eliminar el registro", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    marca = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    marcaNegocio.eliminar(marca.IDMarca);
                    cargar();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
