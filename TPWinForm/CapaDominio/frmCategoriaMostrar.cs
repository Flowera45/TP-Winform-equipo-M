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
using Dominio;

namespace WinformApp
{
    public partial class frmCategoriaMostrar : Form
    {
        private List<Categoria> listaCategorias;
        public frmCategoriaMostrar()
        {
            InitializeComponent();
        }

        public frmCategoriaMostrar(List<Categoria>catergorias)
        {
            InitializeComponent();

            listaCategorias = catergorias;
        }


        private void frmCategoriaMostrar_Load(object sender, EventArgs e)
        {
            if (listaCategorias == null)
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                dgvCategorias.DataSource = negocio.listar();
            }

            else
            {
                dgvCategorias.DataSource = listaCategorias;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
