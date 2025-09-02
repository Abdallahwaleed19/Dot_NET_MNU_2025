namespace Day03;
public class Program
{
    enum PizzaSize
    {
        Small = 1,
        Medium,
        Large
    }

    static void Main(string[] args)
    {
        //Console.WriteLine("Select Pizza Size:");
        //Console.WriteLine(" 1. Small \n 2. Medium \n 3. Large");
        //Console.Write("Enter your choice (1-3):");
        //int choice = int.Parse(Console.ReadLine());
        //PizzaSize selectedSize = (PizzaSize)choice;
        //Console.WriteLine("You selected: " + selectedSize);

        //switch (selectedSize)
        //{
        //    case PizzaSize.Small:
        //        Console.WriteLine("Price: 12$");
        //        break;
        //    case PizzaSize.Medium:
        //        Console.WriteLine("Price: 15$");
        //        break;
        //    case PizzaSize.Large:
        //        Console.WriteLine("Price: 18$");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid selection.");
        //        break;
        //}

        BankAccount account = new BankAccount(100);
        account.Deposit(50);
        account.Withdraw(30);
        Console.WriteLine($"Current Balance: {account.GetBalance():C}");


    }
}