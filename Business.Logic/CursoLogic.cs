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

		public List<Curso> GetAll(string tipoBusqueda, string valorBuscado)
		{
			return CursoData.GetAll(tipoBusqueda, valorBuscado);
		}

		public Curso GetOne(int id)
		{
			return CursoData.GetOne(id);
		}


		public int GetMaxID()
		{
			return CursoData.GetMaxID();
		}

		public void Save(Curso curso)
		{
			CursoData.Save(curso);
		}

		public void Delete(int id)
		{
			CursoData.Delete(id);
		}
	}
}
