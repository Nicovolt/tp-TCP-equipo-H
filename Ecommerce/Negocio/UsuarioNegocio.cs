using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {





        public bool login(Usuario usuario)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setConexion("select ID_Usuario,TipoUser from Usuarios where usuario = @user AND pass = @pass");
                Datos.setearParametro("@user", usuario.User);
                Datos.setearParametro("@pass", usuario.Pass);
                Datos.abrirConexion();

                while (Datos.Lector.Read())
                {
                    usuario.idUsuario = (int)Datos.Lector["ID_Usuario"];
                    usuario.RolUsuario = (int)(Datos.Lector["TipoUser"]) == 2 ? RolUsuario.admin : RolUsuario.normal;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.cerrarConexion(); 
            }
        }

        /*
        public int Logearse(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConexion("SELECT ID_Usuario, Nombre, Apellido, Mail, Telefono, FechaNacimiento, ID_Rol,1 FROM Usuarios WHERE NombreUsuario=@nombreUsuario and Pass=@pass");
                datos.setearParametro("@nombreUsuario", usuario.nombreUsuario);
                datos.setearParametro("@pass", usuario.Pass);
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    if (usuario.rolUsuario == null)
                    {
                        usuario.rolUsuario = new RolUsuario();
                    }

                    usuario.rolUsuario.idRol = (int)datos.Lector["ID_Rol"];
                    usuario.idUsuario = (int)datos.Lector["ID_Usuario"];

                    // Comprobar el rol aquí, ajusta según tus necesidades
                    if (usuario.rolUsuario.idRol > 0)
                    {
                        if (usuario.rolUsuario.idRol == 1)
                        { return 1; }
                        else { return 2; }
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }


        public bool Registrarse(Usuario usuario1)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (!existeUsuario(usuario1.nombreUsuario))
                {
                    datos.setConexion("insert into Usuarios(NombreUsuario,Pass,ID_Rol) output inserted.ID_Usuario values(@usuarionuevo,@pass,2)");
                    datos.setearParametro("@usuarionuevo", usuario1.nombreUsuario);
                    datos.setearParametro("@pass", usuario1.Pass);
                    datos.abrirConexion();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public bool existeUsuario(string nombreUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("select COUNT(NombreUsuario) as 'Cantidad' from usuarios where NombreUsuario like @nombreUsuario");
                datos.setearParametro("@nombreUsuario", nombreUsuario);
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    if ((int)datos.Lector["Cantidad"] == 1)
                    {
                        return true;
                    }
                }
                return false;
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

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            datos.setConexion("select * from usuarios where ID_Rol=2 and Estado=1");
            try
            {
                datos.abrirConexion();
                while (datos.Lector.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.idUsuario = (int)datos.Lector["ID_Usuario"];
                    usuario.nombreUsuario = (string)datos.Lector["NombreUsuario"];
                    usuario.rolUsuario = new RolUsuario();
                    usuario.rolUsuario.idRol = (int)datos.Lector["ID_Rol"];
                    lista.Add(usuario);
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

        public void resetContraseña(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("update Usuarios set Pass='nuevaClave' where ID_Usuario=@idUsuario");
                datos.setearParametro("@idUsuario", idUsuario);
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

        public void resetContraseña2(string nombreUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConexion("update Usuarios set Pass='nuevaClave' where NombreUsuario=@nombreUsuario");
                datos.setearParametro("@nombreUsuario", nombreUsuario);
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
        */
    }
}
