using CapaDominio;
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class Form1 : Form
    {
        private List<Imagen> listaImagen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();
            listaImagen = imgNegocio.listar();

            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();
            // negocio.listar va a la DB y devuelve una lista de datos
            // DataSource recibe esos datos y los modela en la tabla
            dgvArticulos.Columns["IdMarca"].Visible = false;      //No quiero que muestre estos IDs
            dgvArticulos.Columns["IdCategoria"].Visible = false;
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int id = seleccionado.Id;
            buscarYMostrarImagen(id);

        }

        private void buscarYMostrarImagen(int idArticuloBuscado)
        {
            Imagen imgEncontrada = null;

            if(listaImagen != null) { 
                foreach (Imagen item in listaImagen)
                {
                    if(item.IdArticulo == idArticuloBuscado)
                    {
                        imgEncontrada = item;
                        break;
                    }
                }
            }
            if (imgEncontrada != null)
            {
                cargarImagen(imgEncontrada.ImagenUrl);
            }
            else
            {
                cargarImagen(""); // Al estar vacío salta al catch y muestra el placeholder
            }
        }
        /*private void cargarImagen(string imagen)
        {
            try
            {
                pBoxImagenArticulo.Load(imagen);
                
            }
            catch (Exception ex)
            {
                pBoxImagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }

        }*/

        // Un solo HttpClient estático para toda la aplicación (buena práctica de rendimiento)
        private static readonly System.Net.Http.HttpClient clienteHttp = new System.Net.Http.HttpClient();

        private async void cargarImagen(string urlImagen)
        {
            // 1. Mostrar inmediatamente el placeholder por defecto de forma rápida
            pBoxImagenArticulo.LoadAsync("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");

            // Si la URL recibida es nula o vacía, nos quedamos con el placeholder ya cargado
            if (string.IsNullOrEmpty(urlImagen)) return;

            try
            {
                // Configurar un límite de tiempo razonable (800 ms) para no demorar la experiencia del usuario
                using (var cts = new System.Threading.CancellationTokenSource(800))
                {
                    // 2 y 3. Validar y descargar la imagen en segundo plano dentro del rango de tiempo
                    var respuesta = await clienteHttp.GetAsync(urlImagen, cts.Token);

                    if (respuesta.IsSuccessStatusCode)
                    {
                        // Si la respuesta fue exitosa y dentro del tiempo límite, se asigna la imagen
                        pBoxImagenArticulo.LoadAsync(urlImagen);
                    }
                }
            }
            catch (Exception)
            {
                // Si la URL no funciona, no responde a tiempo (Timeout) o se cancela, 
                // la aplicación no se congela y mantiene el placeholder cargado en el paso 1.
            }
        }
    }
}
