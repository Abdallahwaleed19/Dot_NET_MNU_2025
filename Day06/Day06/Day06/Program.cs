namespace Day06;
using System;
class Program
{
    static void Main(string[] args)
    {
        Person student = new Student("Abdallah Waleed", 20230192, 20, "Artifical Intelligence", 3.8);
        Person professor = new Professor("Dr.Tamer", 1001, 45, "Artifical Intelligence", 75000);
        student.DisplayInfo();
        Console.WriteLine("---------------------------------------");
        ((Student)student).RegisterCourses("Introduction to AI");
        Console.WriteLine("---------------------------------------");
        ((Student)student).RegisterCourses("Machine Learning", 3);
        Console.WriteLine("---------------------------------------");
        professor.DisplayInfo();
        Console.WriteLine("---------------------------------------");
        ((Professor)professor).TeachCourse("Advanced AI");

    }
}
