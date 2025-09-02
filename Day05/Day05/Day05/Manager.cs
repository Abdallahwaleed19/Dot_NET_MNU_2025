using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Manager : Employee
    {
        public override void CalculateBonus()
        {
            Console.WriteLine($"Calculating bonus {Salary * 0.15} for manager {Name}");
        }
    }
}
