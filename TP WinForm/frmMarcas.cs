using dominio;
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

namespace TP_WinForm
{
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
