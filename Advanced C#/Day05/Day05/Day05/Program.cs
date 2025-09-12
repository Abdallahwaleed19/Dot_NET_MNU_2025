using System;
namespace Day05
{
    delegate void WelcomeMessage(string name, string message);
    delegate int Mathoperation(int num1, int num2);
    delegate double DiscountCalculator(double price);
    delegate void Notifier();
    delegate bool Numbercheck(int num);
    class Program
    {
        public static void sendSMS()
        {
            Console.WriteLine("SMS Sent");
        }
        public static void sendEmail()
        {
            Console.WriteLine("Email Sent");
        }
        public static void showpopup()
        {
            Console.WriteLine("Popup notification shown");
        }

        public static void ShowFinalPrice(double price, DiscountCalculator d)
        {
            Console.WriteLine($"Original Price: {price}");
            double finalPrice = d(price);
            Console.WriteLine($"Final Price: {finalPrice}");
        }
        public static double TenPercentOff(double price)
        {
            return price - (price * 0.10);
        }
        public static double FiftyOff(double price)
        {
            return price - 50;
        }
        static int add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void print(string message, string name)
        {
            Console.WriteLine($"{message} , {name}");
        }
        static void Main(string[] args)
        {
            //WelcomeMessage m1 = print;
            //m1("Welcome","Abdallah");

            //Mathoperation op1 = add;
            //Mathoperation op2 = subtract;
            //Mathoperation op3 = multiply;
            //int result1 = op1(10, 5);
            //int result2 = op2(10, 5);
            //int result3 = op3(10, 5);
            //Console.WriteLine($"Add:{result1}");
            //Console.WriteLine($"Subtract:{result2}");
            //Console.WriteLine($"Multiply:{result3}");
            //ShowFinalPrice(200, TenPercentOff);
            //ShowFinalPrice(200, FiftyOff);

            //Notifier notifier = sendSMS;
            //notifier += sendEmail;
            //notifier += showpopup;
            //notifier();

            //Numbercheck ispositive = x => x > 0;
            //int num1 = -3;
            //int num2 = 0;
            //int num3 = 5;
            //Console.WriteLine($"{num1} is  {ispositive(num1)}");
            //Console.WriteLine($"{num2} is  {ispositive(num2)}");
            //Console.WriteLine($"{num3} is  {ispositive(num3)}");

            //Action<string, int> printmessage = (message, count) =>
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.WriteLine(message);
            //    }



            //};
            //printmessage("hello", 3);

            //    Func <double , double , double> addnumber = (a,b) => a + b;
            //    Func <double,   double,   double>   avg = (a, b) => (a+b)/2;
            //    double num1 = 4.5;
            //    double num2 = 7.5;
            //    double sum = addnumber(num1, num2);
            //    double avgerage = avg(num1, num2);
            //    Console.WriteLine($"Add = {sum}");
            //    Console.WriteLine($"Average = {avgerage}");

            //Predicate<string> startsWithA = s => s.StartsWith("A", StringComparison.OrdinalIgnoreCase);
            //List<string> fruits = new List<string> { "Apple", "Banana", "Avocado", "Mango" };
            //foreach (string fruit in fruits)
            //{
            //    if (startsWithA(fruit))
            //    {
            //        Console.WriteLine(fruit);
            //    }
            //}
        }
    }
}
      