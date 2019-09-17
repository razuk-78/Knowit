using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaveioral.MementoRealLife
{
    /// <summary>
    /// Caretaker to hold the undo/redo.
    /// </summary>
    public class CareTaker
    {
        private static CareTaker _instance;
        private EmployeeMemento _empMemento;

        private CareTaker()
        {
        }

        public static CareTaker Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CareTaker();
                }
                return _instance;
            }
        }

        public EmployeeMemento EmployeeMemento
        {
            get
            {
                return _empMemento;
            }
            set
            {
                _empMemento = value;
            }
        }
    }
}
