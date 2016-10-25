using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing.Domain
{
    public class Employee
    {
        public enum EmployeeRoleType
        {
            GeneralEmployee = 0,
            TeamLeader = 1,
            Supervisor = 2
        }

        
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private EmployeeRoleType _Role;

        public int Id
        {
            get { return _Id; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public EmployeeRoleType Role
        {
            get { return _Role; }
            set { _Role = value; }
        }

        public Employee(int id)
        {
            _Id = id;
        }
    }
}
