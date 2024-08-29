using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaDatos
    {
        public List<Categoria> listarCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoriaAux = new Categoria();
                    categoriaAux.Id = (int)datos.Lector["Id"];
                    categoriaAux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaCategorias.Add(categoriaAux);
                }

                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
