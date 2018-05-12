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
        private string _Email;
        private DateTime _FechaNacimiento;
        private int _IDPlan;
        private int _Legajo;
        private string _Telefono;
        private TiposPersonas _TiposPersona;


        public enum TiposPersonas
        {
            Administrador,
            Docente,
            Persona
        }
        public TiposPersonas TiposPersona
        {
            get { return _TiposPersona; }
            set { _TiposPersona = value; }
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
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
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

    }
}
