namespace TP_WinForm
{
    partial class frmPrincipal
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
            this.btnAdministrarArticulos = new System.Windows.Forms.Button();
            this.btnAdministrarMarcas = new System.Windows.Forms.Button();
            this.btnAdministrarCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrarArticulos
            // 
            this.btnAdministrarArticulos.Location = new System.Drawing.Point(253, 99);
            this.btnAdministrarArticulos.Name = "btnAdministrarArticulos";
            this.btnAdministrarArticulos.Size = new System.Drawing.Size(243, 52);
            this.btnAdministrarArticulos.TabIndex = 0;
            this.btnAdministrarArticulos.Text = "Administrar Articulos";
            this.btnAdministrarArticulos.UseVisualStyleBackColor = true;
            this.btnAdministrarArticulos.Click += new System.EventHandler(this.btnAdministrarArticulos_Click);
            // 
            // btnAdministrarMarcas
            // 
            this.btnAdministrarMarcas.Location = new System.Drawing.Point(253, 242);
            this.btnAdministrarMarcas.Name = "btnAdministrarMarcas";
            this.btnAdministrarMarcas.Size = new System.Drawing.Size(243, 52);
            this.btnAdministrarMarcas.TabIndex = 1;
            this.btnAdministrarMarcas.Text = "Administrar Marcas";
            this.btnAdministrarMarcas.UseVisualStyleBackColor = true;
            this.btnAdministrarMarcas.Click += new System.EventHandler(this.btnAdministrarMarcas_Click);
            // 
            // btnAdministrarCategorias
            // 
            this.btnAdministrarCategorias.Location = new System.Drawing.Point(253, 169);
            this.btnAdministrarCategorias.Name = "btnAdministrarCategorias";
            this.btnAdministrarCategorias.Size = new System.Drawing.Size(243, 52);
            this.btnAdministrarCategorias.TabIndex = 2;
            this.btnAdministrarCategorias.Text = "Administrar Categorias";
            this.btnAdministrarCategorias.UseVisualStyleBackColor = true;
            this.btnAdministrarCategorias.Click += new System.EventHandler(this.btnAdministrarCategorias_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 389);
            this.Controls.Add(this.btnAdministrarCategorias);
            this.Controls.Add(this.btnAdministrarMarcas);
            this.Controls.Add(this.btnAdministrarArticulos);
            this.MaximumSize = new System.Drawing.Size(783, 428);
            this.MinimumSize = new System.Drawing.Size(783, 428);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrarArticulos;
        private System.Windows.Forms.Button btnAdministrarMarcas;
        private System.Windows.Forms.Button btnAdministrarCategorias;
    }
}