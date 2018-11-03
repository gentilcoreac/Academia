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



		public List<AlumnoInscripcion> GetAll(string tipoBusqueda, string valorBuscado, int ID_Persona)
		{
			List<AlumnoInscripcion> listaAlumnoInscripcion = new List<AlumnoInscripcion>();
			try
			{
				this.OpenConnection();
				string consulta_SelectFrom = @"SELECT ai.id_inscripcion, ai.id_alumno , ai.id_curso, ai.condicion, ai.nota 
														,cu.cupo,cu.anio_calendario
														,ma.desc_materia
														,com.desc_comision
														,count(id_inscripcion) over(partition by ai.id_curso order by ai.id_curso) as cantidad_inscriptos_actual
												FROM personas per
												INNER JOIN alumnos_inscripciones ai ON ai.id_alumno=per.id_persona									
												INNER JOIN cursos cu	 ON  ai.id_curso=cu.id_curso
												INNER JOIN materias ma	 ON ma.id_materia=cu.id_materia
												INNER JOIN comisiones com ON com.id_comision=cu.id_comision ";
				SqlCommand cmdAlumnoInscripcion = null;
				switch (tipoBusqueda)
				{
					case "Todos":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "ID":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ "WHERE per.id_persona = @id_persona AND ai.id_inscripcion like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "ID_Alumno":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND  ai.id_alumno like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "ID_Curso":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND  ai.id_curso  like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "Condicion":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND ai.condicion like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "Nota_MayorA":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND ai.nota >= @valorBuscado ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.Int).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;
					case "Nota_IgualA":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND ai.nota = @valorBuscado ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.Int).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;
					case "Nota_MenorA":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND ai.nota <= @valorBuscado ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.Int).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "Desc_Materia":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND ma.desc_materia like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "Desc_Comision":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND co.desc_Comision like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdAlumnoInscripcion.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;
						
				}

				SqlDataReader drAlumntoInscripcion = cmdAlumnoInscripcion.ExecuteReader();
				while (drAlumntoInscripcion.Read())
				{

					// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
					AlumnoInscripcion oAlumInscripcion = new AlumnoInscripcion();
					oAlumInscripcion.ID = Convert.ToInt32(drAlumntoInscripcion["id_inscripcion"]);

					Persona persona = new Persona();
					persona.ID = Convert.ToInt32(drAlumntoInscripcion["id_alumno"]);
					oAlumInscripcion.IDAlumno = persona;

					Curso curso = new Curso();
					curso.ID = Convert.ToInt32(drAlumntoInscripcion["id_curso"]);
					curso.Cupo = Convert.ToInt32(drAlumntoInscripcion["cupo"]);
					curso.AnioCalendario = Convert.ToInt32(drAlumntoInscripcion["anio_calendario"]);
					Materia materia = new Materia();
					materia.Descripcion = (string)(drAlumntoInscripcion["desc_materia"]);
					curso.Materia = materia;
					Comision comision = new Comision();
					comision.Descripcion = (string)(drAlumntoInscripcion["desc_comision"]);
					curso.Comision = comision;
					oAlumInscripcion.IDCurso = curso;

					oAlumInscripcion.Condicion = (string)(drAlumntoInscripcion["condicion"]);
					oAlumInscripcion.Nota = Convert.ToInt32(drAlumntoInscripcion["nota"]);

					// Agregamos el objeto a la coleccion de resultados
					listaAlumnoInscripcion.Add(oAlumInscripcion);

					oAlumInscripcion = null;
				}
				drAlumntoInscripcion.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las inscripciones, mediante la busqueda " + tipoBusqueda, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaAlumnoInscripcion;
		}

		public List<AlumnoInscripcion> GetAll(string tipoBusqueda, string valorBuscado)
		{
			List<AlumnoInscripcion> listaAlumnoInscripcion = new List<AlumnoInscripcion>();
			try
			{
				this.OpenConnection();
				string consulta_SelectFrom = @"SELECT ai.id_inscripcion, ai.id_alumno , ai.id_curso, ai.condicion, ai.nota 
														,cu.cupo,cu.anio_calendario
														,ma.desc_materia
														,com.desc_comision
														,count(id_inscripcion) over(partition by ai.id_curso order by ai.id_curso) as cantidad_inscriptos_actual
												FROM personas per
												INNER JOIN alumnos_inscripciones ai ON ai.id_alumno=per.id_persona									
												INNER JOIN cursos cu	 ON  ai.id_curso=cu.id_curso
												INNER JOIN materias ma	 ON ma.id_materia=cu.id_materia
												INNER JOIN comisiones com ON com.id_comision=cu.id_comision";
				SqlCommand cmdAlumnoInscripcion = null;
				switch (tipoBusqueda)
				{
					case "Todos":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE 1=1", SqlConn);
						break;

					case "ID":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ "WHERE   ai.id_inscripcion like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "ID_Alumno":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE    ai.id_alumno like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "ID_Curso":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE    ai.id_curso  like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Condicion":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE   ai.condicion like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Nota":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE   ai.nota like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Desc_Materia":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE   ma.desc_materia like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Desc_Comision":
						cmdAlumnoInscripcion = new SqlCommand(consulta_SelectFrom
												+ " WHERE   co.desc_Comision like @valorBuscado+'%' ", SqlConn);
						cmdAlumnoInscripcion.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

				}

				SqlDataReader drAlumntoInscripcion = cmdAlumnoInscripcion.ExecuteReader();
				while (drAlumntoInscripcion.Read())
				{

					// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
					AlumnoInscripcion oAlumInscripcion = new AlumnoInscripcion();
					oAlumInscripcion.ID = Convert.ToInt32(drAlumntoInscripcion["id_inscripcion"]);

					Persona persona = new Persona();
					persona.ID = Convert.ToInt32(drAlumntoInscripcion["id_alumno"]);
					oAlumInscripcion.IDAlumno = persona;

					Curso curso = new Curso();
					curso.ID = Convert.ToInt32(drAlumntoInscripcion["id_curso"]);
					curso.Cupo = Convert.ToInt32(drAlumntoInscripcion["cupo"]);
					curso.AnioCalendario = Convert.ToInt32(drAlumntoInscripcion["anio_calendario"]);

					Materia materia = new Materia();
					materia.Descripcion = (string)(drAlumntoInscripcion["desc_materia"]);
					curso.Materia = materia;
					Comision comision = new Comision();
					comision.Descripcion = (string)(drAlumntoInscripcion["desc_comision"]);
					curso.Comision = comision;
					oAlumInscripcion.IDCurso = curso;

					oAlumInscripcion.Condicion = (string)(drAlumntoInscripcion["condicion"]);
					oAlumInscripcion.Nota = Convert.ToInt32(drAlumntoInscripcion["nota"]);

					// Agregamos el objeto a la coleccion de resultados
					listaAlumnoInscripcion.Add(oAlumInscripcion);

					oAlumInscripcion = null;
				}
				drAlumntoInscripcion.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las inscripciones, mediante la busqueda " + tipoBusqueda, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaAlumnoInscripcion;
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
					oCmd.Parameters.AddWithValue("@id_inscripcion", inscripcion.ID);
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
				throw new Exception("Error al borrar la inscripcion \n\n ", ex);
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
					+"select COUNT(id_inscripcion) as cant_inscriptos	"
					+" from alumnos_inscripciones						"
					+" where id_curso=@curso_buscado					", SqlConn);
				sqlCommand.Parameters.Add("@curso_buscado", SqlDbType.Int).Value = id_curso;
				cantidad_inscriptos = (int)sqlCommand.ExecuteScalar();
				return cantidad_inscriptos;
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener la cantidad de inscriptos del curso " + id_curso + " \n\n" + ex);
			}
		}


		public int EstaInscripto(int id_curso, int id_alumno, int anio_calendario)
		{
			try
			{
				this.OpenConnection();
				SqlCommand sqlCommand = new SqlCommand(@"
						select count(*)
						from alumnos_inscripciones A
								INNER JOIN personas per	ON per.id_persona=A.id_alumno	
								INNER JOIN planes pl	 ON pl.id_plan=per.id_plan 												
								INNER JOIN comisiones co ON co.id_plan=pl.id_plan
								INNER JOIN cursos cu	 ON cu.id_comision=co.id_comision
						where a.id_curso = @id_Curso and A.id_alumno= @id_alumno and cu.anio_calendario=@anio_calendario", SqlConn);
				sqlCommand.Parameters.Add("@id_Curso", SqlDbType.Int).Value = id_curso;
				sqlCommand.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id_alumno;
				sqlCommand.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = anio_calendario;
				return (int)sqlCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener la cantidad de inscriptos del curso " + id_curso + " \n\n" + ex);
			}
		}


		public int GetMaxID()
		{
			int id = -1;
			try
			{
				this.OpenConnection();
				SqlCommand sqlCommand = new SqlCommand(""
					+ " SELECT MAX(id_inscripcion) AS MAX_ID				"
					+ " FROM alumnos_inscripciones					", SqlConn);
				id = (int)sqlCommand.ExecuteScalar();
				return id;
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener el máximo ID de las inscripciones \n\n" + ex);
			}
		}


		public AlumnoInscripcion GetOne(int ID_Inscripcion_buscada)
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
					oCmd.CommandText = "SP_AlumnoInscripcionesGetOne";

					// Asignamos el parámetro para el stored procedure
					oCmd.Parameters.AddWithValue("@id_inscripcionAlumno", ID_Inscripcion_buscada);

					AlumnoInscripcion oAlumInscripcion = null;

					// Ejecutamos el comando y retornamos los valores
					SqlDataReader oReader = oCmd.ExecuteReader();
					using (oReader)
					{
						while (oReader.Read())
						{
							// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
							//id_inscripcion, i.id_alumno, i.id_curso, i.condicion, i.nota
							oAlumInscripcion = new AlumnoInscripcion();
							oAlumInscripcion.ID = Convert.ToInt32(oReader["id_inscripcion"]);

							Persona alumno = new Persona();
							alumno.ID= (int)oReader["id_alumno"];
							oAlumInscripcion.IDAlumno	= alumno;

							Curso curso = new Curso();
							curso.ID = (int)oReader["id_curso"];
							oAlumInscripcion.IDCurso	= curso;

							oAlumInscripcion.Condicion	= (string)oReader["condicion"];
							oAlumInscripcion.Nota = (int)oReader["nota"];

						}
						// Retornamos los valores encontrados
						return oAlumInscripcion;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al recuperar la inscripcion ", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}


	}
}
