using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators

{
    public class Employee
    {
        //Created an Employee class with Id, FirstName and LastName properties. 

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overloaded operator pair to compare employee ids
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;

        }
    }
}