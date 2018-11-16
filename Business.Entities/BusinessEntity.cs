using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int _ID;
        private States _States;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public States State
        {
            get { return _States; }
            set { _States = value; }
        }

        public BusinessEntity()
        {
            this.State = States.New;
        }

        public enum States
        {
            New,
            Deleted,
            Modified,
            Unmodified
        }
    }
}
