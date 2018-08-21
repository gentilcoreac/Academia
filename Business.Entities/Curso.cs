using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnioCalendario;
        private int _Cupo;
        //private int _IDComision;
        //private int _IDMateria;
		private Materia _Materia;
		private Comision _Comision;

        public int AnioCalendario
        {
            get { return _AnioCalendario; }
            set { _AnioCalendario = value ; }
        }

        public int Cupo
        {
            get { return _Cupo ; }
            set { _Cupo = value; }
        }
		 
		public Comision Comision
		{
			get { return _Comision; }
			set { _Comision = value; }
		}

		public Materia Materia
		{
			get { return _Materia; }
			set { _Materia = value; }
		}

		//public int IDComision
		//{
		//    get { return _IDComision; }
		//    set { _IDComision = value; }
		//}

		//public int IDMateria
		//{
		//    get { return _IDMateria; }
		//    set { _IDMateria = value; }
		//}
	}
}
