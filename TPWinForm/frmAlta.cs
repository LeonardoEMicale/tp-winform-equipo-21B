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
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new Negocio.CategoriaNegocio();

            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            Imagen img = new Imagen();
            ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Marca = (Marca)cbMarca.SelectedItem;
                art.Categoria = (Categoria)cbCategoria.SelectedItem;
                art.Precio = decimal.Parse(txtPrecio.Text);

                int IDrecuperado = artNegocio.agregar(art);

                if (IDrecuperado != -1)
                {
                    img.IdArticulo = int.Parse(IDrecuperado.ToString());
                    img.UrlImagen = txtImagenUrl.Text;
                    imgNegocio.agregarImagen(img);
                }

                MessageBox.Show("Articulo agregado correctamenete");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            { 
                    pbImagenAlta.Load(imagen);
            }
            catch (Exception)
            {
                pbImagenAlta.Load("https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg");
            }
        }
    }
}
