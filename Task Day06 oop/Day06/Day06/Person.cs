using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public abstract class Person
    {
        private string fullName;
        private int Id { get; set; }
        public int age;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }

        }
        public virtual void DisplayInfo()
        {
                       Console.WriteLine($"ID: {Id}, Name: {FullName}, Age: {age}");
        }
        public Person(string fullName, int id, int age)
        {
            FullName = fullName;
            Id = id;
            this.age = age;
        }

    }
}
