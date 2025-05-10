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
    public partial class PaginaDatosCliente : System.Web.UI.Page
    {
        private List<Cliente> listaCliente; 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                listaCliente = clienteNegocio.ListarClientes();
                Session["ListaCliente"] = listaCliente;  // guardo en session
            }
            else
            {
                listaCliente = (List<Cliente>)Session["ListaCliente"]; // recupero la lista desde la session guardada
            }
        }

        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listaCliente.Count; i++)
            {
                if (txtDni.Text.Trim() == listaCliente[i].Documento)
                {
                    // Si existe el DNI, se precargan los datos del cliente.
                    txtNombre.Text = listaCliente[i].Nombre;
                    txtApellido.Text = listaCliente[i].Apellido;
                    txtEmail.Text = listaCliente[i].Email;
                    txtDireccion.Text = listaCliente[i].Direccion;
                    txtCiudad.Text = listaCliente[i].Ciudad;
                    txtCP.Text = listaCliente[i].CP.ToString();                    
                }
            }
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            //REDIRECT a PaginaRegistroExitoso

            //INSERTO EN DB los datos del cliente ingresado (tabla Clientes)

            //UPDATE EN DB la fecha de canje (tabla Voucher)
            //UPDATE EN DB del CodigoVoucher (tabla Voucher)
            //UPDATE EN DB el IDCliente (tabla Voucher)
            //UPDATE EN DB el IDArticulo seleccionado a través del session de la paginaPremios (tabla Voucher)

        }
    }
}