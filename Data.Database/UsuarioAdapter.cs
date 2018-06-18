using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Business.Entities;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        public List<Usuario> GetAll()
        {
			List<Usuario> listaUsuarios= new List<Usuario>();
			try
			{
				this.OpenConnection();
				SqlCommand cmdUsuarios = new SqlCommand("" +
					"select  id_usuario,nombre_usuario,clave,habilitado," +
					"		 nombre,apellido,email," +
					"		 cambia_clave,id_persona " +
					"from usuarios", SqlConn);
				SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
				while (drUsuarios.Read())
				{
					Usuario oUsr = new Usuario();
					oUsr.ID = (int)drUsuarios["id_usuario"];
					oUsr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
					oUsr.Clave = (string)drUsuarios["clave"];
					oUsr.Nombre = (string)drUsuarios["nombre"];
					oUsr.Apellido = (string)drUsuarios["apellido"];
					oUsr.Email = drUsuarios["email"].ToString();
					oUsr.Habilitado = (bool)drUsuarios["habilitado"];

					Persona oPersona = new Persona();
					oPersona.ID = (int)drUsuarios["id_persona"];
					oUsr.IDPersona = oPersona;
					listaUsuarios.Add(oUsr);
				}
				drUsuarios.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar los usuarios", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaUsuarios;
		}
		public Business.Entities.Usuario GetLoggedUser(string usuario, string contrasenia)
		{
			Usuario oUsr = new Usuario();
			try
			{	
				//Esto reemplazarlo por un SP

				this.OpenConnection();
				SqlCommand cmdUsuarios = new SqlCommand("" +
					"select  id_usuario,nombre_usuario,clave,habilitado," +
					"		 nombre,apellido,email," +
					"		 cambia_clave,id_persona " +
					"from usuarios " +
					"where nombre_usuario=@nombreUsuario and clave= @contrasenia", SqlConn);
				cmdUsuarios.Parameters.Add("@nombreUsuario", SqlDbType.VarChar,50).Value = usuario;
				cmdUsuarios.Parameters.Add("@contrasenia", SqlDbType.VarChar,50).Value = contrasenia;
				SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
				if (drUsuarios != null && drUsuarios.Read())
				{
					oUsr.ID = (int)drUsuarios["id_usuario"];
					oUsr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
					oUsr.Clave = (string)drUsuarios["clave"];
					oUsr.Nombre = (string)drUsuarios["nombre"];
					oUsr.Apellido = (string)drUsuarios["apellido"];
					oUsr.Email = drUsuarios["email"].ToString();
					oUsr.Habilitado = (bool)drUsuarios["habilitado"];
					Persona oPersona = new Persona();
					oPersona.ID = (int)drUsuarios["id_persona"];
					oUsr.IDPersona = oPersona;
				}
				drUsuarios.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al buscar el usuario", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return oUsr;
		}


		public Business.Entities.Usuario GetOne(int ID)
		{
			Usuario oUsr = new Usuario();
			try
			{
				this.OpenConnection();
				SqlCommand cmdUsuarios = new SqlCommand("" +
					"select  id_usuario,nombre_usuario,clave,habilitado," +
					"		 nombre,apellido,email," +
					"		 cambia_clave,id_persona " +
					"from usuarios " +
					"where id_usuario = @id", SqlConn);
				cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = ID;
				SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
				if (drUsuarios != null && drUsuarios.Read())
				{
					oUsr.ID = (int)drUsuarios["id_usuario"];
					oUsr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
					oUsr.Clave = (string)drUsuarios["clave"];
					oUsr.Nombre = (string)drUsuarios["nombre"];
					oUsr.Apellido = (string)drUsuarios["apellido"];
					oUsr.Email = drUsuarios["email"].ToString();
					oUsr.Habilitado = (bool)drUsuarios["habilitado"];
					Persona oPersona = new Persona();
					oPersona.ID = (int)drUsuarios["id_persona"];
					oUsr.IDPersona = oPersona;
				}
				drUsuarios.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al buscar el usuario", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return oUsr;
		}


        public void Delete(int ID)
        {
			try
			{
				this.OpenConnection();
				SqlCommand cmdDeleteUsuario = new SqlCommand("delete from usuarios where id_usuario = @id", SqlConn);
				cmdDeleteUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
				cmdDeleteUsuario.ExecuteNonQuery();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al borrar el usuario", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
		}

		public void Agregar(Usuario usuario)
		{
			try
			{
				this.OpenConnection();
				SqlCommand cmdInsertUsuario= new SqlCommand("" +
					"INSERT [usuarios] ( nombre_usuario, clave, habilitado, nombre, apellido, email, id_persona) " +
					"				 VALUES( @nombre_usuario, @clave, @habilitado, @nombre, @apellido, @email, @id_persona) "+
					" select @@identity AS id_usuario", SqlConn);
				cmdInsertUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar,50).Value = usuario.NombreUsuario;
				cmdInsertUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
				cmdInsertUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
				cmdInsertUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
				cmdInsertUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
				cmdInsertUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
				cmdInsertUsuario.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.IDPersona.ID;
				usuario.ID = Decimal.ToInt32((decimal)cmdInsertUsuario.ExecuteScalar());
				cmdInsertUsuario.ExecuteNonQuery();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al insertar el usuario\n"+ Ex, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
		} 

		public void Update(Usuario usuario)
		{
			try
			{
				this.OpenConnection();
				SqlCommand cmdUpdateUsuario = new SqlCommand("" +
					"UPDATE[dbo].[usuarios] SET					"+
							"nombre_usuario = @nombre_usuario	"+
							",clave = @clave					"+
							",habilitado = @habilitado			"+
							",nombre = @nombre					"+
							",apellido = @apellido				"+
							",email = @email					"+
							",id_persona = @id_persona			"+
					"WHERE id_usuario = @idusuario_aActualizar"
					, SqlConn);
				cmdUpdateUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
				cmdUpdateUsuario.Parameters.Add("@clave", SqlDbType.VarChar).Value = usuario.Clave;
				cmdUpdateUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
				cmdUpdateUsuario.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.Nombre;
				cmdUpdateUsuario.Parameters.Add("@apellido", SqlDbType.VarChar).Value = usuario.Apellido;
				cmdUpdateUsuario.Parameters.Add("@email", SqlDbType.VarChar).Value = usuario.Email;
				cmdUpdateUsuario.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.IDPersona.ID;
				cmdUpdateUsuario.Parameters.Add("@idusuario_aActualizar", SqlDbType.Int).Value = usuario.ID;

				cmdUpdateUsuario.ExecuteNonQuery();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al actualizar el usuario \n"+Ex, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
		}

		public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                this.Agregar(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
				this.Update(usuario);
			}
            usuario.State = BusinessEntity.States.Unmodified;            
        }	
	}
}