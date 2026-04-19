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
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria formAltaCategoria = new frmAltaCategoria();
            formAltaCategoria.ShowDialog();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarca formAltaMarca = new frmAltaMarca();
            formAltaMarca.ShowDialog();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria formAltaCategoria = new frmAltaCategoria();
            formAltaCategoria.ShowDialog();
        }

        private void btnVolverMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVolverCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
