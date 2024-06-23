using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PedidoNegocio
    {
        public List<Pedido> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Pedido> lista = new List<Pedido>();
            try
            {
                datos.setConexion("select p.ID_Pedido,p.ID_Usuario, p.Importe,p.Estado,p.cantidad from Pedidos p");
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Pedido pedido = new Pedido();
                    pedido.idPedido = (int)datos.Lector["ID_Pedido"];
                    pedido.idUsuario = (int)datos.Lector["ID_Usuario"];
                    pedido.estado = (int)datos.Lector["Estado"];
                    pedido.importe = (decimal)datos.Lector["Importe"];
                    pedido.cantidad = (int)datos.Lector["Cantidad"];
                    lista.Add(pedido);
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
        public int agregar(Pedido nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("INSERT INTO Pedidos (ID_Usuario, Importe, Estado, Cantidad) output inserted.ID_Pedido VALUES (@ID_Usuario, @Importe, @Estado, @Cantidad);");
                datos.setearParametro("ID_Usuario", nuevo.idUsuario);
                datos.setearParametro("Importe", nuevo.importe);
                datos.setearParametro("@Estado", nuevo.estado);
                datos.setearParametro("@Cantidad", nuevo.cantidad);
                int ultimaFila = datos.ejecutarAccionConOutput();
                return ultimaFila;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public int agregarDetallePedido(DetallePedido nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("INSERT INTO DetallePedidos (ID_Pedido, NombreArtculo, Descripcion,NombreCategoria, NombreMarca, Importe,Cantidad,Talle) output inserted.ID_DetallePedido VALUES (@ID_Pedido, @NombreArtculo, @Descripcion, @NombreCategoria, @NombreMarca, @Importe, @Cantidad, @Talle);");
                datos.setearParametro("ID_Pedido", nuevo.idPedido);
                datos.setearParametro("@NombreArtculo", nuevo.nombreArticulo);
                datos.setearParametro("@Descripcion", nuevo.descripcion);
                datos.setearParametro("@NombreCategoria", nuevo.nombreCategoria);
                datos.setearParametro("@NombreMarca", nuevo.nombreMarca);
                datos.setearParametro("Importe", nuevo.importe);
                datos.setearParametro("@Cantidad", nuevo.cantidad);
                datos.setearParametro("Talle", nuevo.talle);
                ///datos.setearParametro("@Estado", nuevo.estado);
                int ultimaFila = datos.ejecutarAccionConOutput();
                return ultimaFila;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void actualizarEstado(int estado, int idPedido)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("update Pedidos set Estado=@estado where ID_Pedido=@idPedido");
                datos.setearParametro("@estado", estado);
                datos.setearParametro("@idPedido", idPedido);
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

        public List<DetallePedido> listarDetallePedido(int idPedido)
        {
            AccesoDatos datos = new AccesoDatos();
            List<DetallePedido> lista = new List<DetallePedido>();
            try
            {
                datos.setConexion("select * from DetallePedidos where id_Pedido=@idPedido");
                datos.setearParametro("idPedido", idPedido);
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Dominio.DetallePedido detallepedido = new Dominio.DetallePedido();
                    detallepedido.idDetallePedido = (int)datos.Lector["ID_DetallePedido"];
                    detallepedido.idPedido = (int)datos.Lector["ID_Pedido"];
                    detallepedido.nombreArticulo = (string)datos.Lector["NombreArtculo"];
                    detallepedido.descripcion = (string)datos.Lector["Descripcion"];
                    detallepedido.nombreCategoria = (string)datos.Lector["NombreCategoria"];
                    detallepedido.nombreMarca = (string)datos.Lector["NombreMarca"];
                    detallepedido.importe = (decimal)datos.Lector["Importe"];
                    detallepedido.cantidad = (int)datos.Lector["Cantidad"];
                    detallepedido.talle = (string)datos.Lector["Talle"];
                    detallepedido.estado = (int)datos.Lector["Estado"];
                    lista.Add(detallepedido);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<DetallePedido> listarConInnerJoin()
        {
            AccesoDatos datos2 = new AccesoDatos();
            List<DetallePedido> lista = new List<DetallePedido>();
            try
            {
                datos2.setConexion("select p.ID_Pedido,u.NombreUsuario,a.NombreArticulo,m.NombreMarca,dp.Talle,SUM(dp.importe) as 'Importe',SUM(dp.cantidad) as 'Cantidad',p.Estado from pedidos p left join detallePedidos dp on dp.ID_Pedido=p.ID_Pedido inner join Articulos a on a.ID_Articulo=dp.id_Articulo inner join Marcas m on a.ID_Marca=m.ID_Marca inner join Usuarios u on u.ID_Usuario=p.ID_Usuario where dp.Estado=1 group by p.ID_Pedido,u.NombreUsuario,p.Estado,a.NombreArticulo,m.NombreMarca,p.Estado,dp.Talle order by p.ID_Pedido");
                datos2.abrirConexion();
                while (datos2.Lector.Read())
                {
                    DetallePedido detallePedido = new DetallePedido();
                    detallePedido.idPedido = (int)datos2.Lector["ID_Pedido"];
                    detallePedido.nombreCategoria = (string)datos2.Lector["NombreCategora"];
                    detallePedido.nombreArticulo = (string)datos2.Lector["NombreArticulo"];
                    detallePedido.nombreMarca = (string)datos2.Lector["NombreMarca"];
                    detallePedido.talle = (string)datos2.Lector["Talle"];
                    detallePedido.cantidad = (int)datos2.Lector["Cantidad"];
                    detallePedido.importe = (decimal)datos2.Lector["Importe"];
                    detallePedido.estado = (int)datos2.Lector["Estado"];
                    lista.Add(detallePedido);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void actualizarDetallePedido(Articulo articulo, int estado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("update DetallePedidos set Estado=@estado where ID_Pedido=@idPedido and ID_Articulo=@idArticulo and Talle like @talle");
                datos.setearParametro("@estado", estado);
                /*datos.setearParametro("@idPedido", articulo.numeroPedido);*/
                datos.setearParametro("@idArticulo", articulo.idArticulo);
                datos.setearParametro("@talle", articulo.talle);
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

        public void actualizarEnvio(string numeroEnvio, string proveedor, int idPedido)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("update Pedidos set Estado=3,NumeroEnvio=@numeroEnvio, Proveedor=@proveedor where ID_Pedido=@idPedido");
                datos.setearParametro("@numeroEnvio", numeroEnvio);
                datos.setearParametro("@idPedido", idPedido);
                datos.setearParametro("@proveedor", proveedor);
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
    }
}