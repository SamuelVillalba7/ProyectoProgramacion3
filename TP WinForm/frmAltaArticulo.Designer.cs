﻿namespace TP_WinForm
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(108, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(104, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(85, 145);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(111, 179);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(111, 245);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(96, 211);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // cboxMarca
            // 
            this.cboxMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(175, 176);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(310, 21);
            this.cboxMarca.TabIndex = 3;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(175, 211);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(310, 21);
            this.cboxCategoria.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.Location = new System.Drawing.Point(175, 76);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(370, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(175, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(370, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(175, 145);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(370, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecio.Location = new System.Drawing.Point(175, 245);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(370, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(681, 314);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtImagen.Location = new System.Drawing.Point(175, 276);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(370, 20);
            this.txtImagen.TabIndex = 7;
            this.txtImagen.TextChanged += new System.EventHandler(this.txtImagen_TextChanged);
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(96, 276);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(62, 13);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "Imagen (url)";
            this.lblImagen.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxArticulo.Location = new System.Drawing.Point(575, 76);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(256, 220);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 9;
            this.pbxArticulo.TabStop = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 394);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.MinimumSize = new System.Drawing.Size(881, 433);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}