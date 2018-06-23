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
				SqlCommand cmdPersonas = new SqlCommand("" +
					"SELECT 												  "+
					"	per.id_persona,										  "+
					"	per.nombre,											  "+
					"	per.apellido,										  "+
					"	per.direccion,										  "+
					"	per.email_personal,									  "+
					"	per.telefono,										  "+
					"	per.fecha_nac,										  "+
					"	per.legajo,											  "+
					"	per.tipo_persona,									  "+
					"	per.id_plan,										  "+
					"	u.id_usuario,										  "+
					"	u.nombre_usuario,									  "+
					"	u.clave,											  "+
					"	u.habilitado,										  "+
					"	u.email_usuario,									  "+
					"	u.cambia_clave,										  "+
					"	u.id_persona,										  "+
					"	pl.id_plan,											  "+
					"	pl.id_especialidad,									  "+
					"	pl.desc_plan										  "+
					"FROM personas per										  "+
					" INNER JOIN usuarios u  ON per.id_persona = u.id_persona "+
					" INNER JOIN planes pl   ON pl.id_plan = per.id_plan      ", SqlConn);
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
					oPer.EmailPersonal = (string)drPersonas["email"];
					oPer.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
					oPer.Legajo = (int)drPersonas["legajo"];
					oPer.Telefono = (string)drPersonas["telefono"];
					oPer.EmailPersonal = (string)drPersonas["email"];

					Plan oPlan = new Plan();
					oPlan.ID = (int)drPersonas["id_plan"];
					oPlan.IDEspecialidad = (int)drPersonas["id_especialidad"];
					oPlan.Descripcion = (string)drPersonas["desc_plan"];
					oPer.Plan_persona = oPlan;
				}
				drPersonas.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las personas", Ex);
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
				SqlCommand cmdPersona = new SqlCommand("" +
					"SELECT  " +
					"	per.id_persona, per.nombre, per.apellido, per.direccion, per.email_personal, per.telefono, per.fecha_nac, " +
					"	per.legajo, per.tipo_persona," +
					"	pl.id_plan, pl.id_especialidad, pl.desc_plan " +
					"FROM personas per " +
					" INNER JOIN planes pl   ON pl.id_plan = per.id_plan " +
					"WHERE id_persona = @id", SqlConn);
				//SE PODRIA AGREGAR QUE FILTRE POR PLAN TAMBIEN
				cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;
				SqlDataReader drPersona = cmdPersona.ExecuteReader();
				if (drPersona != null && drPersona.Read())
				{
					oPer.ID = (int)drPersona["id_persona"];
					oPer.Apellido = (string)drPersona["apellido"];
					oPer.Nombre = (string)drPersona["nombre"];
					oPer.Direccion = (string)drPersona["direccion"];
					oPer.EmailPersonal = (string)drPersona["email"];
					oPer.FechaNacimiento = (DateTime)drPersona["fecha_nac"];					 
					oPer.Legajo = (int)drPersona["legajo"];
					oPer.Telefono = (string)drPersona["telefono"];
					oPer.EmailPersonal = (string)drPersona["email"];

					Plan oPlan = new Plan();
					oPlan.ID= (int)drPersona["id_plan"];
					oPlan.IDEspecialidad = (int)drPersona["id_especialidad"];
					oPlan.Descripcion = (string)drPersona["desc_plan"];
					oPer.Plan_persona = oPlan;

				}
				drPersona.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al buscar la persona", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return oPer;
		}

	}
}
