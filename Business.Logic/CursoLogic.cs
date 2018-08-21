using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
	public class CursoLogic : BusinessLogic
	{
		public CursoAdapter _CursoData;
		public CursoAdapter CursoData
		{
			get { return _CursoData; }
			set { _CursoData = value; }
		}

		public CursoLogic()
		{
			CursoData = new CursoAdapter();
		}

		public List<Curso> GetAll()
		{
			return CursoData.GetAll();
		}
	}
}
