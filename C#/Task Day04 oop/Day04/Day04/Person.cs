﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"Person {Name} created.");
        }
    }
}
