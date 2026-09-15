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

                Categoria nueva = new Categoria();
                nueva.Descripcion = textBox1.Text;

                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.agregar(nueva);

                MessageBox.Show("Categoria agregada correctamente");

                DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
