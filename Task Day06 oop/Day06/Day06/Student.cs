using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Student : Person
    {
        public string major;
        public double gpa;

        public Student(string fullName, int id, int age , string major , double gpa) : base(fullName, id, age)
        {
            this.major = major;
            this.gpa = gpa;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {FullName}, Age: {age}, Major: {major}, GPA: {gpa}");
        }
        public void RegisterCourses(string courseName)
        {
            Console.WriteLine($"{FullName} has registered for the course: {courseName}");
        }
        public void RegisterCourses(string courseName, int credits)
        {
            Console.WriteLine($"{FullName} has registered for the course: {courseName} with {credits} credits");
        }
    }
}
