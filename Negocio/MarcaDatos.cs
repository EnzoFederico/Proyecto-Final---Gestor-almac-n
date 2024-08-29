using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaDatos
    {
        public List<Marca> listarMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marcaAuxiliar = new Marca();
                    marcaAuxiliar.Id = (int)datos.Lector["Id"];
                    marcaAuxiliar.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarcas.Add(marcaAuxiliar);
                }

                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
