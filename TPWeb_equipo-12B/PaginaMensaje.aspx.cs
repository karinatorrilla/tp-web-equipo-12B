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
    public partial class PaginaMensaje : System.Web.UI.Page
    {
        private List<Voucher> listaVoucher;
        private List<Voucher> listaVoucherCanjeados;
        protected void Page_Load(object sender, EventArgs e)
        {
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            listaVoucher = voucherNegocio.ListarVouchers();
            listaVoucherCanjeados = voucherNegocio.ListarVouchersCanjeados();

            lblVoucherCanjeado.Visible = false;
            if (Session["VoucherIngresado"] != null) {

                string voucherIngresado = Session["VoucherIngresado"].ToString();

                for (int i = 0; i < listaVoucherCanjeados.Count; i++)
                {

                    if (voucherIngresado == listaVoucherCanjeados[i].Codigo)
                    {
                        lblVoucherCanjeado.Visible = true;
                        lblVoucherCanjeado.Text = "¡Voucher ya canjeado, intente con uno nuevo!";
                    }
                    else
                    {
                        lblVoucherCanjeado.Visible = true;
                        lblVoucherCanjeado.Text = "\nIngrese un voucher válido...";
                    }


                }


            }

               

        }

        protected void btnIrInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", false);
        }
    }
}