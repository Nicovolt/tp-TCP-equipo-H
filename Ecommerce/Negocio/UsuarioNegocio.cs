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
                //Datos.setConexion("select ID_Usuario,TipoUser from Usuarios where usuario = @user AND pass = @pass");
                Datos.setConexion("select * from Usuarios where NombreUsuario = @user AND Pass = @pass");

                Datos.setearParametro("@user", usuario.User);
                Datos.setearParametro("@pass", usuario.Pass);
                Datos.abrirConexion();

                while (Datos.Lector.Read())
                {
                    usuario.idUsuario = (int)Datos.Lector["ID_Usuario"];
                    usuario.RolUsuario = (int)(Datos.Lector["ID_Rol"]) == 2 ? RolUsuario.admin : RolUsuario.normal;
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

        public bool Registrarse(Usuario usuario1)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (!existeUsuario(usuario1.User))
                {
                    datos.setConexion("insert into Usuarios(NombreUsuario,Pass,ID_Rol, Nombre, Apellido, Mail, Telefono) output inserted.ID_Usuario values(@usuarionuevo,@pass,1,@nombre,@apellido,@mail,@telefono)");

                   // datos.setConexion("insert into Usuarios(User,Pass,ID_Rol, Nombre, Apellido, Mail, Telefono,) output inserted.ID_Usuario values(@usuarionuevo,@pass,1,@nombre,@apellido,mail,telefono)");
                    datos.setearParametro("@usuarionuevo", usuario1.User);
                    datos.setearParametro("@pass", usuario1.Pass);
                    datos.setearParametro("@nombre", usuario1.Nombre);
                    datos.setearParametro("@apellido", usuario1.Apellido);
                    datos.setearParametro("@mail", usuario1.Mail);
                    datos.setearParametro("@telefono", usuario1.Telefono);
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





        public void resetContraseña(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setConexion("update Usuarios set Pass=@NewPass where NombreUsuario=@NombreUsuario and Pass = @OldPass");
                datos.setearParametro("@NombreUsuario", user.User);
                datos.setearParametro("@NewPass", user.PassNew);
                datos.setearParametro("@OldPass", user.Pass);
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


        public void resetUsuario(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setConexion("update Usuarios set NombreUsuario=@NewUser where NombreUsuario=@NombreUsuario and Pass=@pass");
                datos.setearParametro("@NombreUsuario", user.User);
                datos.setearParametro("@NewUser", user.UserNew);
                datos.setearParametro("@pass", user.Pass);
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




        public void resetGmail(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setConexion("update Usuarios set Mail=@NewMail where NombreUsuario=@NombreUsuario and Mail = @OldMail and Pass=@pass");
                datos.setearParametro("@NombreUsuario", user.User);
                datos.setearParametro("@NewMail", user.MailNew);
                datos.setearParametro("@OldMail", user.Mail);
                datos.setearParametro("@pass", user.Pass);
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


        /*
        

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

       
        */
    }
}
