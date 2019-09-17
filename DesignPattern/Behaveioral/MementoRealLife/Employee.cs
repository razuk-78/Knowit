using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaveioral.MementoRealLife
{
    /// <summary>
    /// Represents an Employee
    /// </summary>
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private uint _id;

        public Employee(string firstName, string lastName, uint id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = id;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public uint Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Save an employee to a memento
        /// </summary>
        /// <returns>employee memento</returns>
        public EmployeeMemento SaveEmployee()
        {
            return new EmployeeMemento(this._firstName, this._lastName, this._id);
        }

        /// <summary>
        /// Restore the employee to a previous state held by a memento
        /// </summary>
        /// <param name="empMemento">previous state memento</param>
        public void RestoreEmployee(EmployeeMemento empMemento)
        {
            this._firstName = empMemento.FirstName;
            this._lastName = empMemento.LastName;
            this._id = empMemento.Id;
        }
    }
}
