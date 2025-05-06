using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();	
			try
			{
                datos.setearConsulta("select A.Id,A.Codigo,A.Nombre,A.Descripcion,M.Descripcion as 'Marca',C.Descripcion as 'Categoria',A.Precio, A.IdMarca, A.IdCategoria  from ARTICULOS as A ,MARCAS as M ,CATEGORIAS as C where A.IdMarca=M.Id and A.IdCategoria=C.Id ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

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
