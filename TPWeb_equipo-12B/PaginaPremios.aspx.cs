﻿using System;
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
            listaImagenesPremios = imagenesPremios.ListarConSP();


            RepeaterPremios.DataSource = listaImagenesPremios;
            RepeaterPremios.DataBind();


        }
    }
}