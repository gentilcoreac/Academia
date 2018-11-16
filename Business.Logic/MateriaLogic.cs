using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
	public class MateriaLogic: BusinessLogic
	{
		public MateriaAdapter _materiaData;
		public MateriaAdapter MateriaData
		{
			get { return _materiaData; }
			set { _materiaData = value; }
		}
		public MateriaLogic()
		{
			MateriaData = new MateriaAdapter();
		}

		public List<Materia> GetMateriasDisponibles(int id_comision)

		{

			return MateriaData.GetMateriasDisponibles(id_comision);

		}

		public List<Materia> GetAll()
		{
			return MateriaData.GetAll();
		}
		public List<Materia> GetAll(string tipoBusqueda, string busqueda)
		{
			return MateriaData.GetAll(tipoBusqueda, busqueda);
		}

		public List<Materia> GetAll(string tipoBusqueda, string busqueda, int ID_Persona)
		{
			return MateriaData.GetAll(tipoBusqueda, busqueda, ID_Persona);
		}

		public Materia GetOne(int ID)
		{
			return MateriaData.GetOne(ID);
		}

        public List<Materia> GetMateriasDisponibles(int id_comision)
        {
            return MateriaData.GetMateriasDisponibles(id_comision);
        }

        public void Save(Materia materia)
		{
			MateriaData.Save(materia);
		}

		public void Delete(int id)
		{
			MateriaData.Delete(id);
		}

		public int GetMaxID()
		{
			return MateriaData.GetMaxID();
		}

	}
}
