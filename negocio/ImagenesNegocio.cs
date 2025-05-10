using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenesNegocio
    {

        public List<Imagen> ListarConSP()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                
                //Id,IdArticulo,ImagenUrl,
                //ArticuloNombre,ArticuloDescripcion,ArticuloPrecio,
                //MarcaId,MarcaDescripcion,
                //CategoriaId,CategoriaDescripcion 

                datos.setearProcedimiento("listarImagenes");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];

                    aux.Articulo = new Articulo();
                    aux.Articulo.Id = (int)datos.Lector["IdArticulo"];
                    aux.Articulo.Nombre = (string)datos.Lector["ArticuloNombre"];
                    aux.Articulo.Descripcion = (string)datos.Lector["ArticuloDescripcion"];

                    aux.Articulo.Marca = new Marca();
                    aux.Articulo.Marca.Id = (int)datos.Lector["MarcaId"];
                    aux.Articulo.Marca.Descripcion = (string)datos.Lector["MarcaDescripcion"];//Nombre

                    aux.Articulo.Categoria = new Categoria();
                    aux.Articulo.Categoria.Id = (int)datos.Lector["CategoriaId"];
                    aux.Articulo.Categoria.Descripcion = (string)datos.Lector["CategoriaDescripcion"];//Nombre


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



        //public List<Imagen> ListarImagenesPremios()
        //{
        //    List<Imagen> lista = new List<Imagen>();
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("select I.Id,I.IdArticulo,I.ImagenUrl from IMAGENES as I");
        //        datos.ejecutarLectura();
        //        while (datos.Lector.Read())
        //        {
        //            Imagen aux = new Imagen();
        //            aux.Id = (int)datos.Lector["Id"];

        //            aux.Articulo = new Articulo();
        //            aux.Articulo.Id = (int)datos.Lector["IdArticulo"];

        //            aux.ImagenUrl = (string)datos.Lector["ImagenUrl"].ToString();


        //            lista.Add(aux);
        //        }



        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

}
