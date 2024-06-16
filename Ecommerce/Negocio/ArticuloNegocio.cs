﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("SELECT A.ID_Articulo,A.NombreArticulo,A.Descripcion,A.Estado,A.Talla, C.NombreCategoria AS Categoria,M.NombreMarca AS Marca,A.Precio,A.Stock,STRING_AGG(I.Url_Imagen, ';') AS Imagenes\r\nFROM Articulos A INNER JOIN Categorias C ON C.ID_Categoria = A.ID_Categoria INNER JOIN Marcas M ON M.ID_Marca = A.ID_Marca LEFT JOIN Imagenes I ON I.ID_Articulo = A.ID_Articulo WHERE A.Estado= 1\r\nGROUP BY A.ID_Articulo, A.NombreArticulo, A.Descripcion, A.Talla, A.Estado, C.NombreCategoria, M.NombreMarca, A.Precio, A.Stock");
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.idArticulo = (int)datos.Lector["ID_Articulo"];
                    articulo.nombreArticulo = (string)datos.Lector["NombreArticulo"];
                    articulo.descripcion = (string)datos.Lector["Descripcion"];
                    articulo.categoria = new Categoria();
                    articulo.categoria.nombreCategoria = (string)datos.Lector["Categoria"];
                    articulo.marca = new Marca();
                    articulo.marca.nombreMarca = (string)datos.Lector["Marca"];
                    articulo.precio = (decimal)datos.Lector["Precio"];
                    articulo.stock = (int)datos.Lector["stock"];
                    articulo.talle = (string)datos.Lector["Talla"];
                    articulo.Estado = (int)datos.Lector["Estado"];
                    articulo.listaImagenes = new List<Imagen>();
                    if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Imagenes")))
                    {
                        Imagen imagen = new Imagen();
                        imagen.UrlImagen = (string)datos.Lector["Imagenes"];
                        articulo.listaImagenes.Add(imagen);
                    }
                    lista.Add(articulo);
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
        public List<Articulo> ListarconSP()

        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("sp_ListarArticulos");
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.idArticulo = (int)datos.Lector["ID_Articulo"];
                    articulo.nombreArticulo = (string)datos.Lector["NombreArticulo"];
                    articulo.descripcion = (string)datos.Lector["Descripcion"];
                    articulo.categoria = new Categoria();
                    articulo.categoria.nombreCategoria = (string)datos.Lector["Categoria"];
                    articulo.marca = new Marca();
                    articulo.marca.nombreMarca = (string)datos.Lector["Marca"];
                    articulo.precio = (decimal)datos.Lector["Precio"];
                    articulo.stock = (int)datos.Lector["stock"];
                    articulo.Estado = int.Parse(datos.Lector["Estado"].ToString());
                    articulo.listaImagenes = new List<Imagen>();
                    if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Imagenes")))
                    {
                        Imagen imagen = new Imagen();
                        imagen.UrlImagen = (string)datos.Lector["Imagenes"];
                        articulo.listaImagenes.Add(imagen);
                    }

                    lista.Add(articulo);
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
        public Articulo buscarPorID(int Id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConexion("SELECT A.ID_Articulo, A.NombreArticulo, A.Descripcion, A.Talla, C.ID_Categoria ,C.NombreCategoria AS Categoria, M.ID_Marca ,M.NombreMarca AS Marca, A.Precio, A.Stock, A.Talla, A.Estado FROM Articulos A INNER JOIN Categorias C ON C.ID_Categoria = A.ID_Categoria INNER JOIN Marcas M ON M.ID_Marca = A.ID_Marca WHERE A.ID_Articulo = @ID");
                datos.setearParametro("@ID", Id);
                datos.abrirConexion();

                if (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.idArticulo = (int)datos.Lector["ID_Articulo"];
                    articulo.nombreArticulo = (string)datos.Lector["NombreArticulo"];
                    articulo.descripcion = (string)datos.Lector["Descripcion"];
                    articulo.categoria = new Categoria();
                    articulo.categoria.idCategoria = (int)datos.Lector["ID_Categoria"];
                    articulo.categoria.nombreCategoria = (string)datos.Lector["Categoria"];
                    articulo.marca = new Marca();
                    articulo.marca.idMarca = (int)datos.Lector["ID_Marca"];
                    articulo.marca.nombreMarca = (string)datos.Lector["Marca"];
                    articulo.precio = (decimal)datos.Lector["Precio"];
                    articulo.stock = (int)datos.Lector["Stock"];
                    articulo.talle = (string)datos.Lector["Talla"];
                    articulo.Estado = (int)datos.Lector["Estado"];
                    articulo.listaImagenes = new List<Imagen>(); ;

                    return articulo;
                }
                return null;
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

        public List<Articulo> buscarPorCategoria(string categoria)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
             datos.setConexion("SELECT A.ID_Articulo, A.NombreArticulo, A.Descripcion, C.ID_Categoria ,C.NombreCategoria AS Categoria, M.ID_Marca ,M.NombreMarca AS Marca, A.Precio, A.Stock, A.Estado FROM Articulos A INNER JOIN Categorias C ON C.ID_Categoria = A.ID_Categoria INNER JOIN Marcas M ON M.ID_Marca = A.ID_Marca WHERE C.NombreCategoria = @Categoria");
            datos.setConexion("SELECT A.ID_Articulo as id, A.NombreArticulo, A.Descripcion, C.ID_Categoria ,C.NombreCategoria AS Categoria, M.ID_Marca ,M.NombreMarca AS Marca, I.ID_Imagen, I.Url_Imagen as ImagenUrl, A.Precio, A.Stock, A.Estado FROM Articulos A INNER JOIN Categorias C ON C.ID_Categoria = A.ID_Categoria INNER JOIN Marcas M ON M.ID_Marca = A.ID_Marca INNER JOIN Imagenes I on I.ID_Imagen = A.ID_Articulo WHERE C.NombreCategoria = @Categoria");
                datos.setearParametro("@Categoria", categoria);
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.idArticulo = (int)datos.Lector["id"];
                    articulo.nombreArticulo = (string)datos.Lector["NombreArticulo"];
                    articulo.descripcion = (string)datos.Lector["Descripcion"];
                    articulo.categoria = new Categoria();
                    articulo.categoria.nombreCategoria = (string)datos.Lector["Categoria"];
                    articulo.marca = new Marca();
                    articulo.marca.nombreMarca = (string)datos.Lector["Marca"];
                    articulo.precio = (decimal)datos.Lector["Precio"];
                    articulo.stock = (int)datos.Lector["stock"];
                    articulo.listaImagenes = new List<Imagen>();
                    if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl")))
                    {
                        Imagen imagen = new Imagen();
                        imagen.UrlImagen = (string)datos.Lector["ImagenUrl"];
                        articulo.listaImagenes.Add(imagen);
                    }
                    lista.Add(articulo);
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
        public int agregar(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("INSERT INTO Articulos (NombreArticulo, Descripcion, ID_Categoria, ID_Marca, Precio, Stock, Talla, Estado) output inserted.ID_Articulo VALUES (@NombreArticulo, @Descripcion, @ID_Categoria, @ID_Marca, @Precio, @Stock, @Talla, @Estado);");
                datos.setearParametro("@NombreArticulo", nuevo.nombreArticulo);
                datos.setearParametro("@Descripcion", nuevo.descripcion);
                datos.setearParametro("@ID_Categoria", nuevo.categoria.idCategoria);
                datos.setearParametro("@ID_Marca", nuevo.marca.idMarca);
                datos.setearParametro("@Precio", nuevo.precio);
                datos.setearParametro("@Stock", nuevo.stock);
                datos.setearParametro("@Talla", nuevo.talle);
                datos.setearParametro("@Estado", nuevo.Estado);
                int ultimaFila = datos.ejecutarAccionConOutput();
                return ultimaFila;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void modificarConSP(Articulo arti)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("sp_ModificarArticulo");
                datos.setearParametro("@ID_Articulo", arti.idArticulo);
                datos.setearParametro("@NombreArticulo", arti.nombreArticulo);
                datos.setearParametro("@Descripcion", arti.descripcion);
                datos.setearParametro("@ID_Categoria", arti.categoria.idCategoria);
                datos.setearParametro("@ID_Marca", arti.marca.idMarca);
                datos.setearParametro("@Precio", arti.precio);
                datos.setearParametro("@Stock", arti.stock);
                datos.setearParametro("@Talla", arti.talle);
                datos.setearParametro("@Estado", arti.Estado);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }


        public void EliminarArticulo(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("sp_EliminarArticulo");
                datos.setearParametro("@ID_Articulo", idArticulo);
                datos.ejecutarAccion();
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

        public int generarNumPedido(Articulo compra, int idUsuario)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("insert into Pedidos(ID_Usuario,Importe) output inserted.ID_Pedido values(@idUsuario,@importe)");
                datos2.setearParametro("@idUsuario", idUsuario);
                datos2.setearParametro("@importe", compra.precio);
                int idPedido = datos2.ejecutarAccionConOutput();
                return idPedido;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos2.cerrarConexion();
            }
        }

        public void modificarEstadoCompra(int idPedido, int estado)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("update Pedidos set Estado=@estado where ID_Pedido=@idPedido");
                datos2.setearParametro("@idPedido", idPedido);
                datos2.setearParametro("@estado", estado);
                datos2.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos2.cerrarConexion();
                /*if (estado == 4)
                {
                    modificarDetalleCompra(idPedido,0);
                }*/
            }
        }

        public void modificarDetalleCompra(int idPedido, int estado)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("update DetallePedidos set Estado=@estado where ID_Pedido=@idPedido");
                datos2.setearParametro("@idPedido", idPedido);
                datos2.setearParametro("@estado", estado);
                datos2.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos2.cerrarConexion();
            }
        }

        public void insertarDetallePedido(Articulo articulo, int idPedido)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("insert into DetallePedidos(Cantidad,Talle,ID_Articulo,ID_Pedido,Importe) values(@cantidad,@talle,@idArticulo,@idPedido,@importe)");
             datos2.setearParametro("@cantidad", articulo.Cantidad);
            datos2.setearParametro("@talle", articulo.talle);
                datos2.setearParametro("@idArticulo", articulo.idArticulo);
                datos2.setearParametro("@idPedido", idPedido);
                datos2.setearParametro("@importe", articulo.precio);
                datos2.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos2.cerrarConexion();
            }
        }


        public void actualizarDetallePedido(Articulo articulo, int idPedido)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("update DetallePedidos set Cantidad=@cantidad,Importe=@importe where ID_Articulo=@idArticulo and Talle like @talle and ID_Pedido=@idPedido");
             datos2.setearParametro("@cantidad", articulo.Cantidad);
            datos2.setearParametro("@talle", articulo.talle);
                datos2.setearParametro("@idArticulo", articulo.idArticulo);
                datos2.setearParametro("@idPedido", idPedido);
                datos2.setearParametro("@importe", articulo.precio);
                datos2.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos2.cerrarConexion();
            }
        }

        public Articulo buscarPorId(int Id)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            MarcaNegocio marcaService = new MarcaNegocio();
            CategoriaNegocio categoriaService = new CategoriaNegocio();

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=Ecommerce; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Articulos] WHERE ID_Articulo = @Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();
                Dominio.Articulo articulo;

                while (reader.Read())
                {
                    articulo = new Dominio.Articulo();
                    articulo.marca = new Marca();
                    articulo.categoria = new Dominio.Categoria();
                    articulo.idArticulo = reader.GetInt32(0);

                    articulo.nombreArticulo = (string)reader["Nombre"];
                    articulo.descripcion = (string)reader["Descripcion"];
                    int idMarca = (int)reader["IdMarca"];
                    articulo.marca.nombreMarca = marcaService.obtener(idMarca);
                    int idCategoria = (int)reader["IdCategoria"];
                    articulo.categoria.nombreCategoria = categoriaService.obtener(idCategoria);
                    articulo.precio = (decimal)reader["Precio"];
                    if (articulo.idArticulo == Id)
                    {
                        return articulo;
                    }
                }
                //MessageBox.Show("Articulo no encontrado");
                return articulo = null;


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
