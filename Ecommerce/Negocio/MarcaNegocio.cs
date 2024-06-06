using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Marca> listarMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            datos.setConexion("SELECT * FROM Marcas");
            try
            {
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.idMarca = (int)datos.Lector["ID_Marca"];
                    marca.nombreMarca = (string)datos.Lector["NombreMarca"];
                    listaMarcas.Add(marca);
                }
                return listaMarcas;
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

        public Marca listarMarcaPorId(int idMarca)
        {
            try
            {
                datos.setConexion("select * from marcas where ID_Marca=@idMarca");
                datos.setearParametro("@idMarca", idMarca);
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.idMarca = (int)datos.Lector["ID_Marca"];
                    marca.nombreMarca = (string)datos.Lector["NombreMarca"];
                    return marca;
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

        public void modificarMarca(int idMarca, string nombreMarca)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("update Marcas set NombreMarca=@nombreMarca where ID_Marca=@idMarca");
                datos2.setearParametro("@nombreMarca", nombreMarca);
                datos2.setearParametro("@idMarca", idMarca);
                datos2.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos2.cerrarConexion(); }
        }

        public void agregarMarca(string nuevaMarca)
        {
            AccesoDatos datos2 = new AccesoDatos();
            try
            {
                datos2.setConexion("insert into Marcas(NombreMarca) values(@nuevaMarca)");
                datos2.setearParametro("@nuevaMarca", nuevaMarca);
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
