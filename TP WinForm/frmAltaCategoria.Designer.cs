namespace TP_WinForm
{
    partial class frmAltaCategoria
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
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labelNombreCategoria = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(243, 69);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(210, 22);
            this.txtNombreCategoria.TabIndex = 0;
            this.txtNombreCategoria.TextChanged += new System.EventHandler(this.txtNombreCategoria_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(75, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 47);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNombreCategoria
            // 
            this.labelNombreCategoria.AutoSize = true;
            this.labelNombreCategoria.Location = new System.Drawing.Point(72, 70);
            this.labelNombreCategoria.Name = "labelNombreCategoria";
            this.labelNombreCategoria.Size = new System.Drawing.Size(149, 16);
            this.labelNombreCategoria.TabIndex = 2;
            this.labelNombreCategoria.Text = "Nombre de la categoria";
            this.labelNombreCategoria.Click += new System.EventHandler(this.labelNombreCategoria_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 163);
            this.btnCancel.MinimumSize = new System.Drawing.Size(106, 47);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 249);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelNombreCategoria);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombreCategoria);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(538, 296);
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label labelNombreCategoria;
        private System.Windows.Forms.Button btnCancel;
    }
}