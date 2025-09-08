using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Employee : Person
    {
        public double Salary;
        public Employee(string name, double salary) : base(name)
        {
            Salary = salary;
            Console.WriteLine($"Employee {Name} created with salary {Salary}.");
        }
    }
}
