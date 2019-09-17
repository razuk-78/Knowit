using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaveioral.MementoRealLife
{
    class App
    {
        public  static  void Run()
        {
            var emp=new Employee("johne","alias",1);
            CareTaker.Instance.EmployeeMemento = emp.SaveEmployee();
            var empMemento = emp.SaveEmployee();
            emp.RestoreEmployee(CareTaker.Instance.EmployeeMemento);
            CareTaker.Instance.EmployeeMemento = empMemento;
        }
    }
}
