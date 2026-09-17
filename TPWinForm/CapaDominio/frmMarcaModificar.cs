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

                MarcaNegocio negocio = new MarcaNegocio();
                Marca encontrada = negocio.listar().FirstOrDefault(m => m.Id == id);

                if (encontrada == null)
                {
                    MessageBox.Show("No se encontró la marca con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ocurrió un error al buscar la marca: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (textBox2.Text.Trim().Length > 50)
                {
                    MessageBox.Show("La descripción no puede tener más de 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = int.Parse(textBox1.Text);

                MarcaNegocio negocio = new MarcaNegocio();
                List<Marca> existentes = negocio.listar();

                bool yaexiste = existentes.Any(m => m.Id != id && m.Descripcion.Trim().ToLower() == textBox2.Text.Trim().ToLower());
                if (yaexiste)
                {
                    MessageBox.Show("Ya existe otra marca con esa descripción.");
                    return;
                }

                Marca modificada = new Marca();
                modificada.Id = id;
                modificada.Descripcion = textBox2.Text.Trim();

                negocio.modificar(modificada);

                MessageBox.Show("Marca modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
