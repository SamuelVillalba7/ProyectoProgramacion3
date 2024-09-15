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
    public partial class frmAltaMarcas : Form
    {
        private Marca marca = null;
        public frmAltaMarcas()
        {
            InitializeComponent();
        }
        public frmAltaMarcas(Marca marcas)
        {
            InitializeComponent();
            this.marca = marcas;
            Text = "Modificar Marca";
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            
            if (marca != null)
            {
                txtNombre.Text = marca.Nombre;
              // int.Parse(txtID.Text) = marca.IDMarca;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) )
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
          //  Marca marca = new Marca();
            MarcaNegocio marcanegocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                {
                    marca = new Marca();
                }
                marca.Nombre = txtNombre.Text;
                if (marca.IDMarca == 0)
                {
                  //  marca.IDMarca = int.Parse(txtID.Text);
                    marca.Nombre = txtNombre.Text;
                    marcanegocio.agregar(marca);
                    MessageBox.Show("Agegado exitosamente Pa");
                    Close();

                }
                else
                {
                    marcanegocio.modificar(marca);
                    MessageBox.Show("Marca modificada exitosamente.");
                }
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
