using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Animal
    {
        public string Name;
        public Animal(string name)
        {
            Name = name;
            Console.WriteLine($"Animal {Name} created.");
        }
        public void Eat()
        {
            Console.WriteLine($"Animal {Name} is eating.");
        }
    }
}
