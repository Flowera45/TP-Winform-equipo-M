namespace WinformApp
{
    partial class frmArticuloAgregar
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCaterogoria = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.listImagenes = new System.Windows.Forms.ListBox();
            this.btnQuitarImagen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(86, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Click += new System.EventHandler(this.txtCodigo_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 106);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(14, 140);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(14, 177);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // lblCaterogoria
            // 
            this.lblCaterogoria.AutoSize = true;
            this.lblCaterogoria.Location = new System.Drawing.Point(14, 208);
            this.lblCaterogoria.Name = "lblCaterogoria";
            this.lblCaterogoria.Size = new System.Drawing.Size(57, 13);
            this.lblCaterogoria.TabIndex = 6;
            this.lblCaterogoria.Text = "Categoría:";
            this.lblCaterogoria.Click += new System.EventHandler(this.lblCaterogoria_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(86, 137);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(86, 103);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(86, 169);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 12;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(86, 200);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 255);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(132, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(254, 36);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(87, 13);
            this.lblImagenUrl.TabIndex = 16;
            this.lblImagenUrl.Text = "URL de imagen: ";
            this.lblImagenUrl.Click += new System.EventHandler(this.lblImagenUrl_Click);
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(347, 33);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(275, 20);
            this.txtImagenUrl.TabIndex = 17;
            this.txtImagenUrl.Click += new System.EventHandler(this.txtImagenUrl_Click);
            this.txtImagenUrl.TextChanged += new System.EventHandler(this.txtImagenUrl_TextChanged);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(395, 72);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(128, 23);
            this.btnAgregarImagen.TabIndex = 18;
            this.btnAgregarImagen.Text = "Agregar imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // listImagenes
            // 
            this.listImagenes.FormattingEnabled = true;
            this.listImagenes.Location = new System.Drawing.Point(347, 120);
            this.listImagenes.Name = "listImagenes";
            this.listImagenes.Size = new System.Drawing.Size(231, 95);
            this.listImagenes.TabIndex = 19;
            this.listImagenes.Click += new System.EventHandler(this.listImagenes_Click);
            // 
            // btnQuitarImagen
            // 
            this.btnQuitarImagen.Location = new System.Drawing.Point(395, 238);
            this.btnQuitarImagen.Name = "btnQuitarImagen";
            this.btnQuitarImagen.Size = new System.Drawing.Size(128, 23);
            this.btnQuitarImagen.TabIndex = 20;
            this.btnQuitarImagen.Text = "Quitar Imagen";
            this.btnQuitarImagen.UseVisualStyleBackColor = true;
            this.btnQuitarImagen.Click += new System.EventHandler(this.btnQuitarImagen_Click);
            // 
            // frmArticuloAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnQuitarImagen);
            this.Controls.Add(this.listImagenes);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCaterogoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmArticuloAgregar";
            this.Text = "Agregar artículo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCaterogoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.ListBox listImagenes;
        private System.Windows.Forms.Button btnQuitarImagen;
    }
}