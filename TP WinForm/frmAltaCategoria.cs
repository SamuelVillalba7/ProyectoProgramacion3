using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using dominio;  
using negocio;

namespace TP_WinForm
{
    public partial class frmAltaCategoria : Form
    {
        //para el modify
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoría";
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            // en caso de edit
            if (categoria != null)
            {
                txtNombreCategoria.Text = categoria.Nombre;
            }
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.Nombre = txtNombreCategoria.Text;

                if (categoria.IDCategoria == 0)
                {//categoria nueva
                    categoriaNegocio.agregar(categoria);
                    MessageBox.Show("Categoría agregada exitosamente.");
                }
                else
                {//modify
                    categoriaNegocio.modificar(categoria);
                    MessageBox.Show("Categoría modificada exitosamente.");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }







        private void labelNombreCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
