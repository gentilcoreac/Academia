using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        private string _Apellido;
        private string _Nombre;
        private string _Direccion;
        private string _EmailPersonal;
        private DateTime _FechaNacimiento;
        private Plan _PlanPersona;
        private int _Legajo;
        private string _Telefono;
        private TiposPersonas _TiposPersona;
		private Usuario _Usuario;

        public enum TiposPersonas
        {
            Administrador=1,
            Docente=2,
            Alumno=3
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value ; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public string EmailPersonal
        {
            get { return _EmailPersonal; }
            set { _EmailPersonal = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        public Plan Plan_persona
        {
            get { return _PlanPersona; }
            set { _PlanPersona = value; }
        }
        public int Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
		public TiposPersonas TiposPersona
		{
			get { return _TiposPersona; }
			set { _TiposPersona = value; }
		}

		public Usuario UsuarioPersona
		{
			get{ return _Usuario; }
			set { _Usuario= value;}
		}
	}
}
