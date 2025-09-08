using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day03_oop
{
    public class BankAccount
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance Cannot be Negative");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"The balance is : {balance}");

            }

        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"The Balance is : {balance}");
            }
            else
            {
                Console.WriteLine("Error Operation");
            }
        }
    }
}
