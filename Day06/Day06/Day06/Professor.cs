 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Professor : Person , ITeacher
    {
        public string department;
        public double salary;
        public Professor(string fullName, int id, int age, string department, double salary) : base(fullName, id, age)
        {
            this.department = department;
            this.salary = salary;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {FullName}, Age: {age}, Department: {department}, Salary: {salary}");
        }

        public void TeachCourse(string courseName)
        {
            Console.WriteLine($"{FullName} is teaching the course: {courseName}");
        }
    }
}
