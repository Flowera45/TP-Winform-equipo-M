using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();
            // negocio.listar va a la DB y devuelve una lista de datos
            // DataSource recibe esos datos y los modela en la tabla
            dgvArticulos.Columns["IdMarca"].Visible = false;      //No quiero que muestre estos IDs
            dgvArticulos.Columns["IdCategoria"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pBoxImagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

    }
}
