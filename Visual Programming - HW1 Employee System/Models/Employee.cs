using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Programming___HW1_Employee_System.Models
{
    class Employee
    {
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }

        public Employee(string ssn, string firstName, string lastName, string birthDate, string address, string department)
        {
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
            Department = department;
        }

    }
}
