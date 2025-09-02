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
            this.Name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
