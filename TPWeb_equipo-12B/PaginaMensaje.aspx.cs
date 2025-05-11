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

            string mensajeRegistro = (string)Session["MensajeRegistro"];
            string voucherIngresado = (string)Session["VoucherIngresado"];

            lblVoucherCanjeado.Visible = false;

            // Verificamos si el voucher ya fue canjeado
            if (!string.IsNullOrEmpty(voucherIngresado))
            {
                for (int i = 0; i < listaVoucherCanjeados.Count; i++)
                {
                    if (voucherIngresado == listaVoucherCanjeados[i].Codigo)
                    {
                        lblVoucherCanjeado.Visible = true;
                        lblVoucherCanjeado.Text = "¡Voucher ya canjeado, intente con uno nuevo!";
                        break;
                    }
                }
            }

            // Verificamos si es un registro exitoso
            if (!IsPostBack)
            {
                if (mensajeRegistro == "RegistroExitoso")
                {
                    lblVoucherCanjeado.Text = "¡Enhorabuena! Tu voucher fue canjeado correctamente.";
                    lblVoucherCanjeado.Visible = true;
                }
            }

        }
        protected void btnIrInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", false);
        }
    }
}