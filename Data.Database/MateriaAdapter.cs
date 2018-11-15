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
	public class MateriaAdapter: Adapter
	{
		public List<Materia> GetAll(string tipoBusqueda, string valorBuscado)
		{
			List<Materia> listaMaterias = new List<Materia>();
			try
			{
				this.OpenConnection();
				string consulta_SelectFrom = @"	SELECT m.id_materia, m.desc_materia, m.hs_semanales, m.hs_totales		
																	,p.id_plan, p.desc_plan		
																,esp.id_especialidad, esp.desc_especialidad								
												FROM [dbo].[materias] m													
													INNER JOIN planes p ON p.id_plan=m.id_plan						
													inner join especialidades esp on esp.id_especialidad=p.id_especialidad ";
				SqlCommand cmdMaterias = null;
				switch (tipoBusqueda)
				{
					case "Todos":
						cmdMaterias = new SqlCommand(consulta_SelectFrom, SqlConn);
						break;

					case "ID":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE m.id_materia like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Materia_Descripcion":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE  m.desc_materia like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "HorasSemanales":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE m.hs_semanales like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "HorasTotales":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE m.hs_totales like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Plan_ID":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE m.id_plan like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;

					case "Plan_Descripcion":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE p.desc_plan like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						break;
				}

				SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
				while (drMaterias.Read())
				{
					Materia oMat = new Materia();
					oMat.ID = (int)drMaterias["id_materia"];
					oMat.Descripcion = (string)drMaterias["desc_materia"];
					oMat.HSSemanales = (int)drMaterias["hs_semanales"];
					oMat.HSTotales = (int)drMaterias["hs_totales"];

					Plan oPlan = new Plan();
					oPlan.ID = (int)drMaterias["id_plan"];
                    oPlan.PlanEspecialidad = new Especialidad();
                    oPlan.PlanEspecialidad.ID = (int)drMaterias["id_especialidad"];
                    oPlan.PlanEspecialidad.Descripcion = (string)drMaterias["desc_especialidad"];
                    oPlan.Descripcion = (string)drMaterias["desc_plan"];
					oMat.Plan = oPlan;

					listaMaterias.Add(oMat);
				}
				drMaterias.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las materias con su plan, " + "mediante la busqueda " + tipoBusqueda, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaMaterias;
		}



		public List<Materia> GetAll(string tipoBusqueda, string valorBuscado,  int ID_Persona)
		{
			List<Materia> listaMaterias = new List<Materia>();
			try
			{
				this.OpenConnection();
				string consulta_SelectFrom = @" SELECT m.id_materia, m.desc_materia, m.hs_semanales, m.hs_totales
																	,p.id_plan, p.desc_plan							
																	,per.id_persona							
																	,esp.id_especialidad, esp.desc_especialidad		
												FROM [dbo].[materias] m											
													INNER JOIN planes p ON p.id_plan=m.id_plan						
													INNER JOIN personas per ON per.id_plan=p.id_plan	
													inner join especialidades esp on esp.id_especialidad=p.id_especialidad ";
				SqlCommand cmdMaterias = null;
				switch (tipoBusqueda)
				{
					case "Todos":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona", SqlConn);
						cmdMaterias.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "ID":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND m.id_materia like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdMaterias.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "Materia_Descripcion":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND  m.desc_materia like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdMaterias.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "HorasSemanales":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND m.hs_semanales like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdMaterias.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "HorasTotales":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND m.hs_totales like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdMaterias.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "Plan_ID":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND m.id_plan like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdMaterias.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;

					case "Plan_Descripcion":
						cmdMaterias = new SqlCommand(consulta_SelectFrom
												+ " WHERE per.id_persona = @id_persona AND p.desc_plan like @valorBuscado+'%' ", SqlConn);
						cmdMaterias.Parameters.Add("@valorBuscado", SqlDbType.VarChar, 10).Value = valorBuscado;
						cmdMaterias.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID_Persona;
						break;			
				}

				SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
				while (drMaterias.Read())
				{
					Materia oMat = new Materia();
					oMat.ID= (int)drMaterias["id_materia"];
					oMat.Descripcion = (string)drMaterias["desc_materia"];
					oMat.HSSemanales = (int)drMaterias["hs_semanales"];
					oMat.HSTotales = (int)drMaterias["hs_totales"];

					Plan oPlan = new Plan();
					oPlan.ID = (int)drMaterias["id_plan"];
                    oPlan.PlanEspecialidad = new Especialidad();
                    oPlan.PlanEspecialidad.ID = (int)drMaterias["id_especialidad"];
                    oPlan.PlanEspecialidad.Descripcion = (string)drMaterias["desc_especialidad"];
                    oPlan.Descripcion = (string)drMaterias["desc_plan"];
					oMat.Plan = oPlan;

					listaMaterias.Add(oMat);
				}
				drMaterias.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las materias con su plan, "+"mediante la busqueda "+ tipoBusqueda, Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaMaterias;
		}



		public List<Materia> GetAll()
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
					oCmd.CommandText = "SP_MateriasGetAll";

					// una colección. Es más fácil de manipular y controlar 
					List<Materia> listaMateria = new List<Materia>();
					// Ejecutamos el comando y retornamos los valores
					SqlDataReader oReader = oCmd.ExecuteReader();
					using (oReader)
					{
						while (oReader.Read())
						{
							// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
							Materia oMateria = new Materia();
							oMateria.ID = Convert.ToInt32(oReader["id_materia"]);
							oMateria.Descripcion = (string)oReader["desc_materia"];
							oMateria.HSSemanales = (int)oReader["hs_semanales"];
							oMateria.HSTotales = (int)oReader["hs_totales"];
							Plan oPlan = new Plan();
							oPlan.ID = (int)oReader["id_plan"];
                            oPlan.PlanEspecialidad = new Especialidad();
                            oPlan.PlanEspecialidad.ID = (int)oReader["id_especialidad"];
                            oPlan.PlanEspecialidad.Descripcion = (string)oReader["desc_especialidad"];
                            oPlan.Descripcion = (string)oReader["desc_plan"];
							oMateria.Plan = oPlan; 

							// Agregamos el objeto a la coleccion de resultados
							listaMateria.Add(oMateria);

							oMateria = null;
						}
						// Retornamos los valores encontrados
						return listaMateria;
					}
				}
			}
			catch(Exception ex)
			{
				throw new Exception("Error al recuperar las materias ", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}	
		}


		public Materia GetOne(int ID_Materia_buscado)
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
					oCmd.CommandText = "SP_MateriasGetOne";

					// Asignamos el parámetro para el stored procedure
					oCmd.Parameters.AddWithValue("@id_materia", ID_Materia_buscado);

					Materia oMateria = null;

					// Ejecutamos el comando y retornamos los valores
					SqlDataReader oReader = oCmd.ExecuteReader();
					using (oReader)
					{
						while (oReader.Read())
						{
							// Si existe algun valor, creamos el objeto y lo almacenamos en la colección
							oMateria = new Materia();
							oMateria.ID = Convert.ToInt32(oReader["id_materia"]);
							oMateria.Descripcion = (string)oReader["desc_materia"];
							oMateria.HSSemanales = (int)oReader["hs_semanales"];
							oMateria.HSTotales = (int)oReader["hs_totales"];
							Plan oPlan = new Plan();
							oPlan.ID = (int)oReader["id_plan"];
							oPlan.Descripcion = (string)oReader["desc_plan"];
							oMateria.Plan = oPlan;
						}
						// Retornamos los valores encontrados
						return oMateria;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al recuperar la materia ", ex);
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
					+ " SELECT MAX(id_materia) AS MAX_ID				"
					+ " FROM MATERIAS									", SqlConn);
				id = (int)sqlCommand.ExecuteScalar();
				return id;
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener el máximo ID de las materias \n\n" + ex);
			}
		}




		public int Agregar(Materia materia)
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
					oCmd.CommandText = "SP_AgregarMateria";

					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@desc_materia", materia.Descripcion);
					oCmd.Parameters.AddWithValue("@hs_semanales", materia.HSSemanales);
					oCmd.Parameters.AddWithValue("@hs_totales", materia.HSTotales);
					oCmd.Parameters.AddWithValue("@id_plan", materia.Plan.ID);

					// Ejecutamos el comando y retornamos el id generado
					return Convert.ToInt32(oCmd.ExecuteScalar());
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al agregar la materia \n\n", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}


		public void Update(Materia materia)
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
					oCmd.CommandText = "SP_UpdateMateria";

					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@id_materia", materia.ID);
					oCmd.Parameters.AddWithValue("@desc_materia", materia.Descripcion);
					oCmd.Parameters.AddWithValue("@hs_semanales", materia.HSSemanales);
					oCmd.Parameters.AddWithValue("@hs_totales", materia.HSTotales);
					oCmd.Parameters.AddWithValue("@id_plan", materia.Plan.ID);

					// Ejecutamos el comando
					oCmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al actualizar la materia \n\n", ex);
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
					oCmd.CommandText = "SP_DeleteMateria";
					// Le asignamos los parámetros para el stored procedure
					// Los valores viene en el parámetro item del procedimiento
					oCmd.Parameters.AddWithValue("@id_materia", ID);

					// Ejecutamos el comando
					oCmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al borrar la materia \n\n ", ex);
			}
			finally
			{
				// El Finally nos da siempre la oportunidad de liberar
				// la memoria utilizada por los objetos 
				this.CloseConnection();
			}
		}



		public void Save(Materia materia)
		{
			if (materia.State == BusinessEntity.States.New)
			{
				this.Agregar(materia);
			}
			else if (materia.State == BusinessEntity.States.Deleted)
			{
				this.Delete(materia.ID);
			}
			else if (materia.State == BusinessEntity.States.Modified)
			{
				this.Update(materia);
			}
			materia.State = BusinessEntity.States.Unmodified;
		}

		public List<Materia> GetMateriasDisponibles(int id_comision)

		{

			List<Materia> materiasDisponibles = new List<Materia>();



			try

			{

				this.OpenConnection();

				SqlCommand cmdMateria = new SqlCommand("SELECT c.id_comision, m.id_materia, m.desc_materia FROM comisiones c " +

														" INNER JOIN materias m " +

														" ON m.id_plan = c.id_plan " +

														" LEFT JOIN cursos cu " +

														" ON c.id_comision = cu.id_comision AND m.id_materia = cu.id_materia " +

														" WHERE  id_curso IS NULL AND c.id_comision = @id_comision", SqlConn);

				cmdMateria.Parameters.Add("@id_comision", SqlDbType.Int).Value = id_comision;

				SqlDataReader drMateria = cmdMateria.ExecuteReader();

				while (drMateria.Read())

				{

					Materia oMateria = new Materia();

					oMateria.ID = (int)drMateria["id_materia"];

					oMateria.Descripcion = (string)drMateria["desc_materia"];



					materiasDisponibles.Add(oMateria);

				}

				drMateria.Close();

			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las materias disponibles\n\n", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return materiasDisponibles;

		}



	}
}
