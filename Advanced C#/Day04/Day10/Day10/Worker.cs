using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public abstract class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public double Salary { get; set; }
        public abstract double CalculateBonus();
    }
}
