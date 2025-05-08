using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class VoucherNegocio
    {
        public List<Voucher> ListarVouchers()
        {
            List<Voucher> lista = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select V.CodigoVoucher,V.FechaCanje from Vouchers as V where V.FechaCanje is null");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();
                    aux.Codigo = (string)datos.Lector["CodigoVoucher"];


                    // aux.Cliente = new Cliente();  para obtener datos del cliente


                    lista.Add(aux);
                }




                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Voucher> ListarVouchersCanjeados()
        {
            List<Voucher> lista = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select V.CodigoVoucher,V.FechaCanje from Vouchers as V where V.FechaCanje is not null");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();
                    aux.Codigo = (string)datos.Lector["CodigoVoucher"];

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }



    }
}
