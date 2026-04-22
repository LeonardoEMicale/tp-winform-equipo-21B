using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Utilidades
{
    public class Utils
    {
        public void cargarImagen(List<Imagen> listaURL, PictureBox pbImagen, int indice)
        {
            try
            {
                if (listaURL != null && listaURL.Count > 0)

                    pbImagen.Load(listaURL[indice].UrlImagen);
            }
            catch (Exception)
            {
                pbImagen.Load("https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg");
            }
        }
        public void cargarImagen(string imagen, PictureBox pbimagen)
        {
            try
            {
                pbimagen.Load(imagen);
            }
            catch (Exception)
            {
                pbimagen.Load("https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg");
            }
        }
    }
}
