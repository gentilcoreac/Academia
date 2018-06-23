using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
	public class PersonaLogic: BusinessLogic
	{
		public PersonaAdapter _usuarioData;
		public PersonaAdapter PersonaData
		{
			get { return _usuarioData; }
			set { _usuarioData = value; }
		}
		public PersonaLogic()
		{
			PersonaData = new PersonaAdapter();
		}

		//public Persona getOne(int ID)
		//{
		//	return PersonaData.getOne(ID);
		//}

	}
}
