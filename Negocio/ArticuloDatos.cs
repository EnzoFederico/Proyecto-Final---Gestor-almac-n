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
        public List<Articulo> listarArticulos(int opcion)
        {
            string consulta;
            if (opcion == 1)
            {
                consulta = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria ,IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where Nombre not like '%DELETED' and A.IdMarca = M.Id and C.Id = A.IdCategoria";
            }
            else
            {
                consulta = "";
            }
            List<Articulo> listArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(consulta);
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
                    articuloAux.marca.Descripcion = (string)datos.Lector["Marca"];

                    articuloAux.categoria = new Categoria();
                    articuloAux.categoria.Id = (int)datos.Lector["IdCategoria"];
                    articuloAux.categoria.Descripcion = (string)datos.Lector ["Categoria"];

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

        public void modificar(Articulo modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @marca, IdCategoria = @categoria, ImagenUrl = @imagen, Precio = @precio where Id = @id");

                datos.setearParametro("@nombre", modificado.Nombre);
                datos.setearParametro("@codigo", modificado.Codigo);
                datos.setearParametro("@descripcion", modificado.Descripcion);
                datos.setearParametro("@marca", modificado.marca.Id);
                datos.setearParametro("@categoria", modificado.categoria.Id);
                datos.setearParametro("@imagen", modificado.UrlImagen);
                datos.setearParametro("@precio", modificado.Precio);
                datos.setearParametro("@id", modificado.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally { datos.cerrarConexion(); }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete ARTICULOS where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void bajaLogica(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta($"UPDATE ARTICULOS SET Nombre = Nombre + 'DELETED' WHERE id = {id};");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

      /*  public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("");
            datos.ejecutarAccion();
            return List<>;
        }*/
    }
}
