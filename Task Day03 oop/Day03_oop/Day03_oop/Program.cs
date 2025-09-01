using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Day03_oop
//{
//    internal class Program
//    {
//        enum Pizza
//        {
//            Small = 1,
//            Medium,
//            Large
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Select Pizza Size:");
//            Console.WriteLine("1) Small \n 2)Medium \n 3)Large \n");
//            Console.WriteLine("Enter Your Choice:");
//            int choice = int.Parse(Console.ReadLine());
//            switch ((Pizza)choice)
//            {
//                case Pizza.Small:
//                    Console.WriteLine("You Selected: Small");
//                    Console.WriteLine("Price: $12");
//                    break;
//                case Pizza.Medium:
//                    Console.WriteLine("You Selected: Medium");
//                    Console.WriteLine("Price: $20");
//                    break;
//                case Pizza.Large:
//                    Console.WriteLine("You Selected: Large");
//                    Console.WriteLine("Price: $30");
//                    break;
//            }
//        }
//    }
//}


//namespace Day03_oop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount { Balance = 100000 };
//            account.Deposit(500);
//            Console.WriteLine(account.Balance);
//            account.Withdraw(500);
//            Console.WriteLine(account.Balance);

//        }
//    }
//}


//namespace Day03_oop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student student = new Student();
//            Console.Write("Enter Student ID: ");
//            student.Id = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter Full Name: ");
//            student.fullName = Console.ReadLine();

//            Console.Write("Enter Grade: ");
//            student.Grade = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Student Info: ");
//            Console.WriteLine("ID: " + student.Id);
//            Console.WriteLine("Name: " + student.fullName);
//            Console.WriteLine("Grade: " + student.Grade);
//        }
//    }
//}