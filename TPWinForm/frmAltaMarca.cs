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
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificación de Marca";
        }

        private void btcAceptarMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionMarca.Text))
            {
                MessageBox.Show("La descripción de la marca es obligatoria.", "Campo obligatorio");
                return;
            }

            //Guardo la descripción en una variable porque se pierde el valor al comparar
            string nuevaDescripcion = txtDescripcionMarca.Text.Trim();

            //Validación alfanumerica
            Regex soloAlfanumerico = new Regex("^[a-zA-Z0-9 ]*$");
            if (!soloAlfanumerico.IsMatch(nuevaDescripcion))
            {
                MessageBox.Show("Solo se permiten letras y números", "Formato incorrecto");
                return;
            }

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                if (marca == null) marca = new Marca();

                //Validación de existencia
                bool esNueva = (marca.IdMarca == 0);
                bool cambioNombre = (!esNueva && marca.Descripcion.ToUpper() != nuevaDescripcion.ToUpper());

                if (esNueva || cambioNombre)
                {
                    if (marcaNegocio.existeMarca(nuevaDescripcion))
                    {
                        MessageBox.Show("Ya existe una marca con ese nombre.");
                        return;
                    }
                }

                marca.Descripcion = nuevaDescripcion;

                if (marca.IdMarca != 0)
                {
                    marcaNegocio.modificar(marca);
                    MessageBox.Show("Marca modificada con éxito.");
                }
                else
                {
                    marcaNegocio.agregar(marca);
                    MessageBox.Show("Marca agregada con éxito.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtDescripcionMarca.Text = marca.Descripcion;
            }
        }
    }
}
