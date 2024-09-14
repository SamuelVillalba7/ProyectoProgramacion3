using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForm
{
    public partial class AltaMarcas : Form
    {
        public AltaMarcas()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marca.IDMarca = int.Parse(txtID.Text);
                marca.Nombre = txtNombre.Text;
                negocio.agregar(marca);
                MessageBox.Show("Agegado exitosamente Pa");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
             
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
