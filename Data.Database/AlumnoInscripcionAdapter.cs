using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
	public class AlumnoInscripcionAdapter:Adapter
	{

		public List<AlumnoInscripcion> GetAll(int ID_Alumno)
		{
			try
			{
				this.OpenConnection();

				SqlCommand oCmd = new SqlCommand();
				using (oCmd)
				{
					//asignamos la conexion de trabajo
					oCmd.Connection = SqlConn;

					//utilizamos stored procedures
					oCmd.CommandType = CommandType.StoredProcedure;

					//le indicamos cual stored procedure utilizar
					oCmd.CommandText = "SP_Alumnos_Inscripciones_GetAll";

					// Asignamos el parámetro para el stored procedure
					oCmd.Parameters.AddWithValue("@id_persona", ID_Alumno);


					// una colección. Es más fácil de manipular y controlar 
					List<AlumnoInscripcion> listaAlumnoInscripcion = new List<AlumnoInscripcion>();
					// Ejecutamos el comando y retornamos los valores
					SqlDataReader oReader = oCmd.ExecuteReader();
					using (oReader)
					{
						while (oReader.Read())
						{

							// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
							AlumnoInscripcion oAlumInscripcion = new AlumnoInscripcion();
							oAlumInscripcion.ID = Convert.ToInt32(oReader["id_inscripcion"]);

							Persona persona = new Persona();
							persona.ID = Convert.ToInt32(oReader["id_alumno"]);
							oAlumInscripcion.IDAlumno = persona;

							Curso curso = new Curso();
							curso.ID = Convert.ToInt32(oReader["id_curso"]);
							Materia materia = new Materia();
							materia.Descripcion = (string)(oReader["desc_materia"]);
							curso.Materia = materia;
							Comision comision = new Comision();
							comision.Descripcion = (string)(oReader["desc_comision"]);
							curso.Comision = comision;
							oAlumInscripcion.IDCurso = curso;

							oAlumInscripcion.Condicion = (string)(oReader["condicion"]);
							oAlumInscripcion.Nota = Convert.ToInt32(oReader["nota"]);

							// Agregamos el objeto a la coleccion de resultados
							listaAlumnoInscripcion.Add(oAlumInscripcion);

							oAlumInscripcion = null;
						}
						// Retornamos los valores encontrados
						return listaAlumnoInscripcion;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al recuperar el listado", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}


		public int Agregar(AlumnoInscripcion inscripcion)
		{
			try
			{
				this.OpenConnection();

				SqlCommand oCmd = new SqlCommand();
				using (oCmd)
				{
					//asignamos la conexion de trabajo
					oCmd.Connection = SqlConn;

					//utilizamos stored procedures
					oCmd.CommandType = CommandType.StoredProcedure;

					//el indicamos cual stored procedure utilizar
					oCmd.CommandText = "SP_AgregarInscripcionAlumno";

					// Le asignamos los parámetros para el stored procedure
					oCmd.Parameters.AddWithValue("@id_alumno", inscripcion.IDAlumno.ID);
					oCmd.Parameters.AddWithValue("@id_curso", inscripcion.IDCurso.ID);
					oCmd.Parameters.AddWithValue("@condicion", inscripcion.Condicion);
					oCmd.Parameters.AddWithValue("@nota", inscripcion.Nota);		

					// Ejecutamos el comando y retornamos el id generado
					return Convert.ToInt32(oCmd.ExecuteScalar());
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al agregar la inscripcion \n\n ", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}


		public void Update(AlumnoInscripcion inscripcion)
		{
			try
			{
				this.OpenConnection();

				SqlCommand oCmd = new SqlCommand();
				using (oCmd)
				{
					//asignamos la conexion de trabajo
					oCmd.Connection = SqlConn;

					//utilizamos stored procedures
					oCmd.CommandType = CommandType.StoredProcedure;

					//el indicamos cual stored procedure utilizar
					oCmd.CommandText = "SP_UpdateInscripcionAlumno";

					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@id_curso", inscripcion.ID);
					oCmd.Parameters.AddWithValue("@id_alumno", inscripcion.IDAlumno.ID);
					oCmd.Parameters.AddWithValue("@id_curso", inscripcion.IDCurso.ID);
					oCmd.Parameters.AddWithValue("@condicion", inscripcion.Condicion);
					oCmd.Parameters.AddWithValue("@nota", inscripcion.Nota);

					// Ejecutamos el comando
					oCmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al actualizar la inscripcion \n\n", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}

		public void Delete(int ID)
		{
			try
			{
				this.OpenConnection();

				SqlCommand oCmd = new SqlCommand();
				using (oCmd)
				{
					//asignamos la conexion de trabajo
					oCmd.Connection = SqlConn;

					//utilizamos stored procedures
					oCmd.CommandType = CommandType.StoredProcedure;

					//el indicamos cual stored procedure utilizar
					oCmd.CommandText = "SP_DeleteInscripcionAlumno";
					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@id_inscripcion", ID);

					// Ejecutamos el comando
					oCmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al borrar el curso \n\n ", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}


		public void Save(AlumnoInscripcion inscripcion)
		{
			if (inscripcion.State == BusinessEntity.States.New)
			{
				this.Agregar(inscripcion);
			}
			else if (inscripcion.State == BusinessEntity.States.Deleted)
			{
				this.Delete(inscripcion.ID);
			}
			else if (inscripcion.State == BusinessEntity.States.Modified)
			{
				this.Update(inscripcion);
			}
			inscripcion.State = BusinessEntity.States.Unmodified;
		}


		public int GetCantInscriptos(int id_curso)
		{
			int cantidad_inscriptos = 0;
			try
			{
				this.OpenConnection();
				SqlCommand sqlCommand = new SqlCommand(""
					+"select COUNT(id_inscripcion) as cant_inscriptos"
					+"from alumnos_inscripciones					 "
					+"where id_curso=@curso_buscado					 ", SqlConn);
				sqlCommand.Parameters.Add("@curso_buscado", SqlDbType.VarChar, 50).Value = id_curso;
				cantidad_inscriptos = (int)sqlCommand.ExecuteScalar();
				return cantidad_inscriptos;
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener la cantidad de inscriptos del curso " + id_curso + " \n\n" + ex);
			}
		}


	}
}
