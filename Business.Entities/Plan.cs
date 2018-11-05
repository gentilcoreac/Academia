using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private string _Descripcion;
        private Especialidad _Especialidad;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public Especialidad PlanEspecialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value; }
        }

        public string WebDesc { get => string.Format("{0}-{1}-{2}", ID, Descripcion, PlanEspecialidad.Descripcion); }

        public override string ToString()
		{
			return string.Format("{0}-{1}-{2}", ID, Descripcion, PlanEspecialidad.Descripcion);
		}
	}
}
