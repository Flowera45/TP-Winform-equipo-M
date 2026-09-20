namespace WinformApp
{
    partial class frmArticuloBuscar
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
            this.btnBucar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCaterogoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPrecioDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioHasta = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBucar
            // 
            this.btnBucar.Location = new System.Drawing.Point(35, 336);
            this.btnBucar.Name = "btnBucar";
            this.btnBucar.Size = new System.Drawing.Size(75, 23);
            this.btnBucar.TabIndex = 2;
            this.btnBucar.Text = "Buscar";
            this.btnBucar.UseVisualStyleBackColor = true;
            this.btnBucar.Click += new System.EventHandler(this.btnBucar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(162, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(107, 174);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 27;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(107, 137);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // lblCaterogoria
            // 
            this.lblCaterogoria.AutoSize = true;
            this.lblCaterogoria.Location = new System.Drawing.Point(35, 177);
            this.lblCaterogoria.Name = "lblCaterogoria";
            this.lblCaterogoria.Size = new System.Drawing.Size(57, 13);
            this.lblCaterogoria.TabIndex = 22;
            this.lblCaterogoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 140);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 21;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(32, 140);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lblDescripcion.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 17;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(107, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 31;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(32, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID:";
            // 
            // txtPrecioDesde
            // 
            this.txtPrecioDesde.Location = new System.Drawing.Point(133, 240);
            this.txtPrecioDesde.Name = "txtPrecioDesde";
            this.txtPrecioDesde.Size = new System.Drawing.Size(93, 20);
            this.txtPrecioDesde.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Desde:";
            // 
            // txtPrecioHasta
            // 
            this.txtPrecioHasta.Location = new System.Drawing.Point(133, 279);
            this.txtPrecioHasta.Name = "txtPrecioHasta";
            this.txtPrecioHasta.Size = new System.Drawing.Size(93, 20);
            this.txtPrecioHasta.TabIndex = 35;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(73, 282);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 13);
            this.lblPrecio.TabIndex = 34;
            this.lblPrecio.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Rango de precio:";
            // 
            // frmArticuloBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioHasta);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecioDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCaterogoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnBucar);
            this.Name = "frmArticuloBuscar";
            this.Text = "frmArticuloBuscar";
            this.Load += new System.EventHandler(this.frmArticuloBuscar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBucar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCaterogoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPrecioDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioHasta;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label3;
    }
}