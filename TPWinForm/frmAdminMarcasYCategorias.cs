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

namespace TPWinForm
{
    public partial class frmAdminMarcasYCategorias : Form
    {
        private List<Marca> listaMarca;
        private List<Categoria> listaCategoria;
        public frmAdminMarcasYCategorias()
        {
            InitializeComponent();
        }

        private void frmAdminMarcasYCategorias_Load(object sender, EventArgs e)
        {
            cargarGrids();
            dgvCategoria.ClearSelection();
            dgvMarca.ClearSelection();
        }

        private void cargarGrids()
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            try
            {
                listaMarca = negocioMarca.listar();
                listaCategoria = negocioCategoria.listar();

                dgvMarca.DataSource = listaMarca;
                dgvCategoria.DataSource = listaCategoria;

                //Oculta columna de Id
                dgvCategoria.Columns["IdCategoria"].Visible = false;
                dgvMarca.Columns["IdMarca"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarca formAltaMarca = new frmAltaMarca();
            formAltaMarca.ShowDialog();
            cargarGrids();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria formAltaCategoria = new frmAltaCategoria();
            formAltaCategoria.ShowDialog();
            cargarGrids();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarca.CurrentRow != null)
            {
                Marca marcaSeleccionada;
                marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                frmAltaMarca formAltaMarca = new frmAltaMarca(marcaSeleccionada);
                formAltaMarca.ShowDialog();
                cargarGrids();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria categoriaSeleccionada;
                categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                frmAltaCategoria formAltaCategoria = new frmAltaCategoria(categoriaSeleccionada);
                formAltaCategoria.ShowDialog();
                cargarGrids();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnVolverMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVolverCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if(dgvMarca.CurrentRow != null)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Marca marcaSeleccionada;

                try
                {
                    DialogResult eleccion = MessageBox.Show("Está seguro que desea eliminar la marca?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (eleccion == DialogResult.Yes)
                    {
                        marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                        marcaNegocio.eliminar(marcaSeleccionada.IdMarca);
                        cargarGrids();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {   
            if(dgvCategoria.CurrentRow != null)
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Categoria categoriaSeleccionada;
                try
                {
                    DialogResult eleccion = MessageBox.Show("Está seguro que desea eliminar la categoría?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(eleccion == DialogResult.Yes)
                    {
                    categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    categoriaNegocio.eliminar(categoriaSeleccionada.IdCategoria);
                    cargarGrids();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
