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

		public List<AlumnoInscripcion> GetAll(int ID_Persona)
		{
			return AlumnoInscripcionData.GetAll(ID_Persona);
		}

		public List<AlumnoInscripcion> GetAll(string tipoBusqueda, string busqueda, int ID_Persona)
		{
			return AlumnoInscripcionData.GetAll(tipoBusqueda, busqueda, ID_Persona);
		}

		public List<AlumnoInscripcion> GetAll(string tipoBusqueda, string busqueda)
		{
			return AlumnoInscripcionData.GetAll(tipoBusqueda, busqueda);
		}

		public void Save(AlumnoInscripcion inscripcion)
		{
				AlumnoInscripcionData.Save(inscripcion);	
		}

		public void Delete(int id)
		{
			AlumnoInscripcionData.Delete(id);
		}
		public AlumnoInscripcion GetOne(int ID)
		{
			return AlumnoInscripcionData.GetOne(ID);
		}

		public int GetMaxID()
		{
			return AlumnoInscripcionData.GetMaxID();
		}

		public bool EstaInscripto(int id_Curso, int id_alumno, int anio_calendario)
		{
			if (AlumnoInscripcionData.EstaInscripto(id_Curso, id_alumno, anio_calendario) == 0)             
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool ValidaFechaInscripcion(Usuario usuarioLogueado, string fechaLimite)
		{
			if (DateTime.Parse(fechaLimite) >= DateTime.Now)
			{
				return true;
			}
			else if (usuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool HayCuposParaInscribirse(Usuario usuarioLogueado, Curso curso)
		{			
			if (AlumnoInscripcionData.GetCantInscriptos(curso.ID) <= curso.Cupo)				//FALTA AGREGARLE EL CUPO (VALOR DE CURSO ES)
			{
				return true;
			}
			else if (usuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
			{
				return true;
			}
			else
			{
				return false;
			}
		} 

		public DateTime GetFechaLimiteInscripcion()
		{
			return AlumnoInscripcionData.GetFechaLimiteInscripcion();
		}

		public void ActualizaFechaLimiteInscripcion(DateTime fecha_limite)
		{
			AlumnoInscripcionData.ActualizaFechaLimite(fecha_limite);
		}
	}
}