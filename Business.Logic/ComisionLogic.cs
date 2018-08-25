using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
	public class ComisionLogic : BusinessLogic
	{
		public ComisionAdapter _ComisionData;
		public ComisionAdapter ComisionData
		{
			get { return _ComisionData; }
			set { _ComisionData = value; }
		}

		public ComisionLogic()
		{
			ComisionData = new ComisionAdapter();
		}

		public List<Comision> GetAll()
		{
			return ComisionData.GetAll();
		}


	}
}
