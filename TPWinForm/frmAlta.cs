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
                    btnAnterior.Visible = true;
                    btnSiguiente.Visible = true;
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
                else
                {
                    btnAnterior.Visible = false;
                    btnSiguiente.Visible = false;
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

            if (!validarCampos())
                return;
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

                    // si se elimina la imagen actual al intentar modficiar un articulo, va a tomar la imagen por defecto
                    if (string.IsNullOrWhiteSpace(txtImagenUrl.Text))
                    {
                        txtImagenUrl.Text = "https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg";
                    }

                    if(!string.IsNullOrWhiteSpace(txtImagenUrl.Text) && listaImagenes != null && listaImagenes.Count > 0)
                    {
                        imgNegocio.modificarImagen(listaImagenes[indiceImagen].IdImagen, txtImagenUrl.Text);
                    }
                    MessageBox.Show("Articulo modificado correctamenete");
                }
                else
                {
                    int IDrecuperado = artNegocio.agregar(articulo);
                    Imagen img = new Imagen();

                    if (string.IsNullOrWhiteSpace(txtImagenUrl.Text))
                    {
                        txtImagenUrl.Text = "https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg";
                    }

                    if (IDrecuperado != -1)
                    {
                        img.IdArticulo = IDrecuperado;

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

        private bool validarCampos()
        {
            errorProvider.Clear();

            if(string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider.SetError(txtCodigo, "El código es obligatorio.");
                return false;
            }
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "La descipcion es obligatoria.");
                return false;
            }

            decimal precio;
            if(!decimal.TryParse(txtPrecio.Text, out precio))
            {
                errorProvider.SetError(txtPrecio, "El precio es obligatorio y solo debe contener números.");
                return false;
            }
            return true;
        }
    }
}
