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
                throw ex;
            }
        }
    }
}
