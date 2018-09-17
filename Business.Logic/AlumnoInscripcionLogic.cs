using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
	public class AlumnoInscripcionLogic:BusinessLogic
	{
		public AlumnoInscripcionAdapter _AlumnoInscripcionData;
		public AlumnoInscripcionAdapter AlumnoInscripcionData
		{
			get { return _AlumnoInscripcionData; }
			set { _AlumnoInscripcionData = value; }
		}

		public AlumnoInscripcionLogic()
		{

			AlumnoInscripcionData = new AlumnoInscripcionAdapter();
		}
		public List<AlumnoInscripcion> GetAll(int ID_Alumno)
		{
			return AlumnoInscripcionData.GetAll(ID_Alumno);
		}

		public void Save(AlumnoInscripcion inscripcion)
		{
			AlumnoInscripcionData.Save(inscripcion);
		}

		public void Delete(int id)
		{
			AlumnoInscripcionData.Delete(id);
		}

		public int GetCantInscriptos(int id_curso)
		{
			return AlumnoInscripcionData.GetCantInscriptos(id_curso);
		}
	}
}
