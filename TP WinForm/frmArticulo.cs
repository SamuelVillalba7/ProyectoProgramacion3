﻿using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace TP_WinForm
{
    public partial class frmArticulos : Form
    {

       
        private List<Articulo> lista;
        public frmArticulos()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            lista = articulo.listar();
            dgvArticulos.DataSource = lista;
            panelFiltros.Visible = false;

            cargarImagen(lista[0].Imagenes[0].ToString());
              
     

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
           

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

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (panelFiltros.Visible)
            {
                panelFiltros.Visible =false;
                cargar();
            }
            else
            {
                panelFiltros.Visible = true;
                cboxCampo.Items.Clear();
                cboxCriterio.Items.Clear();
                txtFiltro.Clear();
                cboxCampo.Items.Add("Id");
                cboxCampo.Items.Add("Codigo");
                cboxCampo.Items.Add("Descripcion");
                cboxCampo.Items.Add("Marca");
                cboxCampo.Items.Add("Categoria");
                cboxCampo.Items.Add("Precio");

            }

            
        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opc = cboxCampo.SelectedItem.ToString();
            cboxCriterio.Items.Clear();
            txtFiltro.Clear();
            switch (opc)
            {
                case "Id":
                    cboxCriterio.Items.Add("Mayor a");
                    cboxCriterio.Items.Add("Menor a");
                    cboxCriterio.Items.Add("Igual a");
                    break;
                case "Codigo":
                    cboxCriterio.Items.Add("Termina en");
                    cboxCriterio.Items.Add("Comienza con");
                    cboxCriterio.Items.Add("Contiene");

                    break;
                case "Descripcion":
                    cboxCriterio.Items.Add("Termina en");
                    cboxCriterio.Items.Add("Comienza con");
                    cboxCriterio.Items.Add("Contiene");

                    break;
                case "Marca":
                    cboxCriterio.Items.Add("Termina en");
                    cboxCriterio.Items.Add("Comienza con");
                    cboxCriterio.Items.Add("Contiene");

                    break;
                case "Categoria":
                    cboxCriterio.Items.Add("Termina en");
                    cboxCriterio.Items.Add("Comienza con");
                    cboxCriterio.Items.Add("Contiene");

                    break;
                case "Precio":
                    cboxCriterio.Items.Add("Mayor a");
                    cboxCriterio.Items.Add("Menor a");
                    cboxCriterio.Items.Add("Igual a");

                    break;




            }

        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro= txtFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo,criterio,filtro);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        


        }
        private bool validarFiltro()
        {
            if (cboxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo para filtrar");
                return true;
            }
            if (cboxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio para filtrar");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("El filtro no puede estar vacio");
                return true;
            }
            if (!(soloNumeros(txtFiltro.Text)))
            {
                MessageBox.Show("Ingrese solo numeros");
                return true;
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                {

                    //pbxPokemon.Load(imagen)(articulo.Imagenes[0].ToString());
                    cargarImagen(articulo.Imagenes[0].ToString());
                    
                }
                else
                {
                    cargarImagen("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }

                //Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ImagenNegocio imgNegocio = new ImagenNegocio();
                List<Imagen> imagenes = imgNegocio.listarPorId(articulo.IDArticulo);
                if (imagenes != null && imagenes.Count > 0)
                {
                    cboxImagen.DataSource = imagenes;
                    cboxImagen.ValueMember = "IdImagen"; //lo que muestra en el codobox
                    cboxImagen.DisplayMember = "UrlImagen";


                }
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbxArticulo.Load(url);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void cboxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string url= cboxImagen.SelectedItem.ToString();
            cargarImagen(url);
            //Imagen imagenSeleccionada = (Imagen)cboxImagen.SelectedItem;
            //cargarImagen(imagenSeleccionada.UrlImagen);

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
