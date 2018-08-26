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
	public class CursoAdapter:Adapter
	{

		public List<Curso> GetAll(string tipoBusqueda, string valorBuscado)
		{
			List<Curso> listaCursos = new List<Curso>();
			try
			{
				this.OpenConnection();
				string consulta_SelectFrom =  "SELECT    cur.id_curso											"
											+ "		, cur.id_materia											"
											+ "		, cur.id_comision											"
											+ "		, cur.anio_calendario										"
											+ "		, cur.cupo													"
											+ "		, mat.desc_materia											"
											+ "		, mat.id_plan				as mat_id_plan					"
											+ "		, com.desc_comision											"
											+ "		, com.anio_especialidad										"
											+ "		, com.id_plan				as com_id_plan					"
											+ "FROM cursos	cur													"
											+ "	INNER JOIN materias		mat	on mat.id_materia=cur.id_materia	"
											+ "	INNER JOIN comisiones	com on com.id_comision=cur.id_comision	";
				SqlCommand cmdCursos = null;
				switch (tipoBusqueda)
				{
					case "Todos":
						cmdCursos = new SqlCommand(consulta_SelectFrom, SqlConn);
						break;

					case "ID_Curso":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE  cur.id_curso = @valorBuscado ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "AñoCalendario":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE  cur.anio_calendario = @valorBuscado ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Cupo":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE cur.cupo = @valorBuscado ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "ID_Materia":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE cur.id_materia = @valorBuscado ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Descripcion_Materia":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE mat.desc_materia like @valorBuscado+'%' ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "ID_Comision":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE cur.id_comision = @valorBuscado ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Descripcion_Comision":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE com.desc_comision like @valorBuscado+'%' ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Año_Especialidad":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " WHERE com.anio_especialidad = @valorBuscado ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;
					case "MisCursos":
						cmdCursos = new SqlCommand(consulta_SelectFrom
												+ " 	INNER JOIN planes		pl	on pl.id_plan=com.id_plan"
												+ "		INNER JOIN personas     per on per.id_plan = pl.id_plan"
												+ "	WHERE  per.id_persona = @valorBuscado ", SqlConn);
						cmdCursos.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;
				}

				SqlDataReader drCursos = cmdCursos.ExecuteReader();
				while (drCursos.Read())
				{
					// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
					Curso oCurso = new Curso();
					oCurso.ID = Convert.ToInt32(drCursos["id_curso"]);
					oCurso.AnioCalendario = Convert.ToInt32(drCursos["anio_calendario"]);
					oCurso.Cupo = Convert.ToInt32(drCursos["cupo"]);

					Materia materia = new Materia();
					materia.ID = Convert.ToInt32(drCursos["id_materia"]);
					materia.Descripcion = (string)drCursos["desc_materia"];
					oCurso.Materia = materia;

					Comision comision = new Comision();
					comision.ID = Convert.ToInt32(drCursos["id_comision"]);
					comision.Descripcion = (string)drCursos["desc_comision"];

					oCurso.Comision = comision;

					listaCursos.Add(oCurso);
				}
				drCursos.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar los Cursos con sus materias y comisiones, " + "mediante la busqueda de " + tipoBusqueda, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaCursos;
		}




		public List<Curso> GetAll()
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
					oCmd.CommandText = "SP_CursosGetAll";

					// una colección. Es más fácil de manipular y controlar 
					List<Curso> listaCursos = new List<Curso>();
					// Ejecutamos el comando y retornamos los valores
					SqlDataReader oReader = oCmd.ExecuteReader();
					using (oReader)
					{
						while (oReader.Read())
						{
							// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
							Curso oCurso = new Curso();
							oCurso.ID= Convert.ToInt32(oReader["id_curso"]);
							oCurso.AnioCalendario = Convert.ToInt32(oReader["anio_calendario"]);
							oCurso.Cupo= Convert.ToInt32(oReader["cupo"]);

							Materia materia = new Materia();
							materia.ID = Convert.ToInt32(oReader["id_materia"]);
							materia.Descripcion = (string)oReader["desc_materia"];
							oCurso.Materia = materia;

							Comision comision = new Comision();
							comision.ID= Convert.ToInt32(oReader["id_comision"]);
							comision.Descripcion = (string)oReader["desc_comision"];

							oCurso.Comision = comision;

							// Agregamos el objeto a la coleccion de resultados
							listaCursos.Add(oCurso);

							oCurso = null;
						}
						// Retornamos los valores encontrados
						return listaCursos;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al recuperar los cursos", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}




		public Curso GetOne(int ID_Curso_Buscado)
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
					oCmd.CommandText = "SP_CursosGetOne";

					// Asignamos el parámetro para el stored procedure
					oCmd.Parameters.AddWithValue("@id_curso", ID_Curso_Buscado);

					Curso oCurso = new Curso(); 

					// Ejecutamos el comando y retornamos los valores
					SqlDataReader oReader = oCmd.ExecuteReader();
					using (oReader)
					{
						if (oReader.Read())
						{
							oCurso.ID = Convert.ToInt32(oReader["id_curso"]);
							oCurso.AnioCalendario = Convert.ToInt32(oReader["anio_calendario"]);
							oCurso.Cupo = Convert.ToInt32(oReader["cupo"]);

							Materia materia = new Materia();
							materia.ID = Convert.ToInt32(oReader["id_materia"]);
							materia.Descripcion = (string)oReader["desc_materia"];
							oCurso.Materia = materia;

							Comision comision = new Comision();
							comision.ID = Convert.ToInt32(oReader["id_comision"]);
							comision.Descripcion = (string)oReader["desc_comision"];

							oCurso.Comision = comision;

						}
						// Retornamos los valores encontrados
						return oCurso;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al recuperar el curso", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}


		public int GetMaxID()
		{
			int id = -1;
			try
			{
				this.OpenConnection();
				SqlCommand sqlCommand = new SqlCommand(""
					+ " SELECT MAX(id_curso) AS MAX_ID				"
					+ " FROM CURSOS									", SqlConn);
				id = (int)sqlCommand.ExecuteScalar();
				return id;
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener el máximo ID de los cursos \n\n" + ex);
			}
		}

		public int Agregar(Curso curso)
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
					oCmd.CommandText = "SP_AgregarCurso";

					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@id_materia", curso.Materia.ID);
					oCmd.Parameters.AddWithValue("@id_comision", curso.Comision.ID);
					oCmd.Parameters.AddWithValue("@anio_calendariO", curso.AnioCalendario);
					oCmd.Parameters.AddWithValue("@cupo", curso.Cupo);

					// Ejecutamos el comando y retornamos el id generado
					return Convert.ToInt32(oCmd.ExecuteScalar());
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al agregar el curso \n\n ", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}


		public void Update(Curso curso)
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
					oCmd.CommandText = "SP_UpdateCurso";

					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@id_curso", curso.ID);
					oCmd.Parameters.AddWithValue("@id_materia", curso.Materia.ID);
					oCmd.Parameters.AddWithValue("@id_comision", curso.Comision.ID);
					oCmd.Parameters.AddWithValue("@anio_calendariO", curso.AnioCalendario);
					oCmd.Parameters.AddWithValue("@cupo", curso.Cupo);

					// Ejecutamos el comando
					oCmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al actualizar el curso \n\n", ex);
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
					oCmd.CommandText = "SP_DeleteCurso";
					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@id_curso", ID);

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


		public void Save(Curso curso)
		{
			if (curso.State == BusinessEntity.States.New)
			{
				this.Agregar(curso);
			}
			else if (curso.State == BusinessEntity.States.Deleted)
			{
				this.Delete(curso.ID);
			}
			else if (curso.State == BusinessEntity.States.Modified)
			{
				this.Update(curso);
			}
			curso.State = BusinessEntity.States.Unmodified;
		}


	}
}
