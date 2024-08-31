using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloDatos
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> listArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articuloAux = new Articulo();
                    articuloAux.Id = (int)datos.Lector["Id"];
                    articuloAux.Codigo = (string)datos.Lector["Codigo"];
                    articuloAux.Nombre = (string)datos.Lector["Nombre"];
                    articuloAux.Descripcion = (string)datos.Lector["Descripcion"];
                    articuloAux.marca = new Marca();
                    articuloAux.marca.Id = (int)datos.Lector["IdMarca"];
                    //articuloAux.marca.Descripcion = (string)datos.Lector["Description"];
                    articuloAux.categoria = new Categoria();

                    articuloAux.categoria.Id = (int)datos.Lector["IdCategoria"];
                    //articuloAux.categoria.Descrpcion = (string)datos.Lector ["Description"];
                    articuloAux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    articuloAux.Precio = (decimal)datos.Lector["Precio"];

                    listArticulos.Add(articuloAux);
                }

                return listArticulos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally { datos.cerrarConexion(); }
        }

        public void agregar(Articulo artNuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta($"insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values ('{artNuevo.Codigo}','{artNuevo.Nombre}','{artNuevo.Descripcion}', {artNuevo.marca.Id}, {artNuevo.categoria.Id},'{artNuevo.UrlImagen}', {artNuevo.Precio})");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally { datos.cerrarConexion(); }
        }
    }
}
