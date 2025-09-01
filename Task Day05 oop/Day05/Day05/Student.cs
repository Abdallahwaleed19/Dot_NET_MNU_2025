using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Student
    {
        public String Name;
        public int Age; 
        public Student(String name)
        {
            this.Name = name;
            this.Age = 18;
        }
        public Student(String name, int age) : this(name)
        {
            this.Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}");
        }
    }
}
