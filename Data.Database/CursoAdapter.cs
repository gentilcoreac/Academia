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
	}
}
