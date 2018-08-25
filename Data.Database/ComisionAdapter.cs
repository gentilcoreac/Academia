using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
	public class ComisionAdapter: Adapter
	{


		public List<Comision> GetAll()
		{
			List<Comision> listaComision = new List<Comision>();
			try
			{
				this.OpenConnection();
				SqlCommand cmdComision = new SqlCommand( ""
														+"select  com.id_comision					"
														+"		, com.desc_comision					"
														+"		, com.anio_especialidad				"
														+"		, com.id_plan						"
														+"from comisiones com						"
														+" inner join planes p on p.id_plan = com.id_plan  ", SqlConn);
				SqlDataReader drComision = cmdComision.ExecuteReader();
				while (drComision.Read())
				{
					Comision oComision = new Comision();
					oComision.ID = (int)drComision["id_comision"];
					oComision.Descripcion = (string)drComision["desc_comision"];
					oComision.AnioEspecialidad = (int)drComision["anio_especialidad"];
					oComision.IDPlan = (int)drComision["id_plan"];

					//Plan oPlan = new Plan();
					//oPlan.ID = (int)drComision["id_plan"];
					//oPlan.Descripcion = (string)drComision["desc_plan"];
					
					listaComision.Add(oComision);
				}
				drComision.Close();
			}
			catch (Exception Ex)
			{
				Exception Excepcion = new Exception("Error al recuperar las comisiones\n\n", Ex);
				throw Excepcion;
			}
			finally
			{
				this.CloseConnection();
			}
			return listaComision;
		}


	}
}
