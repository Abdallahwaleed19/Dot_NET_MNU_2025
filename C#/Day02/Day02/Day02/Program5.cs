using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Size : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int sum = 0;
            int evenCount = 0;
            for (int i =0; i < size; i++)
            {
                Console.Write($"Enter your{i + 1} Number : ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                    sum += arr[i];

                }

            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Total Even Numbers : {evenCount}");
            Console.WriteLine($"Sum of Even Numbers : {sum}");
        }
    }
}
