using System;
namespace Day03;
class Program
{
    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }

    }

    static int fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }

    static void printMessage(string message, int reapeat = 1)
    {
        for (int i = 0; i < reapeat; i++)
        {
            Console.WriteLine(message);
        }
    }

    static void showInfo(string name , int age , string country = "Unknown")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Country: {country}");
    }
    static void Main (string[] args)
    {
        //Console.WriteLine(fibonacci(6));
        //Console.WriteLine(Factorial(5));
        //printMessage("Hello");
        //printMessage("Hi", 3);

        //showInfo("Abdallah", 20);                          
        //showInfo("Sara", 23, "Egypt");                
        //showInfo(age: 30, name: "Mona");              
        //showInfo(country: "USA", name: "saif", age: 20); 

        //string text = "Hello";
        //Console.WriteLine(text.ReverseText());

        //int x = 8;
        //Console.WriteLine(x.IsEven());

        //var p1 = new PersonRecord("Abdallah", 20);
        //var p2 = new PersonRecord("Abdallah", 20);
        //Console.WriteLine(p1);
        //Console.WriteLine(p2==p2);

        //var car1 = new CarRecord("Toyota", "Corolla");
        //var car2 = car1 with { Model = "Camry" };
        //Console.WriteLine(car1);
        //Console.WriteLine(car2);






    }

}