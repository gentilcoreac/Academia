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
				SqlCommand cmdUsuarios = new SqlCommand(
					"select  id_usuario,nombre_usuario,clave,habilitado," +
					"		 nombre,apellido,email_usuario," +
					"		 cambia_clave,id_persona " +
					"from usuarios", SqlConn);
				SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
				while (drUsuarios.Read())
				{
					Usuario oUsr = new Usuario();
					oUsr.ID = (int)drUsuarios["id_usuario"];
					oUsr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
					oUsr.Clave = (string)drUsuarios["clave"];
					oUsr.Email = drUsuarios["email_usuario"].ToString();
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
		
		public List<Usuario> GetAll(string tipoBusqueda, string valorBuscado)
		{
			List<Usuario> listaUsuarios = new List<Usuario>();
			try
			{
				this.OpenConnection();
				SqlCommand cmdUsuarios = null;
			

				switch (tipoBusqueda)
				{
					case "ID":
							cmdUsuarios = new SqlCommand(
									"select  id_usuario,nombre_usuario,clave,habilitado," +
									"		 email_usuario," +
									"		 cambia_clave,id_persona " +
									"from usuarios " +
									"where id_usuario like '%'+@id+'%'", SqlConn);
									cmdUsuarios.Parameters.Add("@id", SqlDbType.VarChar,50).Value = int.Parse(valorBuscado);
							break;
					case "Nombre":
							cmdUsuarios = new SqlCommand(
									"select  id_usuario,nombre_usuario,clave,habilitado," +
									"		 email_usuario," +
									"		 cambia_clave,id_persona " +
									"from usuarios " +
									"where nombre like  '%'+@nombre+'%' ", SqlConn);
							cmdUsuarios.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = valorBuscado;
						break;
					case "Apellido":
							cmdUsuarios = new SqlCommand(
									"select  id_usuario,nombre_usuario,clave,habilitado," +
									"		 email_usuario," +
									"		 cambia_clave,id_persona " +
									"from usuarios " +
									"where apellido like '%'+@apellido+'%'", SqlConn);
							cmdUsuarios.Parameters.Add("@apellido", SqlDbType.VarChar,50).Value = valorBuscado;
						break;

					case "Usuario":
							cmdUsuarios = new SqlCommand(
									"select  id_usuario,nombre_usuario,clave,habilitado," +
									"		 email_usuario," +
									"		 cambia_clave,id_persona " +
									"from usuarios " +
									"where nombre_usuario like '%'+@nombre_usuario+'%'", SqlConn);
							cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar,50).Value = valorBuscado;
							break;
					case "Email":
							cmdUsuarios = new SqlCommand(
									"select  id_usuario,nombre_usuario,clave,habilitado," +
									"		 email_usuario," +
									"		 cambia_clave,id_persona " +
									"from usuarios " +
									"where email_usuario like '%'+@email_usuario+'%' ", SqlConn);
							cmdUsuarios.Parameters.Add("@email_usuario", SqlDbType.VarChar,50).Value = valorBuscado;
						break;
					case "Habilitado":
							cmdUsuarios = new SqlCommand(
									"select  id_usuario,nombre_usuario,clave,habilitado," +
									"		 email_usuario," +
									"		 cambia_clave,id_persona " +
									"from usuarios " +
									"where habilitado like '%'+@habilitado+'%' ", SqlConn);
							cmdUsuarios.Parameters.Add("@habilitado", SqlDbType.VarChar,50).Value = valorBuscado;
						break;
					case "Todos":
							cmdUsuarios = new SqlCommand(
									"select  id_usuario,nombre_usuario,clave,habilitado," +
									"		 email_usuario," +
									"		 cambia_clave,id_persona " +
									"from usuarios ", SqlConn);
						break;
					default:
							break;
				}
				SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
				while (drUsuarios!=null && drUsuarios.Read())
				{
					Usuario oUsr = new Usuario();
					oUsr.ID = (int)drUsuarios["id_usuario"];
					oUsr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
					oUsr.Clave = (string)drUsuarios["clave"];
					oUsr.Email = drUsuarios["email_usuario"].ToString();
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
					"		 email_usuario," +
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
					oUsr.Email = drUsuarios["email_usuario"].ToString();
					oUsr.Habilitado = (bool)drUsuarios["habilitado"];
					Persona oPersona = new Persona();
					oPersona.ID = (int)drUsuarios["id_persona"];
					oUsr.IDPersona = oPersona;
				}
				drUsuarios.Close();
			}
			catch (SqlException Ex)
			{
				Exception Excepcion = new Exception("Error al buscar el usuario\n", Ex);
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
					"		 email_usuario," +
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
					oUsr.Email = drUsuarios["email_usuario"].ToString();
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

		/// <summary>
		///	Borra sólo usuario //////////////////////////////////////REVISAR SI QUEDO DE MAS EL DELETE,¿¿EL OTRO SI ES NULL FUNCA??
		/// </summary>
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

		/// <summary>
		///	Borra usuario y persona
		/// </summary>
		public void Delete(Usuario usuario)		
		{
			try
			{
				this.OpenConnection();
				SqlCommand cmdDeleteUsuario = new SqlCommand(""+
									  " BEGIN TRY    												"
									+ "	BEGIN TRAN													"
									+ "		delete from usuarios where id_usuario = @id_usuario		"
									+ "		delete from personas where id_persona = @id_persona		"
									+ "    COMMIT TRAN												"
									+ "END TRY														"
									+ "BEGIN CATCH													"
									+ "    IF(@@TRANCOUNT > 0)										"
									+ "        ROLLBACK TRAN;										"
									+ "    THROW; -- raise error to the client						"
									+ "END CATCH													"
									, SqlConn);
				cmdDeleteUsuario.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuario.ID;
				cmdDeleteUsuario.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.IDPersona.ID;
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
					  " BEGIN TRY    																													"
					+ "	BEGIN TRAN																														"
					+ "			INSERT personas( nombre, apellido, direccion, telefono, fecha_nac, legajo, tipo_persona, id_plan, email_personal)		"
					+ "				   VALUES( @nombre, @apellido, @direccion, @telefono, @fecha_nac, @legajo, @tipo_persona, @id_plan, @email_personal)"
					+ "			DECLARE @ID_PERSONA_RECIEN_INSERTADO AS INT																				"
					+ "			SELECT @ID_PERSONA_RECIEN_INSERTADO =@@IDENTITY																			"
					+ "			INSERT [usuarios]( nombre_usuario,  clave,  habilitado,  email_usuario, id_persona) 									"
					+ "				       VALUES( @nombre_usuario, @clave, @habilitado, @email,		@ID_PERSONA_RECIEN_INSERTADO) 					"
					+ "    COMMIT TRAN																													"
					+ "END TRY																															"
					+ "BEGIN CATCH																														"
					+ "    IF(@@TRANCOUNT > 0)																											"
					+ "        ROLLBACK;	THROW;																											"
					+ "END CATCH																														"
					+" select @@identity AS id_usuario", SqlConn);

				cmdInsertUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Nombre;
				cmdInsertUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Apellido;
				cmdInsertUsuario.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Direccion;
				cmdInsertUsuario.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Telefono;
				cmdInsertUsuario.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = usuario.IDPersona.FechaNacimiento;
				cmdInsertUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = usuario.IDPersona.Legajo;
				cmdInsertUsuario.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = usuario.IDPersona.TiposPersona;
				cmdInsertUsuario.Parameters.Add("@email_personal", SqlDbType.VarChar, 50).Value = usuario.IDPersona.EmailPersonal;
				cmdInsertUsuario.Parameters.Add("@id_plan", SqlDbType.Int).Value = usuario.IDPersona.Plan_persona.ID;

				cmdInsertUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar,50).Value = usuario.NombreUsuario;
				cmdInsertUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
				cmdInsertUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
				cmdInsertUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
				usuario.ID = Decimal.ToInt32((decimal)cmdInsertUsuario.ExecuteScalar());
				//cmdInsertUsuario.ExecuteNonQuery();
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
						  "BEGIN TRY    										"
						+ "	BEGIN TRAN											"
						+ "		UPDATE personas	SET								"
						+ "			 nombre	=@nombre							"
						+ "			,apellido =@apellido						"
						+ "			,direccion =@direccion						"
						+ "			,telefono =@telefono						"
						+ "			,fecha_nac =@fecha_nac						"
						+ "			,legajo =@legajo							"
						+ "			,tipo_persona =@tipo_persona				"
						+ "			,id_plan =@id_plan							"
						+ "			,email_personal =@email_personal			"
						+ "		WHERE id_persona=@id_persona					"
						+ "		UPDATE[dbo].[usuarios] SET						"
						+ "			nombre_usuario = @nombre_usuario			"
						+ "			,clave = @clave								"
						+ "			,habilitado = @habilitado					"
						+ "			,email_usuario = @email						"
						+ "			,id_persona = @id_persona					"
						+ "		WHERE id_usuario = @idusuario_aActualizar		"
						+ "    COMMIT TRAN										"
						+ "END TRY												"
						+ "BEGIN CATCH											"
						+ "    IF(@@TRANCOUNT > 0)								"
						+ "        ROLLBACK TRAN								"
						+ "		;THROW;											"
						+ "END CATCH											"
					, SqlConn);

				cmdUpdateUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Nombre;
				cmdUpdateUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Apellido;
				cmdUpdateUsuario.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Direccion;
				cmdUpdateUsuario.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.IDPersona.Telefono;
				cmdUpdateUsuario.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = usuario.IDPersona.FechaNacimiento;
				cmdUpdateUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = usuario.IDPersona.Legajo;
				cmdUpdateUsuario.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = usuario.IDPersona.TiposPersona;
				cmdUpdateUsuario.Parameters.Add("@email_personal", SqlDbType.VarChar, 50).Value = usuario.IDPersona.EmailPersonal;
				cmdUpdateUsuario.Parameters.Add("@id_plan", SqlDbType.Int).Value = usuario.IDPersona.Plan_persona.ID;

				cmdUpdateUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
				cmdUpdateUsuario.Parameters.Add("@clave", SqlDbType.VarChar).Value = usuario.Clave;
				cmdUpdateUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
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
                this.Delete(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
				this.Update(usuario);
			}
            usuario.State = BusinessEntity.States.Unmodified;            
        }	
	}
}