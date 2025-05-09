using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenesNegocio
    {
        public List<Imagen> ListarImagenesPremios()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select I.Id,I.IdArticulo,I.ImagenUrl from IMAGENES as I");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];

                    aux.Articulo= new Articulo();
                    aux.Articulo.Id = (int)datos.Lector["IdArticulo"];

                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"].ToString();


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
