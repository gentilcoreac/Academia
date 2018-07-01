using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;


namespace Data.Database
{
	public class PersonaAdapter: Adapter
	{
		public List<Persona> GetAll()
		{
			List<Persona> listaPersonas = new List<Persona>();
			try
			{
				this.OpenConnection();
				SqlCommand cmdPersonas = new SqlCommand("" 
					+"SELECT 												  "
					+"	per.id_persona,										  "
					+"	per.nombre,											  "
					+"	per.apellido,										  "
					+"	per.direccion,										  "
					+"	per.email_personal,									  "
					+"	per.telefono,										  "
					+"	per.fecha_nac,										  "
					+"	per.legajo,											  "
					+"	per.tipo_persona,									  "
					+"	per.id_plan,										  "
					+"	pl.id_plan,											  "
					+"	pl.id_especialidad,									  "
					+"	pl.desc_plan,										  "
					+"	u.id_usuario,										  "
					+"	u.nombre_usuario,									  "
					+"	u.clave,											  "
					+"	u.habilitado,										  "
					+"	u.email_usuario,									  "
					+"	u.cambia_clave,										  "
					+"	u.id_persona										  "
					+"FROM personas per										  "
					+" INNER JOIN usuarios u  ON per.id_persona = u.id_persona "
					+" INNER JOIN planes pl   ON pl.id_plan = per.id_plan      ", SqlConn);
				//////////////////////////////////////////////////////////
				///////SE ESTAN CONSULTANDO TABLAS DE MÁS , REVISAR///////
				////////////////////////////////////////////////////////// 
				SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
				while (drPersonas.Read())
				{
					Persona oPer = new Persona();
					oPer.ID = (int)drPersonas["id_persona"];
					oPer.Apellido = (string)drPersonas["apellido"];
					oPer.Nombre = (string)drPersonas["nombre"];
					oPer.Direccion = (string)drPersonas["direccion"];
					oPer.EmailPersonal = (string)drPersonas["email_personal"];
					oPer.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
					oPer.Legajo = (int)drPersonas["legajo"];
					oPer.Telefono = (string)drPersonas["telefono"];
					
					oPer.TiposPersona = (Persona.TiposPersonas)drPersonas["tipo_persona"];

					Plan oPlan = new Plan();
					oPlan.ID = (int)drPersonas["id_plan"];
					//oPlan.PlanEspecialidad 
					oPlan.Descripcion = (string)drPersonas["desc_plan"];
					oPer.Plan_persona = oPlan;

					Usuario oUsr = new Usuario();
					oUsr.ID = (int)drPersonas["id_usuario"];
					oUsr.NombreUsuario = (string)drPersonas["nombre_usuario"];
					oUsr.Clave = (string)drPersonas["clave"];
					oUsr.Email = drPersonas["email_usuario"].ToString();
					oUsr.Habilitado = (bool)drPersonas["habilitado"];

					oPer.UsuarioPersona = oUsr;

					listaPersonas.Add(oPer);
				}
				drPersonas.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las personas con sus usuarios y plan", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaPersonas;
		} 


		public List<Persona> GetAll(string tipoBusqueda, string valorBuscado)
		{
			List<Persona> listaPersonas = new List<Persona>();
			try
			{
				this.OpenConnection();
				SqlCommand cmdPersonas = null;
				//switch (tipoBusqueda)
				//{
				//	case "ID": break;
				//}

				cmdPersonas = new SqlCommand("" 
					+"SELECT 												  "
					+ "	per.id_persona,										  "
					+ "	per.nombre,											  "
					+ "	per.apellido,										  "
					+ "	per.direccion,										  "
					+ "	per.email_personal,									  "
					+ "	per.telefono,										  "
					+ "	per.fecha_nac,										  "
					+ "	per.legajo,											  "
					+ "	per.tipo_persona,									  "
					+ "	per.id_plan,										  "
					+ "	pl.id_plan,											  "
					+ "	pl.id_especialidad,									  "
					+ "	pl.desc_plan,										  "
					+ "	u.id_usuario,										  "
					+ "	u.nombre_usuario,									  "
					+ "	u.clave,											  "
					+ "	u.habilitado,										  "
					+ "	u.email_usuario,									  "
					+ "	u.cambia_clave,										  "
					+ "	u.id_persona										  "
					+ "FROM personas per									  " 
					+ " INNER JOIN usuarios u  ON per.id_persona = u.id_persona " 
					+ " INNER JOIN planes pl   ON pl.id_plan = per.id_plan     ", SqlConn);
				SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
				while (drPersonas.Read())
				{
					Persona oPer = new Persona();
					oPer.ID = (int)drPersonas["id_persona"];
					oPer.Apellido = (string)drPersonas["apellido"];
					oPer.Nombre = (string)drPersonas["nombre"];
					oPer.Direccion = (string)drPersonas["direccion"];
					oPer.EmailPersonal = (string)drPersonas["email_personal"];
					oPer.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
					oPer.Legajo = (int)drPersonas["legajo"];
					oPer.Telefono = (string)drPersonas["telefono"];
					oPer.TiposPersona = (Persona.TiposPersonas)drPersonas["tipo_persona"];

					Plan oPlan = new Plan();
					oPlan.ID = (int)drPersonas["id_plan"];
					//oPlan.PlanEspecialidad 
					oPlan.Descripcion = (string)drPersonas["desc_plan"];
					oPer.Plan_persona = oPlan;

					Usuario oUsr = new Usuario();
					oUsr.ID = (int)drPersonas["id_usuario"];
					oUsr.NombreUsuario = (string)drPersonas["nombre_usuario"];
					oUsr.Clave = (string)drPersonas["clave"];
					oUsr.Email = drPersonas["email_usuario"].ToString();
					oUsr.Habilitado = (bool)drPersonas["habilitado"];

					oPer.UsuarioPersona = oUsr;

					listaPersonas.Add(oPer);
				}
				drPersonas.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las personas con sus usuarios y plan", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaPersonas;
		}

		public Business.Entities.Persona GetOne(int ID)
		{
			Persona oPer = new Persona();
			try
			{
				this.OpenConnection();
				SqlCommand cmdPersona = new SqlCommand("" 
					+"SELECT 													"
					+ "	per.id_persona,											"
					+ "	per.nombre,												"
					+ "	per.apellido,											"
					+ "	per.direccion,											"
					+ "	per.email_personal,										"
					+ "	per.telefono,											"
					+ "	per.fecha_nac,											"
					+ "	per.legajo,												"
					+ "	per.tipo_persona,										"
					+ "	per.id_plan,											"
					+ "	pl.id_plan,												"
					+ "	pl.id_especialidad,										"
					+ "	pl.desc_plan,											"
					+ "	u.id_usuario,											"
					+ "	u.nombre_usuario,										"
					+ "	u.clave,												"
					+ "	u.habilitado,											"
					+ "	u.email_usuario,										"
					+ "	u.cambia_clave,											"
					+ "	u.id_persona											"
					+ "FROM personas per										"
					+ " INNER JOIN usuarios u  ON per.id_persona = u.id_persona "
					+ " INNER JOIN planes pl   ON pl.id_plan = per.id_plan		" 
					+ " WHERE u.id_persona = @id								", SqlConn);
				cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;
				SqlDataReader drPersona = cmdPersona.ExecuteReader();
				if (drPersona.Read())
				{
					oPer.ID = (int)drPersona["id_persona"];
					oPer.Apellido = (string)drPersona["apellido"];
					oPer.Nombre = (string)drPersona["nombre"];
					oPer.Direccion = (string)drPersona["direccion"];
					oPer.EmailPersonal = (string)drPersona["email_personal"];
					oPer.FechaNacimiento = (DateTime)drPersona["fecha_nac"];					 
					oPer.Legajo = (int)drPersona["legajo"];
					oPer.Telefono = (string)drPersona["telefono"];

					oPer.TiposPersona = (Persona.TiposPersonas)drPersona["tipo_persona"];

					Plan oPlan = new Plan();
					oPlan.ID= (int)drPersona["id_plan"];
					//oPlan.PlanEspecialidad
					oPlan.Descripcion = (string)drPersona["desc_plan"];
					oPer.Plan_persona = oPlan;

					Usuario oUsr = new Usuario();
					oUsr.ID = (int)drPersona["id_usuario"];
					oUsr.NombreUsuario = (string)drPersona["nombre_usuario"];
					oUsr.Clave = (string)drPersona["clave"];
					oUsr.Email = drPersona["email_usuario"].ToString();
					oUsr.Habilitado = (bool)drPersona["habilitado"];

					oPer.UsuarioPersona = oUsr;
				}
				drPersona.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al buscar la persona con su usuario y plan", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return oPer;
		}

		public void Agregar(Persona persona)
		{
			try
			{
				this.OpenConnection();
				SqlCommand cmdInsertUsuario = new SqlCommand(""
					+ " BEGIN TRY    																													"
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
					+ "        ROLLBACK;	THROW;																										"
					+ "END CATCH																														"
					+ " select @@identity AS ID_PERSONA", SqlConn);
				cmdInsertUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
				cmdInsertUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
				cmdInsertUsuario.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
				cmdInsertUsuario.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
				cmdInsertUsuario.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
				cmdInsertUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
				cmdInsertUsuario.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TiposPersona;
				cmdInsertUsuario.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.Plan_persona.ID;/////////////////////
				cmdInsertUsuario.Parameters.Add("@email_personal", SqlDbType.VarChar, 50).Value = persona.EmailPersonal;

				cmdInsertUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = persona.UsuarioPersona.NombreUsuario;
				cmdInsertUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = persona.UsuarioPersona.Clave;
				cmdInsertUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = persona.UsuarioPersona.Habilitado;
				cmdInsertUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.UsuarioPersona.Email;

				persona.ID = Decimal.ToInt32((decimal)cmdInsertUsuario.ExecuteScalar());
			}
			catch (Exception ex)
			{
				throw new Exception("Error al insertar una persona y su correspondiente usuario\n\n",ex);
				//Exception exception = new Exception("Error al insertar una persona");
				//throw exception;
			}
			finally
			{
				this.CloseConnection();
			}
		}

		public void Update(Persona persona)
		{
			try
			{
				this.OpenConnection();
				SqlCommand cmdUpdatePersonas = new SqlCommand(""+
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

				/*legajo , tipo_persona, id_plan no se deberian poder cambiar*/
				cmdUpdatePersonas.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
				cmdUpdatePersonas.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
				cmdUpdatePersonas.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
				cmdUpdatePersonas.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
				cmdUpdatePersonas.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
				cmdUpdatePersonas.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
				cmdUpdatePersonas.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TiposPersona;
				cmdUpdatePersonas.Parameters.Add("@email_personal", SqlDbType.VarChar, 50).Value = persona.EmailPersonal;
				cmdUpdatePersonas.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.Plan_persona.ID;
								 
				cmdUpdatePersonas.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = persona.UsuarioPersona.NombreUsuario;
				cmdUpdatePersonas.Parameters.Add("@clave", SqlDbType.VarChar).Value = persona.UsuarioPersona.Clave;
				cmdUpdatePersonas.Parameters.Add("@habilitado", SqlDbType.Bit).Value = persona.UsuarioPersona.Habilitado;
				cmdUpdatePersonas.Parameters.Add("@email", SqlDbType.VarChar).Value = persona.UsuarioPersona.Email;
				cmdUpdatePersonas.Parameters.Add("@id_persona", SqlDbType.Int).Value = persona.UsuarioPersona.IDPersona.ID;
				cmdUpdatePersonas.Parameters.Add("@idusuario_aActualizar", SqlDbType.Int).Value = persona.UsuarioPersona.ID;
				cmdUpdatePersonas.ExecuteNonQuery();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al actualizar la persona y su usuario \n\n" + Ex, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
		}

		public void Delete(int ID)
		{
			try
			{
				this.OpenConnection();
				SqlCommand cmdDeleteUsuario = new SqlCommand(
				" BEGIN TRY    													"
				+ "	BEGIN TRAN													"
				+ "		delete from usuarios where id_persona = @id_persona		"
				+ "		delete from personas where id_persona = @id_persona		"
				+ "COMMIT TRAN													"
				+ "END TRY														"
				+ "BEGIN CATCH													"
				+ "    IF(@@TRANCOUNT > 0)										"
				+ "        ROLLBACK TRAN										"
				+ "		;THROW;													"
				+ "END CATCH													"
									, SqlConn);
				cmdDeleteUsuario.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ID;
				cmdDeleteUsuario.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID;
				cmdDeleteUsuario.ExecuteNonQuery();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al borrar la persona\n\n", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
		}

		public void Save(Persona persona)
		{
			if (persona.State == BusinessEntity.States.New)
			{
				this.Agregar(persona);
			}
			else if (persona.State == BusinessEntity.States.Deleted)
			{
				this.Delete(persona.ID);
			}
			else if (persona.State == BusinessEntity.States.Modified)
			{
				this.Update(persona);
			}
			persona.State = BusinessEntity.States.Unmodified;
		}
	}
}
