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
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria ,IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where Nombre not like '%DELETED' and A.IdMarca = M.Id and C.Id = A.IdCategoria");
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

        public List<Articulo> listarArticulos(string campo, string criterio, string filtro)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            AccesoDatos datos2 = new AccesoDatos();

            try
            {
                string consultaFiltro = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria ,IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS as A, MARCAS as M, CATEGORIAS as C where Nombre not like '%DELETED' AND A.IdMarca = M.Id AND C.Id = A.IdCategoria AND ";

                if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consultaFiltro += $"Nombre like '{filtro}%'";
                            break;
                        case "Termina con":
                            consultaFiltro += $"Nombre like '%{filtro}'";
                            break;
                        case "Contiene":
                            consultaFiltro += $"Nombre like '%{filtro}%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consultaFiltro += $"M.Descripcion like '{filtro}%'";
                            break;
                        case "Termina con":
                            consultaFiltro += $"M.Descripcion like '%{filtro}'";
                            break;
                        case "Contiene":
                            consultaFiltro += $"M.Descripcion like '%{filtro}%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Precio mayor a":
                            consultaFiltro += "Precio < " + filtro;
                            break;
                        case "Precio menor a":
                            consultaFiltro += "Precio > " + filtro;
                            break;
                        case "Precio igual a":
                            consultaFiltro += "Precio = " + filtro;
                            break;
                    }
                }

                datos2.setearConsulta(consultaFiltro);
                datos2.ejecutarLectura();

                while (datos2.Lector.Read())
                {
                    Articulo articuloAux = new Articulo();
                    articuloAux.Id = (int)datos2.Lector["Id"];
                    articuloAux.Codigo = (string)datos2.Lector["Codigo"];
                    articuloAux.Nombre = (string)datos2.Lector["Nombre"];
                    articuloAux.Descripcion = (string)datos2.Lector["Descripcion"];

                    articuloAux.marca = new Marca();
                    articuloAux.marca.Id = (int)datos2.Lector["IdMarca"];
                    articuloAux.marca.Descripcion = (string)datos2.Lector["Marca"];

                    articuloAux.categoria = new Categoria();
                    articuloAux.categoria.Id = (int)datos2.Lector["IdCategoria"];
                    articuloAux.categoria.Descripcion = (string)datos2.Lector["Categoria"];

                    articuloAux.UrlImagen = (string)datos2.Lector["ImagenUrl"];
                    articuloAux.Precio = (decimal)datos2.Lector["Precio"];

                    listaFiltrada.Add(articuloAux);
                }

                return listaFiltrada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos2.cerrarConexion(); }
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

 
    }
}
