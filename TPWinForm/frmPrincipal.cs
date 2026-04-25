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
using Utilidades;

namespace TPWinForm
{
    public partial class frmPrincipal : Form
    {

        private List<Articulo> listaArticulo;
        private List<Imagen> listaImagenes;
        private int indiceImagen;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;

                cboCampo.Items.Add("Marca");
                cboCampo.Items.Add("Categoría");
                cboCampo.Items.Add("Precio");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta formAlta = new frmAlta();
            formAlta.ShowDialog();

            cargarGrids();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalleArticulo formDetalleArticulo = new frmDetalleArticulo();
            formDetalleArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado;
            artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAlta formModificacion = new frmAlta(artSeleccionado);
            formModificacion.ShowDialog();
            cargarGrids();
        }

        private void administrarMarcasYCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminMarcasYCategorias frmAdminMarcasYCategorias = new frmAdminMarcasYCategorias();
            frmAdminMarcasYCategorias.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            // Guardo todas las imagenes encontrada en la base de datos
            listaImagenes = imgNegocio.buscarImagenes(artSeleccionado.IdArticulo);
            indiceImagen = 0;

            Utils util = new Utils();
            util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Utils util = new Utils();

            if(indiceImagen == listaImagenes.Count - 1)
            {
                indiceImagen = 0;
                util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
            }
            else
            {
                indiceImagen++;
                util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Utils util = new Utils();

            if (indiceImagen == 0)
                indiceImagen = listaImagenes.Count - 1;
            else
                indiceImagen--;

            util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
          
            try
            {
                DialogResult eleccion = MessageBox.Show("Está seguro que desea eliminar el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eleccion == DialogResult.Yes)
                {
                    Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    artNegocio.eliminar(artSeleccionado.IdArticulo);

                    cargarGrids();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cargarGrids()
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            try
            {
                listaArticulo = artNegocio.listar();
                dgvArticulos.DataSource = listaArticulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGestImagen_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmGestionImagen gestionImagen = new frmGestionImagen(artSeleccionado);
            gestionImagen.ShowDialog();
            cargarGrids();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Igual a: $");
                cboCriterio.Items.Add("Desde: $");
                cboCriterio.Items.Add("Hasta: $");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltroAv_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            if (cboCampo.SelectedItem == null || cboCriterio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar campo y criterio para filtrar.");
                return;
            }

            if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = artNegocio.listar();
            }
            else
            {
                try
                {
                    string campo = cboCampo.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtroAv = txtFiltroAvanzado.Text;

                    dgvArticulos.DataSource = artNegocio.filtrar(campo, criterio, filtroAv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
