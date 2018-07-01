using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
	public class PlanLogic: BusinessLogic
	{
		public PlanAdapter _PlanData;
		public PlanAdapter PlanData
		{
			get { return _PlanData; }
			set { _PlanData = value; }
		}
		public PlanLogic()
		{
			PlanData = new PlanAdapter();
		}

		public List<Plan> GetAll(string tipoBusqueda, string valorBuscado)
		{
			return PlanData.GetAll(tipoBusqueda, valorBuscado);
		}
		public List<Plan> GetAll()
		{
			return PlanData.GetAll();
		}
	}
}
