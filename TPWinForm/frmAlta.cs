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
using Utilidades;
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm
{
    public partial class frmAlta : Form
    {
        private Articulo articulo = null;
        private List<Imagen> listaImagenes;
        private int indiceImagen;

        public frmAlta()
        {
            InitializeComponent();
        }
        public frmAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new Negocio.CategoriaNegocio();

            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "IdMarca";
                cbMarca.DisplayMember = "Descripcion";

                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "IdCategoria";
                cbCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    ImagenNegocio imgNegocio = new ImagenNegocio();
                    Utils util = new Utils();

                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    listaImagenes = imgNegocio.buscarImagenes(articulo.IdArticulo);
                    txtImagenUrl.Text = listaImagenes[indiceImagen].UrlImagen;
                    util.cargarImagen(listaImagenes, pbImagenAlta, indiceImagen);

                    cbMarca.SelectedValue = articulo.Marca.IdMarca;
                    cbCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);


                if(articulo.IdArticulo != 0)
                {
                    artNegocio.modificar(articulo);
                    imgNegocio.modificarImagen(listaImagenes[indiceImagen].IdImagen, txtImagenUrl.Text);
                    MessageBox.Show("Articulo modificado correctamenete");
                }
                else
                {
                    int IDrecuperado = artNegocio.agregar(articulo);
                    Imagen img = new Imagen();
                    if (IDrecuperado != -1)
                    {
                        img.IdArticulo = int.Parse(IDrecuperado.ToString());
                        img.UrlImagen = txtImagenUrl.Text;
                        imgNegocio.agregarImagen(img);
                    }

                    MessageBox.Show("Articulo agregado correctamenete");
                }
               
                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Propiedad que sirve para mostrar la imagen en el Alta al poner un URL
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            Utils util = new Utils();

            util.cargarImagen(txtImagenUrl.Text,pbImagenAlta);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Utils util = new Utils();

            if (indiceImagen == 0)
                indiceImagen = listaImagenes.Count - 1;
            else
                indiceImagen--;

            // Al cambiar de imagen cambia el campo de la url
            txtImagenUrl.Text = listaImagenes[indiceImagen].UrlImagen;

            util.cargarImagen(listaImagenes, pbImagenAlta, indiceImagen);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Utils util = new Utils();

            if (indiceImagen == listaImagenes.Count - 1)
            {
                indiceImagen = 0;
                util.cargarImagen(listaImagenes, pbImagenAlta, indiceImagen);
            }
            else
            {
                indiceImagen++;
                util.cargarImagen(listaImagenes, pbImagenAlta, indiceImagen);
            }
            // Al cambiar de imagen cambia el campo de la url
            txtImagenUrl.Text = listaImagenes[indiceImagen].UrlImagen;
        }
    }
}
