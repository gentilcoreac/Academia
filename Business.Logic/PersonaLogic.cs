using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
	public class PersonaLogic : BusinessLogic
	{
		public PersonaAdapter _personaData;
		public PersonaAdapter PersonaData
		{
			get { return _personaData; }
			set { _personaData = value; }
		}
		public PersonaLogic()
		{
			PersonaData = new PersonaAdapter();
		}

		//public Persona getOne(int ID)
		//{
		//	return PersonaData.getOne(ID);
		//}
		public List<Persona> GetAll()
		{
			return PersonaData.GetAll();
		} 

		public Persona GetOne(int ID)
		{
			return PersonaData.GetOne(ID);
		}
		public List<Persona> GetAll(string tipoBusqueda, string busqueda)
		{
			return PersonaData.GetAll(tipoBusqueda, busqueda);
		}

		public void Save(Persona persona)
		{
			PersonaData.Save(persona);
		}

		public void Delete(int id)
		{
			PersonaData.Delete(id);
		}

		public int GetMaxID()
		{
			return PersonaData.GetMaxID();
		}
	}
}
