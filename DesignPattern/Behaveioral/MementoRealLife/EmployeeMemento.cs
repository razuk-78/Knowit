namespace Behaveioral.MementoRealLife
{
    /// <summary>
    /// Memento to get/set the state of an Employee
    /// </summary>
    public class EmployeeMemento
    {
        private string _firstName;
        private string _lastName;
        private uint _id;

        public EmployeeMemento(Employee emp)
        {
            _firstName = emp.FirstName;
            _lastName = emp.LastName;
            _id = emp.Id;
        }

        public EmployeeMemento(string firstName, string lastName, uint id)
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
    }
}