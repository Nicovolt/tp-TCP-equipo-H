using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public List<Categoria> listarCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            datos.setConexion("select * from vw_listarCategorias");
            try
            {
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.idCategoria = (int)datos.Lector["ID_Categoria"];
                    categoria.nombreCategoria = (string)datos.Lector["NombreCategoria"];
                    listaCategorias.Add(categoria);
                }
                return listaCategorias;
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

        public Categoria listarCaterogiaPorId(int idCategoria)
        {
            try
            {
                datos.setConexion("select * from categorias where ID_Categoria=@idCategoria");
                datos.setearParametro("@idCategoria", idCategoria);
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.idCategoria = (int)datos.Lector["ID_Categoria"];
                    categoria.nombreCategoria = (string)datos.Lector["NombreCategoria"];
                    return categoria;
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

        public void modificarCategoria(int idCategoria, string nombreCategoria)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("update Categorias set NombreCategoria=@nombreCategoria where ID_Categoria=@idCat");
                datos2.setearParametro("@nombreCategoria", nombreCategoria);
                datos2.setearParametro("@idCat", idCategoria);
                datos2.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos2.cerrarConexion(); }
        }

        public void agregarCategoria(string nuevaCat)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("insert into Categorias(NombreCategoria) values(@nuevaCat)");
                datos2.setearParametro("@nuevaCat", nuevaCat);
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
    }
}
