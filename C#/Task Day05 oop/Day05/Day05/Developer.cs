using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Developer : Employee
    {
        public override void CalculateBonus()
        {
            Console.WriteLine($"Calculating bonus {Salary * 0.10} for developer {Name}");
        }
    }
}
