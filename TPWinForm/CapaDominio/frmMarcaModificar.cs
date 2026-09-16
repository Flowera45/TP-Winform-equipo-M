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
    public partial class frmMarcaModificar : Form
    {
        public frmMarcaModificar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(textBox1.Text);

                CategoriaNegocio negocio = new CategoriaNegocio();
                Categoria encontrada = negocio.listar().FirstOrDefault(c => c.Id == id);

                if (encontrada == null)
                {
                    MessageBox.Show("No se encontró la categoría con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    return;
                }

                textBox2.Text = encontrada.Descripcion;


            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Por favor, ingrese un ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Por favor, ingrese una descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Categoria modificada = new Categoria();
                modificada.Id = int.Parse(textBox1.Text);
                modificada.Descripcion = textBox2.Text;

                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.modificar(modificada);

                MessageBox.Show("Categoría modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();

            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();

        }
    }

}
