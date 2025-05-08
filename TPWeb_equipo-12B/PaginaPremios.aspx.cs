using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace TPWeb_equipo_12B
{
    public partial class PaginaPremios : System.Web.UI.Page
    {
        private List<Imagen> listaImagenesPremios;
        protected void Page_Load(object sender, EventArgs e)
        {
            ImagenesNegocio imagenesNegocio = new ImagenesNegocio();
             listaImagenesPremios = imagenesNegocio.ListarImagenesPremios();
           

        }
    }
}