namespace TP_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.cboxImagen = new System.Windows.Forms.ComboBox();
            this.lblImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 450);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(178, 44);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.UseWaitCursor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(925, 450);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 44);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.UseWaitCursor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(202, 450);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(178, 44);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.UseWaitCursor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(388, 450);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(178, 44);
            this.btnFiltro.TabIndex = 6;
            this.btnFiltro.Text = "Filtros";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.UseWaitCursor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(16, 82);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1087, 331);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.UseWaitCursor = true;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.txtFiltro);
            this.panelFiltros.Controls.Add(this.lblFiltro);
            this.panelFiltros.Controls.Add(this.lblCriterio);
            this.panelFiltros.Controls.Add(this.lblCampo);
            this.panelFiltros.Controls.Add(this.cboxCriterio);
            this.panelFiltros.Controls.Add(this.cboxCampo);
            this.panelFiltros.Controls.Add(this.btnAplicarFiltro);
            this.panelFiltros.Location = new System.Drawing.Point(31, 510);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1059, 66);
            this.panelFiltros.TabIndex = 7;
            this.panelFiltros.UseWaitCursor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(713, 15);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(132, 22);
            this.txtFiltro.TabIndex = 20;
            this.txtFiltro.UseWaitCursor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(624, 20);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(36, 16);
            this.lblFiltro.TabIndex = 19;
            this.lblFiltro.Text = "Filtro";
            this.lblFiltro.UseWaitCursor = true;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(331, 20);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 18;
            this.lblCriterio.Text = "Criterio";
            this.lblCriterio.UseWaitCursor = true;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(37, 20);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 17;
            this.lblCampo.Text = "Campo";
            this.lblCampo.UseWaitCursor = true;
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(420, 15);
            this.cboxCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(132, 24);
            this.cboxCriterio.TabIndex = 16;
            this.cboxCriterio.UseWaitCursor = true;
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(127, 15);
            this.cboxCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(132, 24);
            this.cboxCampo.TabIndex = 15;
            this.cboxCampo.UseWaitCursor = true;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(889, 14);
            this.btnAplicarFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(133, 28);
            this.btnAplicarFiltro.TabIndex = 14;
            this.btnAplicarFiltro.Text = "Filtrar";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.UseWaitCursor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(1145, 82);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(388, 331);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 8;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.UseWaitCursor = true;
            // 
            // cboxImagen
            // 
            this.cboxImagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxImagen.FormattingEnabled = true;
            this.cboxImagen.Location = new System.Drawing.Point(1357, 450);
            this.cboxImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxImagen.Name = "cboxImagen";
            this.cboxImagen.Size = new System.Drawing.Size(120, 24);
            this.cboxImagen.TabIndex = 9;
            this.cboxImagen.UseWaitCursor = true;
            this.cboxImagen.SelectedIndexChanged += new System.EventHandler(this.cboxImagen_SelectedIndexChanged);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(1200, 454);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(117, 16);
            this.lblImagen.TabIndex = 10;
            this.lblImagen.Text = "Opcion de Imagen";
            this.lblImagen.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 587);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.cboxImagen);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1559, 634);
            this.MinimumSize = new System.Drawing.Size(1386, 634);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulos";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.ComboBox cboxImagen;
        private System.Windows.Forms.Label lblImagen;
    }
}

