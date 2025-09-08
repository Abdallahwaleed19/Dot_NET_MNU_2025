//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number : ");
//            int num = int.Parse(Console.ReadLine());
//            if (num % 3 == 0 && num % 4 == 0)
//            {
//                Console.WriteLine("Yes");
//            }
//            else
//            {
//                Console.WriteLine("No");
//            }
//        }
//    }
//}


//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number : ");
//            int num = int.Parse(Console.ReadLine());
//            if (num < 0)
//            {
//                Console.WriteLine("Negative");
//            }
//            else
//            {
//                Console.WriteLine("Positive");
//            }
//        }
//    }
//}


//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Size : ");
//            int Size = int.Parse(Console.ReadLine());
//            int[] arr = new int[Size];
//            int Max = int.MinValue;
//            int Min = int.MaxValue;
//            for (int i = 0; i < Size; i++)
//            {
//                Console.WriteLine("Enter Your Number : ");
//                arr[i] = int.Parse(Console.ReadLine());
//                if (arr[i] < Min)
//                {
//                    Min = arr[i];

//                }
//                if (arr[i] > Max)
//                {
//                    Max = arr[i];
//                }

//            }
//            Console.WriteLine("Max is : " + Max);
//            Console.WriteLine("Min is : " + Min);
//        }
//    }
//}

//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your num : ");
//            int num = int.Parse(Console.ReadLine());
//            if (num % 2 == 0)
//            {
//                Console.WriteLine("Even");
//            }
//            else
//            {
//                Console.WriteLine("Odd");
//            }

//        }
//    }
//}

//using System;
//using System.Linq;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Char : ");
//            char text = char.Parse(Console.ReadLine());
//            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
//            if (vowels.Contains(text))
//            {
//                Console.WriteLine("Vowel");
//            }
//            else
//            {
//                Console.WriteLine("Consonant");
//            }

//        }
//    }
//}

//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number : ");
//            int num = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.Write( i );
//            }
//        }
//    }
//}


//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number : ");
//            int num = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= 12; i++)
//            {
//                Console.WriteLine(num + " * " + i + " = " + (num * i));
//            }
//        }
//    }
//}

//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number : ");
//            int Number = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= Number; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }

//            }

//        }
//    }
//}

//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number1 : ");
//            int Number = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Your Power : ");
//            int Power = int.Parse(Console.ReadLine());
//            int result = 1;
//            while (Power != 0)
//            {
//                result *= Number;
//                Power--;
//            }
//            Console.WriteLine("Result is : " + result);

//        }
//    }
//}


//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Size : ");
//            int Size = int.Parse(Console.ReadLine());
//            int[] arr = new int[Size];
//            int sum = 0;
//            double avg = 0.0;
//            double percentage = 0.0;
//            for (int i = 0; i < Size; i++)
//            {
//                Console.WriteLine("Enter Your Number : ");
//                arr[i] = int.Parse(Console.ReadLine());
//                sum += arr[i];
//                avg = sum / Size;
//                percentage = (avg / 100) * 100 ;
//            }
//            Console.WriteLine("Sum is : " + sum);
//            Console.WriteLine("Avg is : " + avg);
//            Console.WriteLine("Percentage is : " + percentage);
//        }
//    }
//}

//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Number1 : ");
//            int Number1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Your operator  : ");
//            char op = char.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Your Number2 : ");
//            int Number2 = int.Parse(Console.ReadLine());
//            switch (op) {
//                case '+':
//                    Console.WriteLine("Result is : " + (Number1 + Number2));
//                    break;
//                case '-':
//                    Console.WriteLine("Result is : " + (Number1 - Number2));
//                    break;
//                case '*':
//                    Console.WriteLine("Result is : " + (Number1 * Number2));
//                    break;
//                case '/':
//                    Console.WriteLine("Result is : " + (Number1 / Number2));
//                    break;
//                default:
//                    Console.WriteLine("Invalid operator");
//                    break;

//            }

//        }
//    }
//}


//using System;
//namespace Day02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Size : ");
//            int Size = int.Parse(Console.ReadLine());
//            int[] arr = new int[Size];
//            int sum = 0;
//            for (int i = 0; i < Size; i++)
//            {
//                Console.WriteLine("Enter Your Number : ");
//                arr[i] = int.Parse(Console.ReadLine());
//                if (arr[i] % 2 == 0)
//                {
//                    sum += arr[i];
//                }

//            }
//            Console.WriteLine("Sum of Even Numbers is : " + sum);
//        }

//    }
//}            
