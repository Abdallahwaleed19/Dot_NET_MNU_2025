//using System;

//namespace Day01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number:");
//            int number = int.Parse(Console.ReadLine());
//            Console.WriteLine("You Entered: " + number);



//            string name = "Abdallah";
//            int num = Convert.ToInt32(name);
//            Console.WriteLine(num);


//            float num1 = 12.5f;
//            num1 += 0.5f;
//            Console.WriteLine(num1);

//            Console.WriteLine("Enter Your date of birth:");
//            DateTime dateTime = DateTime.Parse(Console.ReadLine());
//            int age = DateTime.Now.Year - dateTime.Year;
//            Console.WriteLine("Your age is: " + age);


//            int a = 10;
//            int b = a;
//            Console.WriteLine(b);
//            a = 20;
//            Console.WriteLine(a);
//            Console.WriteLine(b);



//            int[] arr = { 1, 2, 3, 4, 5 };
//            int[] arr2 = arr;
//            Console.WriteLine(arr2[0]);

//            Console.WriteLine("Enter First Name:");
//            string firstName = Console.ReadLine();
//            Console.WriteLine("Enter Last Name:");
//            string lastName = Console.ReadLine();
//            string fullName = firstName + " " + lastName;
//            Console.WriteLine("Your Full Name is: " + fullName);

//            Console.WriteLine("Enter First Number:");
//            int num1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Second Number:");
//            int num2 = int.Parse(Console.ReadLine());
//            ++num1;
//            num2++;
//            int sum = num1 + num2;
//            int product = num1 * num2;
//            Console.WriteLine("The Sum is: " + sum);
//            Console.WriteLine("The Product is: " + product);


//            Console.WriteLine("Enter Your Number:");
//            int num = int.Parse(Console.ReadLine());
//            if (num % 2 == 0)
//            {
//                Console.WriteLine("Even Number");
//            }
//            else
//            {
//                Console.WriteLine("Odd Number");
//            }

//        }
//    }
//}


using System;

namespace Day01
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your operator (+, -, *, /):");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (op == '+')
            {
                Console.WriteLine("The Sum is: " + (num1 + num2));
            }
            else if (op == '-')
            {
                Console.WriteLine("The Subtraction is: " + (num1 - num2));
            }
            else if (op == '*')
            {
                Console.WriteLine("The Multiplication is: " + (num1 * num2));
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    Console.WriteLine("The Division is: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator.");

            }
        }
    }
}