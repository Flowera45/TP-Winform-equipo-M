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
    public partial class frmMarcaAgregar : Form
    {
        public frmMarcaAgregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("la descripcion no puede estar vacia");
                    return;
                }

                if (textBox1.Text.Trim().Length > 50)
                {
                    MessageBox.Show("la descripcion no puede tener mas de 50 caracteres");
                    return;
                }

                MarcaNegocio negocio = new MarcaNegocio();
                List<Marca> existentes = negocio.listar();

                bool yaexiste = existentes.Any(m => m.Descripcion.Equals(textBox1.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                if (yaexiste)
                {
                    MessageBox.Show("la marca ya existe");
                    return;
                }

                Marca nueva = new Marca();
                nueva.Descripcion = textBox1.Text.Trim();

                negocio.agregar(nueva);

                MessageBox.Show("Marca agregada correctamente");

                DialogResult = DialogResult.OK;
                Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la marca: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
