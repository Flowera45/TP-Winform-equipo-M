using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmCategoriaAgregar : Form
    {
        public frmCategoriaAgregar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {

                    MessageBox.Show("El campo de categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (textBox1.Text.Trim().Length > 50)
                {
                    MessageBox.Show("La descripción no puede tener más de 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CategoriaNegocio negocio = new CategoriaNegocio();
                List<Categoria> existentes = negocio.listar();

                bool yaExiste = existentes.Any(c => c.Descripcion.Trim().ToLower() == textBox1.Text.Trim().ToLower());
                if (yaExiste)
                {
                    MessageBox.Show("La categoría ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Categoria nueva = new Categoria();
                nueva.Descripcion = textBox1.Text.Trim();

                negocio.agregar(nueva);

                MessageBox.Show("Categoria agregada correctamente");

                DialogResult = DialogResult.OK;
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
