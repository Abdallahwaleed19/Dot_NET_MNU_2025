using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Employee
    {
        public String Name;
        public double Salary;
        public virtual void CalculateBonus()
        {
            Console.WriteLine($"Calculating bonus {Salary * 0.05} for employee {Name}");
        }
    }
}
