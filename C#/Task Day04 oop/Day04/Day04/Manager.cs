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
            Console.WriteLine($"Manager {Name} created with salary {Salary}.");
        }
        public void ManageTeam()
        {
            Console.WriteLine($"Manager {Name} is managing the team.");
        }
    }
}
