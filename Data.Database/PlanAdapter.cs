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
	public class PlanAdapter: Adapter
	{

		public List<Plan> GetAll()
		{
			List<Plan> listaPlan = new List<Plan>();
			try
			{
				this.OpenConnection();
				SqlCommand cmdPlan = new SqlCommand("" +
					"SELECT																	" +
					" p.id_plan																" +
					",p.desc_plan															" +
					",e.id_especialidad														" +
					",e.desc_especialidad													" +
					"FROM planes p															" +
					"INNER JOIN especialidades e ON e.id_especialidad = P.id_especialidad	", SqlConn);
				SqlDataReader drPlan = cmdPlan.ExecuteReader();
				while (drPlan.Read())
				{
					Plan oPlan = new Plan();
					oPlan.ID = (int)drPlan["id_plan"];
					oPlan.Descripcion = (string)drPlan["desc_plan"];
					Especialidad oEsp = new Especialidad();
					oEsp.ID = (int)drPlan["id_especialidad"];
					oEsp.Descripcion = (string)drPlan["desc_especialidad"];
					oPlan.PlanEspecialidad = oEsp;
					listaPlan.Add(oPlan);
				}
				drPlan.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar los planes", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaPlan;
		}
		

		public List<Plan> GetAll(string tipoBusqueda, string valorBuscado)
		{
			List<Plan> listaPlan = new List<Plan>();
			try
			{
				this.OpenConnection();
				SqlCommand cmdPlan = null;
				switch (tipoBusqueda)
				{
					case "ID":
							cmdPlan = new SqlCommand("" +
													"SELECT																	" +
													" p.id_plan																" +
													",p.desc_plan															" +
													",e.id_especialidad														" +
													",e.desc_especialidad													" +
													"FROM planes p															" +
													"INNER JOIN especialidades e ON e.id_especialidad = P.id_especialidad	" +
													"WHERE p.id_plan=@id_plan_buscado", SqlConn);
							cmdPlan.Parameters.Add("@id_plan_buscado", SqlDbType.Int).Value = valorBuscado;
						break;
					case "Descripcion":
							cmdPlan = new SqlCommand("" +
													"SELECT																	" +
													" p.id_plan																" +
													",p.desc_plan															" +
													",e.id_especialidad														" +
													",e.desc_especialidad													" +
													"FROM planes p															" +
													"INNER JOIN especialidades e ON e.id_especialidad = P.id_especialidad	" +
													"WHERE p.desc_plan=@desc_plan_buscado", SqlConn);
							cmdPlan.Parameters.Add("@desc_plan_buscado", SqlDbType.VarChar,50).Value = valorBuscado;
							break;
					case "Todos":
							cmdPlan = new SqlCommand("" +
													"SELECT																	" +
													" p.id_plan																" +
													",p.desc_plan															" +
													",e.id_especialidad														" +
													",e.desc_especialidad													" +
													"FROM planes p															" +
													"INNER JOIN especialidades e ON e.id_especialidad = P.id_especialidad	"
													, SqlConn);
							break;
				}
				SqlDataReader drPlan = cmdPlan.ExecuteReader();
				while (drPlan.Read())
				{
					Plan oPlan = new Plan();
					oPlan.ID = (int)drPlan["id_plan"];
					oPlan.Descripcion = (string)drPlan["desc_plan"];
					Especialidad oEsp = new Especialidad();
					oEsp.ID = (int)drPlan["id_especialidad"];
					oEsp.Descripcion= (string)drPlan["desc_especialidad"];
					oPlan.PlanEspecialidad = oEsp;
				}
				drPlan.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar los planes", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaPlan;
		}
	}
}
