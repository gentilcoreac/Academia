﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string _Descripcion;
        private int _HSSemanales;
        private int _HSTotales;
        //private int _IDPlan;
		private Plan _Plan;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value ; } 
        }
        public int HSSemanales
        {
            get { return _HSSemanales; }
            set { _HSSemanales = value ; }
        }
        public int HSTotales
        {
            get { return _HSTotales; }
            set { _HSTotales = value; }
        }
        //public int IDPlan
        //{
        //    get { return _IDPlan ; }
        //    set { _IDPlan = value ; }
        //}
		public Plan Plan
		{
			get { return _Plan; }
			set { _Plan = value; } 
		}

		public override string ToString()
		{
			return string.Format("{0}-{1}-{2}", ID, Descripcion, Plan.Descripcion);
		}

	}
}
