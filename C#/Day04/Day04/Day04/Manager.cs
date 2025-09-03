using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Manager : Employee 
    {
        public Manager(string name, double salary) : base(name, salary)
        {
        }
        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }
}
