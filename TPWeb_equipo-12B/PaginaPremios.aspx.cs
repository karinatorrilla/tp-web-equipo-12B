using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using dominio;
using negocio;

namespace TPWeb_equipo_12B
{
    public partial class PaginaPremios : System.Web.UI.Page
    {
        private List<Articulo> listaArticulos;
        private ImagenesNegocio imagenesNegocio;

        protected void Page_Load(object sender, EventArgs e)
        {

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                imagenesNegocio = new ImagenesNegocio();
                listaArticulos = articuloNegocio.listar();
                RepeaterPremios.DataSource = listaArticulos;
                RepeaterPremios.DataBind();
        }

        // Función para obtener la URL de las iamgenes de un artículo
        protected List<string> ObtenerImagenUrl(object idArticulo)
        {
            int id = Convert.ToInt32(idArticulo);
            List<Imagen> listaImagenes = imagenesNegocio.ListarImagenesPremios();
            List<string> imageUrls = listaImagenes.Where(i => i.Articulo.Id == id).Select(i => i.ImagenUrl).ToList();

            if (imageUrls.Any())
            {
                return imageUrls;
            }
            else
            {
                return new List<string> { "https://t4.ftcdn.net/jpg/07/91/22/59/360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg" };
            }
        }


        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {

            Response.Redirect("PaginaDatosCliente.aspx?id=");
        }
    }
}
