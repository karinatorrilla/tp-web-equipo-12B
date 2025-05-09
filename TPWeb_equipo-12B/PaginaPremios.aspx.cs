using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace TPWeb_equipo_12B
{
    public partial class PaginaPremios : System.Web.UI.Page
    {
        private List<Imagen> listaImagenesPremios;
        protected void Page_Load(object sender, EventArgs e)
        {
            ImagenesNegocio imagenesPremios = new ImagenesNegocio();
            listaImagenesPremios = imagenesPremios.ListarImagenesPremios();

            //                                         Agrupamos las imagenes por id de articulo
            var imgAgrupadasPorArticulo = listaImagenesPremios.GroupBy(i => i.Articulo.Id)
                .Select(g => new
                {
                    ArticuloId = g.Key,
                    Imagenes = g.ToList()
                }).ToList();
                //creamos la lista por cada articulo



            RepeaterPremios.DataSource = imgAgrupadasPorArticulo;
            RepeaterPremios.DataBind();


        }
    }
}