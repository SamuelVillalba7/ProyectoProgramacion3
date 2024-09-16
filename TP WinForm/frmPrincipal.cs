﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdministrarArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos form= new frmArticulos();
            form.ShowDialog();
        }

        private void btnAdministrarCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias form = new frmCategorias();
            form.ShowDialog();

        }

        private void btnAdministrarMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas form= new frmMarcas();
            form.ShowDialog();
        }
    }
}
