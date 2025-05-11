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
        public List<Cliente> listaCliente;
        int IDClienteParticipante;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                listaCliente = clienteNegocio.ListarClientes();
                Session["ListaClientes"] = listaCliente;

            }         
        }

        public void camposEditables(bool estado)
        {
            txtNombre.Enabled = estado;
            txtApellido.Enabled = estado;
            txtEmail.Enabled = estado;
            txtDireccion.Enabled = estado;
            txtCiudad.Enabled = estado;
            txtCP.Enabled = estado;
        }

        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
            listaCliente = (List<Cliente>)Session["ListaClientes"]; 
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

                    camposEditables(false);

                    // Guardo el IDCliente en una session, ya que existe.
                    Session["IDCliente"] = listaCliente[i].Id;
                    break;
                }
                else
                {
                    camposEditables(true);                    
                }
            }                    
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            //INSERTO EN DB los datos del cliente ingresado (tabla Clientes)
            try
            {
                if (Session["IDCliente"] != null)
                {
                    IDClienteParticipante = (int)Session["IDCliente"]; // si el cliente existe, me guardo el IDCliente.
                }
                else
                {
                    // si no existe, lo agrego a la base de datos.

                    cliente.Documento = txtDni.Text;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Ciudad = txtCiudad.Text;
                    cliente.CP = int.Parse(txtCP.Text);
                    clienteNegocio.agregarClienteDB(cliente); // agregar

                    IDClienteParticipante = clienteNegocio.obtenerIDNuevoCliente(); // obtener id de ese cliente

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


            //UPDATE EN DB la fecha de canje (tabla Voucher)
            //UPDATE EN DB del CodigoVoucher (tabla Voucher)
            //UPDATE EN DB el IDCliente (tabla Voucher)
            //UPDATE EN DB el IDArticulo seleccionado a través del session de la paginaPremios (tabla Voucher)

            //REDIRECT a PaginaRegistroExitoso
        }
    }
}