using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificación de Categoría";
        }

        private void btcAceptarCategoria_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDescripcionCategoria.Text))
            {
                MessageBox.Show("La descripción de la categoría es obligatoria.", "Campo obligatorio");
                return;
            }

            //Guardo la descripción en una variable porque se pierde el valor al comparar
            string nuevaDescripcion = txtDescripcionCategoria.Text.Trim();

            //Validación alfanumerica
            Regex soloAlfanumerico = new Regex("^[a-zA-Z0-9 ]*$");
            if (!soloAlfanumerico.IsMatch(nuevaDescripcion))
            {
                MessageBox.Show("Solo se permiten letras y números", "Formato incorrecto");
                return;
            }

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                if (categoria == null) categoria = new Categoria();

                //Validación de existencia
                bool esNueva = (categoria.IdCategoria == 0);
                bool cambioNombre = (!esNueva && categoria.Descripcion.ToUpper() != nuevaDescripcion.ToUpper());

                if (esNueva || cambioNombre)
                {
                    if (categoriaNegocio.existeCategoria(nuevaDescripcion))
                    {
                        MessageBox.Show("Ya existe una categoría con ese nombre.");
                        return;
                    }
                }

                categoria.Descripcion = nuevaDescripcion;

                if (categoria.IdCategoria != 0)
                {
                    categoriaNegocio.modificar(categoria);
                    MessageBox.Show("Categoría modificada con éxito.");
                }
                else
                {
                    categoriaNegocio.agregar(categoria);
                    MessageBox.Show("Categoría agregada con éxito.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            if(categoria != null)
            {
                txtDescripcionCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
